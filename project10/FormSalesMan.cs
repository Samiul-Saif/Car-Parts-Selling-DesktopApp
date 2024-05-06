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
            // Check if there are selected products in the list
            if (BrakingSystem.selectedProductList.Count > 0)
            {
                // Initialize a string to store the cart information
                string cartInfo = "Selected Products:\n";

                // Iterate through the selectedProductList
                foreach (var product in BrakingSystem.selectedProductList)
                {
                    // Append product information to the cartInfo string
                    cartInfo += $"Product ID: {product.Item1}\n";
                    cartInfo += $"Product Name: {product.Item2}\n";
                    cartInfo += $"Category: {product.Item3}\n";
                    cartInfo += $"Brand: {product.Item4}\n";
                    cartInfo += $"Selected Quantity: {product.Item5}\n";
                    cartInfo += $"Price: {product.Item6}\n";
                    cartInfo += $"Individual Cost: {product.Item7}\n\n";
                }

                // Display the cart information in a message box
                MessageBox.Show(cartInfo, "Cart Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // If no products are selected, display a message
                MessageBox.Show("Your cart is empty.", "Cart Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
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

        private void clearcartButton_Click_1(object sender, EventArgs e)
        {
            BrakingSystem.selectedProductList.Clear();
            MessageBox.Show("Your cart has been cleared.", "Cart Cleared", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}