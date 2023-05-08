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
    public partial class adminstaff : Form
    {
        public adminstaff()
        {
            InitializeComponent();
        }

        private void btnStaffRegA_01_Click(object sender, EventArgs e)
        {
            staffReg_A staffReg = new staffReg_A();
            staffReg.ShowDialog();
        }

        private void btnViewMembersA_01_Click(object sender, EventArgs e)
        {
            viewStaffMembers viewStaff = new viewStaffMembers();
            viewStaff.ShowDialog();
        }
    }
}
