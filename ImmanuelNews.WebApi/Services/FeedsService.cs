using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ImmanuelNews.WebApi.Helpers;
using ImmanuelNews.WebApi.Models;
using ImmanuelNews.WebApi.Repositories;

namespace ImmanuelNews.WebApi.Services
{
    public class FeedsService
    {
        private readonly FeedsRepository _feedsRepository = new FeedsRepository();
        private readonly FeedsFakeRepository _feedsFakeRepository = new FeedsFakeRepository();

        public List<Feed> GetList()
        {
            if (FeatureActivator.EnableFakeRepositories)
                return _feedsFakeRepository.GetList();

            return _feedsRepository.GetList();
        }

        public Feed GetById(int id)
        {
            if (FeatureActivator.EnableFakeRepositories)
                return _feedsFakeRepository.GetById(id);

            return _feedsRepository.GetById(id);
        }
    }
}