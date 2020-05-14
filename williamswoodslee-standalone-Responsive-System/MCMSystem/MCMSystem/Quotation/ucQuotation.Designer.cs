namespace MCMSystem.Quotation
{
    partial class ucQuotation
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
            this.pnlQuotation = new System.Windows.Forms.Panel();
            this.btnAddNewQuotation = new System.Windows.Forms.Button();
            this.btnViewQuotation = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlQuotation
            // 
            this.pnlQuotation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlQuotation.BackColor = System.Drawing.Color.White;
            this.pnlQuotation.Location = new System.Drawing.Point(0, 38);
            this.pnlQuotation.Margin = new System.Windows.Forms.Padding(0);
            this.pnlQuotation.Name = "pnlQuotation";
            this.pnlQuotation.Size = new System.Drawing.Size(810, 610);
            this.pnlQuotation.TabIndex = 13;
            // 
            // btnAddNewQuotation
            // 
            this.btnAddNewQuotation.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddNewQuotation.BackColor = System.Drawing.Color.White;
            this.btnAddNewQuotation.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAddNewQuotation.FlatAppearance.BorderSize = 0;
            this.btnAddNewQuotation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNewQuotation.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewQuotation.ForeColor = System.Drawing.Color.Black;
            this.btnAddNewQuotation.Location = new System.Drawing.Point(2, 2);
            this.btnAddNewQuotation.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddNewQuotation.Name = "btnAddNewQuotation";
            this.btnAddNewQuotation.Size = new System.Drawing.Size(401, 34);
            this.btnAddNewQuotation.TabIndex = 3;
            this.btnAddNewQuotation.Text = "Add New Quotation";
            this.btnAddNewQuotation.UseVisualStyleBackColor = false;
            this.btnAddNewQuotation.Click += new System.EventHandler(this.btnAddNewQuotation_Click);
            // 
            // btnViewQuotation
            // 
            this.btnViewQuotation.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnViewQuotation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnViewQuotation.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnViewQuotation.FlatAppearance.BorderSize = 0;
            this.btnViewQuotation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewQuotation.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewQuotation.ForeColor = System.Drawing.Color.White;
            this.btnViewQuotation.Location = new System.Drawing.Point(407, 2);
            this.btnViewQuotation.Margin = new System.Windows.Forms.Padding(2);
            this.btnViewQuotation.Name = "btnViewQuotation";
            this.btnViewQuotation.Size = new System.Drawing.Size(401, 34);
            this.btnViewQuotation.TabIndex = 2;
            this.btnViewQuotation.Text = "View Quotations";
            this.btnViewQuotation.UseVisualStyleBackColor = false;
            this.btnViewQuotation.Click += new System.EventHandler(this.btnViewQuotation_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.btnAddNewQuotation, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnViewQuotation, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(810, 38);
            this.tableLayoutPanel2.TabIndex = 14;
            // 
            // ucQuotation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pnlQuotation);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Name = "ucQuotation";
            this.Size = new System.Drawing.Size(810, 648);
            this.Load += new System.EventHandler(this.ucQuotation_Load);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlQuotation;
        private System.Windows.Forms.Button btnAddNewQuotation;
        private System.Windows.Forms.Button btnViewQuotation;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    }
}
