using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DriveNation.Migrations
{
    public partial class SimplifiedDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Car_Brand_BrandId",
                table: "Car");

            migrationBuilder.DropTable(
                name: "Brand");

            migrationBuilder.DropIndex(
                name: "IX_Car_BrandId",
                table: "Car");

            migrationBuilder.DropColumn(
                name: "BrandId",
                table: "Car");

            migrationBuilder.AddColumn<int>(
                name: "BrandName",
                table: "Car",
                type: "int",
                maxLength: 50,
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BrandName",
                table: "Car");

            migrationBuilder.AddColumn<int>(
                name: "BrandId",
                table: "Car",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Brand",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Brand", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Car_BrandId",
                table: "Car",
                column: "BrandId");

            migrationBuilder.AddForeignKey(
                name: "FK_Car_Brand_BrandId",
                table: "Car",
                column: "BrandId",
                principalTable: "Brand",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
