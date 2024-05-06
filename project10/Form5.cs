using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project10
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Ensure that both username and password are provided
            if (textBox1.Text != "" && textBox2.Text != "" && comboBox1.SelectedItem != null)
            {
                // Create a SQL connection
                using (SqlConnection con = new SqlConnection("Data Source=(localdb)\\local;Initial Catalog=cpms;Integrated Security=True"))
                {
                    // Define the SQL query to insert data
                    string query = "INSERT INTO [User](Username, Password, Contact,Address,Gender,Age,Usertype) VALUES (@Username, @Password, @Contact, @Address, @Gender, @Age , @Usertype)";

                    // Create a SQL command with parameters
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        // Add parameters
                        cmd.Parameters.AddWithValue("@Username", textBox1.Text);
                        cmd.Parameters.AddWithValue("@Password", textBox2.Text);
                        cmd.Parameters.AddWithValue("@Contact", textBox4.Text);
                        cmd.Parameters.AddWithValue("@Address", textBox3.Text);
                        cmd.Parameters.AddWithValue("@Gender", textBox6.Text);
                        cmd.Parameters.AddWithValue("@Age", textBox5.Text);
                        cmd.Parameters.AddWithValue("@Usertype", comboBox1.SelectedItem.ToString());

                        // Open the SQL connection
                        con.Open();

                        // Execute the SQL command
                        int rowsAffected = cmd.ExecuteNonQuery();

                        // Check if any rows were affected (data was inserted)
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Data inserted successfully!");
                        }
                        else
                        {
                            MessageBox.Show("Error: Data insertion failed.");
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please provide username, password, and select user type.");
            }

            // Return to Form1
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormSignin f5 = new FormSignin();
            f5.Show();
            this.Hide();
        }


    }
}
