using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Web.Configuration;
using StockManagementSystemWebApp.Models;

namespace StockManagementSystemWebApp.DAL
{
    public class ItemGateway
    {
        string connectionString = WebConfigurationManager.ConnectionStrings["SMSDB"].ConnectionString;

        public bool IsItemExist(Item item)
        {
            SqlConnection connection = new SqlConnection(connectionString);

            string query = "SELECT * FROM Item_tbl WHERE ItemName = '" + item.ItemName + "'";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();

            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                return true;
            }

            reader.Close();
            connection.Close();

            return false;
        }

        public bool SaveItem(Item item)
        {
            SqlConnection connection = new SqlConnection(connectionString);

            string query = "INSERT INTO Item_tbl(CategoryId, CompanyId, ItemName, ReorderLevel) VALUES("+item.CategoryId+", "+item.CompanyId+", '" + item.ItemName + "', "+item.ReorderLevel+" )";
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

        public List<Item> GetAllItemsFromDB()
        {
            List<Item> items = new List<Item>();

            SqlConnection connection = new SqlConnection(connectionString);

            string query = "SELECT * FROM Item_tbl";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                int itemId = Convert.ToInt32(reader["ItemId"]);
                string itemName = reader["ItemName"].ToString();
                Item item = new Item(itemName);

                items.Add(item);
            }

            reader.Close();
            connection.Close();

            return items;
        }
    }
}