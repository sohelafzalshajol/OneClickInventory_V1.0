using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OneClickInventory.Data;
using OneClickInventory.Models;
using OneClickInventory.Services;
using OneClickInventory.Models.SyncfusionViewModels;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;
using static OneClickInventory.Pages.MainMenu;

namespace OneClickInventory.Controllers.Api
{
    [Authorize]
    [Produces("application/json")]
    [Route("api/Invoice")]
    public class InvoiceController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly INumberSequence _numberSequence;

        public InvoiceController(ApplicationDbContext context,
                        INumberSequence numberSequence)
        {
            _context = context;
            _numberSequence = numberSequence;
        }

        // GET: api/Invoice
        [HttpGet]
        public async Task<IActionResult> GetInvoice()
        {
            List<Models.Invoice> Items = await _context.Invoice.ToListAsync();
            int Count = Items.Count();
            return Ok(new { Items, Count });
        }

        [HttpGet("[action]")]
        public async Task<IActionResult> GetNotPaidYet()
        {
            List<Models.Invoice> invoices = new List<Models.Invoice>();
            try
            {
                List<Models.PaymentReceive> receives = new List<Models.PaymentReceive>();
                receives = await _context.PaymentReceive.ToListAsync();
                List<int> ids = new List<int>();

                foreach (var item in receives)
                {
                    ids.Add(item.InvoiceId);
                }

                invoices = await _context.Invoice
                    .Where(x => !ids.Contains(x.InvoiceId))
                    .ToListAsync();
            }
            catch (Exception)
            {

                throw;
            }
            return Ok(invoices);
        }

        [HttpPost("[action]")]
        public IActionResult Insert([FromBody]CrudViewModel<Models.Invoice> payload)
        {
            Models.Invoice invoice = payload.value;
            invoice.DomainStatus = true;
            /*----User email----*/
            var applicationUserId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            UserProfile userProfile = _context.UserProfile.Where(x => x.ApplicationUserId == applicationUserId).FirstOrDefault();
            invoice.ModifiedAt = DateTime.Now.ToString();
            invoice.ModifiedBy = userProfile.Email;
            invoice.InvoiceName = _numberSequence.GetNumberSequence("INV");
            _context.Invoice.Add(invoice);
            _context.SaveChanges();
            return Ok(invoice);
        }

        [HttpPost("[action]")]
        public IActionResult Update([FromBody]CrudViewModel<Models.Invoice> payload)
        {
            Models.Invoice invoice = payload.value;
            invoice.DomainStatus = true;
            /*----User email----*/
            var applicationUserId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            UserProfile userProfile = _context.UserProfile.Where(x => x.ApplicationUserId == applicationUserId).FirstOrDefault();
            invoice.ModifiedAt = DateTime.Now.ToString();
            invoice.ModifiedBy = userProfile.Email;
            _context.Invoice.Update(invoice);
            _context.SaveChanges();
            return Ok(invoice);
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> Remove([FromBody]CrudViewModel<Models.Invoice> payload)
        {
            var invoice =await _context.Invoice.FindAsync(Convert.ToInt32(payload.key));
            //Invoice invoice = _context.Invoice
            //    .Where(x => x.InvoiceId == Convert.ToInt32(payload.key))
            //    .FirstOrDefault();
            //_context.Invoice.Remove(invoice);
            //_context.SaveChanges();
            //return Ok(invoice);
            if (invoice == null)
            {
                return NotFound();
            }

            try
            {
                invoice.DomainStatus = false;
                /*----User email----*/
                var applicationUserId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
                UserProfile userProfile = _context.UserProfile.Where(x => x.ApplicationUserId == applicationUserId).FirstOrDefault();
                invoice.ModifiedAt = DateTime.Now.ToString();
                invoice.ModifiedBy = userProfile.Email;
                _context.Invoice.Update(invoice);
                await _context.SaveChangesAsync();
                return Ok(invoice);
            }
            catch (DbUpdateException ex)
            {
                //Log the error (uncomment ex variable name and write a log.)
                return NotFound(ex.Message);
            }
        }
    }
}