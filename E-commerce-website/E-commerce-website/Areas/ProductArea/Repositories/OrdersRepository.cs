using E_commerce_website.Context;
using E_commerce_website.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace E_commerce_website.Areas.ProductArea.Repositories
{
    public class OrdersRepository : IOrdersRepository
    {
        private OnlineshoppingContext _context;

        public OrdersRepository(OnlineshoppingContext context)
        {
            _context = context;
        }

        public List<Order> GetAll(string VendorEmail)
        {
            var Orders = (from o in _context.Orders
                          from od in _context.OrderDetails
                          from p in _context.Products
                          from v in _context.Vendors
                          where o.OrderID == od.OrderID
                          && od.ProductID == p.ProductID
                          && p.VendorID == v.VendorID
                          && v.VendorEmail == VendorEmail
                          select o).ToList();
            return Orders;
        }
        public List<OrderItemsOption> OptionDetails(int OrderID, int UserID)
        {
            var Details = _context.OrderItemsOptions
                                                .Where(p => p.OrderID == OrderID && p.UserID == UserID)
                                                .Include(po => po.Order)
                                                .Include(p => p.Product).ToList();
            //var Details = _context.OrderItemsOptions
            //                                    .Where(p => p.OrderID == OrderID)
            //                                    .Include(p => p.Product).ToList();
            return Details;
        }
    }
}
