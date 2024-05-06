using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project10
{
    public partial class FormManager : Form
    {
        public FormManager()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void buttonUser_Click(object sender, EventArgs e)
        {
            
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            bodyPanel.Controls.Clear();
            UserCreateUC f4 = new UserCreateUC();

            bodyPanel.Controls.Add(f4);
        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            this.Close();
            FormSignin loginForm = new FormSignin();
            loginForm.Show();
        }

        private void allProductButton_Click(object sender, EventArgs e)
        {

        }

        private void deleteUserButton_Click(object sender, EventArgs e)
        {
            bodyPanel.Controls.Clear();
            DeleteUsersUC dltUserUC = new DeleteUsersUC();
            bodyPanel.Controls.Add(dltUserUC);
        }

        private void updateUserButton_Click(object sender, EventArgs e)
        {
            bodyPanel.Controls.Clear();
            UpdateUsersUC updateUsersUC = new UpdateUsersUC();
            bodyPanel.Controls.Add(updateUsersUC);
        }

        private void allUserButton_Click(object sender, EventArgs e)
        {
          
            bodyPanel.Controls.Clear();
            AllUsersUC allUserUC = new AllUsersUC();
            bodyPanel.Controls.Add(allUserUC);
        }
    }
}
