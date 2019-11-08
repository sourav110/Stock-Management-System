using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using StockManagementSystemWebApp.Models;
using StockManagementSystemWebApp.DAL;
using StockManagementSystemWebApp.PL;

namespace StockManagementSystemWebApp.BLL
{
    public class StockOutManager
    {
        StockOutGateway stockOutGateway = new StockOutGateway();

        public string SaveStockOut(StockOut stockOut)
        {
            bool isSavedStockOut = stockOutGateway.SaveStockOut(stockOut);

            if (isSavedStockOut)
            {
                return "Stock out saved successfully";
            }

            else
            {
                return "Failed to save";
            }
        }

        public string SaveSale(Sale sale)
        {
            bool isSavedSale = stockOutGateway.SaveSale(sale);

            if (isSavedSale)
            {
                return "Sold out successfully";
            }

            else
            {
                return "Failed to save";
            }
        }
    }
}