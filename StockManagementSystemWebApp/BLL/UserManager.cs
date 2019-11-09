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
    public class UserManager
    {
        UserGateway userGateway = new UserGateway();

        public bool IsExistUser(User user)
        {
            return userGateway.IsExistUser(user);
        }

    }
}