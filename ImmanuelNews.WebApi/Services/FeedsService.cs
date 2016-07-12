using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ImmanuelNews.WebApi.Models;
using ImmanuelNews.WebApi.Repositories;

namespace ImmanuelNews.WebApi.Services
{
    public class FeedsService
    {
        private readonly FeedsRepository _feedsRepository = new FeedsRepository();

        public List<Feed> GetList()
        {
            return _feedsRepository.GetList();
        }

        public Feed GetById(int id)
        {
            return _feedsRepository.GetById(id);
        }
    }
}