using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using E_commerce_website.Context;
using E_commerce_website.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Authorization;
using System.Diagnostics;
using E_commerce_website.Areas.ClientArea.Services;
using E_commerce_website.Services;

namespace E_commerce_website.Areas.ClientArea.Controllers
{
    [Authorize]
    [Area("ClientArea")]
    public class CartController : Controller
    {
        private readonly OnlineshoppingContext _context;

        private readonly IHttpContextAccessor _contextAccessor;
        private ICartService _cartService;
        private ICartOptionsService _cartOptionsService;
        private IProductService _productService;
        private IUserService _userService;
        private int _UserID;

        public CartController(OnlineshoppingContext context, IHttpContextAccessor contextAccessor,
                              ICartService cartService, ICartOptionsService cartOptionsService
                              ,IProductService productService,IUserService userService)
        {
            _context = context;
            _cartService = cartService;
            _cartOptionsService = cartOptionsService;
            _productService = productService;
            _userService = userService;

           var _userEmail = contextAccessor.HttpContext.User.Identity.Name;
            _UserID = userService.GetByEmail(_userEmail).UserID;

        }

        // GET: ClientArea/Cart
        public IActionResult Index()
        {
            var CartItems = _cartService.GetAll(_UserID);

            ViewBag.CartItemsWizOptions =_cartOptionsService.GetAll(_UserID);

            ViewBag.Quantity = CartItems.Select(c => c.Quantity).Sum();


            ViewBag.TotalPrice = CartItems.Select(c => c.Quantity * c.Product.ProductPrice).Sum();

            return View(CartItems);
        }

        public IActionResult Increament(int id)
        {
            _cartService.IncreamentItemInCart(_UserID,id);
            return RedirectToAction("Index");
        }

        public IActionResult Decreament(int id)
        {
            _cartService.DecreamentItemInCart(_UserID, id);
            return RedirectToAction("Index");
        }
     

  

        public IActionResult AddItemsOptionsIntoCart(int Productid, IEnumerable<int> Options)
        {
          
            _cartService.AddItemsOptionsIntoCart(_UserID, Productid, Options);

            return RedirectToAction("Index");
        }


        

      
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int productId)
        {
            _cartService.Remove(_UserID, productId);
            return RedirectToAction(nameof(Index));
        }

    }
}
