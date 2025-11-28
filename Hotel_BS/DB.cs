using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Hotel_BS
{
    public static class DB
    {
        private static string connString = ConfigurationManager.ConnectionStrings["HotelDB"].ConnectionString;

        public static MySqlConnection GetConnection()
        {
            return new MySqlConnection(connString);
        }

        public static void ExecuteNonQuery(string query, MySqlParameter[] parameters = null)
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                using (var cmd = new MySqlCommand(query, conn))
                {
                    if (parameters != null) cmd.Parameters.AddRange(parameters);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
