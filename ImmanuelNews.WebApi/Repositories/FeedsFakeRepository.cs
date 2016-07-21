using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ImmanuelNews.WebApi.Models;

namespace ImmanuelNews.WebApi.Repositories
{
    public class FeedsFakeRepository: AbstractRepository
    {
        public List<Feed> GetList()
        {
            var feeds = new List<Feed>();

            var feed1 = new Feed
            {
                FeedId = 1,
                Title = "Title 1",
                Content = "The content 1 is here.",
                ContentImageUrl = "imagurlhere.com",
                BaseUrl = "baseurl1here.com",
                ViewCount = 3
            };
            var feed2 = new Feed
            {
                FeedId = 2,
                Title = "Title 2",
                Content = "The contnet 2 is here.",
                ContentImageUrl = "google.com",
                BaseUrl = "baseurl2her.com",
                ViewCount = 6
            };

            feeds.Add(feed1);
            feeds.Add(feed2);

            return feeds;
        }

        public Feed GetById(int id)
        {
            return new Feed
            {
                FeedId = 1,
                Title = "Title 1",
                Content = "The content 1 is here.",
                ContentImageUrl = "imagurlhere.com",
                BaseUrl = "baseurl1here.com",
                ViewCount = 3
            };
        }

        public void Add(Feed entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Feed entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Feed entity)
        {
            throw new NotImplementedException();
        }
    }
}