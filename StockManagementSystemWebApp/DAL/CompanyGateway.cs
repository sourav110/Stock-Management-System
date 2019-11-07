using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Web.Configuration;
using StockManagementSystemWebApp.Models;

namespace StockManagementSystemWebApp.DAL
{
    public class CompanyGateway
    {
        string connectionString = WebConfigurationManager.ConnectionStrings["SMSDB"].ConnectionString;

        public bool IsCompanyExist(Company company)
        {
            SqlConnection connection = new SqlConnection(connectionString);

            string query = "SELECT * FROM Company_tbl WHERE CompanyName = '" + company.CompanyName + "'";
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

        public bool SaveCompany(Company company)
        {
            SqlConnection connection = new SqlConnection(connectionString);

            string query = "INSERT INTO Company_tbl(CompanyName) VALUES('" + company.CompanyName + "')";
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

        public List<Company> GetAllCompaniesFromDB()
        {
            List<Company> companies = new List<Company>();

            SqlConnection connection = new SqlConnection(connectionString);

            string query = "SELECT * FROM Company_tbl";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                string companyName = reader["CompanyName"].ToString();
                Company company = new Company(companyName);
                companies.Add(company);
            }

            reader.Close();
            connection.Close();

            return companies;
        }
    }
}