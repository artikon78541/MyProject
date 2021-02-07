using Microsoft.EntityFrameworkCore.Migrations;

namespace Autoshop1.Migrations
{
    public partial class Ver2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "OrderSellingPrice",
                table: "Orders",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<decimal>(
                name: "OrderByuingPrice",
                table: "Orders",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "OrderSellingPrice",
                table: "Orders",
                type: "float",
                nullable: false,
                oldClrType: typeof(decimal));

            migrationBuilder.AlterColumn<double>(
                name: "OrderByuingPrice",
                table: "Orders",
                type: "float",
                nullable: false,
                oldClrType: typeof(decimal));
        }
    }
}
