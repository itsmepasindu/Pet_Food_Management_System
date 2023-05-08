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
    public partial class cashierLoginFrm : Form
    {
        public cashierLoginFrm()
        {
            InitializeComponent();
        }

        private void data()
        {

        }

        private void btnLogin_C_Click(object sender, EventArgs e)
        {
            string username = txtUserName_C.Text;
            string password = txtPassword_C.Text;

            if (username == "cashier" && password == "123")
            {
                ParentForm.Hide();
                CashierPanal cashierPanal = new CashierPanal();
                cashierPanal.Show();
                this.BringToFront();

            }
            else
            {
                MessageBox.Show("invalid User name or password");
            }
        }
    }
}
