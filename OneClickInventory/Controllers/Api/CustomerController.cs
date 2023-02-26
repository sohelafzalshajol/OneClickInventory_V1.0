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

namespace OneClickInventory.Controllers.Api
{
    [Authorize]
    [Produces("application/json")]
    [Route("api/Customer")]
    public class CustomerController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CustomerController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Customer
        [HttpGet]
        public async Task<IActionResult> GetCustomer()
        {
            List<Customer> Items = await _context.Customer.Where(x=>x.DomainStatus==true).ToListAsync();
            int Count = Items.Count();
            return Ok(new { Items, Count });
        }


        [HttpPost("[action]")]
        public IActionResult Insert([FromBody]CrudViewModel<Customer> payload)
        {
            Customer customer = payload.value;
            customer.DomainStatus = true;
            /*----User email----*/
            var applicationUserId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            UserProfile userProfile = _context.UserProfile.Where(x => x.ApplicationUserId == applicationUserId).FirstOrDefault();
            customer.ModifiedBy = userProfile.Email;
            customer.ModifiedAt = DateTime.Now.ToString();

            _context.Customer.Add(customer);
            _context.SaveChanges();
            return Ok(customer);
        }

        [HttpPost("[action]")]
        public IActionResult Update([FromBody]CrudViewModel<Customer> payload)
        {
            Customer customer = payload.value;
            /*----User email----*/
            var applicationUserId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            UserProfile userProfile = _context.UserProfile.Where(x => x.ApplicationUserId == applicationUserId).FirstOrDefault();
            customer.ModifiedBy = userProfile.Email;
            customer.ModifiedAt = DateTime.Now.ToString();
            customer.DomainStatus = true;
            _context.Customer.Update(customer);
            _context.SaveChanges();
            return Ok(customer);
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> Remove([FromBody]CrudViewModel<Customer> payload)
        {
            var customer = await _context.Customer.FindAsync(Convert.ToInt32(payload.key));

            if (customer == null)
            {
                return NotFound();
            }

            try
            {
                /*----User email----*/
                var applicationUserId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
                UserProfile userProfile = _context.UserProfile.Where(x => x.ApplicationUserId == applicationUserId).FirstOrDefault();
                customer.ModifiedBy = userProfile.Email;
                customer.ModifiedAt = DateTime.Now.ToString();
                customer.DomainStatus = false;
                _context.Customer.Update(customer);
                await _context.SaveChangesAsync();
                return Ok(customer);
            }
            catch (DbUpdateException ex)
            {
                //Log the error (uncomment ex variable name and write a log.)
                return NotFound(ex.Message);
            }

        }
    }
}