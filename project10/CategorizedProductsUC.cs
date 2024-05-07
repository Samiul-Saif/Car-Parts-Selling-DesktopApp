using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace project10
{
    public partial class CategorizedProductsUC : UserControl
    {
        public static List<Tuple<int, string, string, string, int, decimal,decimal>> selectedProductList = new List<Tuple<int, string, string, string, int, decimal, decimal>>();
        private const string connectionString = "Data Source=(localdb)\\local;Initial Catalog=cpms;Integrated Security=True";
        String MainCategory;
        public CategorizedProductsUC(string MainCategory)
        {
            this.MainCategory = MainCategory;
            InitializeComponent();
            categoryNameLabel.Text = MainCategory;
            LoadProducts(MainCategory);
        }

        private void LoadProducts(string category)
        {
            DataTable products = GetProductsByCategory(category);

            foreach (DataRow row in products.Rows)
            {
                // Create a card control for each product
                CardControl card = CreateCard(row);

                // Add the card control to the flowLayoutPanel
                flowLayoutPanel1.Controls.Add(card);
            }
        }

        private DataTable GetProductsByCategory(string category)
        {
            string query = "SELECT * FROM [Products]";

            if (MainCategory == "All Products")
            {
                query += " ORDER BY ProductId DESC";
            }
            else
            {
                query += " WHERE Category = @Category";
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    if (MainCategory != "All Products")
                    {
                        command.Parameters.AddWithValue("@Category", category);
                    }

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    return dataTable;
                }
            }
        }


        private CardControl CreateCard(DataRow productData)
        {
            CardControl card = new CardControl
            {
                ProductName = productData["ProductName"].ToString(),
                Price = Convert.ToDecimal(productData["Price"]),
                Image = GetImageFromByteArray(productData["Image"] as byte[]),
                ProductID = Convert.ToInt32(productData["ProductID"]),
                AvailableQuantity = Convert.ToInt32(productData["Quantity"]), 
                Brand = productData["Brand"].ToString(),
                Category = productData["Category"].ToString()

            };

            return card;
        }

        private Image GetImageFromByteArray(byte[] imageData)
        {
            if (imageData == null)
                return null;

            using (MemoryStream ms = new MemoryStream(imageData))
            {
                return Image.FromStream(ms);
            }
        }

        private void quantityNumericUpDown_ValueChanged(object sender, EventArgs e)
        {

        }

        private void addToCartButton_Click(object sender, EventArgs e)
        {
            // Get the selected card
            CardControl selectedCard = flowLayoutPanel1.Controls.OfType<CardControl>().FirstOrDefault(card => card.isSelected);

            if (selectedCard != null)
            {
                int selectedQuantity = (int)quantityNumericUpDown.Value;

                decimal individualCost = selectedCard.Price * selectedQuantity;
                decimal price = selectedCard.Price;

                int productId = selectedCard.ProductID;
                string productName = selectedCard.ProductName;
                string category = selectedCard.Category;
                string brand = selectedCard.Brand;

                selectedProductList.Add(Tuple.Create(productId, productName, category, brand, selectedQuantity, price,individualCost));

                MessageBox.Show("Product added to cart!");
                selectedCard.isSelected = false;
            }
            else
            {
                MessageBox.Show("Please select a product before adding to cart.");
            }
        }

    }
}
