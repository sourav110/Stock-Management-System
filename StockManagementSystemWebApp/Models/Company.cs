using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StockManagementSystemWebApp
{
    public class Company
    {
        public Company(string companyName)
        {
            CompanyName = companyName;
        }

        public Company(int companyId, string companyName)
        {
            CompanyId = companyId;
            CompanyName = companyName;
        }

        public int CompanyId { set; get; }
        public string CompanyName { set; get; }
    }
}