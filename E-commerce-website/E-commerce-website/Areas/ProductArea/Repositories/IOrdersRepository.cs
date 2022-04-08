using E_commerce_website.Models;
using System.Collections.Generic;

namespace E_commerce_website.Areas.ProductArea.Repositories
{
    public interface IOrdersRepository
    {
        List<Order> GetAll(string VendorEmail);
    }
}
