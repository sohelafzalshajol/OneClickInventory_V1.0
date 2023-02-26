using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OneClickInventory.Data;
using OneClickInventory.Models;
using OneClickInventory.Models.SyncfusionViewModels;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;
using System;

namespace OneClickInventory.Controllers.Api
{
    [Authorize]
    [Produces("application/json")]
    [Route("api/BillType")]
    public class BillTypeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public BillTypeController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/BillType
        [HttpGet]
        public async Task<IActionResult> GetBillType()
        {
            List<BillType> Items = await _context.BillType.ToListAsync();
            int Count = Items.Count();
            return Ok(new { Items, Count });
        }


        [HttpPost("[action]")]
        public IActionResult Insert([FromBody]CrudViewModel<BillType> payload)
        {
            BillType billType = payload.value;
            /*----User email----*/
            var applicationUserId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            UserProfile userProfile = _context.UserProfile.Where(x => x.ApplicationUserId == applicationUserId).FirstOrDefault();
            billType.ModifiedAt = DateTime.Now.ToString();
            billType.ModifiedBy = userProfile.Email;
            _context.BillType.Add(billType);
            _context.SaveChanges();
            return Ok(billType);
        }

        [HttpPost("[action]")]
        public IActionResult Update([FromBody]CrudViewModel<BillType> payload)
        {
            BillType billType = payload.value;
            /*----User email----*/
            var applicationUserId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            UserProfile userProfile = _context.UserProfile.Where(x => x.ApplicationUserId == applicationUserId).FirstOrDefault();
            billType.ModifiedAt = DateTime.Now.ToString();
            billType.ModifiedBy = userProfile.Email;
            _context.BillType.Update(billType);
            _context.SaveChanges();
            return Ok(billType);
        }

        [HttpPost("[action]")]
        public IActionResult Remove([FromBody]CrudViewModel<BillType> payload)
        {
            BillType billType = _context.BillType
                .Where(x => x.BillTypeId == Convert.ToInt32(payload.key))
                .FirstOrDefault();
            _context.BillType.Remove(billType);
            _context.SaveChanges();
            return Ok(billType);

        }
    }
}