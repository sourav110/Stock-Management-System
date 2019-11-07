using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StockManagementSystemWebApp.Models
{
    public class Item
    {
        public Item(int itemId, int categoryId, int companyId, string itemName, int reorderLevel, int quantity)
        {
            ItemId = itemId;
            CategoryId = categoryId;
            CompanyId = companyId;
            ItemName = itemName;
            ReorderLevel = reorderLevel;
            Quantity = quantity;
        }

        public int ItemId { get; set; }
        public int CategoryId { get; set; }
        public int CompanyId { get; set; }
        public string ItemName { get; set; }
        public int ReorderLevel { get; set; }
        public int Quantity { get; set; }

    }
}