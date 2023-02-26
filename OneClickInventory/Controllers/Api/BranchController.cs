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
    [Route("api/Branch")]
    public class BranchController : Controller
    {
        private readonly ApplicationDbContext _context;

        public BranchController(ApplicationDbContext context)
        {
            _context = context;
        }
        

        [HttpGet]
        public async Task<IActionResult> GetBranch()
        {
            List<Branch> Items = await _context.Branch.ToListAsync();
            int Count = Items.Count();
            return Ok(new { Items, Count });
        }

        [HttpPost("[action]")]
        public IActionResult Insert([FromBody]CrudViewModel<Branch> payload)
        {
            Branch branch = payload.value;
            /*----User email----*/
            var applicationUserId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            UserProfile userProfile = _context.UserProfile.Where(x => x.ApplicationUserId == applicationUserId).FirstOrDefault();
            branch.ModifiedBy = userProfile.Email;
            branch.ModifiedAt = DateTime.Now.ToString();

            _context.Branch.Add(branch);
            _context.SaveChanges();
            return Ok(branch);
        }

        [HttpPost("[action]")]
        public IActionResult Update([FromBody]CrudViewModel<Branch> payload)
        {
            Branch branch = payload.value;
            /*----User email----*/
            var applicationUserId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            UserProfile userProfile = _context.UserProfile.Where(x => x.ApplicationUserId == applicationUserId).FirstOrDefault();
            branch.ModifiedBy = userProfile.Email;
            branch.ModifiedAt = DateTime.Now.ToString();

            _context.Branch.Update(branch);
            _context.SaveChanges();
            return Ok(branch);
        }

        [HttpPost("[action]")]
        public IActionResult Remove([FromBody]CrudViewModel<Branch> payload)
        {
            Branch branch = _context.Branch
                .Where(x => x.BranchId == Convert.ToInt32(payload.key))
                .FirstOrDefault();
            _context.Branch.Remove(branch);
            _context.SaveChanges();
            return Ok(branch);

        }
        
    }
}