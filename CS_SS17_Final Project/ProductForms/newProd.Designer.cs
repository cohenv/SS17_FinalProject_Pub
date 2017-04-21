namespace CS_SS17_Final_Project.ProductForms
{
    partial class newProd
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
            this.prodNameTxt = new System.Windows.Forms.TextBox();
            this.prodNumberTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listPriceTxt = new System.Windows.Forms.TextBox();
            this.listPriceInput = new System.Windows.Forms.Label();
            this.addProdBut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Product Name";
            // 
            // prodNameTxt
            // 
            this.prodNameTxt.Location = new System.Drawing.Point(121, 24);
            this.prodNameTxt.Name = "prodNameTxt";
            this.prodNameTxt.Size = new System.Drawing.Size(128, 20);
            this.prodNameTxt.TabIndex = 1;
            this.prodNameTxt.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // prodNumberTxt
            // 
            this.prodNumberTxt.Location = new System.Drawing.Point(121, 54);
            this.prodNumberTxt.Name = "prodNumberTxt";
            this.prodNumberTxt.Size = new System.Drawing.Size(128, 20);
            this.prodNumberTxt.TabIndex = 3;
            this.prodNumberTxt.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Product Number";
            // 
            // listPriceTxt
            // 
            this.listPriceTxt.Location = new System.Drawing.Point(121, 88);
            this.listPriceTxt.Name = "listPriceTxt";
            this.listPriceTxt.Size = new System.Drawing.Size(128, 20);
            this.listPriceTxt.TabIndex = 5;
            // 
            // listPriceInput
            // 
            this.listPriceInput.AutoSize = true;
            this.listPriceInput.Location = new System.Drawing.Point(22, 91);
            this.listPriceInput.Name = "listPriceInput";
            this.listPriceInput.Size = new System.Drawing.Size(50, 13);
            this.listPriceInput.TabIndex = 4;
            this.listPriceInput.Text = "List Price";
            // 
            // addProdBut
            // 
            this.addProdBut.Location = new System.Drawing.Point(25, 131);
            this.addProdBut.Name = "addProdBut";
            this.addProdBut.Size = new System.Drawing.Size(224, 23);
            this.addProdBut.TabIndex = 6;
            this.addProdBut.Text = "Add Product";
            this.addProdBut.UseVisualStyleBackColor = true;
            this.addProdBut.Click += new System.EventHandler(this.addProdBut_Click);
            // 
            // newProd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 183);
            this.Controls.Add(this.addProdBut);
            this.Controls.Add(this.listPriceTxt);
            this.Controls.Add(this.listPriceInput);
            this.Controls.Add(this.prodNumberTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.prodNameTxt);
            this.Controls.Add(this.label1);
            this.Name = "newProd";
            this.Text = "newProd";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox prodNameTxt;
        private System.Windows.Forms.TextBox prodNumberTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox listPriceTxt;
        private System.Windows.Forms.Label listPriceInput;
        private System.Windows.Forms.Button addProdBut;
    }
}