using E_commerce_website.Areas.ProductArea.ViewModels;
using E_commerce_website.Context;
using E_commerce_website.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace E_commerce_website.Areas.ProductArea.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private OnlineshoppingContext _context;

        public ProductRepository(OnlineshoppingContext context)
        {
            _context = context;
        }
        public void Add(ProductViewModel productViewModel)
        {
            try
            {
                Product product = new Product();
                product.ProductID = productViewModel.ProductID;
                product.ProductName = productViewModel.ProductName;
                product.ProductPrice = (decimal)productViewModel.ProductPrice;
                product.ProductLongDes = productViewModel.ProductLongDes;
                product.ProductShortDes = productViewModel.ProductShortDes;
                product.ProductStock = productViewModel.ProductStock;
                product.ProductWeight = productViewModel.ProductWeight;
                product.ProductImage = productViewModel.ProductImage;
                product.ProductUpdateDate = productViewModel.ProductUpdateDate;
                product.VendorID = productViewModel.VendorID;
                product.ProductCategoryID = productViewModel.ProductCategoryID;
                _context.Products.Add(product);
                _context.SaveChanges();
            }
            catch
            {

            }
        }
        public List<Product> GetAll(string VendorEmail)
        {
            var vendorProducts = _context.Products.Where(c => c.Vendor.VendorEmail == VendorEmail)
                                                    .Include(p => p.ProductCategory)
                                                    .Include(p => p.Vendor).ToList();
            return vendorProducts;
        }
        public Product GetById(int id)
        {
            return _context.Products
                .Include(p => p.ProductCategory)
                .Include(p => p.Vendor).FirstOrDefault(m => m.ProductID == id);
        }
        public void Remove(int id)
        {
            var product = _context.Products
                .Include(p => p.ProductCategory)
                .Include(p => p.Vendor)
                .FirstOrDefault(m => m.ProductID == id);
            try
            {
                _context.Products.Remove(product);
                _context.SaveChanges();
            }
            catch
            {

            }
        }
        public void Update(int productId, ProductViewModel productViewModel)
        {
            try
            {
                Product oldProduct = GetById(productId);
                oldProduct.ProductName = productViewModel.ProductName;
                oldProduct.ProductPrice = (decimal)productViewModel.ProductPrice;
                oldProduct.ProductLongDes = productViewModel.ProductLongDes;
                oldProduct.ProductShortDes = productViewModel.ProductShortDes;
                oldProduct.ProductStock = productViewModel.ProductStock;
                oldProduct.ProductWeight = productViewModel.ProductWeight;
                oldProduct.ProductImage = productViewModel.ProductImage;
                oldProduct.ProductUpdateDate = productViewModel.ProductUpdateDate;
                oldProduct.VendorID = productViewModel.VendorID;
                oldProduct.ProductCategoryID = productViewModel.ProductCategoryID;
                _context.Products.Update(oldProduct);
                _context.SaveChanges();
            }
            catch
            {

            }
        }
    }
}