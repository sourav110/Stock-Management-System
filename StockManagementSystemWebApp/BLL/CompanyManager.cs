using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Drawing;
using StockManagementSystemWebApp.Models;
using StockManagementSystemWebApp.DAL;
using StockManagementSystemWebApp.PL;

namespace StockManagementSystemWebApp.BLL
{
    public class CompanyManager
    {
        CompanyGateway companyGateway = new CompanyGateway();

        public string SaveCompany(Company company)
        {
            bool isExistCompany = companyGateway.IsCompanyExist(company);
            if (isExistCompany)
            {
                return "Company Already Exists";
            }

            else
            {
                bool isSavedCompany = companyGateway.SaveCompany(company);
                if (isSavedCompany)
                {
                    return "Company saved successfully";
                }

                else
                {
                    return "Failed to save";
                }
            }
        }

        public List<Company> GetAllCompanies()
        {
            return companyGateway.GetAllCompaniesFromDB();
        }
    }
}