using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ImmanuelNews.WebApi.Models;
using ImmanuelNews.WebApi.Repository;

namespace ImmanuelNews.WebApi.Services
{
    public class FeedsService
    {
        FeedsRepository feedsRepository = new FeedsRepository();

        public List<Feed> GetFeeds()
        {
            return feedsRepository.GetFeeds();
        }
    }
}