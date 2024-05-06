namespace project10
{
    partial class FormManager
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.allProductButton = new Guna.UI2.WinForms.Guna2Button();
            this.label3 = new System.Windows.Forms.Label();
            this.deleteUserButton = new Guna.UI2.WinForms.Guna2Button();
            this.updateUserButton = new Guna.UI2.WinForms.Guna2Button();
            this.allUserButton = new Guna.UI2.WinForms.Guna2Button();
            this.addUserPanel = new Guna.UI2.WinForms.Guna2Button();
            this.logoutButton = new Guna.UI2.WinForms.Guna2Button();
            this.bodyPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.userNameLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.guna2Panel1.Controls.Add(this.allProductButton);
            this.guna2Panel1.Controls.Add(this.label3);
            this.guna2Panel1.Controls.Add(this.deleteUserButton);
            this.guna2Panel1.Controls.Add(this.updateUserButton);
            this.guna2Panel1.Controls.Add(this.allUserButton);
            this.guna2Panel1.Controls.Add(this.addUserPanel);
            this.guna2Panel1.Controls.Add(this.logoutButton);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2Panel1.Size = new System.Drawing.Size(244, 777);
            this.guna2Panel1.TabIndex = 6;
            // 
            // allProductButton
            // 
            this.allProductButton.BackColor = System.Drawing.Color.Transparent;
            this.allProductButton.BorderRadius = 5;
            this.allProductButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.allProductButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.allProductButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.allProductButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.allProductButton.FillColor = System.Drawing.Color.CadetBlue;
            this.allProductButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.allProductButton.ForeColor = System.Drawing.Color.White;
            this.allProductButton.ImageSize = new System.Drawing.Size(32, 32);
            this.allProductButton.Location = new System.Drawing.Point(4, 508);
            this.allProductButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.allProductButton.Name = "allProductButton";
            this.allProductButton.Size = new System.Drawing.Size(237, 71);
            this.allProductButton.TabIndex = 13;
            this.allProductButton.Text = "All Products";
            this.allProductButton.Click += new System.EventHandler(this.allProductButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(32, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 29);
            this.label3.TabIndex = 12;
            this.label3.Text = "Admin panel";
            // 
            // deleteUserButton
            // 
            this.deleteUserButton.BackColor = System.Drawing.Color.Transparent;
            this.deleteUserButton.BorderRadius = 5;
            this.deleteUserButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.deleteUserButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.deleteUserButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.deleteUserButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.deleteUserButton.FillColor = System.Drawing.Color.CadetBlue;
            this.deleteUserButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.deleteUserButton.ForeColor = System.Drawing.Color.White;
            this.deleteUserButton.ImageSize = new System.Drawing.Size(32, 32);
            this.deleteUserButton.Location = new System.Drawing.Point(3, 430);
            this.deleteUserButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.deleteUserButton.Name = "deleteUserButton";
            this.deleteUserButton.Size = new System.Drawing.Size(237, 71);
            this.deleteUserButton.TabIndex = 10;
            this.deleteUserButton.Text = "Delete User";
            this.deleteUserButton.Click += new System.EventHandler(this.deleteUserButton_Click);
            // 
            // updateUserButton
            // 
            this.updateUserButton.BackColor = System.Drawing.Color.Transparent;
            this.updateUserButton.BorderRadius = 5;
            this.updateUserButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.updateUserButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.updateUserButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.updateUserButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.updateUserButton.FillColor = System.Drawing.Color.CadetBlue;
            this.updateUserButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.updateUserButton.ForeColor = System.Drawing.Color.White;
            this.updateUserButton.ImageSize = new System.Drawing.Size(32, 32);
            this.updateUserButton.Location = new System.Drawing.Point(3, 352);
            this.updateUserButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.updateUserButton.Name = "updateUserButton";
            this.updateUserButton.Size = new System.Drawing.Size(237, 71);
            this.updateUserButton.TabIndex = 9;
            this.updateUserButton.Text = "Update User";
            this.updateUserButton.Click += new System.EventHandler(this.updateUserButton_Click);
            // 
            // allUserButton
            // 
            this.allUserButton.BackColor = System.Drawing.Color.Transparent;
            this.allUserButton.BorderRadius = 5;
            this.allUserButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.allUserButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.allUserButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.allUserButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.allUserButton.FillColor = System.Drawing.Color.CadetBlue;
            this.allUserButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.allUserButton.ForeColor = System.Drawing.Color.White;
            this.allUserButton.ImageSize = new System.Drawing.Size(32, 32);
            this.allUserButton.Location = new System.Drawing.Point(3, 276);
            this.allUserButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.allUserButton.Name = "allUserButton";
            this.allUserButton.Size = new System.Drawing.Size(237, 71);
            this.allUserButton.TabIndex = 8;
            this.allUserButton.Text = "All Users";
            this.allUserButton.Click += new System.EventHandler(this.allUserButton_Click);
            // 
            // addUserPanel
            // 
            this.addUserPanel.BackColor = System.Drawing.Color.Transparent;
            this.addUserPanel.BorderRadius = 5;
            this.addUserPanel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.addUserPanel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.addUserPanel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.addUserPanel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.addUserPanel.FillColor = System.Drawing.Color.CadetBlue;
            this.addUserPanel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.addUserPanel.ForeColor = System.Drawing.Color.White;
            this.addUserPanel.ImageSize = new System.Drawing.Size(32, 32);
            this.addUserPanel.Location = new System.Drawing.Point(4, 197);
            this.addUserPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addUserPanel.Name = "addUserPanel";
            this.addUserPanel.Size = new System.Drawing.Size(237, 71);
            this.addUserPanel.TabIndex = 7;
            this.addUserPanel.Text = "Add User";
            this.addUserPanel.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // logoutButton
            // 
            this.logoutButton.BackColor = System.Drawing.Color.Transparent;
            this.logoutButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.logoutButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.logoutButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.logoutButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.logoutButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.logoutButton.FillColor = System.Drawing.Color.Transparent;
            this.logoutButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.logoutButton.ForeColor = System.Drawing.Color.White;
            this.logoutButton.Image = global::project10.Properties.Resources.logout11;
            this.logoutButton.ImageSize = new System.Drawing.Size(32, 32);
            this.logoutButton.Location = new System.Drawing.Point(3, 707);
            this.logoutButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(238, 68);
            this.logoutButton.TabIndex = 6;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // bodyPanel
            // 
            this.bodyPanel.BackColor = System.Drawing.Color.White;
            this.bodyPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bodyPanel.Location = new System.Drawing.Point(244, 46);
            this.bodyPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bodyPanel.Name = "bodyPanel";
            this.bodyPanel.Size = new System.Drawing.Size(1080, 731);
            this.bodyPanel.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(829, 382);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Admin panel";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Controls.Add(this.userNameLabel);
            this.panel2.Location = new System.Drawing.Point(244, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1080, 50);
            this.panel2.TabIndex = 12;
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = false;
            this.userNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.userNameLabel.Font = new System.Drawing.Font("Palatino Linotype", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameLabel.ForeColor = System.Drawing.Color.White;
            this.userNameLabel.Location = new System.Drawing.Point(876, 2);
            this.userNameLabel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.userNameLabel.Size = new System.Drawing.Size(189, 41);
            this.userNameLabel.TabIndex = 12;
            this.userNameLabel.Text = "Saif";
            this.userNameLabel.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.userNameLabel.Click += new System.EventHandler(this.guna2HtmlLabel1_Click);
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1324, 777);
            this.Controls.Add(this.bodyPanel);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin ";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button logoutButton;
        private Guna.UI2.WinForms.Guna2Button addUserPanel;
        private Guna.UI2.WinForms.Guna2Button deleteUserButton;
        private Guna.UI2.WinForms.Guna2Button updateUserButton;
        private Guna.UI2.WinForms.Guna2Button allUserButton;
        private System.Windows.Forms.Panel bodyPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2HtmlLabel userNameLabel;
        private Guna.UI2.WinForms.Guna2Button allProductButton;
    }
}