using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalSystem.Common
{
    public class DataSource
    {
        static string url = @"server=localhost;Allow User Variables=True;database=rentalsystem; uid=root;pwd=123456;Character Set=utf8;";

        public MySqlConnection getConnection()
        {
            MySqlConnection conn;
            try
            {
                conn = new MySqlConnection(url);
                conn.Open();
                return conn;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
