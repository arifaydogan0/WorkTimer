using System;

namespace WorkTimer.Forms
{
    public partial class FormMiniScreen : Form
    {
        private FormScreen fs = new();
        public FormMiniScreen()
        {
            InitializeComponent();
        }

        private void FormMiniScreen_Load(object sender, EventArgs e)
        {
            this.Location = new((Screen.AllScreens[0].WorkingArea.Width - this.Width - 15), 20);
            fs.Show();
            this.Visible = false;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            fs.Visible = (fs.ActivePanel == 0) && fs.IsVisible;
            this.Visible = fs.ActivePanel != 0;
            if (DateTime.Now.Hour == 23 && DateTime.Now.Minute == 59 && DateTime.Now.Second == 59)
                Application.Restart();

            panel1.BackColor = fs.ActivePanel == 1 ? fs.panel1.BackColor
                : (fs.ActivePanel == 2 ? fs.panel2.BackColor
                    : (fs.ActivePanel == 3 ? fs.panel3.BackColor
                        : (fs.ActivePanel == 4 ? fs.panel4.BackColor
                            : (fs.ActivePanel == 5 ? fs.panel5.BackColor
                                : panel1.BackColor))));

            labelName1.Text = fs.ActivePanel == 1 ? fs.labelName1.Text
                : (fs.ActivePanel == 2 ? fs.labelName2.Text
                    : (fs.ActivePanel == 3 ? fs.labelName3.Text
                        : (fs.ActivePanel == 4 ? fs.labelName4.Text
                            : (fs.ActivePanel == 5 ? fs.labelName5.Text
                                : labelName1.Text))));

            labelTimeSpan1.Text = fs.ActivePanel == 1 ? fs.labelTimeSpan1.Text
                : (fs.ActivePanel == 2 ? fs.labelTimeSpan2.Text
                    : (fs.ActivePanel == 3 ? fs.labelTimeSpan3.Text
                        : (fs.ActivePanel == 4 ? fs.labelTimeSpan4.Text
                            : (fs.ActivePanel == 5 ? fs.labelTimeSpan5.Text
                                : labelTimeSpan1.Text))));

            buttonPlayPause1.Text = fs.ActivePanel == 1 ? fs.buttonPlayPause1.Text
                : (fs.ActivePanel == 2 ? fs.buttonPlayPause2.Text
                    : (fs.ActivePanel == 3 ? fs.buttonPlayPause3.Text
                        : (fs.ActivePanel == 4 ? fs.buttonPlayPause4.Text
                            : (fs.ActivePanel == 5 ? fs.buttonPlayPause5.Text
                                : buttonPlayPause1.Text))));

            buttonReset1.Text = fs.ActivePanel == 1 ? fs.buttonReset1.Text
                : (fs.ActivePanel == 2 ? fs.buttonReset2.Text
                    : (fs.ActivePanel == 3 ? fs.buttonReset3.Text
                        : (fs.ActivePanel == 4 ? fs.buttonReset4.Text
                            : (fs.ActivePanel == 5 ? fs.buttonReset5.Text
                                : buttonReset1.Text))));

            progressBar1.Value = fs.ActivePanel == 1 ? fs.progressBar1.Value
                : (fs.ActivePanel == 2 ? fs.progressBar2.Value
                    : (fs.ActivePanel == 3 ? fs.progressBar3.Value
                        : (fs.ActivePanel == 4 ? fs.progressBar4.Value
                            : (fs.ActivePanel == 5 ? fs.progressBar5.Value
                                : progressBar1.Value))));

        }

        private void buttonPlayPause1_Click(object sender, EventArgs e)
        {
            switch (fs.ActivePanel)
            {
                case 0: this.Hide(); break;
                case 1: fs.buttonPlayPause1_Click(sender, e); break;
                case 2: fs.buttonPlayPause2_Click(sender, e); break;
                case 3: fs.buttonPlayPause3_Click(sender, e); break;
                case 4: fs.buttonPlayPause4_Click(sender, e); break;
                case 5: fs.buttonPlayPause5_Click(sender, e); break;
            }
        }

        private void buttonReset1_Click(object sender, EventArgs e)
        {
            switch (fs.ActivePanel)
            {
                case 0: this.Hide(); break;
                case 1: fs.buttonReset1_Click(sender, e); break;
                case 2: fs.buttonReset2_Click(sender, e); break;
                case 3: fs.buttonReset3_Click(sender, e); break;
                case 4: fs.buttonReset4_Click(sender, e); break;
                case 5: fs.buttonReset5_Click(sender, e); break;
            }
        }

        private void buttonEdit1_Click(object sender, EventArgs e)
        {

        }

    }
}
