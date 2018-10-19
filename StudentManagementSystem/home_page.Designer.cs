namespace StudentManagementSystem
{
    partial class home_page
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(home_page));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btn_log_out = new System.Windows.Forms.Button();
            this.btn_admin_reg = new System.Windows.Forms.Button();
            this.btn_report = new System.Windows.Forms.Button();
            this.btn_teach_reg = new System.Windows.Forms.Button();
            this.btn_stu_reg = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.teacher_pro = new CircularProgressBar.CircularProgressBar();
            this.child_pro = new CircularProgressBar.CircularProgressBar();
            this.admin_pro = new CircularProgressBar.CircularProgressBar();
            this.stu_progress = new CircularProgressBar.CircularProgressBar();
            this.timer_stu_progress = new System.Windows.Forms.Timer(this.components);
            this.teacher_progress = new System.Windows.Forms.Timer(this.components);
            this.admin_progress = new System.Windows.Forms.Timer(this.components);
            this.child_progress = new System.Windows.Forms.Timer(this.components);
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(242)))), ((int)(((byte)(251)))));
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.btn_log_out);
            this.panel2.Controls.Add(this.btn_admin_reg);
            this.panel2.Controls.Add(this.btn_report);
            this.panel2.Controls.Add(this.btn_teach_reg);
            this.panel2.Controls.Add(this.btn_stu_reg);
            this.panel2.Location = new System.Drawing.Point(2, -2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1280, 180);
            this.panel2.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Teal;
            this.panel4.Location = new System.Drawing.Point(428, 63);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(515, 2);
            this.panel4.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bookman Old Style", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(568, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(285, 21);
            this.label3.TabIndex = 22;
            this.label3.Text = "Student Management System";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::StudentManagementSystem.Properties.Resources.student_home;
            this.pictureBox2.Location = new System.Drawing.Point(497, 6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(65, 51);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 21;
            this.pictureBox2.TabStop = false;
            // 
            // btn_log_out
            // 
            this.btn_log_out.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_log_out.BackColor = System.Drawing.Color.Teal;
            this.btn_log_out.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_log_out.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_log_out.ForeColor = System.Drawing.Color.White;
            this.btn_log_out.Image = ((System.Drawing.Image)(resources.GetObject("btn_log_out.Image")));
            this.btn_log_out.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_log_out.Location = new System.Drawing.Point(1117, 89);
            this.btn_log_out.Name = "btn_log_out";
            this.btn_log_out.Size = new System.Drawing.Size(151, 61);
            this.btn_log_out.TabIndex = 5;
            this.btn_log_out.Text = "Sign-Out";
            this.btn_log_out.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_log_out.UseVisualStyleBackColor = false;
            this.btn_log_out.Click += new System.EventHandler(this.btn_log_out_Click);
            this.btn_log_out.MouseLeave += new System.EventHandler(this.btn_log_out_MouseLeave);
            this.btn_log_out.MouseHover += new System.EventHandler(this.btn_log_out_MouseHover);
            // 
            // btn_admin_reg
            // 
            this.btn_admin_reg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(89)))), ((int)(((byte)(44)))));
            this.btn_admin_reg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_admin_reg.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_admin_reg.ForeColor = System.Drawing.Color.White;
            this.btn_admin_reg.Image = ((System.Drawing.Image)(resources.GetObject("btn_admin_reg.Image")));
            this.btn_admin_reg.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_admin_reg.Location = new System.Drawing.Point(694, 89);
            this.btn_admin_reg.Name = "btn_admin_reg";
            this.btn_admin_reg.Size = new System.Drawing.Size(200, 61);
            this.btn_admin_reg.TabIndex = 4;
            this.btn_admin_reg.Text = "Admin Registration";
            this.btn_admin_reg.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_admin_reg.UseVisualStyleBackColor = false;
            this.btn_admin_reg.Click += new System.EventHandler(this.btn_admin_reg_Click);
            this.btn_admin_reg.MouseLeave += new System.EventHandler(this.btn_admin_reg_MouseLeave);
            this.btn_admin_reg.MouseHover += new System.EventHandler(this.btn_admin_reg_MouseHover);
            // 
            // btn_report
            // 
            this.btn_report.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(75)))), ((int)(((byte)(200)))));
            this.btn_report.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_report.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_report.ForeColor = System.Drawing.Color.White;
            this.btn_report.Image = ((System.Drawing.Image)(resources.GetObject("btn_report.Image")));
            this.btn_report.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_report.Location = new System.Drawing.Point(483, 89);
            this.btn_report.Name = "btn_report";
            this.btn_report.Size = new System.Drawing.Size(195, 61);
            this.btn_report.TabIndex = 3;
            this.btn_report.Text = "Record or Report";
            this.btn_report.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_report.UseVisualStyleBackColor = false;
            this.btn_report.Click += new System.EventHandler(this.btn_report_Click);
            this.btn_report.MouseLeave += new System.EventHandler(this.btn_report_MouseLeave);
            this.btn_report.MouseHover += new System.EventHandler(this.btn_report_MouseHover);
            // 
            // btn_teach_reg
            // 
            this.btn_teach_reg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(159)))), ((int)(((byte)(28)))));
            this.btn_teach_reg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_teach_reg.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_teach_reg.ForeColor = System.Drawing.Color.White;
            this.btn_teach_reg.Image = ((System.Drawing.Image)(resources.GetObject("btn_teach_reg.Image")));
            this.btn_teach_reg.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_teach_reg.Location = new System.Drawing.Point(247, 89);
            this.btn_teach_reg.Name = "btn_teach_reg";
            this.btn_teach_reg.Size = new System.Drawing.Size(218, 61);
            this.btn_teach_reg.TabIndex = 1;
            this.btn_teach_reg.Text = "Teacher Registration";
            this.btn_teach_reg.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_teach_reg.UseVisualStyleBackColor = false;
            this.btn_teach_reg.Click += new System.EventHandler(this.btn_teach_reg_Click);
            this.btn_teach_reg.MouseLeave += new System.EventHandler(this.btn_teach_reg_MouseLeave);
            this.btn_teach_reg.MouseHover += new System.EventHandler(this.btn_teach_reg_MouseHover);
            // 
            // btn_stu_reg
            // 
            this.btn_stu_reg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(142)))), ((int)(((byte)(236)))));
            this.btn_stu_reg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_stu_reg.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_stu_reg.ForeColor = System.Drawing.Color.White;
            this.btn_stu_reg.Image = ((System.Drawing.Image)(resources.GetObject("btn_stu_reg.Image")));
            this.btn_stu_reg.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_stu_reg.Location = new System.Drawing.Point(12, 89);
            this.btn_stu_reg.Name = "btn_stu_reg";
            this.btn_stu_reg.Size = new System.Drawing.Size(218, 61);
            this.btn_stu_reg.TabIndex = 0;
            this.btn_stu_reg.Text = "Student Registration";
            this.btn_stu_reg.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_stu_reg.UseVisualStyleBackColor = false;
            this.btn_stu_reg.Click += new System.EventHandler(this.btn_stu_reg_Click);
            this.btn_stu_reg.MouseLeave += new System.EventHandler(this.btn_stu_reg_MouseLeave);
            this.btn_stu_reg.MouseHover += new System.EventHandler(this.btn_stu_reg_MouseHover);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(160)))), ((int)(((byte)(210)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 632);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1282, 71);
            this.panel1.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bookman Old Style", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(602, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(351, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "All rights reserved. Powered by S11 Limited";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(84)))), ((int)(((byte)(99)))));
            this.label1.Location = new System.Drawing.Point(427, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "©Copyright 2018-2019";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.Teal;
            this.panel3.Controls.Add(this.teacher_pro);
            this.panel3.Controls.Add(this.child_pro);
            this.panel3.Controls.Add(this.admin_pro);
            this.panel3.Controls.Add(this.stu_progress);
            this.panel3.Location = new System.Drawing.Point(0, 170);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1280, 172);
            this.panel3.TabIndex = 28;
            // 
            // teacher_pro
            // 
            this.teacher_pro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.teacher_pro.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.teacher_pro.AnimationSpeed = 3000;
            this.teacher_pro.BackColor = System.Drawing.Color.Transparent;
            this.teacher_pro.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teacher_pro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(87)))), ((int)(((byte)(87)))));
            this.teacher_pro.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.teacher_pro.InnerMargin = 2;
            this.teacher_pro.InnerWidth = -1;
            this.teacher_pro.Location = new System.Drawing.Point(406, 10);
            this.teacher_pro.MarqueeAnimationSpeed = 2000;
            this.teacher_pro.Maximum = 50;
            this.teacher_pro.Name = "teacher_pro";
            this.teacher_pro.OuterColor = System.Drawing.Color.Magenta;
            this.teacher_pro.OuterMargin = -25;
            this.teacher_pro.OuterWidth = 26;
            this.teacher_pro.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.teacher_pro.ProgressWidth = 25;
            this.teacher_pro.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.teacher_pro.Size = new System.Drawing.Size(127, 130);
            this.teacher_pro.StartAngle = 50;
            this.teacher_pro.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(87)))), ((int)(((byte)(87)))));
            this.teacher_pro.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.teacher_pro.SubscriptText = "%";
            this.teacher_pro.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.teacher_pro.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.teacher_pro.SuperscriptText = "";
            this.teacher_pro.TabIndex = 7;
            this.teacher_pro.Text = "50";
            this.teacher_pro.TextMargin = new System.Windows.Forms.Padding(4, 8, 4, 4);
            this.teacher_pro.Value = 50;
            // 
            // child_pro
            // 
            this.child_pro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.child_pro.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.child_pro.AnimationSpeed = 3000;
            this.child_pro.BackColor = System.Drawing.Color.Transparent;
            this.child_pro.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.child_pro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(87)))), ((int)(((byte)(87)))));
            this.child_pro.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.child_pro.InnerMargin = 2;
            this.child_pro.InnerWidth = -1;
            this.child_pro.Location = new System.Drawing.Point(963, 10);
            this.child_pro.MarqueeAnimationSpeed = 2000;
            this.child_pro.Maximum = 90;
            this.child_pro.Name = "child_pro";
            this.child_pro.OuterColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.child_pro.OuterMargin = -25;
            this.child_pro.OuterWidth = 26;
            this.child_pro.ProgressColor = System.Drawing.Color.Orange;
            this.child_pro.ProgressWidth = 25;
            this.child_pro.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.child_pro.Size = new System.Drawing.Size(127, 130);
            this.child_pro.StartAngle = 90;
            this.child_pro.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(87)))), ((int)(((byte)(87)))));
            this.child_pro.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.child_pro.SubscriptText = "%";
            this.child_pro.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.child_pro.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.child_pro.SuperscriptText = "";
            this.child_pro.TabIndex = 6;
            this.child_pro.Text = "90";
            this.child_pro.TextMargin = new System.Windows.Forms.Padding(4, 8, 4, 4);
            this.child_pro.Value = 90;
            // 
            // admin_pro
            // 
            this.admin_pro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.admin_pro.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.admin_pro.AnimationSpeed = 3000;
            this.admin_pro.BackColor = System.Drawing.Color.Transparent;
            this.admin_pro.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admin_pro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(87)))), ((int)(((byte)(87)))));
            this.admin_pro.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.admin_pro.InnerMargin = 2;
            this.admin_pro.InnerWidth = -1;
            this.admin_pro.Location = new System.Drawing.Point(696, 10);
            this.admin_pro.MarqueeAnimationSpeed = 2000;
            this.admin_pro.Maximum = 80;
            this.admin_pro.Name = "admin_pro";
            this.admin_pro.OuterColor = System.Drawing.SystemColors.ActiveCaption;
            this.admin_pro.OuterMargin = -25;
            this.admin_pro.OuterWidth = 26;
            this.admin_pro.ProgressColor = System.Drawing.Color.SpringGreen;
            this.admin_pro.ProgressWidth = 25;
            this.admin_pro.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.admin_pro.Size = new System.Drawing.Size(127, 130);
            this.admin_pro.StartAngle = 80;
            this.admin_pro.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(87)))), ((int)(((byte)(87)))));
            this.admin_pro.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.admin_pro.SubscriptText = "%";
            this.admin_pro.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.admin_pro.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.admin_pro.SuperscriptText = "";
            this.admin_pro.TabIndex = 5;
            this.admin_pro.Text = "80";
            this.admin_pro.TextMargin = new System.Windows.Forms.Padding(4, 8, 4, 4);
            this.admin_pro.Value = 80;
            // 
            // stu_progress
            // 
            this.stu_progress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.stu_progress.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.stu_progress.AnimationSpeed = 3000;
            this.stu_progress.BackColor = System.Drawing.Color.Transparent;
            this.stu_progress.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stu_progress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(87)))), ((int)(((byte)(87)))));
            this.stu_progress.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.stu_progress.InnerMargin = 2;
            this.stu_progress.InnerWidth = -1;
            this.stu_progress.Location = new System.Drawing.Point(133, 10);
            this.stu_progress.MarqueeAnimationSpeed = 2000;
            this.stu_progress.Maximum = 30;
            this.stu_progress.Name = "stu_progress";
            this.stu_progress.OuterColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.stu_progress.OuterMargin = -25;
            this.stu_progress.OuterWidth = 26;
            this.stu_progress.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(71)))), ((int)(((byte)(135)))));
            this.stu_progress.ProgressWidth = 25;
            this.stu_progress.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.stu_progress.Size = new System.Drawing.Size(127, 130);
            this.stu_progress.StartAngle = 30;
            this.stu_progress.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(87)))), ((int)(((byte)(87)))));
            this.stu_progress.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.stu_progress.SubscriptText = "%";
            this.stu_progress.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.stu_progress.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.stu_progress.SuperscriptText = "";
            this.stu_progress.TabIndex = 0;
            this.stu_progress.Text = "30";
            this.stu_progress.TextMargin = new System.Windows.Forms.Padding(4, 8, 4, 4);
            this.stu_progress.Value = 30;
            // 
            // timer_stu_progress
            // 
            this.timer_stu_progress.Enabled = true;
            this.timer_stu_progress.Interval = 2000;
            this.timer_stu_progress.Tick += new System.EventHandler(this.timer_stu_progress_Tick);
            // 
            // teacher_progress
            // 
            this.teacher_progress.Enabled = true;
            this.teacher_progress.Interval = 2000;
            this.teacher_progress.Tick += new System.EventHandler(this.teacher_progress_Tick);
            // 
            // admin_progress
            // 
            this.admin_progress.Enabled = true;
            this.admin_progress.Interval = 2000;
            this.admin_progress.Tick += new System.EventHandler(this.admin_progress_Tick);
            // 
            // child_progress
            // 
            this.child_progress.Enabled = true;
            this.child_progress.Interval = 2000;
            this.child_progress.Tick += new System.EventHandler(this.child_progress_Tick);
            // 
            // chart1
            // 
            this.chart1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chart1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(242)))), ((int)(((byte)(251)))));
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(0, 340);
            this.chart1.Name = "chart1";
            series1.BorderColor = System.Drawing.Color.Teal;
            series1.ChartArea = "ChartArea1";
            series1.Color = System.Drawing.Color.Orange;
            series1.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series1.Legend = "Legend1";
            series1.Name = "Admin";
            series1.ShadowColor = System.Drawing.Color.Orange;
            series1.YValuesPerPoint = 4;
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(1279, 295);
            this.chart1.TabIndex = 29;
            this.chart1.Text = "chart1";
            // 
            // home_page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::StudentManagementSystem.Properties.Resources.blurr_background_green;
            this.ClientSize = new System.Drawing.Size(1280, 700);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.MaximizeBox = false;
            this.Name = "home_page";
            this.Text = "home_page";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.home_page_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_stu_reg;
        private System.Windows.Forms.Button btn_teach_reg;
        private System.Windows.Forms.Button btn_report;
        private System.Windows.Forms.Button btn_admin_reg;
        private System.Windows.Forms.Button btn_log_out;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private CircularProgressBar.CircularProgressBar stu_progress;
        private System.Windows.Forms.Timer timer_stu_progress;
        private CircularProgressBar.CircularProgressBar child_pro;
        private CircularProgressBar.CircularProgressBar admin_pro;
        private System.Windows.Forms.Timer teacher_progress;
        private System.Windows.Forms.Timer admin_progress;
        private System.Windows.Forms.Timer child_progress;
        private CircularProgressBar.CircularProgressBar teacher_pro;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}

