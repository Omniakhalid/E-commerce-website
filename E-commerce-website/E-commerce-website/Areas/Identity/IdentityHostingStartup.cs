using System;
using E_commerce_website.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(E_commerce_website.Areas.Identity.IdentityHostingStartup))]
namespace E_commerce_website.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<E_commerce_websiteContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("E_commerce_websiteContextConnection")));

                services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
                    .AddEntityFrameworkStores<E_commerce_websiteContext>();
            });
        }
    }
}