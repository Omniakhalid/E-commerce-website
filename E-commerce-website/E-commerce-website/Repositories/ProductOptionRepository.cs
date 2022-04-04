using E_commerce_website.Context;
using E_commerce_website.Models;
using System.Collections.Generic;
using System.Linq;

namespace E_commerce_website.Repositories
{
    public class ProductOptionRepository : IProductOptionRepository
    {
        private OnlineshoppingContext _context;

        public ProductOptionRepository(OnlineshoppingContext context)
        {
            _context = context;
        }
        public void Add(ProductOption productOption)
        {
            try
            {
                _context.ProductOptions.Add(productOption);
                _context.SaveChanges();

            }
            catch
            {

            }
        }

        public List<ProductOption> GetAll()
        {
            return _context.ProductOptions.ToList();
        }

        public ProductOption GetById(int productId, int optionId)
        {
            return _context.ProductOptions.FirstOrDefault(c => c.OptionID == optionId && c.ProductID == productId);
        }

        public void Remove(int productId, int optionId)
        {
            var product = GetById(productId,optionId);
            
            try
            {

                _context.ProductOptions.Remove(product);
                _context.SaveChanges();
            }
            catch
            {

            }
        }
    }
}
