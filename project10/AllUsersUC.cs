using System;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace project10
{
    public partial class AllUsersUC : UserControl
    {
        public AllUsersUC()
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

            string query = "SELECT * FROM [User]";

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
                dataGridView1.DataSource = GetUserDataFromDatabase();
            }
            else
            {
                DataTable filteredData = FilterUserData(searchValue);
                dataGridView1.DataSource = filteredData;
            }
        }

        private DataTable FilterUserData(string searchValue)
        {
            string connectionString = "Data Source=(localdb)\\local;Initial Catalog=cpms;Integrated Security=True";

            string query = "SELECT * FROM [User] WHERE Username LIKE @SearchValue";

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
