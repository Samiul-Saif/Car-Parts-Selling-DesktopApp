using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using TheArtOfDevHtmlRenderer.Adapters.Entities;
using TheArtOfDevHtmlRenderer.Adapters;
using System.Data.SqlClient;

namespace project10
{
    public partial class PrintDialogUC : Form
    {
        private string cartInfo;

        public PrintDialogUC(string cartInfo, decimal totalCost)
        {
            InitializeComponent();
            totalCostLabel.Text = totalCost.ToString();
            this.cartInfo = cartInfo;
            AddCartInfo();
        }

        private void AddCartInfo()
        {
            cartInfoLabel.Text = cartInfo;
            flowLayoutPanel1.Controls.Add(cartInfoLabel);
        }

        private void printButton_Click(object sender, EventArgs e)
        {


            foreach (var product in CategorizedProductsUC.selectedProductList)
            {
                int selectedProductId = product.Item1;
                int selectedQuantity = product.Item5;   

                DecrementProductQuantity(selectedProductId, selectedQuantity);
            }

            PrintDialog printDialog1 = new PrintDialog();
            printDialog1.Document = printDocument1;

            DialogResult printResult = printDialog1.ShowDialog();
            if (printResult == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void DecrementProductQuantity(int productId, int quantity)
        {
            string connectionString = "Data Source=(localdb)\\local;Initial Catalog=cpms;Integrated Security=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "UPDATE [Products] SET [Quantity] = [Quantity] - @Quantity WHERE [ProductID] = @ProductId";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Quantity", quantity);
                    command.Parameters.AddWithValue("@ProductId", productId);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        private int currentPageIndex = 0;

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Font titleFont = new Font("Arial", 16, FontStyle.Bold);
            Font normalFont = new Font("Arial", 12, FontStyle.Regular);
            Brush brush = Brushes.Black;

            float startX = 20;
            float startY = 10;
            float lineHeight = normalFont.GetHeight(e.Graphics) + 5;

            string companyName = "Car Parts BD";
            SizeF titleSize = e.Graphics.MeasureString(companyName, titleFont);
            float titleX = (e.PageBounds.Width - titleSize.Width) / 2;
            e.Graphics.DrawString(companyName, titleFont, brush, titleX, startY);
            startY += titleSize.Height + 5; 

            e.Graphics.DrawString("Thank you.", normalFont, brush, titleX + 20, startY);
            startY += lineHeight;

            e.Graphics.DrawLine(Pens.Black, startX, startY, e.PageBounds.Width - startX, startY);
            startY += 10;

            e.Graphics.DrawString($"Customer Name: {customerNameTB.Text}", normalFont, brush, startX, startY);
            startY += lineHeight;
            e.Graphics.DrawString($"Phone: {cutomerPhoneTextbox.Text}", normalFont, brush, startX, startY);
            startY += lineHeight;
            e.Graphics.DrawString($"Total Price: {totalCostLabel.Text}", normalFont, brush, startX, startY);
            startY += lineHeight;

            e.Graphics.DrawLine(Pens.Black, startX, startY, e.PageBounds.Width - startX, startY);
            startY += 10; 

            string[] cartItems = cartInfo.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);

            int linesPerPage = (int)((e.PageBounds.Height - startY) / lineHeight);

            while (currentPageIndex < cartItems.Length && linesPerPage > 0)
            {
                e.Graphics.DrawString(cartItems[currentPageIndex], normalFont, brush, startX, startY);
                startY += lineHeight;
                linesPerPage--;

                currentPageIndex++;
            }

            e.HasMorePages = currentPageIndex < cartItems.Length;
        }


    }
}
