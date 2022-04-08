using E_commerce_website.Context;
using E_commerce_website.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace E_commerce_website.Repositories
{
    public class OrderItemsOptionRepository : IOrderItemsOptionRepository
    {
        private OnlineshoppingContext _context;

        public OrderItemsOptionRepository(OnlineshoppingContext context)
        {
            _context = context;
        }
        public void Add(OrderItemsOption orderItemsOption)
        {
            try
            {
                _context.OrderItemsOptions.Add(orderItemsOption);
                _context.SaveChanges();

            }
            catch
            {

            }
        }

        public List<OrderItemsOption> GetAll()
        {
            return _context.OrderItemsOptions.Include(c => c.Option)
                                             .Include(c => c.Option.OptionGroup).ToList();
        }

        public OrderItemsOption GetById(int orderId, int proudctId, int optionID)
        {
            return _context.OrderItemsOptions.FirstOrDefault(c => c.OrderID == orderId 
                                                                && c.ProductID == proudctId 
                                                                && c.OptionID == optionID);
        }

        public void Remove(int orderId, int proudctId, int optionID)
        {
            var orderItemsOptions = GetById(orderId,proudctId,optionID);

            try
            {

                _context.OrderItemsOptions.Remove(orderItemsOptions);
                _context.SaveChanges();
            }
            catch
            {

            }
        }

        public void RemoveRange(int orderId)
        {
            try
            {
                var orderItemsOptions = _context.OrderItemsOptions.Where(c => c.OrderID == orderId);
                _context.RemoveRange(orderItemsOptions);
                _context.SaveChanges();

            }
            catch
            {
                throw;
            }
        }
    }
}
