using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pet_Food_Shop
{
    public partial class CustomerData : Form
    {
        public CustomerData()
        {
            InitializeComponent();
        }

        private void btnAddCustomer_A_Click(object sender, EventArgs e)
        {
            addCustomer addCustomer = new addCustomer();
            addCustomer.ShowDialog();
        }

        private void btnViewCustomerDataild_Click(object sender, EventArgs e)
        {
            CustomerDetails customerDetails = new CustomerDetails();
            customerDetails.ShowDialog();
        }
    }
}
