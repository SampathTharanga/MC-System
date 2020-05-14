namespace MCMSystem
{
    partial class ucDriver
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
            this.btnDriverReg = new System.Windows.Forms.Button();
            this.btnDriverView = new System.Windows.Forms.Button();
            this.pnlDriver = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDriverReg
            // 
            this.btnDriverReg.BackColor = System.Drawing.Color.White;
            this.btnDriverReg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDriverReg.FlatAppearance.BorderSize = 0;
            this.btnDriverReg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDriverReg.Font = new System.Drawing.Font("Arial", 11F);
            this.btnDriverReg.ForeColor = System.Drawing.Color.Black;
            this.btnDriverReg.Location = new System.Drawing.Point(2, 2);
            this.btnDriverReg.Margin = new System.Windows.Forms.Padding(2);
            this.btnDriverReg.Name = "btnDriverReg";
            this.btnDriverReg.Size = new System.Drawing.Size(401, 34);
            this.btnDriverReg.TabIndex = 0;
            this.btnDriverReg.Text = "Add New Driver";
            this.btnDriverReg.UseVisualStyleBackColor = false;
            this.btnDriverReg.Click += new System.EventHandler(this.btnDriverReg_Click);
            // 
            // btnDriverView
            // 
            this.btnDriverView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnDriverView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDriverView.FlatAppearance.BorderSize = 0;
            this.btnDriverView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDriverView.Font = new System.Drawing.Font("Arial", 11F);
            this.btnDriverView.ForeColor = System.Drawing.Color.White;
            this.btnDriverView.Location = new System.Drawing.Point(407, 2);
            this.btnDriverView.Margin = new System.Windows.Forms.Padding(2);
            this.btnDriverView.Name = "btnDriverView";
            this.btnDriverView.Size = new System.Drawing.Size(401, 34);
            this.btnDriverView.TabIndex = 1;
            this.btnDriverView.Text = "View Drivers";
            this.btnDriverView.UseVisualStyleBackColor = false;
            this.btnDriverView.Click += new System.EventHandler(this.btnDriverView_Click);
            // 
            // pnlDriver
            // 
            this.pnlDriver.BackColor = System.Drawing.Color.White;
            this.pnlDriver.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDriver.Location = new System.Drawing.Point(0, 38);
            this.pnlDriver.Margin = new System.Windows.Forms.Padding(0);
            this.pnlDriver.Name = "pnlDriver";
            this.pnlDriver.Size = new System.Drawing.Size(810, 610);
            this.pnlDriver.TabIndex = 5;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.btnDriverView, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnDriverReg, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(810, 38);
            this.tableLayoutPanel2.TabIndex = 6;
            // 
            // ucDriver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pnlDriver);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ucDriver";
            this.Size = new System.Drawing.Size(810, 648);
            this.Load += new System.EventHandler(this.ucDriver_Load);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDriverReg;
        private System.Windows.Forms.Button btnDriverView;
        private System.Windows.Forms.Panel pnlDriver;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    }
}
