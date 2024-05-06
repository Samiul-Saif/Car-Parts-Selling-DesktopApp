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

            // Set image column properties
            DataGridViewImageColumn imageColumn = (DataGridViewImageColumn)dataGridView1.Columns["Image"];
            imageColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
            imageColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
        }

        private DataTable GetProductDataFromDatabase()
        {
            string connectionString = "Data Source=(localdb)\\local;Initial Catalog=cpms;Integrated Security=True";

            string query = "SELECT * FROM [Products]"; // Selecting all columns from the Products table

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
            // Your button click event handler code
        }
    }
}
