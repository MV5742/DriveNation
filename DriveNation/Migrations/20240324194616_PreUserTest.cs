using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DriveNation.Migrations
{
    public partial class PreUserTest : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BuyPrice",
                table: "Car");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "BuyPrice",
                table: "Car",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);
        }
    }
}
