using System.Configuration;
using System.Data.SqlClient;

namespace GeoService.Data
{
    public class CustomSqlConnection
    {
        public SqlConnection GetConnection()
        {
            SqlConnection connection = new SqlConnection {ConnectionString = GetConnectionString()};

            connection.Open();
            connection.ChangeDatabase("GeoService");

            return connection;
        }
        
        private static string GetConnectionString()
        {
            return ConfigurationManager.AppSettings["SQLServer"];
        }
    }
}