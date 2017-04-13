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
            this.prodNameInput = new System.Windows.Forms.TextBox();
            this.prodNumberInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
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
            // prodNameInput
            // 
            this.prodNameInput.Location = new System.Drawing.Point(121, 24);
            this.prodNameInput.Name = "prodNameInput";
            this.prodNameInput.Size = new System.Drawing.Size(128, 20);
            this.prodNameInput.TabIndex = 1;
            this.prodNameInput.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // prodNumberInput
            // 
            this.prodNumberInput.Location = new System.Drawing.Point(121, 54);
            this.prodNumberInput.Name = "prodNumberInput";
            this.prodNumberInput.Size = new System.Drawing.Size(128, 20);
            this.prodNumberInput.TabIndex = 3;
            this.prodNumberInput.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(121, 88);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(128, 20);
            this.textBox1.TabIndex = 5;
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
            // 
            // newProd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 183);
            this.Controls.Add(this.addProdBut);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listPriceInput);
            this.Controls.Add(this.prodNumberInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.prodNameInput);
            this.Controls.Add(this.label1);
            this.Name = "newProd";
            this.Text = "newProd";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox prodNameInput;
        private System.Windows.Forms.TextBox prodNumberInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label listPriceInput;
        private System.Windows.Forms.Button addProdBut;
    }
}