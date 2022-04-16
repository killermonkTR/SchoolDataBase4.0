//By recep diren ozkan

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
    public partial class LoginPage : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\diren\source\repos\SchoolDataBase4.0\SchoolDataBase4.0\Database1.mdf;Integrated Security=True");
        
        public LoginPage()
        {
            InitializeComponent();
        }

       
        //works with no problem
        private void Login_Click(object sender, EventArgs e)
        {
            
            string query = "Select * from LoginTable Where username ='"  + textBox1.Text.Trim() + "' and password = '" + textBox2.Text.Trim() + " ' ";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dtbl = new DataTable();
            //crashes here if problem with the collaction in string query
            sda.Fill(dtbl); 
            if (dtbl.Rows.Count == 1)
            {
                DataBase f2 = new DataBase();
                this.Hide();
                f2.Show();


            }
            else
            {
                MessageBox.Show("The username and/or password is incorrect");
            }
            
        }

        private void PassChange_Click(object sender, EventArgs e)
        {
            con.Open();

            SqlCommand cmd = new SqlCommand("Select * from LoginTable Where username='" + textBox1.Text.Trim() + "' and password = '" + textBox2.Text.Trim() + " ' ");
            
            SqlDataReader dr = cmd.ExecuteReader();
            //tova ma nervi mnogo >:(
            if (dr.Read())
            {
                MessageBox.Show("Password Changed Successfuly!");

            }
            else
            {
                MessageBox.Show("The username and/or password is incorrect for the change");
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                con.Open(); 
                MessageBox.Show("Connection is active!");
            }
            catch (Exception ex)
            { MessageBox.Show(ex.ToString()); }
        }
    }
}
