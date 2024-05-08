namespace project10
{
    partial class AllProductsUC
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
            this.components = new System.ComponentModel.Container();
            this.loginDataSet = new project10.loginDataSet();
            this.loginDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.loginDataSet1 = new project10.loginDataSet1();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userTableAdapter = new project10.loginDataSet1TableAdapters.userTableAdapter();
            this.selectedButton = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            ((System.ComponentModel.ISupportInitialize)(this.loginDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // loginDataSet
            // 
            this.loginDataSet.DataSetName = "loginDataSet";
            this.loginDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // loginDataSetBindingSource
            // 
            this.loginDataSetBindingSource.DataSource = this.loginDataSet;
            this.loginDataSetBindingSource.Position = 0;
            // 
            // loginDataSet1
            // 
            this.loginDataSet1.DataSetName = "loginDataSet1";
            this.loginDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataMember = "user";
            this.userBindingSource.DataSource = this.loginDataSet1;
            // 
            // userTableAdapter
            // 
            this.userTableAdapter.ClearBeforeFill = true;
            // 
            // selectedButton
            // 
            this.selectedButton.AutoSize = false;
            this.selectedButton.BackColor = System.Drawing.Color.Transparent;
            this.selectedButton.Font = new System.Drawing.Font("Palatino Linotype", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectedButton.ForeColor = System.Drawing.Color.Black;
            this.selectedButton.Location = new System.Drawing.Point(13, 40);
            this.selectedButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.selectedButton.Name = "selectedButton";
            this.selectedButton.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.selectedButton.Size = new System.Drawing.Size(153, 33);
            this.selectedButton.TabIndex = 15;
            this.selectedButton.Text = "All Users List";
            this.selectedButton.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.selectedButton.Click += new System.EventHandler(this.selectedButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(20, 82);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(779, 496);
            this.dataGridView1.TabIndex = 16;
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(670, 53);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(129, 20);
            this.searchTextBox.TabIndex = 17;
            this.searchTextBox.TextChanged += new System.EventHandler(this.searchTextBox_TextChanged);
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.AutoSize = false;
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.Black;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(556, 45);
            this.guna2HtmlLabel1.Margin = new System.Windows.Forms.Padding(2);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(109, 33);
            this.guna2HtmlLabel1.TabIndex = 18;
            this.guna2HtmlLabel1.Text = "Search by name:";
            this.guna2HtmlLabel1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // AllProductsUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.selectedButton);
            this.Name = "AllProductsUC";
            this.Size = new System.Drawing.Size(810, 594);
            ((System.ComponentModel.ISupportInitialize)(this.loginDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource loginDataSetBindingSource;
        private loginDataSet loginDataSet;
        private System.Windows.Forms.BindingSource userBindingSource;
        private loginDataSet1 loginDataSet1;
        private loginDataSet1TableAdapters.userTableAdapter userTableAdapter;
        private Guna.UI2.WinForms.Guna2HtmlLabel selectedButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox searchTextBox;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
    }
}
