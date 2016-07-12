using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ImmanuelNews.WebApi.Models;
using ImmanuelNews.WebApi.Repositories;

namespace ImmanuelNews.WebApi.Services
{
    public class UsersService
    {
        private readonly UsersRepository _usersRepository = new UsersRepository();

        public List<User> GetUsers()
        {
            return _usersRepository.GetUsers();
        }

        public User GetUserById(int id)
        {
            return _usersRepository.GetUserById(id);
        }
    }
}