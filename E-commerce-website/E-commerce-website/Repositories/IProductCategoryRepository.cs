using E_commerce_website.Models;
using System.Collections.Generic;

namespace E_commerce_website.Repositories
{
    public interface IProductCategoryRepository
    {
        void Add(ProductCategory product);
        List<ProductCategory> GetAll();
        ProductCategory GetById(int id);
        void Remove(int id);
    }
}
