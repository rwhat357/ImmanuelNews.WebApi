using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ImmanuelNews.WebApi.Helpers;
using ImmanuelNews.WebApi.Models;
using ImmanuelNews.WebApi.Repositories;

namespace ImmanuelNews.WebApi.Services
{
    public class UsersService
    {
        private readonly UsersRepository _usersRepository = new UsersRepository();
        private readonly UsersFakeRepository _usersFakeRepository = new UsersFakeRepository();

        public List<User> GetList()
        {
            if (FeatureActivator.EnableFakeRepositories)
                return _usersFakeRepository.GetList();

            return _usersRepository.GetList();
        }

        public User GetById(int id)
        {
            if (FeatureActivator.EnableFakeRepositories)
                return _usersFakeRepository.GetById(id);

            return _usersRepository.GetById(id);
        }
    }
}