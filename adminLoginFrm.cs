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
    public partial class adminLoginFrm : Form
    {
        public adminLoginFrm()
        {
            InitializeComponent();
        }

        private void btnLogin_A_Click(object sender, EventArgs e)
        {

            string username = txtUserName_A.Text;
            string password = txtPassword_A.Text;

            if(username == "admin" && password == "123")
            {
                ParentForm.Hide();
                AdminPanal adminPanal = new AdminPanal();
                adminPanal.Show();
                this.BringToFront();

            }
            else
            {
                MessageBox.Show("invalid User name or password");
            }
            

        }
    }
}
