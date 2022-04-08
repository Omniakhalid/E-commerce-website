using E_commerce_website.Areas.ProductArea.ViewModels;
using E_commerce_website.Models;
using System.Collections.Generic;

namespace E_commerce_website.Areas.ProductArea.Repositories
{
    public interface IProductRepository
    {
        List<Product> GetAll(string VendorEmail);//index
        Product GetById(int id);//details
        void Add(ProductViewModel productViewModel);//create
        void Remove(int productId);//delete
        void Update(int productId, ProductViewModel productViewModel);//edit
    }
}
