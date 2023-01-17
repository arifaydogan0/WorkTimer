using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WorkTimer.Models;

namespace WorkTimer.Forms
{
    public partial class FormEdit : Form
    {
        Job job { get; set; }
        byte line { get; set; }
        public FormEdit(Job job, byte line)
        {
            InitializeComponent();
            this.job = job;
            this.line = line;
        }

        private void FormEdit_Load(object sender, EventArgs e)
        {
            textBox1.Text = job.Name;
            comboBox1.Text = job.TotalTime.ToString()[0] + job.TotalTime.ToString()[1].ToString();
            comboBox2.Text = job.TotalTime.ToString()[3] + job.TotalTime.ToString()[4].ToString();
            comboBox3.Text = job.TotalTime.ToString()[6] + job.TotalTime.ToString()[7].ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            job.Name = textBox1.Text;
            job.TotalTime = !(comboBox1.Text == comboBox2.Text && comboBox1.Text == comboBox3.Text && comboBox3.Text == "00") ? TimeSpan.Parse($"{comboBox1.Text}:{comboBox2.Text}:{comboBox3.Text}") : TimeSpan.Parse($"{comboBox1.Text}:{comboBox2.Text}:05");
            job.RemainingTime = job.TotalTime;

            List<string> satirlar = new List<string>();
            using (StreamReader sr = new(Paths.Paths.ConfigFilePath))
            {
                while (!sr.EndOfStream)
                    satirlar.Add(sr.ReadLine() ?? "");
            }
            File.Delete(Paths.Paths.ConfigFilePath);
            satirlar[line] = $"{job.Name}>>>{job.TotalTime}>>>{job.RemainingTime}";
            using (StreamWriter sw = new(Paths.Paths.ConfigFilePath))
            {
                foreach (var satir in satirlar)
                    sw.WriteLine(satir);
            }

            this.Close();
        }
    }
}
