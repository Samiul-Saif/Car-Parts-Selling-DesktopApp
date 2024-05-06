using System;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace project10
{
    public partial class UpdateUsersUC : UserControl
    {
        public UpdateUsersUC()
        {
            InitializeComponent();
            PopulateDataGridView();
        }

        private void PopulateDataGridView()
        {
            DataTable userData = GetUserDataFromDatabase();

            dataGridView1.DataSource = userData;

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private DataTable GetUserDataFromDatabase()
        {
            string connectionString = "Data Source=(localdb)\\local;Initial Catalog=cpms;Integrated Security=True";

            string query = "SELECT [UserID], [Username], [Password], [Contact], [Address], [Gender], [Age], [Usertype] FROM [user]";

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

        private void updateUserButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                DataGridViewCell selectedCell = dataGridView1.SelectedCells[0];

                int rowIndex = selectedCell.RowIndex;
                int columnIndex = selectedCell.ColumnIndex;

                string newValue = selectedCell.Value.ToString();

                int userId = Convert.ToInt32(dataGridView1.Rows[rowIndex].Cells["UserID"].Value);

                string columnName = dataGridView1.Columns[columnIndex].Name;

                UpdateUserInDatabase(userId, columnName, newValue);

                MessageBox.Show("Update successful.");
            }
            else
            {
                MessageBox.Show("Please select a cell to update.");
            }
        }

        private void UpdateUserInDatabase(int userId, string columnName, string newValue)
        {
            string connectionString = "Data Source=(localdb)\\local;Initial Catalog=cpms;Integrated Security=True";

            string query = $"UPDATE [user] SET [{columnName}] = @NewValue WHERE UserID = @UserId";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@NewValue", newValue);
                    command.Parameters.AddWithValue("@UserId", userId);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
