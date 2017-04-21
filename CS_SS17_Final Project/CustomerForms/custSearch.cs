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
    public partial class custSearch : Form
    {
        public custSearch()
        {
            InitializeComponent();
        }

        public void CustomerSearch_Click(object sender, EventArgs e)
        {
            CustomerUtility Utility = new CustomerUtility();

            string query = textBox1.Text;

            List<Customer> Customers = Utility.FindCustomer(query);

            CustomerDataView.DataSource = Customers;



        }

       
    }
}
