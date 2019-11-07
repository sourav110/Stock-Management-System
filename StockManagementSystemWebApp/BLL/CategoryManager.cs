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
    public class CategoryManager
    {
        CategoryGateway categoryGateway = new CategoryGateway();

        public string SaveCategory(Category category)
        {
            bool isExistCategory = categoryGateway.IsCategoryExist(category);
            if (isExistCategory)
            {
                return "Category Already Exists";
            }

            else
            {
                bool isSavedCategory = categoryGateway.SaveCategory(category);
                if (isSavedCategory)
                {
                    return "Category saved successfully";
                }

                else
                {
                    return "Failed to save";
                }
            }
        }

        public List<Category> GetAllCategories()
        {
            return categoryGateway.GetAllCategoriesFromDB();
        }
    }
}