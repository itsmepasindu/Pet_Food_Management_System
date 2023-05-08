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
    public partial class AddFoods : Form
    {
        public AddFoods()
        {
            InitializeComponent();

            GetCate();
            GetFoodCate();
        }

        private void GetCate()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\BIT\2 sem\ICT Project\Pet_Food_Shop\PetShopDataBase.mdf;Integrated Security=True";

            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from Category", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            cmd.ExecuteNonQuery();
            con.Close();

            comBoxPetCate.DataSource = ds.Tables[0];
            comBoxPetCate.DisplayMember = "name";
            comBoxPetCate.ValueMember = "id";
        }

        private void GetFoodCate()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\BIT\2 sem\projecte\Pet_Food_Shop\PetShopDataBase.mdf;Integrated Security=True";

            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from FoodCate", con);
            SqlDataAdapter dr = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            dr.Fill(ds);
            cmd.ExecuteNonQuery();
            con.Close();

            comBoxFoodCate.DataSource = ds.Tables[0];
            comBoxFoodCate.DisplayMember = "Name";
            comBoxFoodCate.ValueMember = "Id";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\BIT\2 sem\projecte\Pet_Food_Shop\PetShopDataBase.mdf;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("sp_AddFoods", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@name", txtFoodName_1.Text);
            cmd.Parameters.AddWithValue("@petCate", comBoxPetCate.Text);
            cmd.Parameters.AddWithValue("@Quentity", txtQuentity.Text);
            cmd.Parameters.AddWithValue("@FoodCate", comBoxFoodCate.Text);

            con.Open();
            //int i = cmd.ExecuteNonQuery();
            var i = cmd.ExecuteNonQuery();
            con.Close();
            if (i != 0)
            {
                MessageBox.Show("Data saved");
                txtFoodName_1.Text = "";
                txtQuentity.Text = "";
            }
        }
    }
}
