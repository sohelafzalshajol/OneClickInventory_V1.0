using Microsoft.EntityFrameworkCore.Migrations;

namespace OneClickInventory.Migrations
{
    public partial class seeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "DomainStatus",
                table: "Product",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "ModifiedAt",
                table: "Product",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ModifiedBy",
                table: "Product",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "DomainStatus",
                table: "PaymentVoucher",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "ModifiedAt",
                table: "PaymentVoucher",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ModifiedBy",
                table: "PaymentVoucher",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "DomainStatus",
                table: "PaymentReceive",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "ModifiedAt",
                table: "PaymentReceive",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ModifiedBy",
                table: "PaymentReceive",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "DomainStatus",
                table: "Invoice",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "ModifiedAt",
                table: "Invoice",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ModifiedBy",
                table: "Invoice",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "DomainStatus",
                table: "Branch",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "ModifiedAt",
                table: "Branch",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ModifiedBy",
                table: "Branch",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "DomainStatus",
                table: "BillType",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "ModifiedAt",
                table: "BillType",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ModifiedBy",
                table: "BillType",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "DomainStatus",
                table: "Bill",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "ModifiedAt",
                table: "Bill",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ModifiedBy",
                table: "Bill",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DomainStatus",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "ModifiedAt",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "DomainStatus",
                table: "PaymentVoucher");

            migrationBuilder.DropColumn(
                name: "ModifiedAt",
                table: "PaymentVoucher");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "PaymentVoucher");

            migrationBuilder.DropColumn(
                name: "DomainStatus",
                table: "PaymentReceive");

            migrationBuilder.DropColumn(
                name: "ModifiedAt",
                table: "PaymentReceive");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "PaymentReceive");

            migrationBuilder.DropColumn(
                name: "DomainStatus",
                table: "Invoice");

            migrationBuilder.DropColumn(
                name: "ModifiedAt",
                table: "Invoice");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "Invoice");

            migrationBuilder.DropColumn(
                name: "DomainStatus",
                table: "Branch");

            migrationBuilder.DropColumn(
                name: "ModifiedAt",
                table: "Branch");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "Branch");

            migrationBuilder.DropColumn(
                name: "DomainStatus",
                table: "BillType");

            migrationBuilder.DropColumn(
                name: "ModifiedAt",
                table: "BillType");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "BillType");

            migrationBuilder.DropColumn(
                name: "DomainStatus",
                table: "Bill");

            migrationBuilder.DropColumn(
                name: "ModifiedAt",
                table: "Bill");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "Bill");
        }
    }
}
