using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Web.Configuration;
using StockManagementSystemWebApp.Models;

namespace StockManagementSystemWebApp.DAL
{
    public class UserGateway
    {
        string connectionString = WebConfigurationManager.ConnectionStrings["SMSDB"].ConnectionString;

        public bool IsExistUser(User user)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            string query = "SELECT * FROM User_tbl WHERE UserName = '"+user.UserName+"' AND Password = '"+user.Password+"' ";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();

            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                return true;
            }
            connection.Close();

            return false;
        }
    }
}