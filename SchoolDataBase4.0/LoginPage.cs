//By recep diren ozkan

/*Just make a simple SQL server if needed using 
 * CREATE TABLE [dbo].[Table]
(   [Id] INT NOT NULL PRIMARY KEY IDENTITY,
    [username] VARCHAR(50) NOT NULL,
    [email] VARCHAR(50) NOT NULL,
    [password] VARCHAR(50) NOT NULL)   */

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
        
        private int clickcount = 0;
        public LoginPage()
        {
            InitializeComponent();
            Login.Click += clicked;
        }
        public void clicked(object sender, EventArgs e)
        {
            if (++clickcount == 4)
            {
                MessageBox.Show("You might wanna check that up again.", "Incorrect Credentials");
            }
           else if (clickcount == 6)
            {
                MessageBox.Show("You sure that's your password?", "Incorrect Credentials");
            }
            else if (clickcount == 8)
            {
                MessageBox.Show("AW man, just reset your password at this point.", "Incorrect Credentials");
            }
            else if (clickcount == 10)
            {
                MessageBox.Show("You're still going???", "Incorrect Credentials");
            }
            else if (clickcount == 11)
            {
                MessageBox.Show("DUDE JUST CHANGE YOUR PASSWORD, IT'S NOT THAT HARD!!", "Incorrect Credentials");
            }
            else if (clickcount == 12)
            {
                MessageBox.Show("okay, ill do it for you dumbass, just email me: serhyundaibuca@gmail.com ", "Incorrect Credentials");
            }
            else if (clickcount == 13)
            {
                MessageBox.Show("Really??? Don't you dare to try again.", "Incorrect Credentials");
            }
            else if (clickcount == 14)
            {
                MessageBox.Show("Yeah F you, bye", "F**k you >:c");
                con.Close();
                Environment.Exit(1);
            }

        }

        //works with no problem
        //login
        private void Login_Click(object sender, EventArgs e)
        {
            
            if(Usernametxt.Text =="a" && Passwordtxt.Text =="a")
            { 
               
             AdminControl f12 = new AdminControl();
                this.Hide();
                f12.Show();
            }
            else {
                string query = "Select * from LoginTable Where username ='" + Usernametxt.Text.Trim() + "' and password = '" + Passwordtxt.Text.Trim() + " ' ";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                DataTable dtbl = new DataTable();
                //crashes here if problem with the connection in string query
                sda.Fill(dtbl);
                if (dtbl.Rows.Count == 1)
                {
                    AppPage f2 = new AppPage();
                    this.Hide();
                    f2.Show();
                    con.Close();

                }
                else
                {
                    MessageBox.Show("The username and/or password is incorrect", "Incorrect Credentials");
                }
            }
        }
        //password change
        private void PassChange_Click(object sender, EventArgs e)
        {
            RegistrationPage f3 = new RegistrationPage();
            f3.Show();
            
        }
        
        
        
        private void LoginPage_Load(object sender, EventArgs e)
        {   //Connection test
            try
            {
                con.Open();
                panel1.Visible = true;
                con.Close();
            }
            catch (Exception ex)
            { MessageBox.Show(ex.ToString()); }
        }

        private void LoginPage_Closing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
             if (MessageBox.Show("Exit or no?","Exit Application", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
        {
                con.Close();
                this.Close();
                Environment.Exit(1);   }
        }

    }
}
