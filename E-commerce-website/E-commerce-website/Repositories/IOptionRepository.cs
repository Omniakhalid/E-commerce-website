using E_commerce_website.Models;
using System.Collections.Generic;

namespace E_commerce_website.Repositories
{
    public interface IOptionRepository
    {
        void Add(Option option);
        List<Option> GetAll();
        Option GetById(int id);
        void Remove(int id);
    }
}
