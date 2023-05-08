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
using PetLibrary.Model;
using System.Drawing.Printing;

namespace Pet_Food_Shop
{
    
    public partial class payments : Form
    {
        public static float calculate;
        public static string cusname;
        public static string petCate;
        public static string amount;
        public static string foodcate;
        

        public payments()
        {
            InitializeComponent();
            PetCate();
            GetFoodCate();


        }

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

            txt_PetCategory.DataSource = ds.Tables[0];
            txt_PetCategory.DisplayMember = "name";
            txt_PetCategory.ValueMember = "id";
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

            txtFoodCate.DataSource = ds.Tables[0];
            txtFoodCate.DisplayMember = "Name";
            txtFoodCate.ValueMember = "Id";
        }
        
        private void saveCustomer()
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\BIT\2 sem\projecte\Pet_Food_Shop\PetShopDataBase.mdf;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("sp_insert_CustomerInfo", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Name", txtCustomerName.Text);
            cmd.Parameters.AddWithValue("@PhoneNumber", txtCustomerPhoneNo.Text);
            cmd.Parameters.AddWithValue("@EmailAddress", txtEmailAddress.Text);

            

            con.Open();
            int i = cmd.ExecuteNonQuery();

            con.Close();

            if (i != 0)
            {
                //MessageBox.Show("Data Saved to customer");
                
            }
        }


        private void billcal()
        {
            //SqlConnection
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\BIT\2 sem\projecte\Pet_Food_Shop\PetShopDataBase.mdf;Integrated Security=True");
            SqlCommand cmdb = new SqlCommand("sp_insert_Bill", con);
            
            cmdb.CommandType = CommandType.StoredProcedure;
            cmdb.Parameters.AddWithValue("@PetCategory", txt_PetCategory.Text);
            cmdb.Parameters.AddWithValue("@FoodCategory", txtFoodCate.Text);
            cmdb.Parameters.AddWithValue("@Amount", txtAmount.Text);
            cmdb.Parameters.AddWithValue("@Price", txtPrize_01.Text);
            cmdb.Parameters.AddWithValue("@total", calculate);
            
            con.Open();
            int i = cmdb.ExecuteNonQuery();

            con.Close();

            if (i != 0)
            {
                //MessageBox.Show("Data Saved to bill");
                
                float amount = int.Parse(txtAmount.Text);
                float price = float.Parse(txtPrize_01.Text);
                

                float calculate1 = amount * price;
                calculate = calculate1;
                //MessageBox.Show(calculate.ToString());
                //txtTotalAmount.Text = calculate.ToString();




            }
        }

        private void btnBill_Click(object sender, EventArgs e)
        {
            saveCustomer();
            billcal();

            cusname = txtCustomerName.Text;
            petCate = txt_PetCategory.Text;
            amount = txtAmount.Text;

            

            bill bills = new bill();
            bills.ShowDialog();

            txtCustomerName.Text = "";
            txtCustomerPhoneNo.Text = "";
            txtEmailAddress.Text = "";

            txt_PetCategory.Text = "";
            txtFoodCate.Text = "";
            txtAmount.Text = "";
            txtPrize_01.Text = "";
        }

        private void txtFoodCate_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        
        
    }
}
