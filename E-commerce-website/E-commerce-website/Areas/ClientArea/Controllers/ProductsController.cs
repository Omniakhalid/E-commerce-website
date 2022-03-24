using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using E_commerce_website.Context;
using E_commerce_website.Models;
using System.Diagnostics;

namespace E_commerce_website.Areas.ClientArea.Controllers
{
    [Area("ClientArea")]
    public class ProductsController : Controller
    {
        private readonly OnlineshoppingContext _context;

        public ProductsController(OnlineshoppingContext context)
        {
            _context = context;
        }

        // GET: ClientArea/Products
        public async Task<IActionResult> Index()
        {
            var onlineshoppingContext = _context.Products
                                                .Include(p => p.ProductCategory)
                                                .Include(p => p.Vendor)
                                                ;


            return View(await onlineshoppingContext.ToListAsync());
        }

        // GET: ClientArea/Products/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = _context.Products
                                .Include(p => p.ProductCategory)
                                .Include(p => p.Vendor)
                                .FirstOrDefault(p => p.ProductID == id);



            var ProductOptions = _context.ProductOptions
                                            .Include(p=>p.Option)
                                            .ThenInclude(p=>p.OptionGroup)
                                            .Where(p => p.ProductID == id).ToList()
                                            .GroupBy(p => p.Option.OptionGroup.OptionGroupName);

            
            foreach(var group in ProductOptions)
            {
                Debug.WriteLine(group.Select(c=>c.Option.OptionGroup.OptionGroupName));

                foreach (var element in group)
                {
                    
                    Debug.WriteLine($"{element.Option.OptionName}{element.Option.OptionID}");
                }
            }

            ViewBag.ProductOptions = ProductOptions;

            return View(product);
        }

        // GET: ClientArea/Products/Create
        public IActionResult Create()
        {
            ViewData["ProductCategoryID"] = new SelectList(_context.ProductCategories, "CategoryID", "CategoryName");
            ViewData["VendorID"] = new SelectList(_context.Vendors, "VendorID", "VendorAddress");
            return View();
        }

        // POST: ClientArea/Products/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ProductID,ProductName,ProductPrice,ProductWeight,ProductShortDes,ProductLongDes,ProductImage,ProductCategoryID,ProductUpdateDate,ProductStock,VendorID")] Product product)
        {
            if (ModelState.IsValid)
            {
                _context.Add(product);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ProductCategoryID"] = new SelectList(_context.ProductCategories, "CategoryID", "CategoryName", product.ProductCategoryID);
            ViewData["VendorID"] = new SelectList(_context.Vendors, "VendorID", "VendorAddress", product.VendorID);
            return View(product);
        }

        // GET: ClientArea/Products/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Products.FindAsync(id);
            if (product == null)
            {
                return NotFound();
            }
            ViewData["ProductCategoryID"] = new SelectList(_context.ProductCategories, "CategoryID", "CategoryName", product.ProductCategoryID);
            ViewData["VendorID"] = new SelectList(_context.Vendors, "VendorID", "VendorAddress", product.VendorID);
            return View(product);
        }

        // POST: ClientArea/Products/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ProductID,ProductName,ProductPrice,ProductWeight,ProductShortDes,ProductLongDes,ProductImage,ProductCategoryID,ProductUpdateDate,ProductStock,VendorID")] Product product)
        {
            if (id != product.ProductID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(product);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProductExists(product.ProductID))
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
            ViewData["ProductCategoryID"] = new SelectList(_context.ProductCategories, "CategoryID", "CategoryName", product.ProductCategoryID);
            ViewData["VendorID"] = new SelectList(_context.Vendors, "VendorID", "VendorAddress", product.VendorID);
            return View(product);
        }

        // GET: ClientArea/Products/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Products
                .Include(p => p.ProductCategory)
                .Include(p => p.Vendor)
                .FirstOrDefaultAsync(m => m.ProductID == id);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        // POST: ClientArea/Products/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var product = await _context.Products.FindAsync(id);
            _context.Products.Remove(product);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProductExists(int id)
        {
            return _context.Products.Any(e => e.ProductID == id);
        }
    }
}
