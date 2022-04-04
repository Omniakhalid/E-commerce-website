using E_commerce_website.Models;
using System.Collections.Generic;

namespace E_commerce_website.Repositories
{
    public interface IOptionGroupRepository
    {
        void Add(OptionGroup optionGroup);
        List<OptionGroup> GetAll();
        OptionGroup GetById(int id);
        void Remove(int id);
    }
}
