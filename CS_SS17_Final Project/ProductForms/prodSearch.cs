using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AdventureData.Models;
using AdventureData.Utility;

namespace CS_SS17_Final_Project
{
    public partial class prodSearch : Form
    {
        public prodSearch()
        {
            InitializeComponent();
        }


        public void ProductSearch_Click(object sender, EventArgs e)
        {
            ProductUtility Utility = new ProductUtility();

            string query = textBox1.Text;

            List<Product> Products = Utility.FindProduct(query);

            ProductSearchView.DataSource = Products;

        }

    }
}
