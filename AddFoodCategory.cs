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
    public partial class AddFoodCategory : Form
    {
        public AddFoodCategory()
        {
            InitializeComponent();
        }

        private void btnAddCate_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\BIT\2 sem\projecte\Pet_Food_Shop\PetShopDataBase.mdf;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("sp_insert_FoodCategory", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@name", txtFoodCateName_1.Text);

            con.Open();
            int i = cmd.ExecuteNonQuery();

            if(i != 0)
            {
                MessageBox.Show("Data saved");
                txtFoodCateName_1.Text = "";
            }
            
        }
    }
}
