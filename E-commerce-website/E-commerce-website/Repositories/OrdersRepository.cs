using E_commerce_website.Context;
using E_commerce_website.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace E_commerce_website.Repositories
{
    public class OrdersRepository : IOrdersRepository
    {
        private OnlineshoppingContext _context;

        public OrdersRepository(OnlineshoppingContext context)
        {
            _context = context;
        }
        public void Add(Order order)
        {
            try
            {
                _context.Orders.Add(order);
                _context.SaveChanges();

            }
            catch
            {

            }
        }

        public List<Order> GetAll()
        {
            return _context.Orders.Include(o => o.User)
                                  .Include(p => p.OrderDetails)
                                  .ThenInclude(p => p.Product).ToList();
        }

        public Order GetById(int id)
        {
            return _context.Orders.FirstOrDefault(c => c.OrderID == id);
        }

        public void Remove(int id)
        {
            var order = _context.Orders.FirstOrDefault(c => c.OrderID == id);
            
            try
            {

                _context.Orders.Remove(order);
                _context.SaveChanges();
            }
            catch
            {

            }
        }
    }
}
