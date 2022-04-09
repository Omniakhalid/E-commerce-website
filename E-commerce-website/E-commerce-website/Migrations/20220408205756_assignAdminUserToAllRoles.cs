using Microsoft.EntityFrameworkCore.Migrations;

namespace E_commerce_website.Migrations
{
    public partial class assignAdminUserToAllRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO [dbo].[AspNetUserRoles](UserId,RoleId) SELECT 'd3f742b8-e84c-4b45-9ae9-1e7939156ee8',Id FROM [dbo].[AspNetRoles]");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM [dbo].[AspNetUserRoles] WHERE UserId='d3f742b8-e84c-4b45-9ae9-1e7939156ee8'");
        }
    }
}
