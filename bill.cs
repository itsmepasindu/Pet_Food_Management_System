using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Pet_Food_Shop
{
    public partial class bill : Form
    {
        

        public bill()
        {
            InitializeComponent();
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            
        }

        private void bill_Load(object sender, EventArgs e)
        {
            customername.Text = payments.cusname;
            petCate.Text = payments.petCate;
            Amount.Text = payments.amount;
            Total.Text = payments.calculate.ToString();

            
        }

        
    }
}
