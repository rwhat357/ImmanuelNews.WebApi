using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ImmanuelNews.WebApi.Repositories
{
    public abstract class AbstractRepository
    {
        protected readonly string ConnectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

        // Returns the a string from the column or 0 if it's null
        public string SafeGetString(SqlDataReader reader, string fieldName)
        {
            return reader[fieldName] == DBNull.Value ? String.Empty : reader[fieldName].ToString();
        }

        // Returns the a integer from the column or 0 if it's null
        public int SafeGetInteger(SqlDataReader reader, string fieldName)
        {
            return reader[fieldName] == DBNull.Value ? 0 : reader.GetInt32(reader.GetOrdinal(fieldName));
        }
    
    }
}