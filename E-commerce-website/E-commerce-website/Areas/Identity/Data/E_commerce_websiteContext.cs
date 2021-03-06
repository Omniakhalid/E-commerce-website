using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using E_commerce_website.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace E_commerce_website.Data
{
    public class E_commerce_websiteContext : IdentityDbContext<websiteUser>
    {
        public E_commerce_websiteContext(DbContextOptions<E_commerce_websiteContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }
    }
}
