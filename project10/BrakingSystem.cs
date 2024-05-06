using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace project10
{
    public partial class BrakingSystem : UserControl
    {
        private const string connectionString = "Data Source=(localdb)\\local;Initial Catalog=cpms;Integrated Security=True";

        public BrakingSystem()
        {
            InitializeComponent();
            LoadProducts("Braking System");
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
            string query = "SELECT * FROM [Products] WHERE Category = @Category";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Category", category);
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
                Image = GetImageFromByteArray(productData["Image"] as byte[])
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
    }
}
