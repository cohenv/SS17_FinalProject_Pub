using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AdventureData.Utility;
using AdventureData.Models;

namespace CS_SS17_Final_Project.ProductForms
{
    public partial class newProd : Form
    {
        public newProd()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public void addProdBut_Click(object sender, EventArgs e)
        {
            ProductUtility Utility = new ProductUtility();
            Product template = new Product();

            template.Name = prodNameTxt;
            template.ProductNumber = prodNumberTxt;
            template.ListPrice = listPriceTxt;

            Product NewProduct = Utility.CreateProduct(template);

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
