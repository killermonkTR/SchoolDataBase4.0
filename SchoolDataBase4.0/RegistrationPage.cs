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
    public partial class RegistrationPage : Form
    {

        public RegistrationPage()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\diren\source\repos\SchoolDataBase4.0\SchoolDataBase4.0\Database1.mdf;Integrated Security=True");
        //idk why i even have this here, will check later
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\diren\source\repos\SchoolDataBase4.0\SchoolDataBase4.0\Database1.mdf;Integrated Security=True";


        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            if (Usernametxt.Text == "" || Passwordtxt.Text == "" || Emailtxt.Text == "" || ConfirmPasswordtxt.Text == "")
            {
                MessageBox.Show("Fill all the fields!");
            }
            else if (Passwordtxt.Text != ConfirmPasswordtxt.Text)
            { MessageBox.Show("Doesnt match"); }
            else { }
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand sqlCmd = new SqlCommand("UserAdd", con);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@username", Usernametxt.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@password", Usernametxt.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@email", Emailtxt.Text.Trim());
                sqlCmd.ExecuteNonQuery();
                MessageBox.Show("Acccount Created");
                Clear();
                con.Close();
            }
        }
        void Clear()
        { Usernametxt.Text = Passwordtxt.Text = Emailtxt.Text = ConfirmPasswordtxt.Text = "";
            label6.Visible = true; label7.Visible = true; label8.Visible = true; label9.Visible = true;
        }


        private void button2_Click(object sender, EventArgs e)
        {
            LoginPage f1 = new LoginPage();
            f1.Show();
            this.Close();

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedStateChanged(object sender, EventArgs e)
        {
            RegisterBtn.Visible = true;
        }
        // !! problem with this is if clicked removes the data entered aka if the person wants to select something or go back, it just deletes everything.
        private void UsernameClick(object sender, EventArgs e)
        {
            { label6.Visible = false; }
        }
        private void EmailClick(object sender, EventArgs e)
        {
            { label7.Visible = false; }
        }
        private void PasswordClick(object sender, EventArgs e)
        {
            { label8.Visible = false; }
        }
        private void PasswordConfirmClick(object sender, EventArgs e)
        {
            { label9.Visible = false; }
        }
    }
}

