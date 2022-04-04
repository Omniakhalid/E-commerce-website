using E_commerce_website.Context;
using E_commerce_website.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace E_commerce_website.Repositories
{
    public class CartItemsOptionRepository : ICartItemsOptionRepository
    {
        private OnlineshoppingContext _context;

        public CartItemsOptionRepository(OnlineshoppingContext context)
        {
            _context = context;
        }
        public void Add(CartItemsOption cartItemsOption)
        {
            try
            {
                _context.CartItemsOptions.Add(cartItemsOption);
                _context.SaveChanges();

            }
            catch
            {

            }
        }

        public List<CartItemsOption> GetAll()
        {
            
            return _context.CartItemsOptions.Include(c => c.Product)
                                            .Include(c => c.Option)
                                            .Include(c => c.Option.OptionGroup)
                                            .ToList();
        }

        public CartItemsOption GetById(int optionId, int productId, int userId)
        {
            return _context.CartItemsOptions.FirstOrDefault(c => c.OptionID == optionId 
                                                               && c.ProductID == productId
                                                               && c.UserID == userId);
        }

        public void Remove(int optionId, int productId, int userId)
        {
            var cartItemOptions = GetById(userId,productId,userId);
            
            try
            {

                _context.CartItemsOptions.Remove(cartItemOptions);
                _context.SaveChanges();
            }
            catch
            {

            }
        }

        public void AddRange(List<CartItemsOption> cartItems)
        {
            try
            {
                _context.CartItemsOptions.AddRange(cartItems);
            }
            catch
            {

            }
        }
        public void RemoveRange(int userId)
        {
            try
            {
                var cartItems = _context.CartItemsOptions.Where(c => c.UserID == userId);
                _context.RemoveRange(cartItems);
            }
            catch
            {

            }
        }
    }
}
