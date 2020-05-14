namespace MCMSystem.Product
{
    partial class ucProduct
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
            this.pnlProduct = new System.Windows.Forms.Panel();
            this.btnAddNewProduct = new System.Windows.Forms.Button();
            this.btnViewProduct = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlProduct
            // 
            this.pnlProduct.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlProduct.BackColor = System.Drawing.Color.White;
            this.pnlProduct.Location = new System.Drawing.Point(0, 38);
            this.pnlProduct.Margin = new System.Windows.Forms.Padding(0);
            this.pnlProduct.Name = "pnlProduct";
            this.pnlProduct.Size = new System.Drawing.Size(810, 610);
            this.pnlProduct.TabIndex = 11;
            // 
            // btnAddNewProduct
            // 
            this.btnAddNewProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddNewProduct.BackColor = System.Drawing.Color.White;
            this.btnAddNewProduct.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAddNewProduct.FlatAppearance.BorderSize = 0;
            this.btnAddNewProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNewProduct.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewProduct.ForeColor = System.Drawing.Color.Black;
            this.btnAddNewProduct.Location = new System.Drawing.Point(2, 2);
            this.btnAddNewProduct.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddNewProduct.Name = "btnAddNewProduct";
            this.btnAddNewProduct.Size = new System.Drawing.Size(401, 34);
            this.btnAddNewProduct.TabIndex = 3;
            this.btnAddNewProduct.Text = "Add New Product";
            this.btnAddNewProduct.UseVisualStyleBackColor = false;
            this.btnAddNewProduct.Click += new System.EventHandler(this.btnAddNewProduct_Click);
            // 
            // btnViewProduct
            // 
            this.btnViewProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnViewProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnViewProduct.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnViewProduct.FlatAppearance.BorderSize = 0;
            this.btnViewProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewProduct.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewProduct.ForeColor = System.Drawing.Color.White;
            this.btnViewProduct.Location = new System.Drawing.Point(407, 2);
            this.btnViewProduct.Margin = new System.Windows.Forms.Padding(2);
            this.btnViewProduct.Name = "btnViewProduct";
            this.btnViewProduct.Size = new System.Drawing.Size(401, 34);
            this.btnViewProduct.TabIndex = 2;
            this.btnViewProduct.Text = "View Product";
            this.btnViewProduct.UseVisualStyleBackColor = false;
            this.btnViewProduct.Click += new System.EventHandler(this.btnViewProduct_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.btnAddNewProduct, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnViewProduct, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(810, 38);
            this.tableLayoutPanel2.TabIndex = 12;
            // 
            // ucProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pnlProduct);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Name = "ucProduct";
            this.Size = new System.Drawing.Size(810, 648);
            this.Load += new System.EventHandler(this.ucProduct_Load);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlProduct;
        private System.Windows.Forms.Button btnAddNewProduct;
        private System.Windows.Forms.Button btnViewProduct;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    }
}
