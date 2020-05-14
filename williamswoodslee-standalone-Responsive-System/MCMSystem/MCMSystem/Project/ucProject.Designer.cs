namespace MCMSystem.Project
{
    partial class ucProject
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
            this.pnlProject = new System.Windows.Forms.Panel();
            this.btnAddNewProject = new System.Windows.Forms.Button();
            this.btnViewProject = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlProject
            // 
            this.pnlProject.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlProject.BackColor = System.Drawing.Color.White;
            this.pnlProject.Location = new System.Drawing.Point(0, 38);
            this.pnlProject.Margin = new System.Windows.Forms.Padding(0);
            this.pnlProject.Name = "pnlProject";
            this.pnlProject.Size = new System.Drawing.Size(810, 610);
            this.pnlProject.TabIndex = 9;
            // 
            // btnAddNewProject
            // 
            this.btnAddNewProject.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddNewProject.BackColor = System.Drawing.Color.White;
            this.btnAddNewProject.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAddNewProject.FlatAppearance.BorderSize = 0;
            this.btnAddNewProject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNewProject.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewProject.ForeColor = System.Drawing.Color.Black;
            this.btnAddNewProject.Location = new System.Drawing.Point(2, 2);
            this.btnAddNewProject.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddNewProject.Name = "btnAddNewProject";
            this.btnAddNewProject.Size = new System.Drawing.Size(401, 34);
            this.btnAddNewProject.TabIndex = 3;
            this.btnAddNewProject.Text = "Add New Project";
            this.btnAddNewProject.UseVisualStyleBackColor = false;
            this.btnAddNewProject.Click += new System.EventHandler(this.btnAddNewProject_Click);
            // 
            // btnViewProject
            // 
            this.btnViewProject.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnViewProject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnViewProject.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnViewProject.FlatAppearance.BorderSize = 0;
            this.btnViewProject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewProject.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewProject.ForeColor = System.Drawing.Color.White;
            this.btnViewProject.Location = new System.Drawing.Point(407, 2);
            this.btnViewProject.Margin = new System.Windows.Forms.Padding(2);
            this.btnViewProject.Name = "btnViewProject";
            this.btnViewProject.Size = new System.Drawing.Size(401, 34);
            this.btnViewProject.TabIndex = 2;
            this.btnViewProject.Text = "View Project";
            this.btnViewProject.UseVisualStyleBackColor = false;
            this.btnViewProject.Click += new System.EventHandler(this.btnViewProject_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.btnAddNewProject, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnViewProject, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(810, 38);
            this.tableLayoutPanel2.TabIndex = 10;
            // 
            // ucProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pnlProject);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Name = "ucProject";
            this.Size = new System.Drawing.Size(810, 648);
            this.Load += new System.EventHandler(this.ucProject_Load);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlProject;
        private System.Windows.Forms.Button btnAddNewProject;
        private System.Windows.Forms.Button btnViewProject;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    }
}
