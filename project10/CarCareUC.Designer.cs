namespace project10
{
    partial class CarCareUC
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
            this.categoryNameLabel = new System.Windows.Forms.Label();
            this.quantityNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.addToCartButton = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.quantityNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 52);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1065, 598);
            this.flowLayoutPanel1.TabIndex = 1;
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
            // CarCareUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.addToCartButton);
            this.Controls.Add(this.quantityNumericUpDown);
            this.Controls.Add(this.categoryNameLabel);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CarCareUC";
            this.Size = new System.Drawing.Size(1065, 650);
            ((System.ComponentModel.ISupportInitialize)(this.quantityNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label categoryNameLabel;
        private System.Windows.Forms.NumericUpDown quantityNumericUpDown;
        private Guna.UI2.WinForms.Guna2Button addToCartButton;
    }
}
