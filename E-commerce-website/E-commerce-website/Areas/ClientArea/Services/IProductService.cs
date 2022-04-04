using E_commerce_website.Models;
using System.Collections.Generic;

namespace E_commerce_website.Areas.ClientArea.Services
{
    public interface IProductService
    {
        List<Product> GetAll();
        Product GetById(int id);
    }
}
