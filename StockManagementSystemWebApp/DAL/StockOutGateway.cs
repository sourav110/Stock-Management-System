using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Web.Configuration;
using StockManagementSystemWebApp.Models;

namespace StockManagementSystemWebApp.DAL
{
    public class StockOutGateway
    {
        string connectionString = WebConfigurationManager.ConnectionStrings["SMSDB"].ConnectionString;

        public bool SaveStockOut(StockOut stockOut)
        {
            SqlConnection connection = new SqlConnection(connectionString);

            string query = "INSERT INTO StockOut_tbl(CompanyId, ItemId, StockOutQuantity) VALUES( " + stockOut.CompanyId + ", '" + stockOut.ItemId + "', " + stockOut.StockOutQuantity + " )";
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

        public bool SaveSale(Sale sale)
        {
            SqlConnection connection = new SqlConnection(connectionString);

            string query = "INSERT INTO Sale_tbl(ItemId, SaleQuantity, SaleDate) VALUES('" + sale.ItemId + "', " + sale.SaleQuantity + ", '"+sale.saleDate+"' )";
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