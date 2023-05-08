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
    public partial class ViewFoods : Form
    {
        public ViewFoods()
        {
            InitializeComponent();

            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\BIT\2 sem\projecte\Pet_Food_Shop\PetShopDataBase.mdf;Integrated Security=True";
            //con.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\BIT\2 sem\ICT Project\Pet_Food_Shop\PetShopDataBase.mdf;Integrated Security=True";

            SqlCommand cmd = new SqlCommand("select * from Foods", con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            BindingSource ValueTuple = new BindingSource();
            ValueTuple.DataSource = dr;

            viewFoodsDataGirdView_01.DataSource = ValueTuple;
            con.Close();
        }
    }
}
