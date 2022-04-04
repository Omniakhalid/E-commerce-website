using E_commerce_website.Models;
using System.Collections.Generic;

namespace E_commerce_website.Repositories
{
    public interface IProductOptionRepository
    {
        void Add(ProductOption productOptions);
        List<ProductOption> GetAll();
        ProductOption GetById(int productId,int optionId);
        void Remove(int productId, int optionId);
    }
}
