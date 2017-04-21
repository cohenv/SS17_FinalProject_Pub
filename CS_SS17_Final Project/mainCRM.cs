using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CS_SS17_Final_Project.ProductForms;
using CS_SS17_Final_Project.SalesForms;

namespace CS_SS17_Final_Project
{
    public partial class QuickCRM : Form
    {
        public QuickCRM()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripLabel3_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void newCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newCust newCustomerForm = new newCust();
            DialogResult dr = newCustomerForm.ShowDialog();
        }


        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            custSearch customerSearchForm = new custSearch();
            DialogResult dr = customerSearchForm.ShowDialog();
        }

        private void findCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            custSearch customerSearchForm = new custSearch();
            DialogResult dr = customerSearchForm.ShowDialog();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox aboutBox = new AboutBox();
            DialogResult dr = aboutBox.ShowDialog();
        }

        private void findProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            prodSearch productSearchForm = new prodSearch();
            DialogResult dr = productSearchForm.ShowDialog();
        }

        private void newProductsToolStripMenuItem_Click(object sender, EventArgs e)
        {
           newProd newProductForm = new newProd();
            DialogResult dr = newProductForm.ShowDialog();
        }

        private void findSalesOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            salesOrderSearch salesOrderSearchForm = new salesOrderSearch();
            DialogResult dr = salesOrderSearchForm.ShowDialog();
        }

        private void newSalesOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newSalesOrder newSalesOrderForm = new newSalesOrder();
            DialogResult dr = newSalesOrderForm.ShowDialog();
        }

       
    }
}
