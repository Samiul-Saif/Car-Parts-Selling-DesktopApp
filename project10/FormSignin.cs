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
    public partial class FormSignin : Form
    {
       

        // Call the SetTransparencyKey method in the constructor after InitializeComponent()
        public FormSignin()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=(localdb)\\local;Initial Catalog=cpms;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("SELECT * FROM [User] WHERE Username = @Username AND Password = @Password", con);
            cmd.Parameters.AddWithValue("@Username", textBox1.Text);
            cmd.Parameters.AddWithValue("@Password", textBox2.Text);

            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                string userType = comboBox1.SelectedItem.ToString();


                foreach (DataRow row in dt.Rows)
                {
                    if (row["Usertype"].ToString() == userType)
                    {
                        MessageBox.Show("You are logged in as " + row["username"]);

                        if (userType == "Admin")
                        {
                            FormAdmin f2 = new FormAdmin();
                            f2.Show();
                            this.Hide();
                        }
                        else if (userType == "Manager")
                        {
                            FormManager f3 = new FormManager();
                            f3.Show();
                            this.Hide();
                        }
                        else if (userType == "Salesman")
                        {
                            FormSalesMan salesman = new FormSalesMan();
                            salesman.Show();
                            this.Hide();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Credential Missmatched");
                    }
                }
            }
            else
            {
                MessageBox.Show("Error: Invalid username or password.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormRegistration f5 = new FormRegistration();
            f5.Show();
            this.Hide();
        }

        private void CustomtPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
