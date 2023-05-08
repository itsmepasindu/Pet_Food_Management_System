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
    public partial class viewStaffMembers : Form
    {
        public viewStaffMembers()
        {
            InitializeComponent();
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\BIT\2 sem\ICT Project\Pet_Food_Shop\PetShopDataBase.mdf;Integrated Security=True";

            SqlCommand cmd = new SqlCommand("select * from staffMembers", con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            BindingSource source = new BindingSource();
            source.DataSource = dr;

            dataGridViewStaffMembers.DataSource = source;
            con.Close();
        }
    }
}
