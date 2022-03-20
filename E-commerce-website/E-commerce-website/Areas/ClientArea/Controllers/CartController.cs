using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using E_commerce_website.Models;
using E_commerce_website.onlineDbContext;

namespace E_commerce_website.Areas.ClientArea.Controllers
{
    [Area("ClientArea")]
    public class CartController : Controller
    {
        private readonly OnlineshoppingContext _context;

        public CartController(OnlineshoppingContext context)
        {
            _context = context;
        }

        // GET: ClientArea/Cart
        public async Task<IActionResult> Index()
        {
            var onlineshoppingContext = _context.CartItems.Where(c=>c.UserID == 1)
                                                          .Include(c => c.Product).Include(c => c.User)
                                                          .Include(c=>c.Product.ProductCategory);

            return View(await onlineshoppingContext.ToListAsync());
        }
       
        public async Task<IActionResult> Increament(int id)
        {
            var cartItems = _context.CartItems.FirstOrDefault(c => c.UserID == 1 && c.ProductID == id);
            cartItems.Quantity++;
           _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Decreament(int id)
        {
            var cartItems = _context.CartItems.FirstOrDefault(c => c.UserID == 1 && c.ProductID == id);
            cartItems.Quantity--;
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
      
        // GET: ClientArea/Cart/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cartItem = await _context.CartItems
                .Include(c => c.Product)
                .Include(c => c.User)
                .FirstOrDefaultAsync(m => m.id == id);
            if (cartItem == null)
            {
                return NotFound();
            }

            return View(cartItem);
        }

        // GET: ClientArea/Cart/Create
        public IActionResult Create()
        {
            ViewData["ProductID"] = new SelectList(_context.Products, "ProductID", "ProductImage");
            ViewData["UserID"] = new SelectList(_context.Users, "UserID", "UserAddress");
            return View();
        }

        // POST: ClientArea/Cart/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,UserID,ProductID,Quantity")] CartItem cartItem)
        {
            if (ModelState.IsValid)
            {
                _context.Add(cartItem);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ProductID"] = new SelectList(_context.Products, "ProductID", "ProductImage", cartItem.ProductID);
            ViewData["UserID"] = new SelectList(_context.Users, "UserID", "UserAddress", cartItem.UserID);
            return View(cartItem);
        }

        // GET: ClientArea/Cart/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cartItem = await _context.CartItems.FindAsync(id);
            if (cartItem == null)
            {
                return NotFound();
            }
            ViewData["ProductID"] = new SelectList(_context.Products, "ProductID", "ProductImage", cartItem.ProductID);
            ViewData["UserID"] = new SelectList(_context.Users, "UserID", "UserAddress", cartItem.UserID);
            return View(cartItem);
        }

        // POST: ClientArea/Cart/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,UserID,ProductID,Quantity")] CartItem cartItem)
        {
            if (id != cartItem.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(cartItem);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CartItemExists(cartItem.id))
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
            ViewData["ProductID"] = new SelectList(_context.Products, "ProductID", "ProductImage", cartItem.ProductID);
            ViewData["UserID"] = new SelectList(_context.Users, "UserID", "UserAddress", cartItem.UserID);
            return View(cartItem);
        }

        // GET: ClientArea/Cart/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cartItem = await _context.CartItems
                .Include(c => c.Product)
                .Include(c => c.User)
                .FirstOrDefaultAsync(m => m.id == id);
            if (cartItem == null)
            {
                return NotFound();
            }

            return View(cartItem);
        }

        // POST: ClientArea/Cart/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var cartItem = await _context.CartItems.FindAsync(id);
            _context.CartItems.Remove(cartItem);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CartItemExists(int id)
        {
            return _context.CartItems.Any(e => e.id == id);
        }
    }
}
