using E_commerce_website.Context;
using E_commerce_website.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace E_commerce_website.Repositories
{
    public class CartItemRepository : ICartItemRepository
    {
        private OnlineshoppingContext _context;

        public CartItemRepository(OnlineshoppingContext context)
        {
            _context = context;
        }
        public void Add(CartItem cartItem)
        {
            try
            {
                _context.CartItems.Add(cartItem);
                _context.SaveChanges();

            }
            catch
            {

            }
        }

        public List<CartItem> GetAll()
        {
            var cartItems = _context.CartItems.Include(c => c.Product).Include(c => c.User)
                                              .Include(c => c.Product.ProductCategory).ToList();
            return cartItems;
        }

        public CartItem GetById(int userId, int productId)
        {
            return _context.CartItems
                           .Include(c=>c.Product)
                           .FirstOrDefault(c => c.UserID == userId && c.ProductID == productId);
        }

        public List<CartItem> GetAll(int userId)
        {
            return _context.CartItems.Include(c => c.Product).Where(c => c.UserID == userId).ToList();
        }

        public void Remove(int userId, int productId)
        {
            var cartItem = GetById(userId,productId);
            
            try
            {

                _context.CartItems.Remove(cartItem);
                _context.SaveChanges();
            }
            catch
            {

            }
        }

        public void RemoveRange(int userId)
        {
            try
            {
                var CartItems = _context.CartItems.Where(c => c.UserID == userId);
                _context.RemoveRange(CartItems);
                _context.SaveChanges();
            }
            catch
            {

            }
        }
        public CartItem Update(int userId, int productId, CartItem cart)
        {
            try
            {
                var cartItems = GetById(userId, productId);
                _context.Attach(cart);
                _context.Entry(cartItems).State = EntityState.Modified;
                _context.SaveChanges();
                return cartItems;
            }
            catch
            {
                return null;
            }
        }
    }
}
