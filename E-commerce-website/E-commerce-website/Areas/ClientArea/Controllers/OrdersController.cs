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

namespace E_commerce_website.Areas.ClientArea.Controllers
{
    [Area("ClientArea")]
    [Authorize]
    public class OrdersController : Controller
    {
        private readonly OnlineshoppingContext _context;
        private readonly IHttpContextAccessor _contextAccessor;
        private readonly string _user;
        public OrdersController(OnlineshoppingContext context, IHttpContextAccessor contextAccessor)
        {
            _context = context;
            _contextAccessor = contextAccessor;
            _user = _contextAccessor.HttpContext.User.Identity.Name;
        }

        public async Task<IActionResult> Checkout()
        {

            return View();
        }
        public async Task<IActionResult> Index()
        {
            return View(GetOrders(_user)??new List<Order>());
        }

        // GET: ClientArea/Orders
        public List<Order> GetOrders(string email)
        {
            var onlineshoppingContext = _context.Orders.Include(o => o.User)
                                                       .Include(p => p.OrderDetails)
                                                       .ThenInclude(p => p.Product)
                                                       .Where(c => c.User.UserEmail == email);

            return (onlineshoppingContext?.ToList());
        }

        // GET: ClientArea/Orders/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var order = await _context.Orders
                .Include(o => o.User)
                .FirstOrDefaultAsync(m => m.OrderID == id);
            if (order == null)
            {
                return NotFound();
            }

            return View(order);
        }

        // GET: ClientArea/Orders/Create
        public IActionResult Create()
        {
            ViewData["UserID"] = new SelectList(_context.Users, "UserID", "UserAddress");
            return View();
        }

        // POST: ClientArea/Orders/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("OrderID,UserID,OrderAmount,ShippingAddress,OrderDate,OrderStatus,OrderTrakingNumber,OrderCountry,OrderCity,OrderPhone,OrderEmail")] Order order)
        {
            try
            {
                var UserID = _context.Users.FirstOrDefault(c => c.UserEmail == _user).UserID;
                order.UserID = UserID;
                _context.Add(order);
                await _context.SaveChangesAsync();

                _context.AddRange(OrderDetails(order.OrderID));
                await _context.SaveChangesAsync();

                var CartItems = _context.CartItems.Where(c => c.UserID == UserID);
                _context.RemoveRange(CartItems);
                _context.SaveChanges();

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                ViewData["UserID"] = new SelectList(_context.Users, "UserID", "UserAddress", order.UserID);
                return View(order);

            }
        }
        public List<OrderDetail> OrderDetails(int OrderID)
        {
            var Cart = _context.CartItems.Where(c => c.User.UserEmail == _user).Include(p => p.Product).ToList();
            var Result = new List<OrderDetail>();
            foreach (var item in Cart)
            {
                Result.Add(new OrderDetail()
                {
                    OrderID = OrderID,
                    ProductID = item.ProductID,
                    Quanity = item.Quantity,
                    ProductName = item.Product?.ProductName,
                    Price = item.Product.ProductPrice * item.Quantity
                });
            }
            return Result;
        }

        // GET: ClientArea/Orders/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var order = await _context.Orders.FindAsync(id);
            if (order == null)
            {
                return NotFound();
            }
            ViewData["UserID"] = new SelectList(_context.Users, "UserID", "UserAddress", order.UserID);
            return View(order);
        }

        // POST: ClientArea/Orders/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("OrderID,UserID,OrderAmount,ShippingAddress,OrderDate,OrderStatus,OrderTrakingNumber,OrderCountry,OrderCity,OrderPhone,OrderEmail")] Order order)
        {
            if (id != order.OrderID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(order);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!OrderExists(order.OrderID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["UserID"] = new SelectList(_context.Users, "UserID", "UserAddress", order.UserID);
            return View(order);
        }

        // GET: ClientArea/Orders/Delete/5
        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var order = await _context.Orders
                .Include(o => o.User)
                .FirstOrDefaultAsync(m => m.OrderID == id);
            if (order == null)
            {
                return NotFound();
            }

            return View(order);
        }

        // POST: ClientArea/Orders/Delete/5
     
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var order = await _context.Orders.FindAsync(id);
            _context.Orders.Remove(order);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool OrderExists(int id)
        {
            return _context.Orders.Any(e => e.OrderID == id);
        }
    }
}
