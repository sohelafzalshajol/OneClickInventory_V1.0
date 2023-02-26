using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using OneClickInventory.Models;

namespace OneClickInventory.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }

        public DbSet<OneClickInventory.Models.ApplicationUser> ApplicationUser { get; set; }

        public DbSet<OneClickInventory.Models.Bill> Bill { get; set; }

        public DbSet<OneClickInventory.Models.BillType> BillType { get; set; }

        public DbSet<OneClickInventory.Models.Branch> Branch { get; set; }

        public DbSet<OneClickInventory.Models.CashBank> CashBank { get; set; }

        public DbSet<OneClickInventory.Models.Currency> Currency { get; set; }

        public DbSet<OneClickInventory.Models.Customer> Customer { get; set; }

        public DbSet<OneClickInventory.Models.CustomerType> CustomerType { get; set; }

        public DbSet<OneClickInventory.Models.GoodsReceivedNote> GoodsReceivedNote { get; set; }

        public DbSet<OneClickInventory.Models.Invoice> Invoice { get; set; }

        public DbSet<OneClickInventory.Models.InvoiceType> InvoiceType { get; set; }

        public DbSet<OneClickInventory.Models.NumberSequence> NumberSequence { get; set; }

        public DbSet<OneClickInventory.Models.PaymentReceive> PaymentReceive { get; set; }

        public DbSet<OneClickInventory.Models.PaymentType> PaymentType { get; set; }

        public DbSet<OneClickInventory.Models.PaymentVoucher> PaymentVoucher { get; set; }

        public DbSet<OneClickInventory.Models.Product> Product { get; set; }

        public DbSet<OneClickInventory.Models.ProductType> ProductType { get; set; }

        public DbSet<OneClickInventory.Models.PurchaseOrder> PurchaseOrder { get; set; }

        public DbSet<OneClickInventory.Models.PurchaseOrderLine> PurchaseOrderLine { get; set; }

        public DbSet<OneClickInventory.Models.PurchaseType> PurchaseType { get; set; }

        public DbSet<OneClickInventory.Models.SalesOrder> SalesOrder { get; set; }

        public DbSet<OneClickInventory.Models.SalesOrderLine> SalesOrderLine { get; set; }

        public DbSet<OneClickInventory.Models.SalesType> SalesType { get; set; }

        public DbSet<OneClickInventory.Models.Shipment> Shipment { get; set; }

        public DbSet<OneClickInventory.Models.ShipmentType> ShipmentType { get; set; }

        public DbSet<OneClickInventory.Models.UnitOfMeasure> UnitOfMeasure { get; set; }

        public DbSet<OneClickInventory.Models.Vendor> Vendor { get; set; }

        public DbSet<OneClickInventory.Models.VendorType> VendorType { get; set; }

        public DbSet<OneClickInventory.Models.Warehouse> Warehouse { get; set; }

        public DbSet<OneClickInventory.Models.UserProfile> UserProfile { get; set; }
    }
}
