using E_commerce_website.Context;
using E_commerce_website.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace E_commerce_website.Repositories
{
    public class UsersRepository : IUsersRepository
    {
        private OnlineshoppingContext _context;

        public UsersRepository(OnlineshoppingContext context)
        {
            _context = context;
        }

        public void Add(User user)
        {
            try
            {
                _context.Add(user);
                _context.SaveChanges();
            }
            catch
            {

            }
        }

        public List<User> GetAll()
        {
            return _context.Users.ToList();
        }

        public User GetByEmail(string email)
        {
            return _context.Users.FirstOrDefault(c => c.UserEmail == email);
        }

        public User GetById(int id)
        {
           return _context.Users.FirstOrDefault(c=>c.UserID == id);
        }

        public void Remove(int id)
        {
            var user = GetById(id);
            _context.Remove(user);
            _context.SaveChanges();
        }
    }
}
