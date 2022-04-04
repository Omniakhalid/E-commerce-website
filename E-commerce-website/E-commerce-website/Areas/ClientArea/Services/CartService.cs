using E_commerce_website.Models;
using E_commerce_website.Repositories;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace E_commerce_website.Areas.ClientArea.Services
{
    public class CartService : ICartService
    {
        private ICartItemRepository _cartRepo;
        private IProductService _productService;
        private ICartOptionsService _cartOptionsService;

        public CartService(ICartItemRepository cartItemRepository,IProductService productService,ICartOptionsService cartOptionsService)
        {
            _cartRepo = cartItemRepository;
            _productService = productService;
            _cartOptionsService = cartOptionsService;

        }
        public void Add(CartItem cartItem)
        {
            if(cartItem != null)
            {
                _cartRepo.Add(cartItem);
            }
        }

        public List<CartItem> GetAll(int userId)
        {
            return _cartRepo.GetAll().FindAll(c => c.User.UserID == userId);
        }

        public CartItem GetById(int userId, int productId)
        {
            return _cartRepo.GetById(userId,productId);
        }
        public void RemoveRange(int userId)
        {
            _cartOptionsService.RemoveRange(userId);
            _cartRepo.RemoveRange(userId);
        }
        public void Remove(int userId, int productId)
        {
            _cartRepo.Remove(userId, productId);
        }
        public CartItem Update(int userId, int productId, CartItem cart)
        {
            return _cartRepo.Update(userId, productId, cart);
        }

        public void IncreamentItemInCart(int userId, int productId)
        {
            var cartItems = _cartRepo.GetById(userId, productId);
            cartItems.Quantity++;
            Update(userId, productId, cartItems);
        }

        public void DecreamentItemInCart(int userId, int productId)
        {
            var cartItems = _cartRepo.GetById(userId, productId);
            cartItems.Quantity--;
            Update(userId, productId, cartItems);
        }
        public void AddItemsIntoCart(int productId, int userId)
        {

            var TotalPrice = _productService.GetById(productId).ProductPrice;

            CartItem cartItem = new CartItem()
            {
                UserID = userId,
                TotalPrice = TotalPrice,
                ProductID = productId,
                Quantity = 1
            };

            Add(cartItem);

        }

        private bool ProductInCartExists(int userId, int pId)
        {
            return GetById(userId, pId) != null;
        }

        public void AddItemsOptionsIntoCart(int _UserId, int Productid, IEnumerable<int> Options)
        {
            try
            {
                if (!ProductInCartExists(_UserId, Productid))
                {
                    AddItemsIntoCart(Productid, _UserId);
                }
                if (Options.Count() > 0)
                {
                    foreach (var optionID in Options)
                    {
                        var cartOption = new CartItemsOption()
                        {
                            UserID = _UserId,
                            ProductID = Productid,
                            OptionID = optionID
                        };
                        _cartOptionsService.Add(cartOption);
                    }
                }
            }
            catch
            {

            }

        }

    }
}
