using E_commerce_website.Models;
using System.Collections.Generic;

namespace E_commerce_website.Repositories
{
    public interface IOrderDetailRepository
    {
        void Add(OrderDetail order);
        List<OrderDetail> GetAll();
        OrderDetail GetById(int orderId,int ProudctId);

        void Remove(int orderId, int proudctId);
    }
}
