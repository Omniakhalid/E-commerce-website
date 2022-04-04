using E_commerce_website.Models;
using System.Collections.Generic;

namespace E_commerce_website.Repositories
{
    public interface IOrderItemsOptionRepository
    {
        void Add(OrderItemsOption orderItemsOption);
        List<OrderItemsOption> GetAll();
        OrderItemsOption GetById(int orderId,int proudctId,int optionID);
        void Remove(int orderId, int proudctId, int optionID);
    }
}
