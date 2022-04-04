using E_commerce_website.Models;
using E_commerce_website.Repositories;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace E_commerce_website.Areas.ClientArea.Services
{
    public class ProductService : IProductService
    {
        private IProductRepository _productRepo;

        public ProductService(IProductRepository productRepository)
        {
            _productRepo = productRepository;

        }

        public List<Product> GetAll()
        {
            return _productRepo.GetAll();
        }

        public Product GetById(int id)
        {
            return _productRepo.GetById(id);
        }

       
    }
}
