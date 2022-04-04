using E_commerce_website.Models;
using System.Collections.Generic;

namespace E_commerce_website.Repositories
{
    public interface ICartItemsOptionRepository
    {
        void Add(CartItemsOption cartItemsOption);
        List<CartItemsOption> GetAll();
        CartItemsOption GetById(int optionId, int productId, int userId);
        void Remove(int optionId, int productId, int userId);

        void AddRange(List<CartItemsOption> cartItems);

        void RemoveRange(int userId);
    }
}
