namespace CS_SS17_Final_Project
{
    partial class custSearch
    {
        /// <summary>\\vmware-host\shared folders\documents\visual studio 2015\Projects\CS_SS17_Final Project\CS_SS17_Final Project\CustomerForms\custSearch.cs
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
            this.CustomerSearch = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.CustomerDataView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerDataView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer Search";
            // 
            // CustomerSearch
            // 
            this.CustomerSearch.Location = new System.Drawing.Point(421, 6);
            this.CustomerSearch.Name = "CustomerSearch";
            this.CustomerSearch.Size = new System.Drawing.Size(64, 22);
            this.CustomerSearch.TabIndex = 1;
            this.CustomerSearch.Text = "Search";
            this.CustomerSearch.UseVisualStyleBackColor = true;
            this.CustomerSearch.Click += new System.EventHandler(this.CustomerSearch_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(108, 8);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(307, 20);
            this.textBox1.TabIndex = 2;
            // 
            // CustomerDataView
            // 
            this.CustomerDataView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CustomerDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CustomerDataView.Location = new System.Drawing.Point(12, 34);
            this.CustomerDataView.Name = "CustomerDataView";
            this.CustomerDataView.Size = new System.Drawing.Size(519, 248);
            this.CustomerDataView.TabIndex = 3;
            // 
            // custSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 292);
            this.Controls.Add(this.CustomerDataView);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.CustomerSearch);
            this.Controls.Add(this.label1);
            this.Name = "custSearch";
            this.Text = "Customer Search";
         
            ((System.ComponentModel.ISupportInitialize)(this.CustomerDataView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CustomerSearch;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView CustomerDataView;
    }
}