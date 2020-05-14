namespace MCMSystem.Invoice
{
    partial class ucInvoice
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
            this.pnlInvoice = new System.Windows.Forms.Panel();
            this.btnViewInvoice = new System.Windows.Forms.Button();
            this.btnAddNewInvoice = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlInvoice
            // 
            this.pnlInvoice.BackColor = System.Drawing.Color.White;
            this.pnlInvoice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlInvoice.Location = new System.Drawing.Point(0, 38);
            this.pnlInvoice.Margin = new System.Windows.Forms.Padding(0);
            this.pnlInvoice.Name = "pnlInvoice";
            this.pnlInvoice.Size = new System.Drawing.Size(810, 610);
            this.pnlInvoice.TabIndex = 9;
            // 
            // btnViewInvoice
            // 
            this.btnViewInvoice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnViewInvoice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnViewInvoice.FlatAppearance.BorderSize = 0;
            this.btnViewInvoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewInvoice.Font = new System.Drawing.Font("Arial", 11F);
            this.btnViewInvoice.ForeColor = System.Drawing.Color.White;
            this.btnViewInvoice.Location = new System.Drawing.Point(407, 2);
            this.btnViewInvoice.Margin = new System.Windows.Forms.Padding(2);
            this.btnViewInvoice.Name = "btnViewInvoice";
            this.btnViewInvoice.Size = new System.Drawing.Size(401, 34);
            this.btnViewInvoice.TabIndex = 1;
            this.btnViewInvoice.Text = "View Invoice";
            this.btnViewInvoice.UseVisualStyleBackColor = false;
            this.btnViewInvoice.Click += new System.EventHandler(this.btnViewInvoice_Click);
            // 
            // btnAddNewInvoice
            // 
            this.btnAddNewInvoice.BackColor = System.Drawing.Color.White;
            this.btnAddNewInvoice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddNewInvoice.FlatAppearance.BorderSize = 0;
            this.btnAddNewInvoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNewInvoice.Font = new System.Drawing.Font("Arial", 11F);
            this.btnAddNewInvoice.ForeColor = System.Drawing.Color.Black;
            this.btnAddNewInvoice.Location = new System.Drawing.Point(2, 2);
            this.btnAddNewInvoice.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddNewInvoice.Name = "btnAddNewInvoice";
            this.btnAddNewInvoice.Size = new System.Drawing.Size(401, 34);
            this.btnAddNewInvoice.TabIndex = 0;
            this.btnAddNewInvoice.Text = "Add New Invoice";
            this.btnAddNewInvoice.UseVisualStyleBackColor = false;
            this.btnAddNewInvoice.Click += new System.EventHandler(this.btnAddNewInvoice_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.btnViewInvoice, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnAddNewInvoice, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(810, 38);
            this.tableLayoutPanel2.TabIndex = 10;
            // 
            // ucInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pnlInvoice);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Name = "ucInvoice";
            this.Size = new System.Drawing.Size(810, 648);
            this.Load += new System.EventHandler(this.ucInvoice_Load);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlInvoice;
        private System.Windows.Forms.Button btnViewInvoice;
        private System.Windows.Forms.Button btnAddNewInvoice;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    }
}
