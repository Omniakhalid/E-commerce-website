using E_commerce_website.Context;
using E_commerce_website.Models;
using System.Collections.Generic;
using System.Linq;

namespace E_commerce_website.Repositories
{
    public class OrderDetailRepository : IOrderDetailRepository
    {
        private OnlineshoppingContext _context;

        public OrderDetailRepository(OnlineshoppingContext context)
        {
            _context = context;
        }
        public void Add(OrderDetail orderDetail)
        {
            try
            {
                _context.OrderDetails.Add(orderDetail);
                _context.SaveChanges();

            }
            catch
            {

            }
        }

        public List<OrderDetail> GetAll()
        {
            return _context.OrderDetails.ToList();
        }

        public OrderDetail GetById(int orderId, int proudctId)
        {
            return _context.OrderDetails.FirstOrDefault(c => c.OrderID == orderId && c.ProductID == proudctId);
        }

        public void Remove(int orderId, int proudctId)
        {
            var orderDetail = _context.OrderDetails.FirstOrDefault(c => c.OrderID == orderId && c.ProductID == proudctId);

            try
            {

                _context.OrderDetails.Remove(orderDetail);
                _context.SaveChanges();
            }
            catch
            {

            }
        }
    }
}
