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
    public partial class ResetPasswordPage : Form
    {
        public ResetPasswordPage()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\diren\source\repos\SchoolDataBase4.0\SchoolDataBase4.0\Database1.mdf;Integrated Security=True");

        private void button1_Click(object sender, EventArgs e)
        {
            //checks for the ID of user and then removes the panel
            //check old password and username
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from LoginTable where username='" + txtusername.Text + "'", con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                panel1.Visible = true;
            }
            else
            {
                MessageBox.Show("Incorrect credentials!");
            }
            dr.Close();
            con.Close();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox3.Text == textBox4.Text)
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("update LoginTable set password='" + textBox3.Text + "' where username ='" + txtusername + "'", con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Password Changed");
                
                this.Close();
            }
            else
            {
                MessageBox.Show("Password has not Changed, not matching!");
            }
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}
