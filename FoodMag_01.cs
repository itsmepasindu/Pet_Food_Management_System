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
    public partial class FoodMag_01 : Form
    {
        public FoodMag_01()
        {
            InitializeComponent();
        }

        private void btnAddFood_01_Click(object sender, EventArgs e)
        {
            AddFoods foods = new AddFoods();
            foods.ShowDialog();
        }

        private void btnViewFood_01_Click(object sender, EventArgs e)
        {
            ViewFoods view = new ViewFoods();
            view.ShowDialog();
        }

        private void FoodMag_01_Load(object sender, EventArgs e)
        {

        }

        private void btnAddFoodCate_Click(object sender, EventArgs e)
        {
            AddFoodCategory category = new AddFoodCategory();
            category.ShowDialog();
        }
    }
}
