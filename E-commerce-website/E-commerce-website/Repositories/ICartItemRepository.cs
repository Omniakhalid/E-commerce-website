using E_commerce_website.Models;
using System.Collections.Generic;

namespace E_commerce_website.Repositories
{
    public interface ICartItemRepository
    {
        void Add(CartItem order);
        List<CartItem> GetAll();
        CartItem GetById(int userId,int productId);
        void Remove(int userId, int productId);
        List<CartItem> GetAll(int userId);
        CartItem Update(int userId, int productId, CartItem cart);

        void RemoveRange(int userId);
    }
}
