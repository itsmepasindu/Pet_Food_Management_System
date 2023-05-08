
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
    public partial class addNewCategory : Form
    {
        public addNewCategory()
        {
            InitializeComponent();
        }

        private void btnClose_1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSaveNewCategory_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\BIT\2 sem\ICT Project\Pet_Food_Shop\PetShopDataBase.mdf;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("sp_insert_Category", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@name", textCategoryName_1.Text);

            con.Open();
            int i = cmd.ExecuteNonQuery();

            con.Close();

            if (i != 0)
            {
                MessageBox.Show("Data Saved");
                textCategoryName_1.Text = "";
            }
        }
    }
}
