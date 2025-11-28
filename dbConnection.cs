using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ZooShopDesktop
{
    internal class DbConfig
    {
        private static readonly string connectionString = "server=localhost;database=zoo_shop;Uid=root;Pwd=123456789";

        public static void ExecuteQuery(string query)
        {
            try
            {
                using (var connection = new MySqlConnection(connectionString))
                using (var cmd = new MySqlCommand(query, connection))
                {
                    connection.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        public static MySqlDataReader ReadData(string query)
        {
            try
            {
                var connection = new MySqlConnection(connectionString);
                connection.Open();
                var cmd = new MySqlCommand(query, connection);
                return cmd.ExecuteReader(CommandBehavior.CloseConnection);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
    }
}