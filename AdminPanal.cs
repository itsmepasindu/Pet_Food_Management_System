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
    public partial class AdminPanal : Form
    {
        public AdminPanal()
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
            panalAdmin_view_01.Controls.Add(childForm);
            panalAdmin_view_01.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }

        private void panalAdmin_view_01_Paint(object sender, PaintEventArgs e)
        {
            
        }

        

        private void AdminPanal_Load(object sender, EventArgs e)
        {
            
        }

        private void btnStaffReg_A_Click(object sender, EventArgs e)
        {
            openChildForm(new adminstaff());
        }

        private void btnAvailable_A_Click(object sender, EventArgs e)
        {
            openChildForm(new available());
        }

        private void btnFoodManag_A_Click(object sender, EventArgs e)
        {
            openChildForm(new FoodMag_01());
        }

        private void btnReports_A_Click(object sender, EventArgs e)
        {
            openChildForm(new report());
        }

        private void btnPayment_A_Click(object sender, EventArgs e)
        {
            openChildForm(new payments());
        }

        private void btnLogout_A_Click(object sender, EventArgs e)
        {
            loginfrm login = new loginfrm();
            login.Show();
            this.Hide();

        }

        private void btnCustomerDate_A_Click(object sender, EventArgs e)
        {
            openChildForm(new CustomerData());
        }

        private void btnCategory_A_Click(object sender, EventArgs e)
        {
            openChildForm(new CategoryFrm(Text));
        }
    }
}
