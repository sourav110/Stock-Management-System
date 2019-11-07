using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Web.Configuration;
using StockManagementSystemWebApp.Models;

namespace StockManagementSystemWebApp.DAL
{
    public class StockInGateway
    {
        string connectionString = WebConfigurationManager.ConnectionStrings["SMSDB"].ConnectionString;

        public bool SaveStockIn(StockIn stockIn)
        {
            SqlConnection connection = new SqlConnection(connectionString);

            string query = "INSERT INTO StockIn_tbl(CompanyId, ItemId, StockInQuantity) VALUES( " + stockIn.CompanyId + ", '" + stockIn.ItemId + "', " + stockIn.StockInQuantity + " )";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            int rowEffect = command.ExecuteNonQuery();
            connection.Close();

            if (rowEffect > 0)
            {
                return true;
            }

            return false;
        }
    }
}