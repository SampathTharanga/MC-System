namespace MCMSystem.DeliveryNote
{
    partial class ucDeliveryNote
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
            this.pnlDeliveryNote = new System.Windows.Forms.Panel();
            this.btnViewDeliveryNote = new System.Windows.Forms.Button();
            this.btnAddDeliveryNote = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlDeliveryNote
            // 
            this.pnlDeliveryNote.BackColor = System.Drawing.Color.White;
            this.pnlDeliveryNote.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDeliveryNote.Location = new System.Drawing.Point(0, 38);
            this.pnlDeliveryNote.Margin = new System.Windows.Forms.Padding(0);
            this.pnlDeliveryNote.Name = "pnlDeliveryNote";
            this.pnlDeliveryNote.Size = new System.Drawing.Size(810, 610);
            this.pnlDeliveryNote.TabIndex = 7;
            // 
            // btnViewDeliveryNote
            // 
            this.btnViewDeliveryNote.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnViewDeliveryNote.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnViewDeliveryNote.FlatAppearance.BorderSize = 0;
            this.btnViewDeliveryNote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewDeliveryNote.Font = new System.Drawing.Font("Arial", 11F);
            this.btnViewDeliveryNote.ForeColor = System.Drawing.Color.White;
            this.btnViewDeliveryNote.Location = new System.Drawing.Point(407, 2);
            this.btnViewDeliveryNote.Margin = new System.Windows.Forms.Padding(2);
            this.btnViewDeliveryNote.Name = "btnViewDeliveryNote";
            this.btnViewDeliveryNote.Size = new System.Drawing.Size(401, 34);
            this.btnViewDeliveryNote.TabIndex = 1;
            this.btnViewDeliveryNote.Text = "View Delivery";
            this.btnViewDeliveryNote.UseVisualStyleBackColor = false;
            this.btnViewDeliveryNote.Click += new System.EventHandler(this.btnViewDeliveryNote_Click);
            // 
            // btnAddDeliveryNote
            // 
            this.btnAddDeliveryNote.BackColor = System.Drawing.Color.White;
            this.btnAddDeliveryNote.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddDeliveryNote.FlatAppearance.BorderSize = 0;
            this.btnAddDeliveryNote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddDeliveryNote.Font = new System.Drawing.Font("Arial", 11F);
            this.btnAddDeliveryNote.ForeColor = System.Drawing.Color.Black;
            this.btnAddDeliveryNote.Location = new System.Drawing.Point(2, 2);
            this.btnAddDeliveryNote.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddDeliveryNote.Name = "btnAddDeliveryNote";
            this.btnAddDeliveryNote.Size = new System.Drawing.Size(401, 34);
            this.btnAddDeliveryNote.TabIndex = 0;
            this.btnAddDeliveryNote.Text = "Add New Delivery";
            this.btnAddDeliveryNote.UseVisualStyleBackColor = false;
            this.btnAddDeliveryNote.Click += new System.EventHandler(this.btnAddDeliveryNote_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.btnViewDeliveryNote, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnAddDeliveryNote, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(810, 38);
            this.tableLayoutPanel2.TabIndex = 8;
            // 
            // ucDeliveryNote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pnlDeliveryNote);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Name = "ucDeliveryNote";
            this.Size = new System.Drawing.Size(810, 648);
            this.Load += new System.EventHandler(this.ucDeliveryNote_Load);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlDeliveryNote;
        private System.Windows.Forms.Button btnViewDeliveryNote;
        private System.Windows.Forms.Button btnAddDeliveryNote;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    }
}
