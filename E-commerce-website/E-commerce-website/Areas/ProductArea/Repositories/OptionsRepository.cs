using E_commerce_website.Areas.ProductArea.ViewModels;
using E_commerce_website.Context;
using E_commerce_website.Models;

namespace E_commerce_website.Areas.ProductArea.Repositories
{
    public class OptionsRepository : IOptionsRepository
    {
        private OnlineshoppingContext _context;

        public OptionsRepository(OnlineshoppingContext context)
        {
            _context = context;
        }
        public void Add(OptionViewModel optionViewModel)
        {
            Option op = new Option
            {
                OptionID = optionViewModel.OptionID,
                OptionName = optionViewModel.OptionName,
                OptionGroupID = optionViewModel.OptionGroupID,
            };
            ProductOption productOption = new ProductOption()
            {
                OptionID = optionViewModel.OptionID,
                ProductID = optionViewModel.ProductID,
                id = optionViewModel.id
            };
            _context.Add(op);
            _context.Add(productOption);
            _context.SaveChanges();
        }
    }
}
