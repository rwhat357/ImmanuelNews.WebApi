using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ImmanuelNews.WebApi.Models;

namespace ImmanuelNews.WebApi.Repositories
{
    public class UsersFakeRepository: AbstractRepository
    {
        public List<User> GetList()
        {
            var users = new List<User>();

            var user1 = new User
            {
                UserId = 1,
                Firstname = "Fred1",
                Lastname = "lastname1",
                Email = "test1@test.com",
                Password = "password",
            };
            var user2 = new User
            {
                UserId = 2,
                Firstname = "Fred1",
                Lastname = "lastname1",
                Email = "test1@test.com",
                Password = "password",
            };
            users.Add(user1);
            users.Add(user2);

            return users;
        }

        public User GetById(int id)
        {
            return new User
            {
                UserId = 1,
                Firstname = "Fred1",
                Lastname = "lastname1",
                Email = "test1@test.com",
                Password = "password",
            };
        }
    }
}