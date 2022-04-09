using Microsoft.EntityFrameworkCore.Migrations;

namespace E_commerce_website.Migrations
{
    public partial class addAdminUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO [dbo].[AspNetUsers] ([Id], [UserFirstName], [UserCity], [UserPhone], [UserAddress], [type], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount], [Userimage]) VALUES (N'd3f742b8-e84c-4b45-9ae9-1e7939156ee8', N'Admin', N'cairo', N'01111111111', N'Egypt', 2, N'nadamostafa42127@gmail.com', N'NADAMOSTAFA42127@GMAIL.COM', N'nadamostafa42127@gmail.com', N'NADAMOSTAFA42127@GMAIL.COM', 1, N'AQAAAAEAACcQAAAAEHkhF/aHvYkcC6JCjO5LxFHMlrS5k/kMgrlbhimuxhsgJJYmo2QwdvFc7cOGBE2ofQ==', N'GY7F4H2BY22KCOE6PDUTONF2VFBQAUR7', N'478f5c44-4c8b-4e0d-833c-1911cf90045c', NULL, 0, 0, NULL, 1, 0, NULL)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM [dbo].[AspNetUsers] WHERE Id='d3f742b8-e84c-4b45-9ae9-1e7939156ee8'");
        }
    }
}
