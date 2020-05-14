namespace MCMSystem.Order
{
    partial class ucPurchaseOrder
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
            this.pnlOrder = new System.Windows.Forms.Panel();
            this.btnOrderView = new System.Windows.Forms.Button();
            this.btnAddNewOrder = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlOrder
            // 
            this.pnlOrder.BackColor = System.Drawing.Color.White;
            this.pnlOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlOrder.Location = new System.Drawing.Point(0, 38);
            this.pnlOrder.Margin = new System.Windows.Forms.Padding(0);
            this.pnlOrder.Name = "pnlOrder";
            this.pnlOrder.Size = new System.Drawing.Size(810, 610);
            this.pnlOrder.TabIndex = 7;
            // 
            // btnOrderView
            // 
            this.btnOrderView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnOrderView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnOrderView.FlatAppearance.BorderSize = 0;
            this.btnOrderView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrderView.Font = new System.Drawing.Font("Arial", 11F);
            this.btnOrderView.ForeColor = System.Drawing.Color.White;
            this.btnOrderView.Location = new System.Drawing.Point(407, 2);
            this.btnOrderView.Margin = new System.Windows.Forms.Padding(2);
            this.btnOrderView.Name = "btnOrderView";
            this.btnOrderView.Size = new System.Drawing.Size(401, 34);
            this.btnOrderView.TabIndex = 1;
            this.btnOrderView.Text = "View Order";
            this.btnOrderView.UseVisualStyleBackColor = false;
            this.btnOrderView.Click += new System.EventHandler(this.btnOrderView_Click);
            // 
            // btnAddNewOrder
            // 
            this.btnAddNewOrder.BackColor = System.Drawing.Color.White;
            this.btnAddNewOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddNewOrder.FlatAppearance.BorderSize = 0;
            this.btnAddNewOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNewOrder.Font = new System.Drawing.Font("Arial", 11F);
            this.btnAddNewOrder.ForeColor = System.Drawing.Color.Black;
            this.btnAddNewOrder.Location = new System.Drawing.Point(2, 2);
            this.btnAddNewOrder.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddNewOrder.Name = "btnAddNewOrder";
            this.btnAddNewOrder.Size = new System.Drawing.Size(401, 34);
            this.btnAddNewOrder.TabIndex = 0;
            this.btnAddNewOrder.Text = "Add New Order";
            this.btnAddNewOrder.UseVisualStyleBackColor = false;
            this.btnAddNewOrder.Click += new System.EventHandler(this.btnAddNewOrder_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.btnOrderView, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnAddNewOrder, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(810, 38);
            this.tableLayoutPanel2.TabIndex = 8;
            // 
            // ucPurchaseOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pnlOrder);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Name = "ucPurchaseOrder";
            this.Size = new System.Drawing.Size(810, 648);
            this.Load += new System.EventHandler(this.ucOrder_Load);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlOrder;
        private System.Windows.Forms.Button btnOrderView;
        private System.Windows.Forms.Button btnAddNewOrder;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    }
}
