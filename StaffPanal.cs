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
    public partial class StaffPanal : Form
    {
        public StaffPanal()
        {
            InitializeComponent();
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
            StaffPanalView_01.Controls.Add(childForm);
            StaffPanalView_01.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }

        private void btnLogout_A_Click(object sender, EventArgs e)
        {
            loginfrm login = new loginfrm();
            login.Show();
            this.Hide();
        }

        private void btnPayment_S_Click(object sender, EventArgs e)
        {
            openChildForm(new payments());
        }
    }
}
