using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ImmanuelNews.WebApi.Models;
using ImmanuelNews.WebApi.Services;

namespace ImmanuelNews.WebApi.Controllers
{
    public class FeedsController : ApiController
    {
        FeedsService feedService = new FeedsService();

        // GET api/feeds
        public List<Feed> Get()
        {
            return feedService.GetFeeds();
            //return new string[] { "value1", "value2", matchingPerson.Firstname, matchingPerson.Lastname };
        }

        // GET api/feeds/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/feeds
        public void Post([FromBody]string value)
        {
        }

        // PUT api/feeds/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/feeds/5
        public void Delete(int id)
        {
        }
    }
}
