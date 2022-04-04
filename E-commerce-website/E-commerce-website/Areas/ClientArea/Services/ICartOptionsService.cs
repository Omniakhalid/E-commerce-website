using E_commerce_website.Models;
using System.Collections.Generic;

namespace E_commerce_website.Areas.ClientArea.Services
{
    public interface ICartOptionsService
    {
        void Add(CartItemsOption cartItemsOption);
        List<CartItemsOption> GetAll(int userId);
        CartItemsOption GetById(int optionId, int productId, int userId);
        void Remove(int optionId, int productId, int userId);

        void AddRange(List<CartItemsOption> cartItemsOptions);

        void RemoveRange(int userId);
    }
}
