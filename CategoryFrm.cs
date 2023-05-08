using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pet_Food_Shop
{
    public partial class CategoryFrm : Form
    {
        public CategoryFrm(string text)
        {
            InitializeComponent();
        }

        private void btnAdd_new_category_A_Click(object sender, EventArgs e)
        {
            addNewCategory addNewCategory = new addNewCategory();
            addNewCategory.ShowDialog();
        }

        private void btnViewCategory_A_Click(object sender, EventArgs e)
        {
            View_Catagory view_Catagory = new View_Catagory();
            view_Catagory.ShowDialog();
        }
    }
}
