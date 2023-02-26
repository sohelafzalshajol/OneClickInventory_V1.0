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

namespace OneClickInventory.Controllers.Api
{
    [Authorize]
    [Produces("application/json")]
    [Route("api/VendorType")]
    public class VendorTypeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public VendorTypeController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/VendorType
        [HttpGet]
        public async Task<IActionResult> GetVendorType()
        {
            List<VendorType> Items = await _context.VendorType.ToListAsync();
            int Count = Items.Count();
            return Ok(new { Items, Count });
        }

        [HttpPost("[action]")]
        public IActionResult Insert([FromBody]CrudViewModel<VendorType> payload)
        {
            VendorType vendorType = payload.value;
            _context.VendorType.Add(vendorType);
            _context.SaveChanges();
            return Ok(vendorType);
        }

        [HttpPost("[action]")]
        public IActionResult Update([FromBody]CrudViewModel<VendorType> payload)
        {
            VendorType vendorType = payload.value;
            _context.VendorType.Update(vendorType);
            _context.SaveChanges();
            return Ok(vendorType);
        }

        [HttpPost("[action]")]
        public IActionResult Remove([FromBody]CrudViewModel<VendorType> payload)
        {
            VendorType vendorType = _context.VendorType
                .Where(x => x.VendorTypeId == Convert.ToInt32(payload.key))
                .FirstOrDefault();
            _context.VendorType.Remove(vendorType);
            _context.SaveChanges();
            return Ok(vendorType);

        }
    }
}