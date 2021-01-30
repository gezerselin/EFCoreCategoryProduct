using Microsoft.EntityFrameworkCore.Migrations;

namespace EFCoreCategoryProduct.Migrations
{
    public partial class guncel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ProductCount",
                table: "Categories",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProductCount",
                table: "Categories");
        }
    }
}
