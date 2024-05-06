using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace project10
{
    public partial class UpdateProductsUC : UserControl
    {
        public UpdateProductsUC()
        {
            InitializeComponent();
            PopulateDataGridView();
        }

        private void PopulateDataGridView()
        {
            DataTable productData = GetProductDataFromDatabase();

            dataGridView1.DataSource = productData;

            // Set DataGridView auto size mode
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private DataTable GetProductDataFromDatabase()
        {
            string connectionString = "Data Source=(localdb)\\local;Initial Catalog=cpms;Integrated Security=True";

            string query = "SELECT [ProductID], [ProductName], [Brand], [Category], [Price], [Quantity], [Image] FROM [Products]";

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

        private void updateProductButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                DataGridViewCell selectedCell = dataGridView1.SelectedCells[0];

                int rowIndex = selectedCell.RowIndex;
                int columnIndex = selectedCell.ColumnIndex;

                string newValue = selectedCell.Value.ToString();

                int productId = Convert.ToInt32(dataGridView1.Rows[rowIndex].Cells["ProductID"].Value);

                string columnName = dataGridView1.Columns[columnIndex].Name;

                UpdateProductInDatabase(productId, columnName, newValue);

                MessageBox.Show("Update successful.");
            }
            else
            {
                MessageBox.Show("Please select a cell to update.");
            }
        }

        private void UpdateProductInDatabase(int productId, string columnName, string newValue)
        {
            string connectionString = "Data Source=(localdb)\\local;Initial Catalog=cpms;Integrated Security=True";

            string query = $"UPDATE [Products] SET [{columnName}] = @NewValue WHERE ProductID = @ProductId";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@NewValue", newValue);
                    command.Parameters.AddWithValue("@ProductId", productId);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
