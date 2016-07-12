using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ImmanuelNews.WebApi.Models;
using ImmanuelNews.WebApi.Repository;

namespace ImmanuelNews.WebApi.Services
{
    public class UsersService
    {

        UsersRepository usersRepository = new UsersRepository();

        public List<User> GetUsers()
        {
            return usersRepository.GetUsers();
        }
    }
}