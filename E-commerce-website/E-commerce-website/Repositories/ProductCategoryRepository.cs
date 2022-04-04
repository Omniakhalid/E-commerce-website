using E_commerce_website.Context;
using E_commerce_website.Models;
using System.Collections.Generic;
using System.Linq;

namespace E_commerce_website.Repositories
{
    public class ProductCategoryRepository : IProductCategoryRepository
    {
        private OnlineshoppingContext _context;

        public ProductCategoryRepository(OnlineshoppingContext context)
        {
            _context = context;
        }
        public void Add(ProductCategory productCategory)
        {
            try
            {
                _context.ProductCategories.Add(productCategory);
                _context.SaveChanges();

            }
            catch
            {

            }
        }

        public List<ProductCategory> GetAll()
        {
            return _context.ProductCategories.ToList();
        }

        public ProductCategory GetById(int id)
        {
            return _context.ProductCategories.FirstOrDefault(c => c.CategoryID == id);
        }

        public void Remove(int id)
        {
            var product = GetById(id);
            
            try
            {

                _context.ProductCategories.Remove(product);
                _context.SaveChanges();
            }
            catch
            {

            }
        }
    }
}
