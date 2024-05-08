using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace project10
{
    public partial class AllProductsUC : UserControl
    {
        public AllProductsUC()
        {
            InitializeComponent();
            PopulateDataGridView();
        }

        private void PopulateDataGridView()
        {
            DataTable productData = GetProductDataFromDatabase();

            dataGridView1.DataSource = productData;

            dataGridView1.RowTemplate.Height = 70;

            DataGridViewImageColumn imageColumn = (DataGridViewImageColumn)dataGridView1.Columns["Image"];
            imageColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
            imageColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
        }

        private DataTable GetProductDataFromDatabase()
        {
            string connectionString = "Data Source=(localdb)\\local;Initial Catalog=cpms;Integrated Security=True";

            string query = "SELECT * FROM [Products]"; 

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    DataTable dataTable = new DataTable();
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(dataTable);
                    return dataTable;
                }
            }
        }

        private void selectedButton_Click(object sender, EventArgs e)
        {
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            string searchValue = searchTextBox.Text.Trim();

            if (string.IsNullOrEmpty(searchValue))
            {
                dataGridView1.DataSource = GetProductDataFromDatabase();
            }
            else
            {
                DataTable filteredData = FilterProductData(searchValue);
                dataGridView1.DataSource = filteredData;
            }
        }

        private DataTable FilterProductData(string searchValue)
        {
            string connectionString = "Data Source=(localdb)\\local;Initial Catalog=cpms;Integrated Security=True";

            string query = "SELECT * FROM [Products] WHERE ProductName LIKE @SearchValue";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@SearchValue", "%" + searchValue + "%");

                    DataTable dataTable = new DataTable();
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(dataTable);
                    return dataTable;
                }
            }
        }

    }
}
