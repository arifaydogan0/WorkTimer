using System;
using System.Diagnostics.Eventing.Reader;
using WorkTimer.Models;

namespace WorkTimer.Forms
{
    public partial class FormScreen : Form
    {
        public static List<Job> Jobs { get; set; } = Job.Jobs;
        public byte ActivePanel = 0;
        public bool IsVisible = true;
        private bool CancelExit = true;
        public FormScreen()
        {
            InitializeComponent();
        }
        public void FormScreen_Load(object sender, EventArgs e)
        {
            this.Location = new((Screen.AllScreens[0].WorkingArea.Width - this.Width - 1), 3);
            SetComponents();
        }
        void SetComponents()
        {
            labelName1.Text = Jobs[0].Name;
            labelTimeSpan1.Text = Jobs[0].RemainingTime.ToString();

            labelName2.Text = Jobs[1].Name;
            labelTimeSpan2.Text = Jobs[1].RemainingTime.ToString();

            labelName3.Text = Jobs[2].Name;
            labelTimeSpan3.Text = Jobs[2].RemainingTime.ToString();

            labelName4.Text = Jobs[3].Name;
            labelTimeSpan4.Text = Jobs[3].RemainingTime.ToString();

            labelName5.Text = Jobs[4].Name;
            labelTimeSpan5.Text = Jobs[4].RemainingTime.ToString();
        }

        public void timer1_Tick(object sender, EventArgs e)
        {
            //label1.Text = DateTime.Now.ToLongDateString();
            //label2.Text = DateTime.Now.ToLongTimeString();
        }

        public void timerCounter_Tick(object sender, EventArgs e)
        {
            if (Jobs[0].IsContinue)
            {
                Jobs[0].RemainingTime -= new TimeSpan(0, 0, 0, 1);
                labelTimeSpan1.Text = Jobs[0].RemainingTime.ToString();
                progressBar1.Value = (int)(100 - ((decimal)Jobs[0].RemainingTime.TotalSeconds / (decimal)Jobs[0].TotalTime.TotalSeconds) * 100);
                if (Jobs[0].RemainingTime.TotalMilliseconds < 1000)
                {
                    panel2.Enabled = panel3.Enabled = panel4.Enabled = panel5.Enabled = true;
                    buttonPlayPause1.Enabled = false;
                    Jobs[0].IsCompleted = true;
                    Jobs[0].IsContinue = false;
                    panel1.BackColor = Color.DarkGreen;
                    ActivePanel = 0;
                    this.Opacity = 0.7d;
                    new FormComplete(Jobs[0]).ShowDialog();
                    this.Opacity = 1d;
                }
            }
            else if (Jobs[1].IsContinue)
            {
                Jobs[1].RemainingTime -= new TimeSpan(0, 0, 0, 1);
                labelTimeSpan2.Text = Jobs[1].RemainingTime.ToString();
                progressBar2.Value = (int)(100 - ((decimal)Jobs[1].RemainingTime.TotalSeconds / (decimal)Jobs[1].TotalTime.TotalSeconds) * 100);
                if (Jobs[1].RemainingTime.TotalMilliseconds < 1000)
                {
                    panel1.Enabled = panel3.Enabled = panel4.Enabled = panel5.Enabled = true;
                    buttonPlayPause2.Enabled = false;
                    Jobs[1].IsCompleted = true;
                    Jobs[1].IsContinue = false;
                    panel2.BackColor = Color.DarkGreen;
                    ActivePanel = 0;
                    this.Opacity = 0.7d;
                    new FormComplete(Jobs[1]).ShowDialog();
                    this.Opacity = 1d;
                }
            }
            else if (Jobs[2].IsContinue)
            {
                Jobs[2].RemainingTime -= new TimeSpan(0, 0, 0, 1);
                labelTimeSpan3.Text = Jobs[2].RemainingTime.ToString();
                progressBar3.Value = (int)(100 - ((decimal)Jobs[2].RemainingTime.TotalSeconds / (decimal)Jobs[2].TotalTime.TotalSeconds) * 100);
                if (Jobs[2].RemainingTime.TotalMilliseconds < 1000)
                {
                    panel1.Enabled = panel2.Enabled = panel4.Enabled = panel5.Enabled = true;
                    buttonPlayPause3.Enabled = false;
                    Jobs[2].IsCompleted = true;
                    Jobs[2].IsContinue = false;
                    panel3.BackColor = Color.DarkGreen;
                    ActivePanel = 0;
                    this.Opacity = 0.7d;
                    new FormComplete(Jobs[2]).ShowDialog();
                    this.Opacity = 1d;
                }
            }
            else if (Jobs[3].IsContinue)
            {
                Jobs[3].RemainingTime -= new TimeSpan(0, 0, 0, 1);
                labelTimeSpan4.Text = Jobs[3].RemainingTime.ToString();
                progressBar4.Value = (int)(100 - ((decimal)Jobs[3].RemainingTime.TotalSeconds / (decimal)Jobs[3].TotalTime.TotalSeconds) * 100);
                if (Jobs[3].RemainingTime.TotalMilliseconds < 1000)
                {
                    panel1.Enabled = panel2.Enabled = panel3.Enabled = panel5.Enabled = true;
                    buttonPlayPause4.Enabled = false;
                    Jobs[3].IsCompleted = true;
                    Jobs[3].IsContinue = false;
                    panel4.BackColor = Color.DarkGreen;
                    ActivePanel = 0;
                    this.Opacity = 0.7d;
                    new FormComplete(Jobs[3]).ShowDialog();
                    this.Opacity = 1d;
                }
            }
            else if (Jobs[4].IsContinue)
            {
                Jobs[4].RemainingTime -= new TimeSpan(0, 0, 0, 1);
                labelTimeSpan5.Text = Jobs[4].RemainingTime.ToString();
                progressBar5.Value = (int)(100 - ((decimal)Jobs[4].RemainingTime.TotalSeconds / (decimal)Jobs[4].TotalTime.TotalSeconds) * 100);
                if (Jobs[4].RemainingTime.TotalMilliseconds < 1000)
                {
                    panel1.Enabled = panel2.Enabled = panel3.Enabled = panel4.Enabled = true;
                    buttonPlayPause5.Enabled = false;
                    Jobs[4].IsCompleted = true;
                    Jobs[4].IsContinue = false;
                    panel5.BackColor = Color.DarkGreen;
                    ActivePanel = 0;
                    this.Opacity = 0.7d;
                    new FormComplete(Jobs[4]).ShowDialog();
                    this.Opacity = 1d;
                }
            }
        }

