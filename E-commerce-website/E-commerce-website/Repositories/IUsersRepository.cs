using E_commerce_website.Models;
using System.Collections.Generic;

namespace E_commerce_website.Repositories
{
    public interface IUsersRepository
    {
        void Add(User user);
        List<User> GetAll();
        User GetById(int id);

        User GetByEmail(string email);
        void Remove(int id);
    }
}
