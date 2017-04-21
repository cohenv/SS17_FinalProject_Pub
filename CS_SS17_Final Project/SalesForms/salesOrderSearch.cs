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


namespace CS_SS17_Final_Project.SalesForms
{
    public partial class salesOrderSearch : Form
    {
        public salesOrderSearch()
        {
            InitializeComponent();
        }


        public void salesOrderSearchBtn_Click(object sender, EventArgs e)
        {
           SalesUtility Utility = new SalesUtility();

            string query = salesOrderNumberTxt.Text;

            List<SalesOrderDetail> Sales = Utility.FindSales(query);

            SalesOrderView.DataSource = Sales;
        }

       
    }
}
