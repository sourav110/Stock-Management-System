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
    public partial class StockInUi : System.Web.UI.Page
    {
        CompanyManager companyManager = new CompanyManager();
        ItemManager itemManager = new ItemManager();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindCompanyDropDownList();
                BindItemDropDownList();
            }
        }

        private void BindCompanyDropDownList()
        {
            ddlCompany.DataTextField = "CompanyName";
            ddlCompany.DataValueField = "CompanyId";
            ddlCompany.DataSource = companyManager.GetAllCompanies();
            ddlCompany.DataBind();
        }

        private void BindItemDropDownList()
        {
            ddlItem.DataTextField = "ItemName";
            ddlItem.DataValueField = "ItemId";
            ddlItem.DataSource = itemManager.GetAllItems();
            ddlItem.DataBind();
        }

        protected void saveButton_Click(object sender, EventArgs e)
        {

        }
    }
}