using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using StockManagementSystemWebApp.Models;
using StockManagementSystemWebApp.DAL;
using StockManagementSystemWebApp.PL;


namespace StockManagementSystemWebApp.BLL
{
    public class StockInManager
    {
        StockInGateway stockInGateway = new StockInGateway();

        public string SaveStockIn(StockIn stockIn)
        {
            bool isSavedStockIn = stockInGateway.SaveStockIn(stockIn);

            if (isSavedStockIn)
            {
                return "Stock in saved successfully";
            }

            else
            {
                return "Failed to save";
            }
        }
    }
}