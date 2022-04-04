using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using E_commerce_website.Context;
using E_commerce_website.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using E_commerce_website.Areas.ClientArea.Services;
using E_commerce_website.Services;

namespace E_commerce_website.Areas.ClientArea.Controllers
{
    [Area("ClientArea")]
    [Authorize]
    public class OrdersController : Controller
    {
        private readonly IHttpContextAccessor _contextAccessor;
        private readonly int _userId;
        private readonly IOrderItemsOptionService _orderItemsOptionService;
        private readonly IOrderService _orderService;
        private readonly ICartService _cartService;
        private readonly IUserService _userService;

        public OrdersController( IHttpContextAccessor contextAccessor,
                                IOrderItemsOptionService orderItemsOptionService,IOrderService orderService,
                                ICartService cartService,IUserService userService)
        {

            _orderItemsOptionService = orderItemsOptionService;
            _orderService = orderService;
            _cartService = cartService;
            _userService = userService;

            var _userEmail = contextAccessor.HttpContext.User.Identity.Name;
            _userId = _userService.GetByEmail(_userEmail).UserID;

        }

        public IActionResult Checkout()
        {
            return View();
        }

        public IActionResult Index()
        {
            ViewBag.OrderOptions = _orderItemsOptionService.GetAll(_userId);

            var orders = _orderService.GetAll(_userId);

            return View(orders);
        }

 
        // POST: ClientArea/Orders/Create
   
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("OrderID,UserID,OrderAmount,ShippingAddress,OrderDate,OrderStatus,OrderTrakingNumber,OrderCountry,OrderCity,OrderPhone,OrderEmail")] Order order)
        {
            try
            {
                
                order.UserID = _userId;
                _orderService.Add(order);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                ViewData["UserID"] = new SelectList(_userService.GetAll(), "UserID", "UserAddress", order.UserID);
                return View(order);

            }
        }

      

        // POST: ClientArea/Orders/Edit/5


 

      


        
    }
}
