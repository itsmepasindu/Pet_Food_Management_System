using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Pet_Food_Shop
{
    public partial class staffReg_A : Form
    {
        public staffReg_A()
        {
            InitializeComponent();
        }

        private void btnCloseA_01_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void staffReg_A_Load(object sender, EventArgs e)
        {
            txtFirstNameA_01.Select();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        
        private void btnSaveA_01_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\BIT\2 sem\ICT Project\Pet_Food_Shop\PetShopDataBase.mdf;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("sp_insert_Staff", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@FirstName", txtFirstNameA_01.Text);
            cmd.Parameters.AddWithValue("@LastName", txtLastNameA_01.Text);
            cmd.Parameters.AddWithValue("@Address", txtAddressA_01.Text);
            cmd.Parameters.AddWithValue("@Birthday", txtDOB_A_01.Text);
            cmd.Parameters.AddWithValue("@ContactNo", txtContactNumberA_01.Text);
            cmd.Parameters.AddWithValue("@CivilStatus", comCivilStatusA_01.Text);
            cmd.Parameters.AddWithValue("@Email", txtEmailAddressA_01.Text);
            cmd.Parameters.AddWithValue("@Gender", txtGenderA_01.Text);
            cmd.Parameters.AddWithValue("@Password", txtPasswordA_01.Text);
            cmd.Parameters.AddWithValue("@UserName", txtUserNameA_01.Text);

            con.Open();
            int i = cmd.ExecuteNonQuery();

            con.Close();

            if (i != 0)
            {
                MessageBox.Show("Data Saved");
                txtFirstNameA_01.Text = "";
                txtLastNameA_01.Text = "";
                txtAddressA_01.Text = "";
                txtDOB_A_01.Text = "";
                txtContactNumberA_01.Text = "";
                comCivilStatusA_01.Text = "";
                txtGenderA_01.Text = "";
                txtPasswordA_01.Text = "";
                txtUserNameA_01.Text = "";

            }
        }
    }
}
