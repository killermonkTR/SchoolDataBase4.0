using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolDataBase4._0
{
    
    
    public partial class AdminControl : Form
    {
        public AdminControl()
        {
            InitializeComponent();

        }
        private void AdminClose(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        LoginPage f1 = new LoginPage();
        ResetPasswordPage f3 = new ResetPasswordPage();

        private void button1_Click(object sender, EventArgs e)
        {
            
            f1.Show();
            f1.panel1.Visible = false;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            
            f1.panel1.Visible = false; 
        }
        private void button3_Click(object sender, EventArgs e)
        {
            RegistrationPage f4 = new RegistrationPage();
            f4.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            f1.panel1.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
            f3.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            f3.Show();
            f3.panel1.Visible = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            AppPage f2 = new AppPage();
            f2.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            f3.panel1.Visible = false;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            LoginPage f1 = new LoginPage();
            button9.Click += f1.clicked;
        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void SignOutbtn_Click(object sender, EventArgs e)
        {
            LoginPage f1 = new LoginPage();
            f1.Show();
            this.Hide();

        }
    }
}
