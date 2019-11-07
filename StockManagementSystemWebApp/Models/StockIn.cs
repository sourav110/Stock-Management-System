using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StockManagementSystemWebApp.Models
{
    public class StockIn
    {
        public int StockInId { set; get; }
        public int CompanyId { set; get; }
        public int ItemId { set; get; }
        public int ReorderLevel { set; get; }
        public int AvailableQuantity { set; get; }
        public int StockInQuantity { set; get; }
    }
}