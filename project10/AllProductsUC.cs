using System;
using System.Data;
using System.Data.SqlClient;
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

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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
        }
    }
}
