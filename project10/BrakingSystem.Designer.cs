namespace project10
{
    partial class BrakingSystem
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.cardPanel = new System.Windows.Forms.Panel();
            this.productPriceLabel = new System.Windows.Forms.Label();
            this.pricePlaceholed = new System.Windows.Forms.Label();
            this.ProductNameLabel = new System.Windows.Forms.Label();
            this.productPictureBox = new System.Windows.Forms.PictureBox();
            this.categoryNameLabel = new System.Windows.Forms.Label();
            this.quantityNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.addToCartButton = new Guna.UI2.WinForms.Guna2Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.cardPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantityNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.cardPanel);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 52);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1065, 598);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // cardPanel
            // 
            this.cardPanel.BackColor = System.Drawing.Color.Black;
            this.cardPanel.Controls.Add(this.productPriceLabel);
            this.cardPanel.Controls.Add(this.pricePlaceholed);
            this.cardPanel.Controls.Add(this.ProductNameLabel);
            this.cardPanel.Controls.Add(this.productPictureBox);
            this.cardPanel.Location = new System.Drawing.Point(20, 18);
            this.cardPanel.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.cardPanel.Name = "cardPanel";
            this.cardPanel.Size = new System.Drawing.Size(315, 279);
            this.cardPanel.TabIndex = 5;
            // 
            // productPriceLabel
            // 
            this.productPriceLabel.AutoSize = true;
            this.productPriceLabel.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productPriceLabel.ForeColor = System.Drawing.Color.GreenYellow;
            this.productPriceLabel.Location = new System.Drawing.Point(85, 238);
            this.productPriceLabel.Name = "productPriceLabel";
            this.productPriceLabel.Size = new System.Drawing.Size(26, 22);
            this.productPriceLabel.TabIndex = 15;
            this.productPriceLabel.Text = "35";
            // 
            // pricePlaceholed
            // 
            this.pricePlaceholed.AutoSize = true;
            this.pricePlaceholed.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pricePlaceholed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pricePlaceholed.Location = new System.Drawing.Point(17, 236);
            this.pricePlaceholed.Name = "pricePlaceholed";
            this.pricePlaceholed.Size = new System.Drawing.Size(51, 22);
            this.pricePlaceholed.TabIndex = 14;
            this.pricePlaceholed.Text = "Price:";
            // 
            // ProductNameLabel
            // 
            this.ProductNameLabel.AutoSize = true;
            this.ProductNameLabel.Font = new System.Drawing.Font("Palatino Linotype", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductNameLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ProductNameLabel.Location = new System.Drawing.Point(16, 197);
            this.ProductNameLabel.Name = "ProductNameLabel";
            this.ProductNameLabel.Size = new System.Drawing.Size(173, 29);
            this.ProductNameLabel.TabIndex = 13;
            this.ProductNameLabel.Text = "Car Seat Covers";
            // 
            // productPictureBox
            // 
            this.productPictureBox.Image = global::project10.Properties.Resources.car_light;
            this.productPictureBox.Location = new System.Drawing.Point(23, 20);
            this.productPictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.productPictureBox.Name = "productPictureBox";
            this.productPictureBox.Size = new System.Drawing.Size(275, 174);
            this.productPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.productPictureBox.TabIndex = 0;
            this.productPictureBox.TabStop = false;
            // 
            // categoryNameLabel
            // 
            this.categoryNameLabel.AutoSize = true;
            this.categoryNameLabel.Font = new System.Drawing.Font("Palatino Linotype", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryNameLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.categoryNameLabel.Location = new System.Drawing.Point(36, 12);
            this.categoryNameLabel.Name = "categoryNameLabel";
            this.categoryNameLabel.Size = new System.Drawing.Size(182, 29);
            this.categoryNameLabel.TabIndex = 14;
            this.categoryNameLabel.Text = "Braking Systems";
            // 
            // quantityNumericUpDown
            // 
            this.quantityNumericUpDown.Location = new System.Drawing.Point(906, 12);
            this.quantityNumericUpDown.Name = "quantityNumericUpDown";
            this.quantityNumericUpDown.Size = new System.Drawing.Size(72, 22);
            this.quantityNumericUpDown.TabIndex = 25;
            this.quantityNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // addToCartButton
            // 
            this.addToCartButton.BackColor = System.Drawing.Color.Transparent;
            this.addToCartButton.BorderRadius = 5;
            this.addToCartButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.addToCartButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.addToCartButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.addToCartButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.addToCartButton.FillColor = System.Drawing.Color.ForestGreen;
            this.addToCartButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.addToCartButton.ForeColor = System.Drawing.Color.White;
            this.addToCartButton.Image = global::project10.Properties.Resources.add_cart;
            this.addToCartButton.ImageSize = new System.Drawing.Size(32, 32);
            this.addToCartButton.Location = new System.Drawing.Point(1003, 4);
            this.addToCartButton.Margin = new System.Windows.Forms.Padding(4);
            this.addToCartButton.Name = "addToCartButton";
            this.addToCartButton.Size = new System.Drawing.Size(46, 40);
            this.addToCartButton.TabIndex = 26;
            this.addToCartButton.Click += new System.EventHandler(this.addToCartButton_Click);
            // 
            // BrakingSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.addToCartButton);
            this.Controls.Add(this.quantityNumericUpDown);
            this.Controls.Add(this.categoryNameLabel);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "BrakingSystem";
            this.Size = new System.Drawing.Size(1065, 650);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.cardPanel.ResumeLayout(false);
            this.cardPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantityNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel cardPanel;
        private System.Windows.Forms.Label productPriceLabel;
        private System.Windows.Forms.Label pricePlaceholed;
        private System.Windows.Forms.Label ProductNameLabel;
        private System.Windows.Forms.PictureBox productPictureBox;
        private System.Windows.Forms.Label categoryNameLabel;
        private System.Windows.Forms.NumericUpDown quantityNumericUpDown;
        private Guna.UI2.WinForms.Guna2Button addToCartButton;
    }
}
