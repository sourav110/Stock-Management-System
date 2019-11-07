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
    public partial class CategorySetupUi : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ShowAllCatagories();
        }
        CategoryManager categoryManager = new CategoryManager();

        protected void saveButton_Click(object sender, EventArgs e)
        {
            string categoryName = inputCategoryName.Value;
            Category category = new Category(categoryName);

            string message = categoryManager.SaveCategory(category);
            messageLabel.Text = message;
            if (message == "Category saved successfully")
            {
                messageLabel.ForeColor = Color.Green;
            }
            else
            {
                messageLabel.ForeColor = Color.Red;
            }
            
            ClearField();
        }

        public void ShowAllCatagories()
        {
            List<Category> categories = new List<Category>();
            categories = categoryManager.GetAllCategories();

            categoryGridView.DataSource = categories;
            categoryGridView.DataBind();
        }

        private void ClearField()
        {
            inputCategoryName.Value = String.Empty;
        }
    }
}