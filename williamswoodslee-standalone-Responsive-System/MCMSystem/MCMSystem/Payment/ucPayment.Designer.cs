﻿namespace MCMSystem.Payment
{
    partial class ucPayment
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
            this.pnlPayment = new System.Windows.Forms.Panel();
            this.btnPaymentView = new System.Windows.Forms.Button();
            this.btnAddNewPayment = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlPayment
            // 
            this.pnlPayment.BackColor = System.Drawing.Color.White;
            this.pnlPayment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPayment.Location = new System.Drawing.Point(0, 38);
            this.pnlPayment.Margin = new System.Windows.Forms.Padding(0);
            this.pnlPayment.Name = "pnlPayment";
            this.pnlPayment.Size = new System.Drawing.Size(810, 610);
            this.pnlPayment.TabIndex = 9;
            // 
            // btnPaymentView
            // 
            this.btnPaymentView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnPaymentView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPaymentView.FlatAppearance.BorderSize = 0;
            this.btnPaymentView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPaymentView.Font = new System.Drawing.Font("Arial", 11F);
            this.btnPaymentView.ForeColor = System.Drawing.Color.White;
            this.btnPaymentView.Location = new System.Drawing.Point(407, 2);
            this.btnPaymentView.Margin = new System.Windows.Forms.Padding(2);
            this.btnPaymentView.Name = "btnPaymentView";
            this.btnPaymentView.Size = new System.Drawing.Size(401, 34);
            this.btnPaymentView.TabIndex = 1;
            this.btnPaymentView.Text = "View Payment";
            this.btnPaymentView.UseVisualStyleBackColor = false;
            this.btnPaymentView.Click += new System.EventHandler(this.btnPaymentView_Click);
            // 
            // btnAddNewPayment
            // 
            this.btnAddNewPayment.BackColor = System.Drawing.Color.White;
            this.btnAddNewPayment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddNewPayment.FlatAppearance.BorderSize = 0;
            this.btnAddNewPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNewPayment.Font = new System.Drawing.Font("Arial", 11F);
            this.btnAddNewPayment.ForeColor = System.Drawing.Color.Black;
            this.btnAddNewPayment.Location = new System.Drawing.Point(2, 2);
            this.btnAddNewPayment.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddNewPayment.Name = "btnAddNewPayment";
            this.btnAddNewPayment.Size = new System.Drawing.Size(401, 34);
            this.btnAddNewPayment.TabIndex = 0;
            this.btnAddNewPayment.Text = "Add New Payment";
            this.btnAddNewPayment.UseVisualStyleBackColor = false;
            this.btnAddNewPayment.Click += new System.EventHandler(this.btnAddNewPayment_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.btnPaymentView, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnAddNewPayment, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(810, 38);
            this.tableLayoutPanel2.TabIndex = 10;
            // 
            // ucPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pnlPayment);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Name = "ucPayment";
            this.Size = new System.Drawing.Size(810, 648);
            this.Load += new System.EventHandler(this.ucPayment_Load);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlPayment;
        private System.Windows.Forms.Button btnPaymentView;
        private System.Windows.Forms.Button btnAddNewPayment;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    }
}
