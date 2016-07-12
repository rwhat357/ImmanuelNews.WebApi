using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using ImmanuelNews.WebApi.Models;

namespace ImmanuelNews.WebApi.Repositories
{
    public class FeedsRepository: AbstractRepository
    {
        public List<Feed> GetFeeds()
        {
            var feeds = new List<Feed>();

            using (SqlConnection sqlConnection = new SqlConnection(ConnectionString))
            {
                string oString = "SELECT * FROM Feeds";
                SqlCommand oCmd = new SqlCommand(oString, sqlConnection);
                sqlConnection.Open();
                using (SqlDataReader oReader = oCmd.ExecuteReader())
                {
                    while (oReader.Read())
                    {
                        var feed = new Feed
                        {
                            FeedId = SafeGetInteger(oReader, "FeedId"),
                            Title = SafeGetString(oReader, "Title"),
                            Content = SafeGetString(oReader, "Content"),
                            ContentImageUrl = SafeGetString(oReader, "ContentImageUrl"),
                            BaseUrl = SafeGetString(oReader, "BaseUrl"),
                            ViewCount = SafeGetInteger(oReader, "ViewCount")
                        };
                        feeds.Add(feed);
                    }
                    sqlConnection.Close();
                }
            }

            return feeds;
        }

    }
}