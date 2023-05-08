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
    public partial class staffLoginfrm : Form
    {
        public staffLoginfrm()
        {
            InitializeComponent();
        }

        private void btnLogin_S_Click(object sender, EventArgs e)
        {
            string username = txtUserName_S.Text;
            string password = txtPassword_S.Text;

            if (username == "staff" && password == "123")
            {
                ParentForm.Hide();
                StaffPanal staffPanal = new StaffPanal();
                staffPanal.Show();
                this.BringToFront();

            }
            else
            {
                MessageBox.Show("invalid User name or password");
            }
        }
    
    }
}
