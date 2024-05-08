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
            if (string.IsNullOrWhiteSpace(productnameTextBox.Text) ||
                string.IsNullOrWhiteSpace(brandTextBox.Text) ||
                string.IsNullOrWhiteSpace(productPriceTextBox.Text) ||
                string.IsNullOrWhiteSpace(productQuantityTextBox.Text) ||
                prductCategoryComboBox.SelectedItem == null)
            {
                MessageBox.Show("Please fill all the required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

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

            if (pictureBox1.Image == null)
            {
                MessageBox.Show("Please select an image for the product.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            AddProductToDatabase();
        }

        private void AddProductToDatabase()
        {
            try
            {
                byte[] imageData = null;
                if (pictureBox1.Image != null)
                {
                    using (MemoryStream ms = new MemoryStream())
                    {
                        pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
                        imageData = ms.ToArray();
                    }
                }

                string connectionString = "Data Source=(localdb)\\local;Initial Catalog=cpms;Integrated Security=True";

                string query = "INSERT INTO Products (ProductName, Brand, Category, Price, Quantity, Image) " +
                               "VALUES (@ProductName, @Brand, @Category, @Price, @Quantity, @Image)";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ProductName", productnameTextBox.Text);
                        command.Parameters.AddWithValue("@Brand", brandTextBox.Text);
                        command.Parameters.AddWithValue("@Category", prductCategoryComboBox.SelectedItem.ToString());
                        command.Parameters.AddWithValue("@Price", Convert.ToDecimal(productPriceTextBox.Text));
                        command.Parameters.AddWithValue("@Quantity", Convert.ToInt32(productQuantityTextBox.Text));
                        command.Parameters.AddWithValue("@Image", (object)imageData ?? DBNull.Value);

                        connection.Open();
                        command.ExecuteNonQuery();

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
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files (*.bmp;*.jpg;*.jpeg;*.gif;*.png)|*.BMP;*.JPG;*.JPEG;*.GIF;*.PNG";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    pictureBox1.Image = new Bitmap(openFileDialog.FileName);
                }
            }
        }
    }
}
