

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

namespace SchoolDataBase4._0
{

    public partial class AppPage : Form
    {

        public AppPage()
        {

            InitializeComponent();

        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\diren\source\repos\SchoolDataBase4.0\SchoolDataBase4.0\Database1.mdf;Integrated Security=True");

        private void DataBase_Load(object sender, EventArgs e)
        {
            
            //this.Hide();
        }
        private void SignOutBtn_Click(object sender, EventArgs e)
        {
            LoginPage f1 = new LoginPage();
            this.Hide();
            f1.Show();
        }
        private void AppPage_Closing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }

        private void CoinFlip_Click(object sender, EventArgs e)
        {
            CoinFlipper f5 = new CoinFlipper();
            this.Hide();
            f5.Show();
        }
    }
}
