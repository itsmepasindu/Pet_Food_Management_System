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
    public partial class report : Form
    {
        public report()
        {
            InitializeComponent();


        }

        private void DayReport()
        {
            
        }

        private void btnDailyReport_A_Click(object sender, EventArgs e)
        {
            dailyReports day = new dailyReports();
            day.ShowDialog();
        }

        private void btnMonthlyReport_A_Click(object sender, EventArgs e)
        {
            MonthlyReports monthly = new MonthlyReports();
            monthly.ShowDialog();
        }

        
    }
}
