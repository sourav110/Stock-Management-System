using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;
using StockManagementSystemWebApp.Models;
using StockManagementSystemWebApp.BLL;
using StockManagementSystemWebApp.PL;

namespace StockManagementSystemWebApp.PL
{
    public partial class CompanySetupUi : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ShowAllCompanies();
        }

        CompanyManager companyManager = new CompanyManager();

        protected void saveButton_Click(object sender, EventArgs e)
        {
            string companyName = inputCompanyName.Value;
            Company company = new Company(companyName);

            string message = companyManager.SaveCompany(company);
            messageLabel.Text = message;

            if (message == "Company saved successfully")
            {
                messageLabel.ForeColor = Color.Green;
            }
            else
            {
                messageLabel.ForeColor = Color.Red;
            }

            ClearField();
        }

        public void ShowAllCompanies()
        {
            List<Company> companies = new List<Company>();
            companies = companyManager.GetAllCompanies();

            companyGridView.DataSource = companies;
            companyGridView.DataBind();
        }

        private void ClearField()
        {
            inputCompanyName.Value = String.Empty;
        }
    }
}