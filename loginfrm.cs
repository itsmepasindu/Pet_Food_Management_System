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
    public partial class loginfrm : Form
    {
        public loginfrm()
        {
            InitializeComponent();
        }

        private void btnClose_01_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private Form activeForm = null;

        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();

            }

            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            loginViewPanal_01.Controls.Add(childForm);
            loginViewPanal_01.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }

        private void btnAdmin_01_Click(object sender, EventArgs e)
        {
            openChildForm(new adminLoginFrm());
        }

        private void btnCashier_01_Click(object sender, EventArgs e)
        {
            openChildForm(new cashierLoginFrm());
        }

        private void btnStaff_01_Click(object sender, EventArgs e)
        {
            openChildForm(new staffLoginfrm());
        }
    }
}
