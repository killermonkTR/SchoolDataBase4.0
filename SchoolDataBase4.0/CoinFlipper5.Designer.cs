
namespace SchoolDataBase4._0
{
    partial class CoinFlipper
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CoinFlipper));
            this.CoinImage = new System.Windows.Forms.PictureBox();
            this.FlipBtn = new System.Windows.Forms.Button();
            this.HeadsLabel = new System.Windows.Forms.Label();
            this.TailsLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.CoinImage)).BeginInit();
            this.SuspendLayout();
            // 
            // CoinImage
            // 
            this.CoinImage.Image = global::SchoolDataBase4._0.Properties.Resources.Heads;
            this.CoinImage.Location = new System.Drawing.Point(23, 3);
            this.CoinImage.Name = "CoinImage";
            this.CoinImage.Size = new System.Drawing.Size(175, 176);
            this.CoinImage.TabIndex = 0;
            this.CoinImage.TabStop = false;
            this.CoinImage.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // FlipBtn
            // 
            this.FlipBtn.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FlipBtn.Location = new System.Drawing.Point(23, 182);
            this.FlipBtn.Name = "FlipBtn";
            this.FlipBtn.Size = new System.Drawing.Size(84, 29);
            this.FlipBtn.TabIndex = 1;
            this.FlipBtn.Text = "Flip";
            this.FlipBtn.UseVisualStyleBackColor = true;
            this.FlipBtn.Click += new System.EventHandler(this.FlipBtn_Click);
            // 
            // HeadsLabel
            // 
            this.HeadsLabel.AutoSize = true;
            this.HeadsLabel.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeadsLabel.Location = new System.Drawing.Point(105, 182);
            this.HeadsLabel.Name = "HeadsLabel";
            this.HeadsLabel.Size = new System.Drawing.Size(52, 16);
            this.HeadsLabel.TabIndex = 2;
            this.HeadsLabel.Text = "Heads:";
            // 
            // TailsLabel
            // 
            this.TailsLabel.AutoSize = true;
            this.TailsLabel.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TailsLabel.Location = new System.Drawing.Point(113, 198);
            this.TailsLabel.Name = "TailsLabel";
            this.TailsLabel.Size = new System.Drawing.Size(43, 16);
            this.TailsLabel.TabIndex = 3;
            this.TailsLabel.Text = "Tails:";
            // 
            // CoinFlipper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(221, 219);
            this.Controls.Add(this.TailsLabel);
            this.Controls.Add(this.HeadsLabel);
            this.Controls.Add(this.FlipBtn);
            this.Controls.Add(this.CoinImage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CoinFlipper";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CoinFlipper";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CoinFlipper_Closing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CoinFlipper_Closed);
            ((System.ComponentModel.ISupportInitialize)(this.CoinImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox CoinImage;
        private System.Windows.Forms.Button FlipBtn;
        private System.Windows.Forms.Label HeadsLabel;
        private System.Windows.Forms.Label TailsLabel;
    }
}