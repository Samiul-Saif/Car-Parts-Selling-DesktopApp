using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace project10
{
    public partial class AddProductUC : UserControl
    {
        public AddProductUC()
        {
            InitializeComponent();
        }

        private void createProductButton_Click(object sender, EventArgs e)
        {
            // Check if any required field is empty
            if (string.IsNullOrWhiteSpace(productnameTextBox.Text) ||
                string.IsNullOrWhiteSpace(brandTextBox.Text) ||
                string.IsNullOrWhiteSpace(productPriceTextBox.Text) ||
                string.IsNullOrWhiteSpace(productQuantityTextBox.Text) ||
                prductCategoryComboBox.SelectedItem == null)
            {
                MessageBox.Show("Please fill all the required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Check if Price and Quantity are numeric
            decimal price;
            if (!decimal.TryParse(productPriceTextBox.Text, out price))
            {
                MessageBox.Show("Please enter a valid price.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int quantity;
            if (!int.TryParse(productQuantityTextBox.Text, out quantity))
            {
                MessageBox.Show("Please enter a valid quantity.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Check if an image is selected
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("Please select an image for the product.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Add the product to the database
            AddProductToDatabase();
        }

        private void AddProductToDatabase()
        {
            try
            {
                // Convert image to byte array
                byte[] imageData = null;
                if (pictureBox1.Image != null)
                {
                    using (MemoryStream ms = new MemoryStream())
                    {
                        pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
                        imageData = ms.ToArray();
                    }
                }

                // Connection string
                string connectionString = "Data Source=(localdb)\\local;Initial Catalog=cpms;Integrated Security=True";

                // SQL query
                string query = "INSERT INTO Products (ProductName, Brand, Category, Price, Quantity, Image) " +
                               "VALUES (@ProductName, @Brand, @Category, @Price, @Quantity, @Image)";

                // Create connection and command objects
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Add parameters
                        command.Parameters.AddWithValue("@ProductName", productnameTextBox.Text);
                        command.Parameters.AddWithValue("@Brand", brandTextBox.Text);
                        command.Parameters.AddWithValue("@Category", prductCategoryComboBox.SelectedItem.ToString());
                        command.Parameters.AddWithValue("@Price", Convert.ToDecimal(productPriceTextBox.Text));
                        command.Parameters.AddWithValue("@Quantity", Convert.ToInt32(productQuantityTextBox.Text));
                        command.Parameters.AddWithValue("@Image", (object)imageData ?? DBNull.Value);

                        // Open connection and execute query
                        connection.Open();
                        command.ExecuteNonQuery();

                        // Show success message
                        MessageBox.Show("Product added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while adding the product: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
           
        }

        private void selectImageButton1_Click(object sender, EventArgs e)
        {
            // Open file dialog to select image
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files (*.bmp;*.jpg;*.jpeg;*.gif;*.png)|*.BMP;*.JPG;*.JPEG;*.GIF;*.PNG";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Display selected image in PictureBox
                    pictureBox1.Image = new Bitmap(openFileDialog.FileName);
                }
            }
        }
    }
}
