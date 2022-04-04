using E_commerce_website.Context;
using E_commerce_website.Models;
using System.Collections.Generic;
using System.Linq;

namespace E_commerce_website.Repositories
{
    public class OptionRepository : IOptionRepository
    {
        private OnlineshoppingContext _context;

        public OptionRepository(OnlineshoppingContext context)
        {
            _context = context;
        }
        public void Add(Option option)
        {
            try
            {
                _context.Options.Add(option);
                _context.SaveChanges();

            }
            catch
            {

            }
        }

        public List<Option> GetAll()
        {
            return _context.Options.ToList();
        }

        public Option GetById(int id)
        {
            return _context.Options.FirstOrDefault(c => c.OptionID == id);
        }

        public void Remove(int id)
        {
            var option = GetById(id);
            
            try
            {

                _context.Options.Remove(option);
                _context.SaveChanges();
            }
            catch
            {

            }
        }
    }
}
