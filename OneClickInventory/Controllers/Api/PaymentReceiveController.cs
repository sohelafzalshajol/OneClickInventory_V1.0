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
    [Route("api/PaymentReceive")]
    public class PaymentReceiveController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly INumberSequence _numberSequence;

        public PaymentReceiveController(ApplicationDbContext context,
                        INumberSequence numberSequence)
        {
            _context = context;
            _numberSequence = numberSequence;
        }

        // GET: api/PaymentReceive
        [HttpGet]
        public async Task<IActionResult> GetPaymentReceive()
        {
            List<Models.PaymentReceive> Items = await _context.PaymentReceive.Where(x => x.DomainStatus == true).ToListAsync();
            int Count = Items.Count();
            return Ok(new { Items, Count });
        }

        [HttpPost("[action]")]
        public IActionResult Insert([FromBody]CrudViewModel<Models.PaymentReceive> payload)
        {
            Models.PaymentReceive paymentReceive = payload.value;
            paymentReceive.DomainStatus = true;
            /*----User email----*/
            var applicationUserId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            UserProfile userProfile = _context.UserProfile.Where(x => x.ApplicationUserId == applicationUserId).FirstOrDefault();
            paymentReceive.ModifiedBy = userProfile.Email;
            paymentReceive.ModifiedAt = DateTime.Now.ToString();

            paymentReceive.PaymentReceiveName = _numberSequence.GetNumberSequence("PAYRCV");
            _context.PaymentReceive.Add(paymentReceive);
            _context.SaveChanges();
            return Ok(paymentReceive);
        }

        [HttpPost("[action]")]
        public IActionResult Update([FromBody]CrudViewModel<Models.PaymentReceive> payload)
        {
            Models.PaymentReceive paymentReceive = payload.value;
            paymentReceive.DomainStatus = true;
            /*----User email----*/
            var applicationUserId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            UserProfile userProfile = _context.UserProfile.Where(x => x.ApplicationUserId == applicationUserId).FirstOrDefault();
            paymentReceive.ModifiedBy = userProfile.Email;
            paymentReceive.ModifiedAt = DateTime.Now.ToString();

            _context.PaymentReceive.Update(paymentReceive);
            _context.SaveChanges();
            return Ok(paymentReceive);
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> Remove([FromBody]CrudViewModel<Models.PaymentReceive> payload)
        {
            //Models.PaymentReceive paymentReceive = _context.PaymentReceive
            //    .Where(x => x.PaymentReceiveId == Convert.ToInt32(payload.key))
            //    .FirstOrDefault();
            //_context.PaymentReceive.Remove(paymentReceive);
            //_context.SaveChanges();
            //return Ok(paymentReceive);
            var paymentReceive = await _context.PaymentReceive.FindAsync(Convert.ToInt32(payload.key));

            if (paymentReceive == null)
            {
                return NotFound();
            }

            try
            {
                /*----User email----*/
                var applicationUserId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
                UserProfile userProfile = _context.UserProfile.Where(x => x.ApplicationUserId == applicationUserId).FirstOrDefault();
                paymentReceive.ModifiedBy = userProfile.Email;
                paymentReceive.ModifiedAt = DateTime.Now.ToString();
                paymentReceive.DomainStatus = false;
                _context.PaymentReceive.Update(paymentReceive);
                await _context.SaveChangesAsync();
                return Ok(paymentReceive);
            }
            catch (DbUpdateException ex)
            {
                //Log the error (uncomment ex variable name and write a log.)
                return NotFound(ex.Message);
            }

        }
    }
}