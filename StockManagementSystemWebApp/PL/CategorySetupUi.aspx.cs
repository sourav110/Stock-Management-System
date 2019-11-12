using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
//using System.Drawing;
using StockManagementSystemWebApp.Models;
using StockManagementSystemWebApp.BLL;
using StockManagementSystemWebApp.PL;

using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.html.simpleparser;


namespace StockManagementSystemWebApp.PL
{
    public partial class CategorySetupUi : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ShowAllCatagories();
        }

        CategoryManager categoryManager = new CategoryManager();

        protected void saveButton_Click(object sender, EventArgs e)
        {
            string categoryName = inputCategoryName.Value;
            Category category = new Category(categoryName);

            string message = categoryManager.SaveCategory(category);
            messageLabel.Text = message;

            if (message == "Category saved successfully")
            {
                messageLabel.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                messageLabel.ForeColor = System.Drawing.Color.Red;
            }
            
            ClearField();
        }

        public void ShowAllCatagories()
        {
            List<Category> categories = new List<Category>();
            categories = categoryManager.GetAllCategories();

            categoryGridView.DataSource = categories;
            categoryGridView.DataBind();
        }

        private void ClearField()
        {
            inputCategoryName.Value = String.Empty;
        }


        protected void printReportButton_Click(object sender, EventArgs e)
        {
            int columnsCount = categoryGridView.HeaderRow.Cells.Count;
            // Create the PDF Table specifying the number of columns

            PdfPTable pdfTable = new PdfPTable(columnsCount);

            foreach (TableCell gridViewHeaderCell in categoryGridView.HeaderRow.Cells)
            {
                Font font = new Font();
                font.Color = new BaseColor(categoryGridView.HeaderStyle.ForeColor);

                PdfPCell pdfCell = new PdfPCell(new Phrase(gridViewHeaderCell.Text, font));

                pdfCell.BackgroundColor = new BaseColor(categoryGridView.HeaderStyle.BackColor);

                pdfTable.AddCell(pdfCell);
            }

            foreach (GridViewRow gridViewRow in categoryGridView.Rows)
            {
                if (gridViewRow.RowType == DataControlRowType.DataRow)
                {
                    foreach (TableCell gridViewCell in gridViewRow.Cells)
                    {
                        Font font = new Font();
                        font.Color = new BaseColor(categoryGridView.RowStyle.ForeColor);

                        PdfPCell pdfCell = new PdfPCell(new Phrase(gridViewCell.Text, font));

                        pdfCell.BackgroundColor = new BaseColor(categoryGridView.RowStyle.BackColor);

                        pdfTable.AddCell(pdfCell);
                    }
                }
            }

            Document pdfDocument = new Document(PageSize.A4, 10f, 10f, 10f, 10f);

            PdfWriter.GetInstance(pdfDocument, Response.OutputStream);

            pdfDocument.Open();
            pdfDocument.Add(pdfTable);
            pdfDocument.Close();

            Response.ContentType = "application/pdf";
            Response.AppendHeader("content-disposition",
                "attachment;filename=Category.pdf");
            Response.Write(pdfDocument);
            Response.Flush();
            Response.End();
        }
    }
}