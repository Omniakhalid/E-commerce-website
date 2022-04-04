using E_commerce_website.Models;
using E_commerce_website.Repositories;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace E_commerce_website.Services
{
    public class UserService : IUserService
    {
        private IUsersRepository _usersRepo;
      
        public UserService(IUsersRepository usersRepository)
        {
            _usersRepo = usersRepository;
        }

        public void Add(User user)
        {
            _usersRepo.Add(user);
        }

        public List<User> GetAll()
        {
            return _usersRepo.GetAll();
        }

        public User GetByEmail(string email)
        {
            return _usersRepo.GetByEmail(email);
        }

        public User GetById(int id)
        {
            return _usersRepo.GetById(id);
        }

        public void Remove(int id)
        {
            _usersRepo.Remove(id);
        }
    }
}
