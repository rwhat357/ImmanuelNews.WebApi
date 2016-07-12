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
    public class UsersController : ApiController
    {
        UsersService userService = new UsersService();

        // GET api/users
        public IEnumerable<User> Get()
        {
            return userService.GetUsers();
        }

        // GET api/users/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/users
        public void Post([FromBody]string value)
        {
        }

        // PUT api/users/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/users/5
        public void Delete(int id)
        {
        }
    }
}
