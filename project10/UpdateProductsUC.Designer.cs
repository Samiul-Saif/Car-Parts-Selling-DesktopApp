namespace project10
{
    partial class UpdateProductsUC
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
            this.selectedButton = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.updateProductButton = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // selectedButton
            // 
            this.selectedButton.AutoSize = false;
            this.selectedButton.BackColor = System.Drawing.Color.Transparent;
            this.selectedButton.Font = new System.Drawing.Font("Palatino Linotype", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectedButton.ForeColor = System.Drawing.Color.Black;
            this.selectedButton.Location = new System.Drawing.Point(13, 43);
            this.selectedButton.Margin = new System.Windows.Forms.Padding(2);
            this.selectedButton.Name = "selectedButton";
            this.selectedButton.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.selectedButton.Size = new System.Drawing.Size(224, 35);
            this.selectedButton.TabIndex = 17;
            this.selectedButton.Text = "Select to Update User";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.dataGridView1.Location = new System.Drawing.Point(13, 93);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(782, 410);
            this.dataGridView1.TabIndex = 19;
            // 
            // updateProductButton
            // 
            this.updateProductButton.BackColor = System.Drawing.Color.Transparent;
            this.updateProductButton.BorderRadius = 5;
            this.updateProductButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.updateProductButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.updateProductButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.updateProductButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.updateProductButton.FillColor = System.Drawing.Color.SeaGreen;
            this.updateProductButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.updateProductButton.ForeColor = System.Drawing.Color.White;
            this.updateProductButton.ImageSize = new System.Drawing.Size(32, 32);
            this.updateProductButton.Location = new System.Drawing.Point(710, 518);
            this.updateProductButton.Name = "updateProductButton";
            this.updateProductButton.Size = new System.Drawing.Size(86, 39);
            this.updateProductButton.TabIndex = 20;
            this.updateProductButton.Text = "Update";
            this.updateProductButton.Click += new System.EventHandler(this.updateProductButton_Click);
            // 
            // UpdateProductsUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.updateProductButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.selectedButton);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UpdateProductsUC";
            this.Size = new System.Drawing.Size(810, 594);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel selectedButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Guna.UI2.WinForms.Guna2Button updateProductButton;
    }
}
