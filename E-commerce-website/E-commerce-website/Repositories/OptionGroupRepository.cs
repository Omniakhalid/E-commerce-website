using E_commerce_website.Context;
using E_commerce_website.Models;
using System.Collections.Generic;
using System.Linq;

namespace E_commerce_website.Repositories
{
    public class OptionGroupRepository : IOptionGroupRepository
    {
        private OnlineshoppingContext _context;

        public OptionGroupRepository(OnlineshoppingContext context)
        {
            _context = context;
        }
        public void Add(OptionGroup optionGroup)
        {
            try
            {
                _context.OptionGroups.Add(optionGroup);
                _context.SaveChanges();

            }
            catch
            {

            }
        }

        public List<OptionGroup> GetAll()
        {
            return _context.OptionGroups.ToList();
        }

        public OptionGroup GetById(int id)
        {
            return _context.OptionGroups.FirstOrDefault(c => c.OptionGroupID == id);
        }

        public void Remove(int id)
        {
            var option = GetById(id);
            
            try
            {
                _context.OptionGroups.Remove(option);
                _context.SaveChanges();
            }
            catch
            {

            }
        }
    }
}
