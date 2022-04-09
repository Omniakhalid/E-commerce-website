using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using E_commerce_website.Models;
using E_commerce_website.Context;
using Microsoft.AspNetCore.Hosting;
using E_commerce_website.Areas.ProductArea.ViewModels;
using System.IO;
using Microsoft.AspNetCore.Http;
using E_commerce_website.Areas.ProductArea.Repositories;
using Microsoft.AspNetCore.Authorization;

namespace E_commerce_website.Areas.ProductArea.Controllers
{
    [Area("ProductArea")]
    [Authorize(Roles = "Vendor")]
    public class ProductsController : Controller
    {
        private readonly OnlineshoppingContext _context;
        private readonly IWebHostEnvironment webHostEnvironment;
        private readonly IHttpContextAccessor _contextAccessor;
        private IProductRepository _productRepository;
        private IOptionsRepository _optionsRepository;
        private IOrdersRepository _ordersRepository;
        private readonly string _vendor;
        private Vendor _vendorData;
        public ProductsController(OnlineshoppingContext context,
            IWebHostEnvironment hostEnvironment, IHttpContextAccessor contextAccessor,
            IProductRepository productRepository, IOptionsRepository optionsRepository
            , IOrdersRepository ordersRepository)
        {
            _context = context;
            webHostEnvironment = hostEnvironment;
            _contextAccessor = contextAccessor;
            _productRepository = productRepository;
            _optionsRepository = optionsRepository;
            _ordersRepository = ordersRepository;
            _vendor = _contextAccessor.HttpContext.User.Identity.Name;
            _vendorData = _context.Vendors.FirstOrDefault(v=>v.VendorEmail == _vendor);
        }

        // GET: ProductArea/Products
        public IActionResult Index()
        {
            return View(_productRepository.GetAll(_vendor));
        }

        // GET: ProductArea/Products/Create
        public IActionResult Create()
        {
            ViewData["ProductCategoryID"] = new SelectList(_context.ProductCategories, "CategoryID", "CategoryName");
            //ViewData["VendorID"] = new SelectList(_context.Vendors, "VendorID", "VendorName");
            return View();
        }

        // POST: ProductArea/Products/Create
        [HttpPost, ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(ProductViewModel productViewModel)
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
            productViewModel.VendorID = _vendorData.VendorID;
            _productRepository.Add(productViewModel);
            return RedirectToAction(nameof(Index));
        }

        // GET: ProductArea/Products/Details/5
        public IActionResult Details(int id)
        {
            Product product = _productRepository.GetById(id);
            return View(product);
        }

        public IActionResult Delete(int id)
        {
            _productRepository.Remove(id);
            return RedirectToAction(nameof(Index));
        }

        // GET: ProductArea/Products/Edit/5
        public IActionResult Edit(int id)
        {
            ProductViewModel productViewModel = new ProductViewModel();
            var product = _productRepository.GetById(id);
            productViewModel.ProductName = product.ProductName;
            productViewModel.ProductPrice = product.ProductPrice;
            productViewModel.ProductLongDes = product.ProductLongDes;
            productViewModel.ProductShortDes = product.ProductShortDes;
            productViewModel.ProductStock = product.ProductStock;
            productViewModel.ProductWeight = product.ProductWeight;
            productViewModel.ProductImage = product.ProductImage;
            productViewModel.ProductUpdateDate = product.ProductUpdateDate;
            productViewModel.VendorID = product.VendorID;
            productViewModel.ProductCategoryID = product.ProductCategoryID;
            ViewData["ProductCategoryID"] = new SelectList(_context.ProductCategories, "CategoryID", "CategoryName", product.ProductCategoryID);
            ViewData["VendorID"] = new SelectList(_context.Vendors, "VendorID", "VendorName", product.VendorID);
            return View(productViewModel);
        }
        [HttpPost, ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, ProductViewModel productViewModel)
        {
            try
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
                _productRepository.Update(id, productViewModel);

            }
            catch (DbUpdateConcurrencyException)
            {
            }
            return RedirectToAction(nameof(Index));
        }
        private bool ProductExists(int id)
        {
            return _context.Products.Any(e => e.ProductID == id);
        }
        public IActionResult GetOrders()
        {
            return View(_ordersRepository.GetAll(_vendor));
        }
        public IActionResult OptionDetails(int OrderID, int UserID)
        {
            var Details = _context.OrderItemsOptions
                                                .Where(p => p.OrderID == OrderID && p.UserID == UserID)
                                                .Include(po => po.Order)
                                                .Include(p => p.Product)
                                                .Include(op=>op.Option)
                                                .ToList();
            return View(Details);
        }

        public IActionResult Options()
        {
            ViewData["ProductID"] = new SelectList(_productRepository.GetAll(_vendor), "ProductID", "ProductName");
            ViewData["OptionGroupID"] = new SelectList(_context.OptionGroups, "OptionGroupID", "OptionGroupName");
            return View();
        }
        [HttpPost]
        public IActionResult Options(OptionViewModel optionViewModel)
        {
            _optionsRepository.Add(optionViewModel);
            return RedirectToAction(nameof(Options));

        }
    }
}
