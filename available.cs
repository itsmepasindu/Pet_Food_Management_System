using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pet_Food_Shop
{
    public partial class available : Form
    {
        private void PetCate()
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

            comboBox2.DataSource = ds.Tables[0];
            comboBox2.DisplayMember = "name";
            comboBox2.ValueMember = "id";
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

            comboBox1.DataSource = ds.Tables[0];
            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "Id";
        }
        public available()
        {
            InitializeComponent();

            PetCate();
            GetFoodCate();

        }
        /*
          [Id]       INT            IDENTITY (1, 1) NOT NULL,
          [name]     NVARCHAR (150) NOT NULL,
          [petCate]  NVARCHAR (150) NOT NULL,
          [Quentity] INT            NOT NULL,
          [FoodCate] NVARCHAR (150) NOT NULL,
          PRIMARY KEY CLUSTERED ([Id] ASC)
        */
        private void check_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\BIT\2 sem\projecte\Pet_Food_Shop\PetShopDataBase.mdf;Integrated Security=True";

            string petcate = comboBox1.Text;
            string foodcate = comboBox2.Text;

            con.Open();
            string query = "SELECT Quentity From Foods WHERE petCate = @petcategory AND FoodCate = @Foodcategory";
            
             
            SqlCommand command = new SqlCommand(query, con);
            command.Parameters.AddWithValue("@petcategory", petcate);
            command.Parameters.AddWithValue("@Foodcategory", foodcate);

            SqlDataReader reader = command.ExecuteReader();

            

            if (reader.Read())
            {
                
                lblAvailable.Text = reader["Quentity"].ToString();;
            }
            else
            {
                
                lblAvailable.Text = "No items found";
            }


            con.Close();

            
        }
    }
}
