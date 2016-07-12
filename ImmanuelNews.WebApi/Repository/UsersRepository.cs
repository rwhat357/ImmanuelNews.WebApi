using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using ImmanuelNews.WebApi.Models;

namespace ImmanuelNews.WebApi.Repository
{
    public class UsersRepository: ImmanuelNewsRepository
    {
        public List<User> GetUsers()
        {
            var users = new List<User>();

            using (SqlConnection sqlConnection = new SqlConnection(ConnectionString))
            {
                string oString = "SELECT * FROM Users";
                var oCmd = new SqlCommand(oString, sqlConnection);
                sqlConnection.Open();
                using (SqlDataReader oReader = oCmd.ExecuteReader())
                {
                    while (oReader.Read())
                    {
                        var user = new User
                        {
                            UserId = oReader.GetInt32(oReader.GetOrdinal("UserId")),
                            Firstname = SafeGetString(oReader, "FirstName"),
                            Lastname = SafeGetString(oReader, "LastName"),
                            Email = SafeGetString(oReader, "Email"),
                            Password = SafeGetString(oReader, "Password"),
                        };
                        users.Add(user);
                    }

                    sqlConnection.Close();
                }
            }

            return users;
        }
    }
}