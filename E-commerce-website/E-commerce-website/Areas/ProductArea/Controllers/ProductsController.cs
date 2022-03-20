using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using E_commerce_website.Models;
using E_commerce_website.onlineDbContext;
using Microsoft.AspNetCore.Hosting;
using E_commerce_website.Areas.ProductArea.ViewModels;
using System.IO;

namespace E_commerce_website.Areas.ProductArea.Controllers
{
    [Area("ProductArea")]
    public class ProductsController : Controller
    {
        private readonly OnlineshoppingContext _context;
        private readonly IWebHostEnvironment webHostEnvironment;

        public ProductsController(OnlineshoppingContext context, IWebHostEnvironment hostEnvironment)
        {
            _context = context;
            webHostEnvironment = hostEnvironment;
        }

        // GET: ProductArea/Products
        public async Task<IActionResult> Index()
        {
            var onlineshoppingContext = _context.Products.Include(p => p.ProductCategory).Include(p => p.Vendor);
            return View(await onlineshoppingContext.ToListAsync());
        }

        // GET: ProductArea/Products/Details/5
        public async Task<IActionResult> Details(int? id)
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

        // GET: ProductArea/Products/Create
        public IActionResult Create()
        {
            ViewData["ProductCategoryID"] = new SelectList(_context.ProductCategories, "CategoryID", "CategoryName");
            ViewData["VendorID"] = new SelectList(_context.Vendors, "VendorID", "VendorName");
            return View();
        }

        // POST: ProductArea/Products/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ProductID,ProductName,ProductPrice,ProductWeight,ProductShortDes,ProductLongDes,ProductImage,ProductCategoryID,ProductUpdateDate,ProductStock,VendorID")] Product product,ProductViewModel productViewModel)
        {
            //if (ModelState.IsValid)
            if(productViewModel.ProductName!=null)
            {
                string wwwRootPath = webHostEnvironment.WebRootPath;//GUID
                string fileName = Path.GetFileNameWithoutExtension(productViewModel.ProductImageFile.FileName);
                string extension = Path.GetExtension(productViewModel.ProductImageFile.FileName);
                productViewModel.ProductImage = fileName = fileName + DateTime.Now.ToString("yymmssfff") + extension;
                string path = Path.Combine(wwwRootPath + "/dbImages/", fileName);
                using (var fileStream = new FileStream(path, FileMode.Create))
                {
                    await productViewModel.ProductImageFile.CopyToAsync(fileStream);
                }
                Product prod = new Product
                {
                    ProductID = productViewModel.ProductID,
                    ProductName = productViewModel.ProductName,
                    ProductPrice=productViewModel.ProductPrice,
                    ProductLongDes=productViewModel.ProductLongDes,
                    ProductShortDes=productViewModel.ProductShortDes,
                    ProductStock=productViewModel.ProductStock,
                    ProductWeight=productViewModel.ProductWeight,
                    ProductImage=productViewModel.ProductImage,
                    ProductUpdateDate=productViewModel.ProductUpdateDate,
                    VendorID=productViewModel.VendorID,
                    ProductCategoryID = productViewModel.ProductCategoryID

                };
                _context.Add(prod);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ProductCategoryID"] = new SelectList(_context.ProductCategories, "CategoryID", "CategoryName", productViewModel.ProductCategoryID);
            ViewData["VendorID"] = new SelectList(_context.Vendors, "VendorID", "VendorName", productViewModel.VendorID);
            return View();
        }

        // GET: ProductArea/Products/Edit/5
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
            ViewData["VendorID"] = new SelectList(_context.Vendors, "VendorID", "VendorName", product.VendorID);
            return View(product);
        }

        // POST: ProductArea/Products/Edit/5
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
            ViewData["VendorID"] = new SelectList(_context.Vendors, "VendorID", "VendorName", product.VendorID);
            return View(product);
        }

        // GET: ProductArea/Products/Delete/5
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

        // POST: ProductArea/Products/Delete/5
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
