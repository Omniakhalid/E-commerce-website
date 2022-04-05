using E_commerce_website.Models;
using E_commerce_website.Repositories;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace E_commerce_website.Areas.ClientArea.Services
{
    public class OrderService : IOrderService
    {
        private IOrdersRepository _orderRepo;
        private ICartOptionsService _cartOptionsService;
        private IOrderDetailRepository _orderDetailService;
        private ICartService _cartService;
        private IOrderItemsOptionService _orderItemsOptionService;

        public OrderService(IOrdersRepository ordersRepository, IOrderDetailRepository orderDetailService, 
                            ICartService cartService, IOrderItemsOptionService orderItemsOptionService,
                            ICartOptionsService cartOptionsService)
        {
            _orderRepo = ordersRepository;
            _cartOptionsService = cartOptionsService;
            _orderDetailService = orderDetailService;
            _cartService = cartService;
            _orderItemsOptionService = orderItemsOptionService;
        }
        private void InsertCartIemsDetails(int orderID)
        {
            var Cart = _cartService.GetAll(orderID);

            foreach (var item in Cart)
            {
                _orderDetailService.Add(new OrderDetail()
                {
                    OrderID = orderID,
                    ProductID = item.ProductID,
                    Quanity = item.Quantity,
                    ProductName = item.Product?.ProductName,
                    Price = item.Product.ProductPrice * item.Quantity
                });
            }
            
        }

        private void AddOrderOptions(int OrderID,int userID)
        {
            try
            {
                var CartOrderOptions = _cartOptionsService.GetAll(userID);
                foreach (var item in CartOrderOptions)
                {
                    _orderItemsOptionService.Add(
                        new OrderItemsOption()
                        {
                            OrderID = OrderID,
                            ProductID = item.ProductID,
                            OptionID = item.OptionID,
                            UserID = userID
                        });
                }
            }
            catch
            {

            }
        }
     
        public void Add(Order order)
        {
            _orderRepo.Add(order);
            InsertCartIemsDetails(order.OrderID);
            AddOrderOptions(order.OrderID, order.UserID);
            _cartService.RemoveRange(order.UserID);
        }

        public List<Order> GetAll(int userId)
        {
            return _orderRepo.GetAll().FindAll(c=>c.UserID == userId).ToList();
        }

        public Order GetById(int orderId)
        {
           return _orderRepo.GetById(orderId);
        }

        public void Remove(int orderId)
        {
             _orderRepo.Remove(orderId);
        }


    }
}
