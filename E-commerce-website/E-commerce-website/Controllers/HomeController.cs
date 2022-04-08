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
using System.Security.Claims;

namespace E_commerce_website.Controllers
{
    public class HomeController : Controller
    {
        // private readonly ILogger<HomeController> _logger;
        private readonly OnlineshoppingContext _context;
        private readonly ClaimsPrincipal _user;

        public HomeController(OnlineshoppingContext context, IHttpContextAccessor contextAccessor)
        {
            // _logger = logger;
            _context = context;
            _user = contextAccessor.HttpContext.User;

        }

        public async Task<IActionResult> Index()
        {
            if (_user.IsInRole("Vendor"))
                return RedirectToAction("Index", "Products", new { area = "ProductArea" });

            var onlineshoppingContext = _context.Products.Include(c => c.ProductCategory);

            var mylist = _context.ProductCategories.Where(c=>c.CategoryName != null).ToList();
            ViewBag.categories = mylist;
            ViewBag.categories2 = new SelectList(_context.ProductCategories.ToList(), "CategoryID", "CategoryName");
            return View(await onlineshoppingContext.ToListAsync());
            //return View();
        }



        [HttpPost]
        public ActionResult Index(int CategoryID)
        {
            SelectList items = new SelectList(_context.ProductCategories.ToList(), "CategoryID", "CategoryName");
            ViewBag.categories2 = items;
            return View(_context.Products.Where(c => c.ProductCategoryID == CategoryID).ToList());
        }





        public IActionResult showProductsByCategoryID()
        {
            return PartialView("showProductsByCategoryID", _context.ProductCategories.ToList());
        }

        public IActionResult getProductbyId(int? CategoryID)
        {
            if (CategoryID != null)
            {
                var productList = _context.Products
                                          //.OrderByDescending(x => x.ProductID)
                                          .Where(x => x.ProductCategoryID == CategoryID)
                                          .ToList();
                return Json(productList);
            }
            else
            {
                var productList = _context.Products
                                          .OrderByDescending(x => x.ProductID)
                                          .ToList();
                return Json(productList);
            }
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
