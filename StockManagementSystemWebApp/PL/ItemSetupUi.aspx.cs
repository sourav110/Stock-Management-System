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
    public partial class ItemSetupUi : System.Web.UI.Page
    {
        CategoryManager categoryManager = new CategoryManager();
        CompanyManager companyManager = new CompanyManager();
        ItemManager itemManager = new ItemManager();
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindCategoryDropDownList();
                BindCompanyDropDownList();
            }
        }

        private void BindCategoryDropDownList()
        {
            ddlCategory.DataTextField = "CategoryName";
            ddlCategory.DataValueField = "CategoryId";
            ddlCategory.DataSource = categoryManager.GetAllCategories();
            ddlCategory.DataBind();
        }

        private void BindCompanyDropDownList()
        {
            ddlCompany.DataTextField = "CompanyName";
            ddlCompany.DataValueField = "CompanyId";
            ddlCompany.DataSource = companyManager.GetAllCompanies();
            ddlCompany.DataBind();
        }

        protected void saveButton_Click(object sender, EventArgs e)
        {
            int categoryId = Convert.ToInt32(ddlCategory.SelectedValue);
            int companyId = Convert.ToInt32(ddlCompany.SelectedValue);
            string itemName = inputItemName.Value;
            int reorderLevel = Convert.ToInt32(inputReorderLevel.Value);

            Item item = new Item(categoryId, companyId, itemName, reorderLevel);

            string message = itemManager.SaveItem(item);
            messageLabel.Text = message;

            if (message == "Item saved successfully")
            {
                messageLabel.ForeColor = Color.Green;
            }
            else
            {
                messageLabel.ForeColor = Color.Red;
            }

            ClearField();
        }

        private void ClearField()
        {
            inputItemName.Value = String.Empty;
        }
    }
}