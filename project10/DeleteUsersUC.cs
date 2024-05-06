using System;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace project10
{
    public partial class DeleteUsersUC : UserControl
    {
        public DeleteUsersUC()
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

        private void deleteUserButton_Click(object sender, EventArgs e)
        {
            // Check if any row is selected
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                // Get the user ID of the selected user
                int userId = Convert.ToInt32(selectedRow.Cells["UserID"].Value);

                // Delete the user from the database
                DeleteUserFromDatabase(userId);

                // Remove the selected row from the DataGridView
                dataGridView1.Rows.Remove(selectedRow);
            }
            else
            {
                MessageBox.Show("Please select a row to delete.");
            }
        }

        private void DeleteUserFromDatabase(int userId)
        {
            string connectionString = "Data Source=(localdb)\\local;Initial Catalog=cpms;Integrated Security=True";

            string query = "DELETE FROM [user] WHERE UserID = @UserId";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UserId", userId);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
