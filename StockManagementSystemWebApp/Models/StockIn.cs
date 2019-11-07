using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StockManagementSystemWebApp.Models
{
    public class StockIn
    {
        public StockIn(int companyId, int itemId, int stockInQuantity)
        {
            CompanyId = companyId;
            ItemId = itemId;
            StockInQuantity = stockInQuantity;
        }

        public StockIn(int companyId, int itemId, int reorderLevel, int availableQuantity, int stockInQuantity)
        {
            CompanyId = companyId;
            ItemId = itemId;
            ReorderLevel = reorderLevel;
            AvailableQuantity = availableQuantity;
            StockInQuantity = stockInQuantity;
        }

        public StockIn(int stockInId, int companyId, int itemId, int reorderLevel, int availableQuantity, int stockInQuantity)
        {
            StockInId = stockInId;
            CompanyId = companyId;
            ItemId = itemId;
            ReorderLevel = reorderLevel;
            AvailableQuantity = availableQuantity;
            StockInQuantity = stockInQuantity;
        }

        public int StockInId { set; get; }
        public int CompanyId { set; get; }
        public int ItemId { set; get; }
        public int ReorderLevel { set; get; }
        public int AvailableQuantity { set; get; }
        public int StockInQuantity { set; get; }
    }
}