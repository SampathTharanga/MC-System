namespace MCMSystem
{
    partial class ucVehicleRegistration
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
            this.btnViewVehicles = new System.Windows.Forms.Button();
            this.btnAddNewVehicle = new System.Windows.Forms.Button();
            this.pnlVehicle = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnViewVehicles
            // 
            this.btnViewVehicles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnViewVehicles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnViewVehicles.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnViewVehicles.FlatAppearance.BorderSize = 0;
            this.btnViewVehicles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewVehicles.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewVehicles.ForeColor = System.Drawing.Color.White;
            this.btnViewVehicles.Location = new System.Drawing.Point(407, 2);
            this.btnViewVehicles.Margin = new System.Windows.Forms.Padding(2);
            this.btnViewVehicles.Name = "btnViewVehicles";
            this.btnViewVehicles.Size = new System.Drawing.Size(401, 34);
            this.btnViewVehicles.TabIndex = 2;
            this.btnViewVehicles.Text = "View Vehicles";
            this.btnViewVehicles.UseVisualStyleBackColor = false;
            this.btnViewVehicles.Click += new System.EventHandler(this.btnViewVehicles_Click);
            // 
            // btnAddNewVehicle
            // 
            this.btnAddNewVehicle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddNewVehicle.BackColor = System.Drawing.Color.White;
            this.btnAddNewVehicle.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAddNewVehicle.FlatAppearance.BorderSize = 0;
            this.btnAddNewVehicle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNewVehicle.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewVehicle.ForeColor = System.Drawing.Color.Black;
            this.btnAddNewVehicle.Location = new System.Drawing.Point(2, 2);
            this.btnAddNewVehicle.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddNewVehicle.Name = "btnAddNewVehicle";
            this.btnAddNewVehicle.Size = new System.Drawing.Size(401, 34);
            this.btnAddNewVehicle.TabIndex = 3;
            this.btnAddNewVehicle.Text = "Add New Vehicle";
            this.btnAddNewVehicle.UseVisualStyleBackColor = false;
            this.btnAddNewVehicle.Click += new System.EventHandler(this.btnAddNewVehicle_Click);
            // 
            // pnlVehicle
            // 
            this.pnlVehicle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlVehicle.Location = new System.Drawing.Point(0, 38);
            this.pnlVehicle.Margin = new System.Windows.Forms.Padding(0);
            this.pnlVehicle.Name = "pnlVehicle";
            this.pnlVehicle.Size = new System.Drawing.Size(810, 610);
            this.pnlVehicle.TabIndex = 4;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.btnAddNewVehicle, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnViewVehicles, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(810, 38);
            this.tableLayoutPanel2.TabIndex = 6;
            // 
            // ucVehicleRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pnlVehicle);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ucVehicleRegistration";
            this.Size = new System.Drawing.Size(810, 648);
            this.Load += new System.EventHandler(this.ucVehicleRegistration_Load);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnViewVehicles;
        private System.Windows.Forms.Button btnAddNewVehicle;
        private System.Windows.Forms.Panel pnlVehicle;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    }
}