        public void buttonPlayPause1_Click(object sender, EventArgs e)
        {
            ActivePanel = 1;
            if (buttonPlayPause1.Text == "Başlat")
            {
                panel1.BackColor = panel1.BackColor != Color.DarkKhaki ? Color.DarkKhaki : panel1.BackColor;
                panel2.Enabled = panel3.Enabled = panel4.Enabled = panel5.Enabled = false;
                Jobs[0].IsStart = true;
                Jobs[0].IsContinue = true;
                buttonPlayPause1.Text = "Duraklat";
            }
            else if (buttonPlayPause1.Text == "Duraklat")
            {
                Jobs[0].IsContinue = false;
                buttonPlayPause1.Text = "Başlat";
            }
        }
        public void buttonReset1_Click(object sender, EventArgs e)
        {
            ActivePanel = 0;
            buttonPlayPause1.Text = "Başlat";
            panel1.BackColor = Color.DimGray;
            panel2.Enabled = panel3.Enabled = panel4.Enabled = panel5.Enabled = true;
            Jobs[0].IsStart = false;
            Jobs[0].IsContinue = false;
            Jobs[0].IsCompleted = false;
            Jobs[0].RemainingTime = Jobs[0].TotalTime;
            labelTimeSpan1.Text = Jobs[0].RemainingTime.ToString();
            progressBar1.Value = 0;
            buttonPlayPause1.Enabled = true;
        }

        public void buttonPlayPause2_Click(object sender, EventArgs e)
        {
            ActivePanel = 2;
            if (buttonPlayPause2.Text == "Başlat")
            {
                panel2.BackColor = panel2.BackColor != Color.DarkKhaki ? Color.DarkKhaki : panel2.BackColor;
                panel1.Enabled = panel3.Enabled = panel4.Enabled = panel5.Enabled = false;
                Jobs[1].IsStart = true;
                Jobs[1].IsContinue = true;
                buttonPlayPause2.Text = "Duraklat";
            }
            else if (buttonPlayPause2.Text == "Duraklat")
            {
                Jobs[1].IsContinue = false;
                buttonPlayPause2.Text = "Başlat";
            }
        }
        public void buttonReset2_Click(object sender, EventArgs e)
        {
            ActivePanel = 0;
            buttonPlayPause2.Text = "Başlat";
            panel2.BackColor = Color.DimGray;
            panel1.Enabled = panel3.Enabled = panel4.Enabled = panel5.Enabled = true;
            Jobs[1].IsStart = false;
            Jobs[1].IsContinue = false;
            Jobs[1].IsCompleted = false;
            Jobs[1].RemainingTime = Jobs[1].TotalTime;
            labelTimeSpan2.Text = Jobs[1].RemainingTime.ToString();
            progressBar2.Value = 0;
            buttonPlayPause2.Enabled = true;
        }

