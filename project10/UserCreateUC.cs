using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace project10
{
    public partial class UserCreateUC : UserControl
    {
        public UserCreateUC()
        {
            InitializeComponent();
        }

        private void createUserButton_Click(object sender, EventArgs e)
        {
            if (AllFieldsFilled())
            {
                string username = usernameTextBox.Text;
                string password = passTextBox.Text;
                string contact = contactTextBox.Text;
                string address = addressTextBox.Text;
                string gender = genderTextBox.Text;
                int age = Convert.ToInt32(ageTextBox.Text);
                string userType = UserTypeComboBox.SelectedItem.ToString();

                if (IsUsernameExists(username))
                {
                    MessageBox.Show("Username already exists. Please choose a different username.");
                    return;
                }

                AddUserToDatabase(username, password, contact, address, gender, age, userType);

                MessageBox.Show("User added successfully.");

                ClearTextBoxes();
            }
            else
            {
                MessageBox.Show("Please fill all required fields.");
            }
        }

        private bool AllFieldsFilled()
        {
            bool isValid = true;

            if (string.IsNullOrWhiteSpace(usernameTextBox.Text))
            {
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(passTextBox.Text))
            {
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(contactTextBox.Text))
            {
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(addressTextBox.Text))
            {
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(genderTextBox.Text))
            {
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(ageTextBox.Text))
            {
                isValid = false;
            }
            else
            {
                if (!int.TryParse(ageTextBox.Text, out int age))
                {
                    MessageBox.Show("Please enter a valid age.");
                    isValid = false;
                }
            }

            if (UserTypeComboBox.SelectedItem == null)
            {
                isValid = false;
            }

            return isValid;
        }

        private bool IsUsernameExists(string username)
        {
            string connectionString = "Data Source=(localdb)\\local;Initial Catalog=cpms;Integrated Security=True";
            string query = "SELECT COUNT(*) FROM [user] WHERE [Username] = @Username";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Username", username);

                    connection.Open();
                    int count = (int)command.ExecuteScalar();
                    return count > 0;
                }
            }
        }

        private void AddUserToDatabase(string username, string password, string contact, string address, string gender, int age, string userType)
        {
            string connectionString = "Data Source=(localdb)\\local;Initial Catalog=cpms;Integrated Security=True";
            string query = "INSERT INTO [user] ([Username], [Password], [Contact], [Address], [Gender], [Age], [Usertype]) VALUES (@Username, @Password, @Contact, @Address, @Gender, @Age, @Usertype)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@Password", password);
                    command.Parameters.AddWithValue("@Contact", contact);
                    command.Parameters.AddWithValue("@Address", address);
                    command.Parameters.AddWithValue("@Gender", gender);
                    command.Parameters.AddWithValue("@Age", age);
                    command.Parameters.AddWithValue("@Usertype", userType);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        private void ClearTextBoxes()
        {
            usernameTextBox.Clear();
            passTextBox.Clear();
            contactTextBox.Clear();
            addressTextBox.Clear();
            genderTextBox.Clear();
            ageTextBox.Clear();
            UserTypeComboBox.SelectedItem = null;
        }
    }
}
