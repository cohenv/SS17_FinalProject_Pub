﻿namespace CS_SS17_Final_Project.SalesForms
{
    partial class salesOrderSearch
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.salesOrderNumberTxt = new System.Windows.Forms.TextBox();
            this.salesOrderSearchBut = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sales Order Number";
            // 
            // salesOrderNumberTxt
            // 
            this.salesOrderNumberTxt.Location = new System.Drawing.Point(121, 10);
            this.salesOrderNumberTxt.Name = "salesOrderNumberTxt";
            this.salesOrderNumberTxt.Size = new System.Drawing.Size(242, 20);
            this.salesOrderNumberTxt.TabIndex = 1;
            // 
            // salesOrderSearchBut
            // 
            this.salesOrderSearchBut.Location = new System.Drawing.Point(370, 10);
            this.salesOrderSearchBut.Name = "salesOrderSearchBut";
            this.salesOrderSearchBut.Size = new System.Drawing.Size(75, 23);
            this.salesOrderSearchBut.TabIndex = 2;
            this.salesOrderSearchBut.Text = "Search";
            this.salesOrderSearchBut.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 36);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(543, 279);
            this.dataGridView1.TabIndex = 3;
            // 
            // salesOrderSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 327);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.salesOrderSearchBut);
            this.Controls.Add(this.salesOrderNumberTxt);
            this.Controls.Add(this.label1);
            this.Name = "salesOrderSearch";
            this.Text = "salesOrderSearch";
            this.Load += new System.EventHandler(this.salesOrderSearch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox salesOrderNumberTxt;
        private System.Windows.Forms.Button salesOrderSearchBut;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}