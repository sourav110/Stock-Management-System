using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using StockManagementSystemWebApp.Models;
using StockManagementSystemWebApp.DAL;
using StockManagementSystemWebApp.PL;

namespace StockManagementSystemWebApp.BLL
{
    public class ItemManager
    {
        ItemGateway itemGateway = new ItemGateway();
        
        public string SaveItem(Item item)
        {
            bool isExistItem = itemGateway.IsItemExist(item);
            if (isExistItem)
            {
                return "Item Already Exists";
            }

            else
            {
                bool isSavedItem = itemGateway.SaveItem(item);
                if (isSavedItem)
                {
                    return "Item saved successfully";
                }

                else
                {
                    return "Failed to save";
                }
            }
        }
    }
}