using E_commerce_website.Models;
using E_commerce_website.Repositories;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace E_commerce_website.Areas.ClientArea.Services
{
    public class CartOptionsService : ICartOptionsService
    {
        private ICartItemsOptionRepository _cartOptionsRepo;

        public CartOptionsService(ICartItemsOptionRepository cartOptionsRepository)
        {
            _cartOptionsRepo = cartOptionsRepository;

        }
        public void Add(CartItemsOption cartItemsOption)
        {
            if(cartItemsOption != null)
            {
                _cartOptionsRepo.Add(cartItemsOption);
            }
        }

        public List<CartItemsOption> GetAll(int userId)
        {
            return _cartOptionsRepo.GetAll().FindAll(c => c.UserID== userId);
        }

        public CartItemsOption GetById(int optionId, int productId, int userId)
        {
            return _cartOptionsRepo.GetById(userId,productId,userId);
        }

        public void Remove(int optionId, int productId, int userId)
        {
            _cartOptionsRepo.Remove(optionId,userId, productId);
        }
        public void AddRange(List<CartItemsOption> cartItemsOptions)
        {
            _cartOptionsRepo.AddRange(cartItemsOptions);
        }

        public void RemoveRange(int userId)
        {
            _cartOptionsRepo.RemoveRange(userId);
        }
    }
}
