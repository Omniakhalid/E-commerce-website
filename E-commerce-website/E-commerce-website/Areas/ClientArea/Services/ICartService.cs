using E_commerce_website.Models;
using System.Collections.Generic;

namespace E_commerce_website.Areas.ClientArea.Services
{
    public interface ICartService
    {
        void Add(CartItem cartItem);
        List<CartItem> GetAll(int userId);
        CartItem GetById(int userId, int productId);
        void Remove(int userId, int productId);
        void RemoveRange(int userId);

        CartItem Update(int userId, int productId, CartItem cart);

        void IncreamentItemInCart(int userId, int productId);
        void DecreamentItemInCart(int userId, int productId);

        public void AddItemsOptionsIntoCart(int _UserId, int Productid, IEnumerable<int> Options);
    }
}
