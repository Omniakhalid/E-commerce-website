using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace E_commerce_website.Migrations
{
    public partial class addprofilePic : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte[]>(
                name: "Userimage",
                table: "AspNetUsers",
                type: "varbinary(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Userimage",
                table: "AspNetUsers");
        }
    }
}
