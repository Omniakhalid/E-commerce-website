using Microsoft.EntityFrameworkCore.Migrations;

namespace E_commerce_website.Migrations.Onlineshopping
{
    public partial class EditCartOptionsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Quantity",
                table: "CartItemsOptions");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Quantity",
                table: "CartItemsOptions",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
