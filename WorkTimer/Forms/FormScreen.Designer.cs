namespace WorkTimer.Forms
{
    partial class FormScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormScreen));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.buttonEdit5 = new System.Windows.Forms.Button();
            this.buttonReset5 = new System.Windows.Forms.Button();
            this.buttonPlayPause5 = new System.Windows.Forms.Button();
            this.labelTimeSpan5 = new System.Windows.Forms.Label();
            this.labelName5 = new System.Windows.Forms.Label();
            this.progressBar5 = new System.Windows.Forms.ProgressBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonEdit1 = new System.Windows.Forms.Button();
            this.buttonReset1 = new System.Windows.Forms.Button();
            this.buttonPlayPause1 = new System.Windows.Forms.Button();
            this.labelTimeSpan1 = new System.Windows.Forms.Label();
            this.labelName1 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonEdit2 = new System.Windows.Forms.Button();
            this.buttonReset2 = new System.Windows.Forms.Button();
            this.buttonPlayPause2 = new System.Windows.Forms.Button();
            this.labelTimeSpan2 = new System.Windows.Forms.Label();
            this.labelName2 = new System.Windows.Forms.Label();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.panel3 = new System.Windows.Forms.Panel();
            this.buttonEdit3 = new System.Windows.Forms.Button();
            this.buttonReset3 = new System.Windows.Forms.Button();
            this.buttonPlayPause3 = new System.Windows.Forms.Button();
            this.labelTimeSpan3 = new System.Windows.Forms.Label();
            this.labelName3 = new System.Windows.Forms.Label();
            this.progressBar3 = new System.Windows.Forms.ProgressBar();
            this.panel4 = new System.Windows.Forms.Panel();
            this.buttonEdit4 = new System.Windows.Forms.Button();
            this.buttonReset4 = new System.Windows.Forms.Button();
            this.buttonPlayPause4 = new System.Windows.Forms.Button();
            this.labelTimeSpan4 = new System.Windows.Forms.Label();
            this.labelName4 = new System.Windows.Forms.Label();
            this.progressBar4 = new System.Windows.Forms.ProgressBar();
            this.timerCounter = new System.Windows.Forms.Timer(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.gösterGizleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel5, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 0, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(2, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(256, 492);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel5.Controls.Add(this.buttonEdit5);
            this.panel5.Controls.Add(this.buttonReset5);
            this.panel5.Controls.Add(this.buttonPlayPause5);
            this.panel5.Controls.Add(this.labelTimeSpan5);
            this.panel5.Controls.Add(this.labelName5);
            this.panel5.Controls.Add(this.progressBar5);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(3, 395);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(250, 94);
            this.panel5.TabIndex = 4;
            // 
            // buttonEdit5
            // 
            this.buttonEdit5.BackColor = System.Drawing.Color.Transparent;
            this.buttonEdit5.BackgroundImage = global::WorkTimer.Properties.Resources.info;
            this.buttonEdit5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonEdit5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonEdit5.Location = new System.Drawing.Point(222, 65);
            this.buttonEdit5.Name = "buttonEdit5";
            this.buttonEdit5.Size = new System.Drawing.Size(21, 23);
            this.buttonEdit5.TabIndex = 5;
            this.buttonEdit5.UseVisualStyleBackColor = false;
            this.buttonEdit5.Click += new System.EventHandler(this.buttonEdit5_Click);
            // 
            // buttonReset5
            // 
            this.buttonReset5.BackColor = System.Drawing.Color.White;
            this.buttonReset5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonReset5.Location = new System.Drawing.Point(179, 38);
            this.buttonReset5.Name = "buttonReset5";
            this.buttonReset5.Size = new System.Drawing.Size(64, 23);
            this.buttonReset5.TabIndex = 3;
            this.buttonReset5.Text = "Reset";
            this.buttonReset5.UseVisualStyleBackColor = false;
            this.buttonReset5.Click += new System.EventHandler(this.buttonReset5_Click);
            // 
            // buttonPlayPause5
            // 
            this.buttonPlayPause5.BackColor = System.Drawing.Color.White;
            this.buttonPlayPause5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonPlayPause5.Location = new System.Drawing.Point(179, 9);
            this.buttonPlayPause5.Name = "buttonPlayPause5";
            this.buttonPlayPause5.Size = new System.Drawing.Size(64, 23);
            this.buttonPlayPause5.TabIndex = 3;
            this.buttonPlayPause5.Text = "Başlat";
            this.buttonPlayPause5.UseVisualStyleBackColor = false;
            this.buttonPlayPause5.Click += new System.EventHandler(this.buttonPlayPause5_Click);
            // 
            // labelTimeSpan5
            // 
            this.labelTimeSpan5.AutoSize = true;
            this.labelTimeSpan5.Font = new System.Drawing.Font("Microsoft PhagsPa", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelTimeSpan5.ForeColor = System.Drawing.Color.White;
            this.labelTimeSpan5.Location = new System.Drawing.Point(-3, 23);
            this.labelTimeSpan5.Name = "labelTimeSpan5";
            this.labelTimeSpan5.Size = new System.Drawing.Size(157, 44);
            this.labelTimeSpan5.TabIndex = 2;
            this.labelTimeSpan5.Text = "00:00:00";
            // 
            // labelName5
            // 
            this.labelName5.AutoSize = true;
            this.labelName5.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelName5.ForeColor = System.Drawing.Color.White;
            this.labelName5.Location = new System.Drawing.Point(0, 0);
            this.labelName5.Name = "labelName5";
            this.labelName5.Size = new System.Drawing.Size(97, 25);
            this.labelName5.TabIndex = 1;
            this.labelName5.Text = "Görev Adı";
            // 
            // progressBar5
            // 
            this.progressBar5.Location = new System.Drawing.Point(2, 72);
            this.progressBar5.Name = "progressBar5";
            this.progressBar5.Size = new System.Drawing.Size(214, 13);
            this.progressBar5.TabIndex = 0;
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
            this.panel1.Location = new System.Drawing.Point(3, 3);
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
            this.buttonEdit1.Location = new System.Drawing.Point(222, 65);
            this.buttonEdit1.Name = "buttonEdit1";
            this.buttonEdit1.Size = new System.Drawing.Size(21, 23);
            this.buttonEdit1.TabIndex = 4;
            this.buttonEdit1.UseVisualStyleBackColor = false;
            this.buttonEdit1.Click += new System.EventHandler(this.buttonEdit1_Click);
            // 
            // buttonReset1
            // 
            this.buttonReset1.BackColor = System.Drawing.Color.White;
            this.buttonReset1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonReset1.Location = new System.Drawing.Point(179, 38);
            this.buttonReset1.Name = "buttonReset1";
            this.buttonReset1.Size = new System.Drawing.Size(64, 23);
            this.buttonReset1.TabIndex = 3;
            this.buttonReset1.Text = "Reset";
            this.buttonReset1.UseVisualStyleBackColor = false;
            this.buttonReset1.Click += new System.EventHandler(this.buttonReset1_Click);
            // 
            // buttonPlayPause1
            // 
            this.buttonPlayPause1.BackColor = System.Drawing.Color.White;
            this.buttonPlayPause1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonPlayPause1.Location = new System.Drawing.Point(179, 9);
            this.buttonPlayPause1.Name = "buttonPlayPause1";
            this.buttonPlayPause1.Size = new System.Drawing.Size(64, 23);
            this.buttonPlayPause1.TabIndex = 3;
            this.buttonPlayPause1.Text = "Başlat";
            this.buttonPlayPause1.UseVisualStyleBackColor = false;
            this.buttonPlayPause1.Click += new System.EventHandler(this.buttonPlayPause1_Click);
            // 
            // labelTimeSpan1
            // 
            this.labelTimeSpan1.AutoSize = true;
            this.labelTimeSpan1.Font = new System.Drawing.Font("Microsoft PhagsPa", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelTimeSpan1.ForeColor = System.Drawing.Color.White;
            this.labelTimeSpan1.Location = new System.Drawing.Point(-3, 23);
            this.labelTimeSpan1.Name = "labelTimeSpan1";
            this.labelTimeSpan1.Size = new System.Drawing.Size(157, 44);
            this.labelTimeSpan1.TabIndex = 2;
            this.labelTimeSpan1.Text = "00:00:00";
            // 
            // labelName1
            // 
            this.labelName1.AutoSize = true;
            this.labelName1.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelName1.ForeColor = System.Drawing.Color.White;
            this.labelName1.Location = new System.Drawing.Point(0, 0);
            this.labelName1.Name = "labelName1";
            this.labelName1.Size = new System.Drawing.Size(97, 25);
            this.labelName1.TabIndex = 1;
            this.labelName1.Text = "Görev Adı";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(2, 72);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(214, 13);
            this.progressBar1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel2.Controls.Add(this.buttonEdit2);
            this.panel2.Controls.Add(this.buttonReset2);
            this.panel2.Controls.Add(this.buttonPlayPause2);
            this.panel2.Controls.Add(this.labelTimeSpan2);
            this.panel2.Controls.Add(this.labelName2);
            this.panel2.Controls.Add(this.progressBar2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 101);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(250, 92);
            this.panel2.TabIndex = 1;
            // 
            // buttonEdit2
            // 
            this.buttonEdit2.BackColor = System.Drawing.Color.Transparent;
            this.buttonEdit2.BackgroundImage = global::WorkTimer.Properties.Resources.info;
            this.buttonEdit2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonEdit2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonEdit2.Location = new System.Drawing.Point(222, 65);
            this.buttonEdit2.Name = "buttonEdit2";
            this.buttonEdit2.Size = new System.Drawing.Size(21, 23);
            this.buttonEdit2.TabIndex = 5;
            this.buttonEdit2.UseVisualStyleBackColor = false;
            this.buttonEdit2.Click += new System.EventHandler(this.buttonEdit2_Click);
            // 
            // buttonReset2
            // 
            this.buttonReset2.BackColor = System.Drawing.Color.White;
            this.buttonReset2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonReset2.Location = new System.Drawing.Point(179, 38);
            this.buttonReset2.Name = "buttonReset2";
            this.buttonReset2.Size = new System.Drawing.Size(64, 23);
            this.buttonReset2.TabIndex = 3;
            this.buttonReset2.Text = "Reset";
            this.buttonReset2.UseVisualStyleBackColor = false;
            this.buttonReset2.Click += new System.EventHandler(this.buttonReset2_Click);
            // 
            // buttonPlayPause2
            // 
            this.buttonPlayPause2.BackColor = System.Drawing.Color.White;
            this.buttonPlayPause2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonPlayPause2.Location = new System.Drawing.Point(179, 9);
            this.buttonPlayPause2.Name = "buttonPlayPause2";
            this.buttonPlayPause2.Size = new System.Drawing.Size(64, 23);
            this.buttonPlayPause2.TabIndex = 3;
            this.buttonPlayPause2.Text = "Başlat";
            this.buttonPlayPause2.UseVisualStyleBackColor = false;
            this.buttonPlayPause2.Click += new System.EventHandler(this.buttonPlayPause2_Click);
            // 
            // labelTimeSpan2
            // 
            this.labelTimeSpan2.AutoSize = true;
            this.labelTimeSpan2.Font = new System.Drawing.Font("Microsoft PhagsPa", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelTimeSpan2.ForeColor = System.Drawing.Color.White;
            this.labelTimeSpan2.Location = new System.Drawing.Point(-3, 23);
            this.labelTimeSpan2.Name = "labelTimeSpan2";
            this.labelTimeSpan2.Size = new System.Drawing.Size(157, 44);
            this.labelTimeSpan2.TabIndex = 2;
            this.labelTimeSpan2.Text = "00:00:00";
            // 
            // labelName2
            // 
            this.labelName2.AutoSize = true;
            this.labelName2.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelName2.ForeColor = System.Drawing.Color.White;
            this.labelName2.Location = new System.Drawing.Point(0, 0);
            this.labelName2.Name = "labelName2";
            this.labelName2.Size = new System.Drawing.Size(97, 25);
            this.labelName2.TabIndex = 1;
            this.labelName2.Text = "Görev Adı";
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(2, 72);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(214, 13);
            this.progressBar2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel3.Controls.Add(this.buttonEdit3);
            this.panel3.Controls.Add(this.buttonReset3);
            this.panel3.Controls.Add(this.buttonPlayPause3);
            this.panel3.Controls.Add(this.labelTimeSpan3);
            this.panel3.Controls.Add(this.labelName3);
            this.panel3.Controls.Add(this.progressBar3);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 199);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(250, 92);
            this.panel3.TabIndex = 2;
            // 
            // buttonEdit3
            // 
            this.buttonEdit3.BackColor = System.Drawing.Color.Transparent;
            this.buttonEdit3.BackgroundImage = global::WorkTimer.Properties.Resources.info;
            this.buttonEdit3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonEdit3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonEdit3.Location = new System.Drawing.Point(222, 65);
            this.buttonEdit3.Name = "buttonEdit3";
            this.buttonEdit3.Size = new System.Drawing.Size(21, 23);
            this.buttonEdit3.TabIndex = 5;
            this.buttonEdit3.UseVisualStyleBackColor = false;
            this.buttonEdit3.Click += new System.EventHandler(this.buttonEdit3_Click);
            // 
            // buttonReset3
            // 
            this.buttonReset3.BackColor = System.Drawing.Color.White;
            this.buttonReset3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonReset3.Location = new System.Drawing.Point(179, 38);
            this.buttonReset3.Name = "buttonReset3";
            this.buttonReset3.Size = new System.Drawing.Size(64, 23);
            this.buttonReset3.TabIndex = 3;
            this.buttonReset3.Text = "Reset";
            this.buttonReset3.UseVisualStyleBackColor = false;
            this.buttonReset3.Click += new System.EventHandler(this.buttonReset3_Click);
            // 
            // buttonPlayPause3
            // 
            this.buttonPlayPause3.BackColor = System.Drawing.Color.White;
            this.buttonPlayPause3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonPlayPause3.Location = new System.Drawing.Point(179, 9);
            this.buttonPlayPause3.Name = "buttonPlayPause3";
            this.buttonPlayPause3.Size = new System.Drawing.Size(64, 23);
            this.buttonPlayPause3.TabIndex = 3;
            this.buttonPlayPause3.Text = "Başlat";
            this.buttonPlayPause3.UseVisualStyleBackColor = false;
            this.buttonPlayPause3.Click += new System.EventHandler(this.buttonPlayPause3_Click);
            // 
            // labelTimeSpan3
            // 
            this.labelTimeSpan3.AutoSize = true;
            this.labelTimeSpan3.Font = new System.Drawing.Font("Microsoft PhagsPa", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelTimeSpan3.ForeColor = System.Drawing.Color.White;
            this.labelTimeSpan3.Location = new System.Drawing.Point(-3, 23);
            this.labelTimeSpan3.Name = "labelTimeSpan3";
            this.labelTimeSpan3.Size = new System.Drawing.Size(157, 44);
            this.labelTimeSpan3.TabIndex = 2;
            this.labelTimeSpan3.Text = "00:00:00";
            // 
            // labelName3
            // 
            this.labelName3.AutoSize = true;
            this.labelName3.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelName3.ForeColor = System.Drawing.Color.White;
            this.labelName3.Location = new System.Drawing.Point(0, 0);
            this.labelName3.Name = "labelName3";
            this.labelName3.Size = new System.Drawing.Size(97, 25);
            this.labelName3.TabIndex = 1;
            this.labelName3.Text = "Görev Adı";
            // 
            // progressBar3
            // 
            this.progressBar3.Location = new System.Drawing.Point(2, 72);
            this.progressBar3.Name = "progressBar3";
            this.progressBar3.Size = new System.Drawing.Size(214, 13);
            this.progressBar3.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel4.Controls.Add(this.buttonEdit4);
            this.panel4.Controls.Add(this.buttonReset4);
            this.panel4.Controls.Add(this.buttonPlayPause4);
            this.panel4.Controls.Add(this.labelTimeSpan4);
            this.panel4.Controls.Add(this.labelName4);
            this.panel4.Controls.Add(this.progressBar4);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(3, 297);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(250, 92);
            this.panel4.TabIndex = 3;
            // 
            // buttonEdit4
            // 
            this.buttonEdit4.BackColor = System.Drawing.Color.Transparent;
            this.buttonEdit4.BackgroundImage = global::WorkTimer.Properties.Resources.info;
            this.buttonEdit4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonEdit4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonEdit4.Location = new System.Drawing.Point(222, 65);
            this.buttonEdit4.Name = "buttonEdit4";
            this.buttonEdit4.Size = new System.Drawing.Size(21, 23);
            this.buttonEdit4.TabIndex = 5;
            this.buttonEdit4.UseVisualStyleBackColor = false;
            this.buttonEdit4.Click += new System.EventHandler(this.buttonEdit4_Click);
            // 
            // buttonReset4
            // 
            this.buttonReset4.BackColor = System.Drawing.Color.White;
            this.buttonReset4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonReset4.Location = new System.Drawing.Point(179, 38);
            this.buttonReset4.Name = "buttonReset4";
            this.buttonReset4.Size = new System.Drawing.Size(64, 23);
            this.buttonReset4.TabIndex = 3;
            this.buttonReset4.Text = "Reset";
            this.buttonReset4.UseVisualStyleBackColor = false;
            this.buttonReset4.Click += new System.EventHandler(this.buttonReset4_Click);
            // 
            // buttonPlayPause4
            // 
            this.buttonPlayPause4.BackColor = System.Drawing.Color.White;
            this.buttonPlayPause4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonPlayPause4.Location = new System.Drawing.Point(179, 9);
            this.buttonPlayPause4.Name = "buttonPlayPause4";
            this.buttonPlayPause4.Size = new System.Drawing.Size(64, 23);
            this.buttonPlayPause4.TabIndex = 3;
            this.buttonPlayPause4.Text = "Başlat";
            this.buttonPlayPause4.UseVisualStyleBackColor = false;
            this.buttonPlayPause4.Click += new System.EventHandler(this.buttonPlayPause4_Click);
            // 
            // labelTimeSpan4
            // 
            this.labelTimeSpan4.AutoSize = true;
            this.labelTimeSpan4.Font = new System.Drawing.Font("Microsoft PhagsPa", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelTimeSpan4.ForeColor = System.Drawing.Color.White;
            this.labelTimeSpan4.Location = new System.Drawing.Point(-3, 23);
            this.labelTimeSpan4.Name = "labelTimeSpan4";
            this.labelTimeSpan4.Size = new System.Drawing.Size(157, 44);
            this.labelTimeSpan4.TabIndex = 2;
            this.labelTimeSpan4.Text = "00:00:00";
            // 
            // labelName4
            // 
            this.labelName4.AutoSize = true;
            this.labelName4.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelName4.ForeColor = System.Drawing.Color.White;
            this.labelName4.Location = new System.Drawing.Point(0, 0);
            this.labelName4.Name = "labelName4";
            this.labelName4.Size = new System.Drawing.Size(97, 25);
            this.labelName4.TabIndex = 1;
            this.labelName4.Text = "Görev Adı";
            // 
            // progressBar4
            // 
            this.progressBar4.Location = new System.Drawing.Point(2, 72);
            this.progressBar4.Name = "progressBar4";
            this.progressBar4.Size = new System.Drawing.Size(214, 13);
            this.progressBar4.TabIndex = 0;
            // 
            // timerCounter
            // 
            this.timerCounter.Enabled = true;
            this.timerCounter.Interval = 998;
            this.timerCounter.Tick += new System.EventHandler(this.timerCounter_Tick);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "WorkTimer";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gösterGizleToolStripMenuItem,
            this.çıkışToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(139, 48);
            // 
            // gösterGizleToolStripMenuItem
            // 
            this.gösterGizleToolStripMenuItem.Name = "gösterGizleToolStripMenuItem";
            this.gösterGizleToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.gösterGizleToolStripMenuItem.Text = "Göster/Gizle";
            this.gösterGizleToolStripMenuItem.Click += new System.EventHandler(this.gösterGizleToolStripMenuItem_Click);
            // 
            // çıkışToolStripMenuItem
            // 
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.çıkışToolStripMenuItem.Text = "Çıkış";
            this.çıkışToolStripMenuItem.Click += new System.EventHandler(this.çıkışToolStripMenuItem_Click);
            // 
            // FormScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(260, 501);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormScreen";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "FormScreen";
            this.Load += new System.EventHandler(this.FormScreen_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        public Panel panel1;
        public System.Windows.Forms.Timer timer1;
        public TableLayoutPanel tableLayoutPanel1;
        public Button buttonReset1;
        public Button buttonPlayPause1;
        public Label labelTimeSpan1;
        public Label labelName1;
        public ProgressBar progressBar1;
        public Panel panel5;
        public Button buttonReset5;
        public Button buttonPlayPause5;
        public Label labelTimeSpan5;
        public Label labelName5;
        public ProgressBar progressBar5;
        public Panel panel2;
        public Button buttonReset2;
        public Button buttonPlayPause2;
        public Label labelTimeSpan2;
        public Label labelName2;
        public ProgressBar progressBar2;
        public Panel panel3;
        public Button buttonReset3;
        public Button buttonPlayPause3;
        public Label labelTimeSpan3;
        public Label labelName3;
        public ProgressBar progressBar3;
        public Panel panel4;
        public Button buttonReset4;
        public Button buttonPlayPause4;
        public Label labelTimeSpan4;
        public Label labelName4;
        public ProgressBar progressBar4;
        public Button buttonEdit1;
        public Button buttonEdit5;
        public Button buttonEdit2;
        public Button buttonEdit3;
        public Button buttonEdit4;
        public System.Windows.Forms.Timer timerCounter;
        private NotifyIcon notifyIcon1;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem gösterGizleToolStripMenuItem;
        private ToolStripMenuItem çıkışToolStripMenuItem;
    }
}