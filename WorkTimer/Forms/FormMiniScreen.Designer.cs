namespace WorkTimer.Forms
{
    partial class FormMiniScreen
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMiniScreen));
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonEdit1 = new System.Windows.Forms.Button();
            this.buttonReset1 = new System.Windows.Forms.Button();
            this.buttonPlayPause1 = new System.Windows.Forms.Button();
            this.labelTimeSpan1 = new System.Windows.Forms.Label();
            this.labelName1 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.buttonEdit1);
            this.panel1.Controls.Add(this.buttonReset1);
            this.panel1.Controls.Add(this.buttonPlayPause1);
            this.panel1.Controls.Add(this.labelTimeSpan1);
            this.panel1.Controls.Add(this.labelName1);
            this.panel1.Controls.Add(this.progressBar1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 92);
            this.panel1.TabIndex = 0;
            // 
            // buttonEdit1
            // 
            this.buttonEdit1.BackColor = System.Drawing.Color.Transparent;
            this.buttonEdit1.BackgroundImage = global::WorkTimer.Properties.Resources.info;
            this.buttonEdit1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonEdit1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonEdit1.Location = new System.Drawing.Point(227, 67);
            this.buttonEdit1.Name = "buttonEdit1";
            this.buttonEdit1.Size = new System.Drawing.Size(21, 23);
            this.buttonEdit1.TabIndex = 10;
            this.buttonEdit1.UseVisualStyleBackColor = false;
            this.buttonEdit1.Click += new System.EventHandler(this.buttonEdit1_Click);
            // 
            // buttonReset1
            // 
            this.buttonReset1.BackColor = System.Drawing.Color.White;
            this.buttonReset1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonReset1.Location = new System.Drawing.Point(184, 40);
            this.buttonReset1.Name = "buttonReset1";
            this.buttonReset1.Size = new System.Drawing.Size(64, 23);
            this.buttonReset1.TabIndex = 8;
            this.buttonReset1.Text = "Reset";
            this.buttonReset1.UseVisualStyleBackColor = false;
            this.buttonReset1.Click += new System.EventHandler(this.buttonReset1_Click);
            // 
            // buttonPlayPause1
            // 
            this.buttonPlayPause1.BackColor = System.Drawing.Color.White;
            this.buttonPlayPause1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonPlayPause1.Location = new System.Drawing.Point(184, 11);
            this.buttonPlayPause1.Name = "buttonPlayPause1";
            this.buttonPlayPause1.Size = new System.Drawing.Size(64, 23);
            this.buttonPlayPause1.TabIndex = 9;
            this.buttonPlayPause1.Text = "Başlat";
            this.buttonPlayPause1.UseVisualStyleBackColor = false;
            this.buttonPlayPause1.Click += new System.EventHandler(this.buttonPlayPause1_Click);
            // 
            // labelTimeSpan1
            // 
            this.labelTimeSpan1.AutoSize = true;
            this.labelTimeSpan1.Font = new System.Drawing.Font("Microsoft PhagsPa", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelTimeSpan1.ForeColor = System.Drawing.Color.White;
            this.labelTimeSpan1.Location = new System.Drawing.Point(2, 25);
            this.labelTimeSpan1.Name = "labelTimeSpan1";
            this.labelTimeSpan1.Size = new System.Drawing.Size(157, 44);
            this.labelTimeSpan1.TabIndex = 7;
            this.labelTimeSpan1.Text = "00:00:00";
            // 
            // labelName1
            // 
            this.labelName1.AutoSize = true;
            this.labelName1.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelName1.ForeColor = System.Drawing.Color.White;
            this.labelName1.Location = new System.Drawing.Point(5, 2);
            this.labelName1.Name = "labelName1";
            this.labelName1.Size = new System.Drawing.Size(97, 25);
            this.labelName1.TabIndex = 6;
            this.labelName1.Text = "Görev Adı";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(7, 74);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(214, 13);
            this.progressBar1.TabIndex = 5;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 77;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FormMiniScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(250, 92);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMiniScreen";
            this.Opacity = 0.9D;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "FormMiniScreen";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FormMiniScreen_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Button buttonEdit1;
        private Button buttonReset1;
        private Button buttonPlayPause1;
        private Label labelTimeSpan1;
        private Label labelName1;
        private ProgressBar progressBar1;
        private System.Windows.Forms.Timer timer1;
    }
}