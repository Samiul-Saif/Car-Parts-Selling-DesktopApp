﻿namespace project10
{
    partial class DeleteUsersUC
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
            this.deleteUserButton = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // selectedButton
            // 
            this.selectedButton.AutoSize = false;
            this.selectedButton.BackColor = System.Drawing.Color.Transparent;
            this.selectedButton.Font = new System.Drawing.Font("Palatino Linotype", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectedButton.ForeColor = System.Drawing.Color.Black;
            this.selectedButton.Location = new System.Drawing.Point(17, 44);
            this.selectedButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.selectedButton.Name = "selectedButton";
            this.selectedButton.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.selectedButton.Size = new System.Drawing.Size(298, 52);
            this.selectedButton.TabIndex = 17;
            this.selectedButton.Text = "Select to Delete User";
            this.selectedButton.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.dataGridView1.Location = new System.Drawing.Point(17, 115);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1043, 504);
            this.dataGridView1.TabIndex = 19;
            // 
            // deleteUserButton
            // 
            this.deleteUserButton.BackColor = System.Drawing.Color.Transparent;
            this.deleteUserButton.BorderRadius = 5;
            this.deleteUserButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.deleteUserButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.deleteUserButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.deleteUserButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.deleteUserButton.FillColor = System.Drawing.Color.Crimson;
            this.deleteUserButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.deleteUserButton.ForeColor = System.Drawing.Color.White;
            this.deleteUserButton.ImageSize = new System.Drawing.Size(32, 32);
            this.deleteUserButton.Location = new System.Drawing.Point(946, 637);
            this.deleteUserButton.Margin = new System.Windows.Forms.Padding(4);
            this.deleteUserButton.Name = "deleteUserButton";
            this.deleteUserButton.Size = new System.Drawing.Size(114, 48);
            this.deleteUserButton.TabIndex = 20;
            this.deleteUserButton.Text = "Delete";
            this.deleteUserButton.Click += new System.EventHandler(this.deleteUserButton_Click);
            // 
            // DeleteUsersUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.deleteUserButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.selectedButton);
            this.Name = "DeleteUsersUC";
            this.Size = new System.Drawing.Size(1080, 731);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel selectedButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Guna.UI2.WinForms.Guna2Button deleteUserButton;
    }
}
