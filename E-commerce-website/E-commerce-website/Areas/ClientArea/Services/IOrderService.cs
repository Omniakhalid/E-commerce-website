using E_commerce_website.Models;
using System.Collections.Generic;

namespace E_commerce_website.Areas.ClientArea.Services
{
    public interface IOrderService
    {
        void Add(Order order);
        List<Order> GetAll(int userId);
        Order GetById(int orderId);
        void Remove(int orderId);
    }
}
