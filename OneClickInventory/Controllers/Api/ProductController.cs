using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OneClickInventory.Data;
using OneClickInventory.Models;
using OneClickInventory.Models.SyncfusionViewModels;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;
using static OneClickInventory.Pages.MainMenu;

namespace OneClickInventory.Controllers.Api
{
    [Authorize]
    [Produces("application/json")]
    [Route("api/Product")]
    public class ProductController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ProductController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Product
        [HttpGet]
        public async Task<IActionResult> GetProduct()
        {
            List<Models.Product> Items = await _context.Product.Where(x => x.DomainStatus == true).ToListAsync();
            int Count = Items.Count();
            return Ok(new { Items, Count });
        }



        [HttpPost("[action]")]
        public IActionResult Insert([FromBody]CrudViewModel<Models.Product> payload)
        {
            Models.Product product = payload.value;
            product.DomainStatus = true;
            /*----User email----*/
            var applicationUserId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            UserProfile userProfile = _context.UserProfile.Where(x => x.ApplicationUserId == applicationUserId).FirstOrDefault();
            product.ModifiedBy = userProfile.Email;
            product.ModifiedAt = DateTime.Now.ToString();
            _context.Product.Add(product);
            _context.SaveChanges();
            return Ok(product);
        }

        [HttpPost("[action]")]
        public IActionResult Update([FromBody]CrudViewModel<Models.Product> payload)
        {
            Models.Product product = payload.value;

            product.DomainStatus = true;
            /*----User email----*/
            var applicationUserId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            UserProfile userProfile = _context.UserProfile.Where(x => x.ApplicationUserId == applicationUserId).FirstOrDefault();
            product.ModifiedBy = userProfile.Email;
            product.ModifiedAt = DateTime.Now.ToString();
            _context.Product.Update(product);
            _context.SaveChanges();
            return Ok(product);
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> Remove([FromBody]CrudViewModel<Models.Product> payload)
        {
            //Product product = _context.Product
            //    .Where(x => x.ProductId == Convert.ToInt32(payload.key))
            //    .FirstOrDefault();
            //_context.Product.Remove(product);
            //_context.SaveChanges();
            //return Ok(product);

            var product = await _context.Product.FindAsync(Convert.ToInt32(payload.key));

            if (product == null)
            {
                return NotFound();
            }

            try
            {
                /*----User email----*/
                var applicationUserId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
                UserProfile userProfile = _context.UserProfile.Where(x => x.ApplicationUserId == applicationUserId).FirstOrDefault();
                product.ModifiedBy = userProfile.Email;
                product.ModifiedAt = DateTime.Now.ToString();
                product.DomainStatus = false;
                _context.Product.Update(product);
                await _context.SaveChangesAsync();
                return Ok(product);
            }
            catch (DbUpdateException ex)
            {
                //Log the error (uncomment ex variable name and write a log.)
                return NotFound(ex.Message);
            }

        }
    }
}