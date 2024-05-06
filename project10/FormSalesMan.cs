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
    public partial class FormSalesMan : Form
    {
        public FormSalesMan()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }



        private void clearcartButton_Click(object sender, EventArgs e)
        {

        }

        private void cartViewButton_Click(object sender, EventArgs e)
        {

        }

        private void BrakingSystemButton_Click(object sender, EventArgs e)
        {
            bodyPanel.Controls.Clear();
            BrakingSystem brakingSystem = new BrakingSystem();
            bodyPanel.Controls.Add(brakingSystem);
        }

        private void EnginePartsButton_Click(object sender, EventArgs e)
        {

        }

        private void LightingSystemButton_Click(object sender, EventArgs e)
        {

        }

        private void UpgradesButton_Click(object sender, EventArgs e)
        {

        }

        private void CarCareButton_Click(object sender, EventArgs e)
        {

        }

        private void interiorButton_Click(object sender, EventArgs e)
        {

        }

        private void bodyPartsButton_Click(object sender, EventArgs e)
        {

        }

        private void accessoriesButton_Click(object sender, EventArgs e)
        {

        }

        private void wheelsButton_Click(object sender, EventArgs e)
        {

        }

        private void OthersButton_Click(object sender, EventArgs e)
        {

        }
    }
}