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

namespace StockManagementSystemWebApp
{
    public partial class LoginUi : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        UserManager userManager = new UserManager();

        protected void saveButton_Click(object sender, EventArgs e)
        {
            string userName = inputUserName.Value;
            string password = inputPassword.Value;

            User user = new User(userName, password);

            bool isExistUser = userManager.IsExistUser(user);

            if (isExistUser)
            {
                HttpCookie cookie = new HttpCookie("UserInfo");
                cookie["Name"] = user.UserName;
                cookie["Password"] = user.Password;
                Response.Cookies.Add(cookie);
                Response.Redirect("CategorySetupUi.aspx");
            }
            else
            {
                messageLabel.Text = "User not found !";
                messageLabel.ForeColor = Color.Red;
            }

            ClearField();
        }

        private void ClearField()
        {
            inputUserName.Value = String.Empty;
            inputPassword.Value = String.Empty;
        }
    }
}