using E_commerce_website.Models;
using System.Collections.Generic;

namespace E_commerce_website.Repositories
{
    public interface IOrdersRepository
    {
        void Add(Order order);
        List<Order> GetAll();
        Order GetById(int id);
        void Remove(int id);
    }
}
