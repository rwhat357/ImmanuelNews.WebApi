using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ImmanuelNews.WebApi.Models
{
    public class Feed
    {
        public int FeedId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string ContentImageUrl { get; set; }
        public string BaseUrl { get; set; }
        public int ViewCount { get; set; }
    }
}