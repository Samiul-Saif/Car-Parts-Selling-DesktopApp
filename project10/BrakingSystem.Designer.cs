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
            this.flowLayoutPanel1.SuspendLayout();
            this.cardPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.cardPanel);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 42);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(5);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(799, 486);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // cardPanel
            // 
            this.cardPanel.BackColor = System.Drawing.Color.Black;
            this.cardPanel.Controls.Add(this.productPriceLabel);
            this.cardPanel.Controls.Add(this.pricePlaceholed);
            this.cardPanel.Controls.Add(this.ProductNameLabel);
            this.cardPanel.Controls.Add(this.productPictureBox);
            this.cardPanel.Location = new System.Drawing.Point(15, 15);
            this.cardPanel.Margin = new System.Windows.Forms.Padding(10);
            this.cardPanel.Name = "cardPanel";
            this.cardPanel.Size = new System.Drawing.Size(236, 227);
            this.cardPanel.TabIndex = 5;
            // 
            // productPriceLabel
            // 
            this.productPriceLabel.AutoSize = true;
            this.productPriceLabel.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productPriceLabel.ForeColor = System.Drawing.Color.GreenYellow;
            this.productPriceLabel.Location = new System.Drawing.Point(64, 193);
            this.productPriceLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
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
            this.pricePlaceholed.Location = new System.Drawing.Point(13, 192);
            this.pricePlaceholed.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
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
            this.ProductNameLabel.Location = new System.Drawing.Point(12, 160);
            this.ProductNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ProductNameLabel.Name = "ProductNameLabel";
            this.ProductNameLabel.Size = new System.Drawing.Size(173, 29);
            this.ProductNameLabel.TabIndex = 13;
            this.ProductNameLabel.Text = "Car Seat Covers";
            // 
            // productPictureBox
            // 
            this.productPictureBox.Image = global::project10.Properties.Resources.car_light;
            this.productPictureBox.Location = new System.Drawing.Point(17, 16);
            this.productPictureBox.Name = "productPictureBox";
            this.productPictureBox.Size = new System.Drawing.Size(206, 141);
            this.productPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.productPictureBox.TabIndex = 0;
            this.productPictureBox.TabStop = false;
            // 
            // categoryNameLabel
            // 
            this.categoryNameLabel.AutoSize = true;
            this.categoryNameLabel.Font = new System.Drawing.Font("Palatino Linotype", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryNameLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.categoryNameLabel.Location = new System.Drawing.Point(27, 10);
            this.categoryNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.categoryNameLabel.Name = "categoryNameLabel";
            this.categoryNameLabel.Size = new System.Drawing.Size(182, 29);
            this.categoryNameLabel.TabIndex = 14;
            this.categoryNameLabel.Text = "Braking Systems";
            // 
            // BrakingSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.categoryNameLabel);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "BrakingSystem";
            this.Size = new System.Drawing.Size(799, 528);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.cardPanel.ResumeLayout(false);
            this.cardPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productPictureBox)).EndInit();
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
    }
}
