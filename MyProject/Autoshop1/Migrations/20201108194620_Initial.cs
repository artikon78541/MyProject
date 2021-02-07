using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Autoshop1.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CartItems",
                columns: table => new
                {
                    CartItemID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CartVendorId = table.Column<int>(nullable: false),
                    CartBrand = table.Column<string>(nullable: true),
                    CartPartNumber = table.Column<string>(nullable: true),
                    CartPartName = table.Column<string>(nullable: true),
                    CartBuyingPrice = table.Column<decimal>(nullable: false),
                    CartSellingPrice = table.Column<decimal>(nullable: false),
                    CartQuantity = table.Column<int>(nullable: false),
                    CartId = table.Column<string>(nullable: true),
                    DeliveryDate = table.Column<DateTime>(nullable: false),
                    CartDate = table.Column<DateTime>(nullable: false),
                    UserId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CartItems", x => x.CartItemID);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    CustomerId = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 30, nullable: false),
                    Phone = table.Column<string>(maxLength: 14, nullable: false),
                    Email = table.Column<string>(nullable: false),
                    Address = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.CustomerId);
                });

            migrationBuilder.CreateTable(
                name: "Parts",
                columns: table => new
                {
                    PartId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VendorId = table.Column<int>(nullable: false),
                    Brand = table.Column<string>(maxLength: 30, nullable: false),
                    PartNumber = table.Column<string>(maxLength: 15, nullable: false),
                    PartName = table.Column<string>(nullable: false),
                    BuyingPrice = table.Column<decimal>(nullable: false),
                    SellingPrice = table.Column<decimal>(nullable: false),
                    QuantityInStock = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Parts", x => x.PartId);
                });

            migrationBuilder.CreateTable(
                name: "Vendors",
                columns: table => new
                {
                    VendorId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VendorName = table.Column<string>(maxLength: 30, nullable: true),
                    DeliveryTime = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vendors", x => x.VendorId);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    OrderId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderDate = table.Column<DateTime>(nullable: false),
                    CustomerId = table.Column<string>(nullable: true),
                    OrderSellingPrice = table.Column<double>(nullable: false),
                    OrderByuingPrice = table.Column<double>(nullable: false),
                    ToSellDate = table.Column<DateTime>(nullable: false),
                    DeliveryType = table.Column<string>(maxLength: 3, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.OrderId);
                    table.ForeignKey(
                        name: "FK_Orders_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "CustomerId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OrderedParts",
                columns: table => new
                {
                    OrderedPartId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VendorId = table.Column<string>(nullable: true),
                    OrdBrand = table.Column<string>(maxLength: 30, nullable: false),
                    OrdPartNumber = table.Column<string>(maxLength: 15, nullable: false),
                    OrdPartName = table.Column<string>(nullable: false),
                    OrdBuyingPrice = table.Column<decimal>(nullable: false),
                    OrdSellingPrice = table.Column<decimal>(nullable: false),
                    OrdQuant = table.Column<int>(nullable: false),
                    TotalOrdBuyingPrice = table.Column<decimal>(nullable: false),
                    TotalOrdSellingPrice = table.Column<decimal>(nullable: false),
                    CustomerId = table.Column<string>(nullable: true),
                    OrderId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderedParts", x => x.OrderedPartId);
                    table.ForeignKey(
                        name: "FK_OrderedParts_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "OrderId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_OrderedParts_OrderId",
                table: "OrderedParts",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_CustomerId",
                table: "Orders",
                column: "CustomerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CartItems");

            migrationBuilder.DropTable(
                name: "OrderedParts");

            migrationBuilder.DropTable(
                name: "Parts");

            migrationBuilder.DropTable(
                name: "Vendors");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Customers");
        }
    }
}
