using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StockManagementSystemWebApp.Models
{
    public class Sale
    {
        public Sale(int itemId, int saleQuantity, DateTime saleDate)
        {
            ItemId = itemId;
            SaleQuantity = saleQuantity;
            this.saleDate = saleDate;
        }

        public Sale(int salelId, int itemId, int saleQuantity, DateTime saleDate)
        {
            SalelId = salelId;
            ItemId = itemId;
            SaleQuantity = saleQuantity;
            this.saleDate = saleDate;
        }

        public Sale(int salelId, int companyId, int itemId, int saleQuantity, DateTime saleDate)
        {
            SalelId = salelId;
            CompanyId = companyId;
            ItemId = itemId;
            SaleQuantity = saleQuantity;
            this.saleDate = saleDate;
        }

        public int SalelId { set; get; }
        public int CompanyId { set; get; }
        public int ItemId { set; get; }
        public int SaleQuantity { set; get; }
        public DateTime saleDate { set; get; }
    }
}