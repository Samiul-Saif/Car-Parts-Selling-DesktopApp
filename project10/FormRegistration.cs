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
    public partial class FormRegistration : Form
    {
        public FormRegistration()
        {
            InitializeComponent();
            bodyPanel.Controls.Clear();
            UserCreateUC uC = new UserCreateUC();
            bodyPanel.Controls.Add(uC);
        }

        private void bodyPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            FormSignin loginForm = new FormSignin();
            loginForm.Show();
        }
    }
}
