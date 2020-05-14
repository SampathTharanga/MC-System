namespace MCMSystem.Customer
{
    partial class ucCustomer
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
            this.pnlCustomer = new System.Windows.Forms.Panel();
            this.btnAddNewCustomer = new System.Windows.Forms.Button();
            this.btnViewCustomers = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlCustomer
            // 
            this.pnlCustomer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlCustomer.BackColor = System.Drawing.Color.White;
            this.pnlCustomer.Location = new System.Drawing.Point(0, 38);
            this.pnlCustomer.Margin = new System.Windows.Forms.Padding(0);
            this.pnlCustomer.Name = "pnlCustomer";
            this.pnlCustomer.Size = new System.Drawing.Size(810, 610);
            this.pnlCustomer.TabIndex = 7;
            // 
            // btnAddNewCustomer
            // 
            this.btnAddNewCustomer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddNewCustomer.BackColor = System.Drawing.Color.White;
            this.btnAddNewCustomer.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAddNewCustomer.FlatAppearance.BorderSize = 0;
            this.btnAddNewCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNewCustomer.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewCustomer.ForeColor = System.Drawing.Color.Black;
            this.btnAddNewCustomer.Location = new System.Drawing.Point(2, 2);
            this.btnAddNewCustomer.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddNewCustomer.Name = "btnAddNewCustomer";
            this.btnAddNewCustomer.Size = new System.Drawing.Size(401, 34);
            this.btnAddNewCustomer.TabIndex = 3;
            this.btnAddNewCustomer.Text = "Add New Customer";
            this.btnAddNewCustomer.UseVisualStyleBackColor = false;
            this.btnAddNewCustomer.Click += new System.EventHandler(this.btnAddNewCustomer_Click);
            // 
            // btnViewCustomers
            // 
            this.btnViewCustomers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnViewCustomers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnViewCustomers.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnViewCustomers.FlatAppearance.BorderSize = 0;
            this.btnViewCustomers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewCustomers.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewCustomers.ForeColor = System.Drawing.Color.White;
            this.btnViewCustomers.Location = new System.Drawing.Point(407, 2);
            this.btnViewCustomers.Margin = new System.Windows.Forms.Padding(2);
            this.btnViewCustomers.Name = "btnViewCustomers";
            this.btnViewCustomers.Size = new System.Drawing.Size(401, 34);
            this.btnViewCustomers.TabIndex = 2;
            this.btnViewCustomers.Text = "View Customers";
            this.btnViewCustomers.UseVisualStyleBackColor = false;
            this.btnViewCustomers.Click += new System.EventHandler(this.btnViewCustomers_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.btnAddNewCustomer, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnViewCustomers, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(810, 38);
            this.tableLayoutPanel2.TabIndex = 8;
            // 
            // ucCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pnlCustomer);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Name = "ucCustomer";
            this.Size = new System.Drawing.Size(810, 648);
            this.Load += new System.EventHandler(this.ucCustomer_Load);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlCustomer;
        private System.Windows.Forms.Button btnAddNewCustomer;
        private System.Windows.Forms.Button btnViewCustomers;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    }
}
