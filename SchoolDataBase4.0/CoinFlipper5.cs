using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace SchoolDataBase4._0
{
    public partial class CoinFlipper : Form
    {
        public CoinFlipper()
        {
            InitializeComponent();
        }
        int heads = 0;
        int tails = 0;
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void FlipBtn_Click(object sender, EventArgs e)
        {
            Random CoinFlip = new Random();
            int result = CoinFlip.Next(1, 3);

            //Heads
            if(result == 1)
            {
                string RunningPath = AppDomain.CurrentDomain.BaseDirectory;
                string FileName = string.Format("{0}\\Resources\\Heads.png", Path.GetFullPath(Path.Combine(RunningPath, @"..\..\")));
                CoinImage.ImageLocation = FileName;
                heads++;
                HeadsLabel.Text = "Heads: " + heads.ToString();

            }
            //Tails
            else
            {
                string RunningPath = AppDomain.CurrentDomain.BaseDirectory;
                string FileName = string.Format("{0}\\Resources\\Tails.png", Path.GetFullPath(Path.Combine(RunningPath, @"..\..\")));
                CoinImage.ImageLocation = FileName;
                tails++;
                TailsLabel.Text = "Tails: " + tails.ToString();
            }
        }
        private void CoinFlipper_Closing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void CoinFlipper_Closed(object sender, FormClosedEventArgs e)
        {
            AppPage f2 = new AppPage();
            f2.Show();
            this.Hide();
        }
    }
}
