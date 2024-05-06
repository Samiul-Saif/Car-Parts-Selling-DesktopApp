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

            // Set DataGridView auto size mode
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
            // Your button click event handler code
        }
    }
}
