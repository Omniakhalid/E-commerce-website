using E_commerce_website.Context;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using E_commerce_website.Models;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using E_commerce_website.Areas.Identity.Data;
using E_commerce_website.Repositories;
using E_commerce_website.Areas.ClientArea.Services;
using E_commerce_website.Services;

namespace E_commerce_website
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();

            services.AddHttpContextAccessor();
            services.AddDbContext<OnlineshoppingContext>(options => options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
           
            
            services.Configure<StripeSettings>(Configuration.GetSection("Stripe"));
            services.AddTransient<IEmailSender, EmailSender>();
            #region Repository DI

            // Products
            services.AddScoped<IProductRepository, ProductRepository>();
                services.AddScoped<IProductOptionRepository, ProductOptionRepository>();
                services.AddScoped<IProductCategoryRepository, ProductCategoryRepository>();

                //Cart
                services.AddScoped<ICartItemRepository, CartItemRepository>();
                services.AddScoped<ICartItemsOptionRepository, CartItemsOptionRepository>();

                // Order
                services.AddScoped<IOrdersRepository, OrdersRepository>();
                services.AddScoped<IOrderDetailRepository, OrderDetailRepository>();
                services.AddScoped<IOrderItemsOptionRepository, OrderItemsOptionRepository>();

                //Option

                services.AddScoped<IOptionRepository, OptionRepository>();
                services.AddScoped<IOptionGroupRepository, OptionGroupRepository>();
                
                //Users
                services.AddScoped<IUsersRepository, UsersRepository>();
                

            #endregion

            #region Services ClientArea DI

            //Cart
            services.AddScoped<ICartService, CartService>();
            services.AddScoped<ICartOptionsService, CartOptionsService>();

            //Product
            services.AddScoped<IProductService, ProductService>();

            //Order
            services.AddScoped<IOrderService, OrderService>();
            services.AddScoped<IOrderItemsOptionService, OrderItemsOptionService>();
            #endregion


            #region Shared Services
            services.AddScoped<IUserService, UserService>();

            #endregion
            #region External Logins
            services.AddAuthentication().AddGoogle(op =>
            {
                IConfigurationSection googleAuthSection = Configuration.GetSection("Authentication:Google");
                op.ClientId = googleAuthSection["ClientId"];
                op.ClientSecret = googleAuthSection["ClientSecret"];
            }).AddFacebook(op =>
            {
                IConfigurationSection facebookAuthSection = Configuration.GetSection("Authentication:FaceBook");
                op.ClientId = facebookAuthSection["ClientId"];
                op.ClientSecret = facebookAuthSection["ClientSecret"];
            });
            #endregion
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {

         
            app.UseAuthentication();
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}");
            });
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
