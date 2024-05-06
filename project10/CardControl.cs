using System;
using System.Drawing;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace project10
{
    public partial class CardControl : Guna2Panel
    {
        private Guna2HtmlLabel productNameLabel;
        private Guna2HtmlLabel priceLabel;
        private Guna2PictureBox productPictureBox;
        public bool isSelected = false;

        public int ProductID { get; set; }
        public int AvailableQuantity { get; set; }
        public string Brand { get; set; }
        public string Category { get; set; }

        public string ProductName
        {
            get { return productNameLabel.Text; }
            set { productNameLabel.Text = value; }
        }

        public decimal Price
        {
            get { return Convert.ToDecimal(priceLabel.Text); }
            set { priceLabel.Text = value.ToString(); }
        }

        public Image Image
        {
            get { return productPictureBox.Image; }
            set { productPictureBox.Image = value; }
        }

        public CardControl()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.productNameLabel = new Guna2HtmlLabel();
            this.priceLabel = new Guna2HtmlLabel();
            this.productPictureBox = new Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.productPictureBox)).BeginInit();
            this.SuspendLayout();

            // 
            // productNameLabel
            // 
            this.productNameLabel.AutoSize = false;
            this.productNameLabel.Font = new Font("Palatino Linotype", 16.2F, FontStyle.Bold);
            this.productNameLabel.ForeColor = Color.White;
            this.productNameLabel.Location = new Point(12, 160);
            this.productNameLabel.Margin = new Padding(2, 0, 2, 0);
            this.productNameLabel.Name = "productNameLabel";
            this.productNameLabel.Size = new Size(173, 29);
            this.productNameLabel.TabIndex = 13;
            this.productNameLabel.Text = "Product Name";
            this.productNameLabel.MouseEnter += CardControl_MouseEnter;
            this.productNameLabel.MouseLeave += CardControl_MouseLeave;
            this.productNameLabel.Click += CardControl_Click;
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = false;
            this.priceLabel.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold);
            this.priceLabel.ForeColor = Color.Red;
            this.priceLabel.Location = new Point(12, 193);
            this.priceLabel.Margin = new Padding(2, 0, 2, 0);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new Size(46, 22);
            this.priceLabel.TabIndex = 15;
            this.priceLabel.MouseEnter += CardControl_MouseEnter;
            this.priceLabel.MouseLeave += CardControl_MouseLeave;
            this.priceLabel.Click += CardControl_Click;
            // 
            // productPictureBox
            // 
            this.productPictureBox.Location = new Point(17, 16);
            this.productPictureBox.Name = "productPictureBox";
            this.productPictureBox.Size = new Size(206, 141);
            this.productPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            this.productPictureBox.TabIndex = 0;
            this.productPictureBox.TabStop = false;
            this.productPictureBox.MouseEnter += CardControl_MouseEnter;
            this.productPictureBox.MouseLeave += CardControl_MouseLeave;
            this.productPictureBox.Click += CardControl_Click;

            // 
            // CardControl
            // 
            this.BackColor = Color.Aquamarine;
            this.Margin = new Padding(10);
            this.BorderRadius = 10;

            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.productNameLabel);
            this.Controls.Add(this.productPictureBox);
            this.Name = "CardControl";
            this.Size = new Size(236, 227);
            ((System.ComponentModel.ISupportInitialize)(this.productPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
            this.MouseEnter += CardControl_MouseEnter;
            this.MouseLeave += CardControl_MouseLeave;
            this.Click += CardControl_Click;
        }

        private void CardControl_MouseEnter(object sender, EventArgs e)
        {
            if (!isSelected)
            {
                this.BorderColor = Color.GreenYellow;
                this.BorderThickness = 5;
            }
        }

        private void CardControl_MouseLeave(object sender, EventArgs e)
        {
            if (!isSelected)
            {
                this.BorderThickness = 0;
            }
        }

        private static CardControl selectedCard = null;

        private void CardControl_Click(object sender, EventArgs e)
        {
            
            if (selectedCard != null)
            {
                selectedCard.isSelected = false;
                selectedCard.BorderThickness = 0;
            }

            isSelected = true;
            this.BorderThickness = 5;
            selectedCard = this;
        }
    }
}
