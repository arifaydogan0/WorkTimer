using System;
using System.Media;
using System.Reflection;
using WorkTimer.Models;

namespace WorkTimer.Forms
{
    public partial class FormComplete : Form
    {
        private Job job;
        SoundPlayer soundPlayer;
        public FormComplete(Job job)
        {
            InitializeComponent();
            this.job = job;
            soundPlayer = new SoundPlayer();
            var x = new Random().Next(100) % 4;
            switch (x)
            {
                case 0: pictureBox1.Image = Properties.Resources.giphy; break;
                case 1: pictureBox1.Image = Properties.Resources.giphy__1_; break;
                case 2: pictureBox1.Image = Properties.Resources.giphy__2_; break;
                case 3: pictureBox1.Image = Properties.Resources.giphy__3_; break;
            }
        }

        private void FormComplete_Load(object sender, EventArgs e)
        {
            label1.Text = job.Name;
            soundPlayer.Stream = Properties.Resources.sound;
            soundPlayer.PlayLooping();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            soundPlayer.Stop();
            this.Close();
        }
    }
}
