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
    public partial class StockOutUi : System.Web.UI.Page
    {
        CompanyManager companyManager = new CompanyManager();
        ItemManager itemManager = new ItemManager();
        StockOutManager stockOutManager = new StockOutManager();
        
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

        protected void addButton_Click(object sender, EventArgs e)
        {
            int companyId = Convert.ToInt32(ddlCompany.SelectedValue);
            int itemId = Convert.ToInt32(ddlItem.SelectedValue);
            int stockOutQuantity = Convert.ToInt32(inputStockOutQuantity.Value);

            StockOut stockOut = new StockOut(companyId, itemId, stockOutQuantity);

            string message = stockOutManager.SaveStockOut(stockOut);
            messageLabel.Text = message;

            if (message == "Stock out saved successfully")
            {
                messageLabel.ForeColor = Color.Green;
            }
            else
            {
                messageLabel.ForeColor = Color.Red;
            }

            //ClearField();
        }

        protected void sellButton_Click(object sender, EventArgs e)
        {
            int companyId = Convert.ToInt32(ddlCompany.SelectedValue);
            int itemId = Convert.ToInt32(ddlItem.SelectedValue);
            //int saleQuantity = Convert.ToInt32(inputStockOutQuantity.Value);
            int saleQuantity = Convert.ToInt32(inputStockOutQuantity.Value);
            DateTime saleDate = DateTime.Today;

            Sale sale = new Sale(itemId, saleQuantity, saleDate);

            string message = stockOutManager.SaveSale(sale);
            messageLabel.Text = message;

            ClearField();
        }

        private void ClearField()
        {
            inputStockOutQuantity.Value = String.Empty;
        }
    }
}