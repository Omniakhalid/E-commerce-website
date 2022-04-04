using E_commerce_website.Context;
using E_commerce_website.Models;
using System.Collections.Generic;
using System.Linq;

namespace E_commerce_website.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private OnlineshoppingContext _context;

        public ProductRepository(OnlineshoppingContext context)
        {
            _context = context;
        }
        public void Add(Product product)
        {
            try
            {
                _context.Products.Add(product);
                _context.SaveChanges();

            }
            catch
            {

            }
        }

        public List<Product> GetAll()
        {
            return _context.Products.ToList();
        }

        public Product GetById(int id)
        {
            return _context.Products.FirstOrDefault(c => c.ProductID == id);
        }

        public void Remove(int id)
        {
            var product = GetById(id);
            
            try
            {

                _context.Products.Remove(product);
                _context.SaveChanges();
            }
            catch
            {

            }
        }
    }
}
