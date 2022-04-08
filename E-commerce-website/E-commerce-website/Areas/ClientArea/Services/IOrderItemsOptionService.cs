using E_commerce_website.Models;
using System.Collections.Generic;

namespace E_commerce_website.Areas.ClientArea.Services
{
    public interface IOrderItemsOptionService
    {
        void Add(OrderItemsOption orderItemsOption);
        List<OrderItemsOption> GetAll(int userId);
        OrderItemsOption GetById(int orderId, int proudctId, int optionID);
        void Remove(int orderId, int proudctId, int optionID);
        void RemoveRange(int orderId);

    }
}
