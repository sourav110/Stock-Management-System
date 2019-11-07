using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Web.Configuration;
using StockManagementSystemWebApp.Models;

namespace StockManagementSystemWebApp.DAL
{
    public class CategoryGateway
    {
        string connectionString = WebConfigurationManager.ConnectionStrings["SMSDB"].ConnectionString;

        public bool IsCategoryExist(Category category)
        {
            SqlConnection connection = new SqlConnection(connectionString);

            string query = "SELECT * FROM Category_tbl WHERE CategoryName = '"+category.CategoryName+"'";
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

        public bool SaveCategory(Category category)
        {
            SqlConnection connection = new SqlConnection(connectionString);

            string query = "INSERT INTO Category_tbl(CategoryName) VALUES('"+category.CategoryName+"')";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            int rowEffect = command.ExecuteNonQuery();
            connection.Close();

            if(rowEffect > 0)
            {
                return true;
            }

            return false;
        }

        public List<Category> GetAllCategoriesFromDB()
        {
            List<Category> categories = new List<Category>();

            SqlConnection connection = new SqlConnection(connectionString);

            string query = "SELECT * FROM Category_tbl";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                int categoryId = Convert.ToInt32(reader["CategoryId"]);
                string categoryName = reader["CategoryName"].ToString();
                Category category = new Category(categoryId, categoryName);
                categories.Add(category);
            }

            reader.Close();
            connection.Close();

            return categories;
        } 
    }
}