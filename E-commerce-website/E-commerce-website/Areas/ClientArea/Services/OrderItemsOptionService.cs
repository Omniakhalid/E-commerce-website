using E_commerce_website.Models;
using E_commerce_website.Repositories;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace E_commerce_website.Areas.ClientArea.Services
{
    public class OrderItemsOptionService : IOrderItemsOptionService
    {
        private IOrderItemsOptionRepository _orderOptionsRepo;

        public OrderItemsOptionService(IOrderItemsOptionRepository orderItemsOptionRepository)
        {
            _orderOptionsRepo = orderItemsOptionRepository;

        }
        public void Add(OrderItemsOption orderItemsOption)
        {
            if(orderItemsOption != null)
            {
                _orderOptionsRepo.Add(orderItemsOption);
            }
        }

        public List<OrderItemsOption> GetAll(int userId)
        {
            return _orderOptionsRepo.GetAll().FindAll(c => c.UserID== userId);
        }

        public OrderItemsOption GetById(int orderId, int proudctId, int optionID)
        {
            return _orderOptionsRepo.GetById(orderId, proudctId, optionID);
        }

        public void Remove(int optionId, int productId, int userId)
        {
            _orderOptionsRepo.Remove(optionId,userId, productId);
        }
    }
}