        public void buttonPlayPause3_Click(object sender, EventArgs e)
        {
            ActivePanel = 3;
            if (buttonPlayPause3.Text == "Başlat")
            {
                panel3.BackColor = panel3.BackColor != Color.DarkKhaki ? Color.DarkKhaki : panel3.BackColor;
                panel1.Enabled = panel2.Enabled = panel4.Enabled = panel5.Enabled = false;
                Jobs[2].IsStart = true;
                Jobs[2].IsContinue = true;
                buttonPlayPause3.Text = "Duraklat";
            }
            else if (buttonPlayPause3.Text == "Duraklat")
            {
                Jobs[2].IsContinue = false;
                buttonPlayPause3.Text = "Başlat";
            }
        }
        public void buttonReset3_Click(object sender, EventArgs e)
        {
            ActivePanel = 0;
            buttonPlayPause3.Text = "Başlat";
            panel3.BackColor = Color.DimGray;
            panel1.Enabled = panel2.Enabled = panel4.Enabled = panel5.Enabled = true;
            Jobs[2].IsStart = false;
            Jobs[2].IsContinue = false;
            Jobs[2].IsCompleted = false;
            Jobs[2].RemainingTime = Jobs[2].TotalTime;
            labelTimeSpan3.Text = Jobs[2].RemainingTime.ToString();
            progressBar3.Value = 0;
            buttonPlayPause3.Enabled = true;
        }

        public void buttonPlayPause4_Click(object sender, EventArgs e)
        {
            ActivePanel = 4;
            if (buttonPlayPause4.Text == "Başlat")
            {
                panel4.BackColor = panel4.BackColor != Color.DarkKhaki ? Color.DarkKhaki : panel4.BackColor;
                panel1.Enabled = panel2.Enabled = panel3.Enabled = panel5.Enabled = false;
                Jobs[3].IsStart = true;
                Jobs[3].IsContinue = true;
                buttonPlayPause4.Text = "Duraklat";
            }
            else if (buttonPlayPause4.Text == "Duraklat")
            {
                Jobs[3].IsContinue = false;
                buttonPlayPause4.Text = "Başlat";
            }
        }
        public void buttonReset4_Click(object sender, EventArgs e)
        {
            ActivePanel = 0;
            buttonPlayPause4.Text = "Başlat";
            panel4.BackColor = Color.DimGray;
            panel1.Enabled = panel2.Enabled = panel3.Enabled = panel5.Enabled = true;
            Jobs[3].IsStart = false;
            Jobs[3].IsContinue = false;
            Jobs[3].IsCompleted = false;
            Jobs[3].RemainingTime = Jobs[3].TotalTime;
            labelTimeSpan4.Text = Jobs[3].RemainingTime.ToString();
            progressBar4.Value = 0;
            buttonPlayPause4.Enabled = true;
        }

        public void buttonPlayPause5_Click(object sender, EventArgs e)
        {
            ActivePanel = 5;
            if (buttonPlayPause5.Text == "Başlat")
            {
                panel5.BackColor = panel5.BackColor != Color.DarkKhaki ? Color.DarkKhaki : panel5.BackColor;
                panel1.Enabled = panel2.Enabled = panel3.Enabled = panel4.Enabled = false;
                Jobs[4].IsStart = true;
                Jobs[4].IsContinue = true;
                buttonPlayPause5.Text = "Duraklat";
            }
            else if (buttonPlayPause5.Text == "Duraklat")
            {
                Jobs[4].IsContinue = false;
                buttonPlayPause5.Text = "Başlat";
            }
        }
        public void buttonReset5_Click(object sender, EventArgs e)
        {
            ActivePanel = 0;
            buttonPlayPause5.Text = "Başlat";
            panel5.BackColor = Color.DimGray;
            panel1.Enabled = panel2.Enabled = panel3.Enabled = panel4.Enabled = true;
            Jobs[4].IsStart = false;
            Jobs[4].IsContinue = false;
            Jobs[4].IsCompleted = false;
            Jobs[4].RemainingTime = Jobs[4].TotalTime;
            labelTimeSpan5.Text = Jobs[4].RemainingTime.ToString();
            progressBar5.Value = 0;
            buttonPlayPause5.Enabled = true;
        }

        public void buttonEdit1_Click(object sender, EventArgs e)
        {
            buttonReset1_Click(sender, e);
            new FormEdit(Jobs[0], 0).ShowDialog();
            Jobs = Job.Jobs;
            SetComponents();
        }

        public void buttonEdit2_Click(object sender, EventArgs e)
        {
            buttonReset2_Click(sender, e);
            new FormEdit(Jobs[1], 1).ShowDialog();
            Jobs = Job.Jobs;
            SetComponents();
        }

        public void buttonEdit3_Click(object sender, EventArgs e)
        {
            buttonReset3_Click(sender, e);
            new FormEdit(Jobs[2], 2).ShowDialog();
            Jobs = Job.Jobs;
            SetComponents();
        }

        public void buttonEdit4_Click(object sender, EventArgs e)
        {
            buttonReset4_Click(sender, e);
            new FormEdit(Jobs[3], 3).ShowDialog();
            Jobs = Job.Jobs;
            SetComponents();
        }

        public void buttonEdit5_Click(object sender, EventArgs e)
        {
            buttonReset5_Click(sender, e);
            new FormEdit(Jobs[4], 4).ShowDialog();
            Jobs = Job.Jobs;
            SetComponents();
        }

        private void gösterGizleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.IsVisible = !this.IsVisible;
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CancelExit = false;
            Application.Exit();
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.BringToFront();
        }

        private void FormScreen_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = CancelExit;
        }
    }
}
