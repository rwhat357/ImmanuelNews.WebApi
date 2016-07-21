using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace ImmanuelNews.WebApi.Helpers
{
    public static class FeatureActivator
    {
        public static bool EnableFakeRepositories =
            ConfigurationManager.AppSettings["FeatureActivator:EnableFakeRepositories"] == null ? false
                : bool.Parse(ConfigurationManager.AppSettings["FeatureActivator:EnableFakeRepositories"]);

    }
}