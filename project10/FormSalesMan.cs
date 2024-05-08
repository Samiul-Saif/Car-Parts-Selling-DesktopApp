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
        public FormSalesMan(string uname)
        {
            InitializeComponent();
            userNameLabel.Text = uname;
            bodyPanel.Controls.Clear();
            CategorizedProductsUC brakingSystem = new CategorizedProductsUC("All Products");
            bodyPanel.Controls.Add(brakingSystem);
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }



        private void clearcartButton_Click(object sender, EventArgs e)
        {

        }

        private void cartViewButton_Click(object sender, EventArgs e)
        {
            decimal totalCost = 0;
            if (CategorizedProductsUC.selectedProductList.Count > 0)
            {
                string cartInfo = "\n";

                foreach (var product in CategorizedProductsUC.selectedProductList)
                {
                    cartInfo += $"Product ID: {product.Item1}\n";
                    cartInfo += $"Product Name: {product.Item2}\n";
                    cartInfo += $"Category: {product.Item3}\n";
                    cartInfo += $"Brand: {product.Item4}\n";
                    cartInfo += $"Selected Quantity: {product.Item5}\n";
                    cartInfo += $"Price: {product.Item6}\n";
                    cartInfo += $"Individual Cost: {product.Item7}\n\n";

                    totalCost+= product.Item7;
                }

                PrintDialogUC printDialog = new PrintDialogUC(cartInfo,totalCost);
                printDialog.ShowDialog();
            }
            else
            {
                MessageBox.Show("Your cart is empty.", "Cart Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }




        private void BrakingSystemButton_Click(object sender, EventArgs e)
        {
            bodyPanel.Controls.Clear();
            CategorizedProductsUC brakingSystem = new CategorizedProductsUC("Braking System");
            bodyPanel.Controls.Add(brakingSystem);
        }

        private void EnginePartsButton_Click(object sender, EventArgs e)
        {
            bodyPanel.Controls.Clear();
            CategorizedProductsUC brakingSystem = new CategorizedProductsUC("Engine Parts");
            bodyPanel.Controls.Add(brakingSystem);
        }

        private void LightingSystemButton_Click(object sender, EventArgs e)
        {
            bodyPanel.Controls.Clear();
            CategorizedProductsUC brakingSystem = new CategorizedProductsUC("Lighting System");
            bodyPanel.Controls.Add(brakingSystem);
        }

        private void UpgradesButton_Click(object sender, EventArgs e)
        {

        }

        private void CarCareButton_Click(object sender, EventArgs e)
        {
            bodyPanel.Controls.Clear();
            CategorizedProductsUC brakingSystem = new CategorizedProductsUC("Car Care");
            bodyPanel.Controls.Add(brakingSystem);
        }

        private void interiorButton_Click(object sender, EventArgs e)
        {
            bodyPanel.Controls.Clear();
            CategorizedProductsUC brakingSystem = new CategorizedProductsUC("Interior Accessories");
            bodyPanel.Controls.Add(brakingSystem);
        }

        private void bodyPartsButton_Click(object sender, EventArgs e)
        {
            bodyPanel.Controls.Clear();
            CategorizedProductsUC brakingSystem = new CategorizedProductsUC("Body Parts");
            bodyPanel.Controls.Add(brakingSystem);
        }

        private void accessoriesButton_Click(object sender, EventArgs e)
        {
            bodyPanel.Controls.Clear();
            CategorizedProductsUC brakingSystem = new CategorizedProductsUC("Accessories");
            bodyPanel.Controls.Add(brakingSystem);
        }

        private void wheelsButton_Click(object sender, EventArgs e)
        {
            bodyPanel.Controls.Clear();
            CategorizedProductsUC brakingSystem = new CategorizedProductsUC("Wheels & Tires");
            bodyPanel.Controls.Add(brakingSystem);
        }

        private void OthersButton_Click(object sender, EventArgs e)
        {
            bodyPanel.Controls.Clear();
            CategorizedProductsUC brakingSystem = new CategorizedProductsUC("Others");
            bodyPanel.Controls.Add(brakingSystem);
        }

        private void clearcartButton_Click_1(object sender, EventArgs e)
        {
            CategorizedProductsUC.selectedProductList.Clear();
            MessageBox.Show("Your cart has been cleared.", "Cart Cleared", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void AllProductsButton_Click(object sender, EventArgs e)
        {
            bodyPanel.Controls.Clear();
            CategorizedProductsUC brakingSystem = new CategorizedProductsUC("All Products");
            bodyPanel.Controls.Add(brakingSystem);
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            this.Close();
            FormSignin loginForm = new FormSignin();
            loginForm.Show();
        }
    }
}