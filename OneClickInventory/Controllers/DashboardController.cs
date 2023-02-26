using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OneClickInventory.Data;
using OneClickInventory.Models;

namespace OneClickInventory.Controllers
{
    
    public class DashboardController : Controller
    {
        private readonly ApplicationDbContext _context;
        public DashboardController(ApplicationDbContext context)
        {
            _context = context;
        }
        [Authorize(Roles = Pages.MainMenu.Dashboard.RoleName)]
        public async Task<IActionResult> Index()
        {
            List<ProductType> ProductTypes = await _context.ProductType.ToListAsync();
            int ProductTypeCount = 0;
            foreach (var productType in ProductTypes)
            {
                ProductTypeCount++;
            }
            ViewBag.ProductTypeCount = ProductTypeCount.ToString();

            List<Product> Products = await _context.Product.Where(x => x.DomainStatus == true).ToListAsync();
            int ProductCount = 0;
            foreach(var count in Products)
            {
                ProductCount++;
            }
            ViewBag.ProductCount = ProductCount.ToString();

            List<SalesOrder> SalesOrders = await _context.SalesOrder.ToListAsync();
            int SalesOrderCount = 0;
            foreach(var sales in SalesOrders) 
            {
                SalesOrderCount++;
            }
            ViewBag.SalesOrderCount = SalesOrderCount.ToString();

            List<Customer> customers = await _context.Customer.ToListAsync();
            int customersCount = 0;
            foreach (var customer in customers)
            {
                customersCount++;
            }
            ViewBag.customersCount = customersCount.ToString();



            return View();
        }
    }
}