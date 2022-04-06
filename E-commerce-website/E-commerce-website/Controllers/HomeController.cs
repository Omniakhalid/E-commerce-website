using E_commerce_website.Models;
using E_commerce_website.Context;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace E_commerce_website.Controllers
{
    public class HomeController : Controller
    {
        // private readonly ILogger<HomeController> _logger;
        private readonly OnlineshoppingContext _context;
        private readonly bool _contextAccessor;

        public HomeController(OnlineshoppingContext context, IHttpContextAccessor contextAccessor)
        {
            // _logger = logger;
            _context = context;
            _contextAccessor = contextAccessor.HttpContext.User.IsInRole("Vendor");

        }

        public async Task<IActionResult> Index()
        {
            var onlineshoppingContext = _context.Products;
        /*    if (!_contextAccessor)
                return RedirectToRoute("ProductArea/Products/Index");*/
            return View(await onlineshoppingContext.ToListAsync());
            //return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
