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
    public partial class MonthlyReports : Form
    {
        public MonthlyReports()
        {
            InitializeComponent();

            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\BIT\2 sem\projecte\Pet_Food_Shop\PetShopDataBase.mdf;Integrated Security=True";

            SqlCommand cmd = new SqlCommand("select * from Bill;", con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            BindingSource source = new BindingSource();
            source.DataSource = dr;

            monthlyReportView_01.DataSource = source;
            con.Close();
        }
    }
}
