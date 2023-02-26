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
using static OneClickInventory.Pages.MainMenu;
using System.Security.Claims;

namespace OneClickInventory.Controllers.Api
{
    [Authorize]
    [Produces("application/json")]
    [Route("api/PaymentVoucher")]
    public class PaymentVoucherController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly INumberSequence _numberSequence;

        public PaymentVoucherController(ApplicationDbContext context,
                        INumberSequence numberSequence)
        {
            _context = context;
            _numberSequence = numberSequence;
        }

        // GET: api/PaymentVoucher
        [HttpGet]
        public async Task<IActionResult> GetPaymentVoucher()
        {
            List<Models.PaymentVoucher> Items = await _context.PaymentVoucher.Where(x => x.DomainStatus == true).ToListAsync();
            int Count = Items.Count();
            return Ok(new { Items, Count });
        }



        [HttpPost("[action]")]
        public IActionResult Insert([FromBody]CrudViewModel<Models.PaymentVoucher> payload)
        {
            Models.PaymentVoucher paymentVoucher = payload.value;
            paymentVoucher.PaymentVoucherName = _numberSequence.GetNumberSequence("PAYVCH");
            paymentVoucher.DomainStatus = true;
            /*----User email----*/
            var applicationUserId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            UserProfile userProfile = _context.UserProfile.Where(x => x.ApplicationUserId == applicationUserId).FirstOrDefault();
            paymentVoucher.ModifiedBy = userProfile.Email;
            paymentVoucher.ModifiedAt = DateTime.Now.ToString();

            _context.PaymentVoucher.Add(paymentVoucher);
            _context.SaveChanges();
            return Ok(paymentVoucher);
        }

        [HttpPost("[action]")]
        public IActionResult Update([FromBody]CrudViewModel<Models.PaymentVoucher> payload)
        {
            Models.PaymentVoucher paymentVoucher = payload.value;

            paymentVoucher.DomainStatus = true;
            /*----User email----*/
            var applicationUserId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            UserProfile userProfile = _context.UserProfile.Where(x => x.ApplicationUserId == applicationUserId).FirstOrDefault();
            paymentVoucher.ModifiedBy = userProfile.Email;
            paymentVoucher.ModifiedAt = DateTime.Now.ToString();
            _context.PaymentVoucher.Update(paymentVoucher);
            _context.SaveChanges();
            return Ok(paymentVoucher);
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> Remove([FromBody]CrudViewModel<Models.PaymentVoucher> payload)
        {
            //Models.PaymentVoucher paymentVoucher = _context.PaymentVoucher
            //    .Where(x => x.PaymentvoucherId == Convert.ToInt32(payload.key))
            //    .FirstOrDefault();
            //_context.PaymentVoucher.Remove(paymentVoucher);
            //_context.SaveChanges();
            //return Ok(paymentVoucher);
            var paymentVoucher = await _context.PaymentVoucher.FindAsync(Convert.ToInt32(payload.key));

            if (paymentVoucher == null)
            {
                return NotFound();
            }

            try
            {
                /*----User email----*/
                var applicationUserId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
                UserProfile userProfile = _context.UserProfile.Where(x => x.ApplicationUserId == applicationUserId).FirstOrDefault();
                paymentVoucher.ModifiedBy = userProfile.Email;
                paymentVoucher.ModifiedAt = DateTime.Now.ToString();
                paymentVoucher.DomainStatus = false;
                _context.PaymentVoucher.Update(paymentVoucher);
                await _context.SaveChangesAsync();
                return Ok(paymentVoucher);
            }
            catch (DbUpdateException ex)
            {
                //Log the error (uncomment ex variable name and write a log.)
                return NotFound(ex.Message);
            }

        }
    }
}