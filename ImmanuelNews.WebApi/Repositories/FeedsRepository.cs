using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using ImmanuelNews.WebApi.Models;

namespace ImmanuelNews.WebApi.Repositories
{
    public class FeedsRepository: AbstractRepository, IRepository<Feed>
    {
        public List<Feed> GetList()
        {
            var feeds = new List<Feed>();

            using (var connection = new SqlConnection(ConnectionString))
            {
                string cmdText = "SELECT * FROM Feeds";
                var cmd = new SqlCommand(cmdText, connection);
                connection.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var feed = new Feed
                        {
                            FeedId = SafeGetInteger(reader, "FeedId"),
                            Title = SafeGetString(reader, "Title"),
                            Content = SafeGetString(reader, "Content"),
                            ContentImageUrl = SafeGetString(reader, "ContentImageUrl"),
                            BaseUrl = SafeGetString(reader, "BaseUrl"),
                            ViewCount = SafeGetInteger(reader, "ViewCount")
                        };
                        feeds.Add(feed);
                    }
                }
            }

            return feeds;
        }

        public Feed GetById(int id)
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                string cmdText = "SELECT * FROM Feeds WHERE FeedId = @FeedId";
                var cmd = new SqlCommand(cmdText, connection);
                cmd.Parameters.AddWithValue("@FeedId", id);
                connection.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    reader.Read();
                    if (reader.HasRows)
                    {
                        return new Feed
                        {
                            FeedId = SafeGetInteger(reader, "FeedId"),
                            Title = SafeGetString(reader, "Title"),
                            Content = SafeGetString(reader, "Content"),
                            ContentImageUrl = SafeGetString(reader, "ContentImageUrl"),
                            BaseUrl = SafeGetString(reader, "BaseUrl"),
                            ViewCount = SafeGetInteger(reader, "ViewCount")
                        };
                    }
                }
            }

            return null;
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