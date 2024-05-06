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
            this.guna2Panel1.Controls.Add(this.label3);
            this.guna2Panel1.Controls.Add(this.deleteUserButton);
            this.guna2Panel1.Controls.Add(this.updateUserButton);
            this.guna2Panel1.Controls.Add(this.allUserButton);
            this.guna2Panel1.Controls.Add(this.addUserPanel);
            this.guna2Panel1.Controls.Add(this.logoutButton);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(2);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Padding = new System.Windows.Forms.Padding(2);
            this.guna2Panel1.Size = new System.Drawing.Size(183, 631);
            this.guna2Panel1.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(24, 9);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 29);
            this.label3.TabIndex = 12;
            this.label3.Text = "Manager";
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
            this.deleteUserButton.Location = new System.Drawing.Point(2, 349);
            this.deleteUserButton.Name = "deleteUserButton";
            this.deleteUserButton.Size = new System.Drawing.Size(178, 58);
            this.deleteUserButton.TabIndex = 10;
            this.deleteUserButton.Text = "Delete Products";
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
            this.updateUserButton.Location = new System.Drawing.Point(2, 286);
            this.updateUserButton.Name = "updateUserButton";
            this.updateUserButton.Size = new System.Drawing.Size(178, 58);
            this.updateUserButton.TabIndex = 9;
            this.updateUserButton.Text = "Update Products";
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
            this.allUserButton.Location = new System.Drawing.Point(2, 224);
            this.allUserButton.Name = "allUserButton";
            this.allUserButton.Size = new System.Drawing.Size(178, 58);
            this.allUserButton.TabIndex = 8;
            this.allUserButton.Text = "All Products";
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
            this.addUserPanel.Location = new System.Drawing.Point(3, 160);
            this.addUserPanel.Name = "addUserPanel";
            this.addUserPanel.Size = new System.Drawing.Size(178, 58);
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
            this.logoutButton.Location = new System.Drawing.Point(2, 574);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(179, 55);
            this.logoutButton.TabIndex = 6;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // bodyPanel
            // 
            this.bodyPanel.BackColor = System.Drawing.Color.White;
            this.bodyPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bodyPanel.Location = new System.Drawing.Point(183, 38);
            this.bodyPanel.Margin = new System.Windows.Forms.Padding(2);
            this.bodyPanel.Name = "bodyPanel";
            this.bodyPanel.Size = new System.Drawing.Size(810, 593);
            this.bodyPanel.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(622, 310);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Admin panel";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Controls.Add(this.userNameLabel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(183, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(810, 38);
            this.panel2.TabIndex = 12;
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = false;
            this.userNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.userNameLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.userNameLabel.Font = new System.Drawing.Font("Palatino Linotype", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameLabel.ForeColor = System.Drawing.Color.White;
            this.userNameLabel.Location = new System.Drawing.Point(514, 0);
            this.userNameLabel.Margin = new System.Windows.Forms.Padding(2);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Padding = new System.Windows.Forms.Padding(0, 0, 40, 0);
            this.userNameLabel.Size = new System.Drawing.Size(296, 38);
            this.userNameLabel.TabIndex = 12;
            this.userNameLabel.Text = "Saif";
            this.userNameLabel.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.userNameLabel.Click += new System.EventHandler(this.guna2HtmlLabel1_Click);
            // 
            // FormManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(993, 631);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.bodyPanel);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manager";
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
    }
}