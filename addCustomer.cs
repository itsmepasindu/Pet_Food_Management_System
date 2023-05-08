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
    public partial class addCustomer : Form
    {
        public addCustomer()
        {
            InitializeComponent();
        }

       

        private void btnSaveCustomerData_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\BIT\2 sem\ICT Project\Pet_Food_Shop\PetShopDataBase.mdf;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("sp_insert_CustomerInfo", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Name", txtCutomerName.Text);
            cmd.Parameters.AddWithValue("@PhoneNumber", txtCustomerPhoneNo.Text);
            cmd.Parameters.AddWithValue("@EmailAddress", txtCustomerEmail.Text);

            con.Open();
            int i = cmd.ExecuteNonQuery();

            con.Close();

            if (i != 0)
            {
                MessageBox.Show("Data Saved");
                txtCutomerName.Text = "";
                txtCustomerPhoneNo.Text = "";
                txtCustomerEmail.Text = "";
            }
        }
    }
}
