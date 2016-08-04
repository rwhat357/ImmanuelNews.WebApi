using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;

namespace ImmanuelNews.WebApi.Controllers
{
    public class HomeController : Controller
    {
        private readonly string _swaggerUrl = "http://localhost:51057/swagger";

        [Route("GoToSwaggerPage")]
        public ActionResult GoToSwaggerPage()
        {
            return RedirectPermanent(_swaggerUrl);
        }
    }
}
