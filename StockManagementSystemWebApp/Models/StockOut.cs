using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StockManagementSystemWebApp.Models
{
    public class StockOut
    {
        public StockOut(int companyId, int itemId, int stockOutQuantity)
        {
            CompanyId = companyId;
            ItemId = itemId;
            StockOutQuantity = stockOutQuantity;
        }

        public StockOut(int stockOutId, int companyId, int itemId, int stockOutQuantity)
        {
            StockOutId = stockOutId;
            CompanyId = companyId;
            ItemId = itemId;
            StockOutQuantity = stockOutQuantity;
        }

        public StockOut(int stockOutId, int companyId, int itemId, int reorderLevel, int availableQuantity, int stockOutQuantity) : this(stockOutId, companyId, itemId, reorderLevel)
        {
            AvailableQuantity = availableQuantity;
            StockOutQuantity = stockOutQuantity;
        }

        public int StockOutId { set; get; }
        public int CompanyId { set; get; }
        public int ItemId { set; get; }
        public int ReorderLevel { set; get; } 
        public int AvailableQuantity { set; get; }
        public int StockOutQuantity { set; get; }
    }
}