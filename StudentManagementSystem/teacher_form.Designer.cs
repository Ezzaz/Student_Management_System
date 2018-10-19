namespace StudentManagementSystem
{
    partial class teacher_form
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btn_teacher_log_out = new System.Windows.Forms.Button();
            this.btn_teacher_result = new System.Windows.Forms.Button();
            this.btn_teacher_pro = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            this.timer_teah_progress = new System.Windows.Forms.Timer(this.components);
            this.timer_admin_progress = new System.Windows.Forms.Timer(this.components);
            this.timer_child_progress = new System.Windows.Forms.Timer(this.components);
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(242)))), ((int)(((byte)(251)))));
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.btn_teacher_log_out);
            this.panel1.Controls.Add(this.btn_teacher_result);
            this.panel1.Controls.Add(this.btn_teacher_pro);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1283, 180);
            this.panel1.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Teal;
            this.panel4.Location = new System.Drawing.Point(396, 61);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(515, 2);
            this.panel4.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bookman Old Style", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(568, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(285, 21);
            this.label3.TabIndex = 22;
            this.label3.Text = "Student Management System";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::StudentManagementSystem.Properties.Resources.student_home;
            this.pictureBox2.Location = new System.Drawing.Point(497, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(65, 51);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 21;
            this.pictureBox2.TabStop = false;
            // 
            // btn_teacher_log_out
            // 
            this.btn_teacher_log_out.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_teacher_log_out.BackColor = System.Drawing.Color.Teal;
            this.btn_teacher_log_out.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_teacher_log_out.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_teacher_log_out.ForeColor = System.Drawing.Color.White;
            this.btn_teacher_log_out.Image = global::StudentManagementSystem.Properties.Resources.sign_out;
            this.btn_teacher_log_out.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_teacher_log_out.Location = new System.Drawing.Point(1107, 97);
            this.btn_teacher_log_out.Name = "btn_teacher_log_out";
            this.btn_teacher_log_out.Size = new System.Drawing.Size(151, 61);
            this.btn_teacher_log_out.TabIndex = 6;
            this.btn_teacher_log_out.Text = "Sign-Out";
            this.btn_teacher_log_out.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_teacher_log_out.UseVisualStyleBackColor = false;
            this.btn_teacher_log_out.Click += new System.EventHandler(this.btn_teacher_log_out_Click);
            this.btn_teacher_log_out.MouseLeave += new System.EventHandler(this.btn_teacher_log_out_MouseLeave);
            this.btn_teacher_log_out.MouseHover += new System.EventHandler(this.btn_teacher_log_out_MouseHover);
            // 
            // btn_teacher_result
            // 
            this.btn_teacher_result.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(75)))), ((int)(((byte)(200)))));
            this.btn_teacher_result.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_teacher_result.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_teacher_result.ForeColor = System.Drawing.Color.White;
            this.btn_teacher_result.Image = global::StudentManagementSystem.Properties.Resources.report1;
            this.btn_teacher_result.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_teacher_result.Location = new System.Drawing.Point(184, 97);
            this.btn_teacher_result.Name = "btn_teacher_result";
            this.btn_teacher_result.Size = new System.Drawing.Size(128, 61);
            this.btn_teacher_result.TabIndex = 4;
            this.btn_teacher_result.Text = "Result";
            this.btn_teacher_result.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_teacher_result.UseVisualStyleBackColor = false;
            this.btn_teacher_result.Click += new System.EventHandler(this.btn_teacher_result_Click);
            this.btn_teacher_result.MouseLeave += new System.EventHandler(this.btn_teacher_result_MouseLeave);
            this.btn_teacher_result.MouseHover += new System.EventHandler(this.btn_teacher_result_MouseHover);
            // 
            // btn_teacher_pro
            // 
            this.btn_teacher_pro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(142)))), ((int)(((byte)(236)))));
            this.btn_teacher_pro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_teacher_pro.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_teacher_pro.ForeColor = System.Drawing.Color.White;
            this.btn_teacher_pro.Image = global::StudentManagementSystem.Properties.Resources.tec_reg;
            this.btn_teacher_pro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_teacher_pro.Location = new System.Drawing.Point(29, 97);
            this.btn_teacher_pro.Name = "btn_teacher_pro";
            this.btn_teacher_pro.Size = new System.Drawing.Size(125, 61);
            this.btn_teacher_pro.TabIndex = 1;
            this.btn_teacher_pro.Text = "Profile";
            this.btn_teacher_pro.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_teacher_pro.UseVisualStyleBackColor = false;
            this.btn_teacher_pro.Click += new System.EventHandler(this.btn_teacher_pro_Click);
            this.btn_teacher_pro.MouseLeave += new System.EventHandler(this.btn_teacher_pro_MouseLeave);
            this.btn_teacher_pro.MouseHover += new System.EventHandler(this.btn_teacher_pro_MouseHover);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(160)))), ((int)(((byte)(210)))));
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(-1, 629);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1280, 71);
            this.panel2.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bookman Old Style", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(603, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(351, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "All rights reserved. Powered by S11 Limited";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(84)))), ((int)(((byte)(99)))));
            this.label1.Location = new System.Drawing.Point(428, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 18);
            this.label1.TabIndex = 2;
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
            this.panel3.Location = new System.Drawing.Point(1, 176);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1278, 158);
            this.panel3.TabIndex = 27;
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
            this.teacher_pro.Location = new System.Drawing.Point(434, 10);
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
            this.teacher_pro.TabIndex = 11;
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
            this.child_pro.Location = new System.Drawing.Point(991, 10);
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
            this.child_pro.TabIndex = 10;
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
            this.admin_pro.Location = new System.Drawing.Point(724, 10);
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
            this.admin_pro.TabIndex = 9;
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
            this.stu_progress.Location = new System.Drawing.Point(161, 10);
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
            this.stu_progress.TabIndex = 8;
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
            // 
            // admin_progress
            // 
            this.admin_progress.Enabled = true;
            this.admin_progress.Interval = 2000;
            // 
            // child_progress
            // 
            this.child_progress.Enabled = true;
            this.child_progress.Interval = 2000;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 2000;
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 2000;
            // 
            // timer3
            // 
            this.timer3.Enabled = true;
            this.timer3.Interval = 2000;
            // 
            // timer4
            // 
            this.timer4.Enabled = true;
            this.timer4.Interval = 2000;
            // 
            // timer_teah_progress
            // 
            this.timer_teah_progress.Enabled = true;
            this.timer_teah_progress.Interval = 2000;
            this.timer_teah_progress.Tick += new System.EventHandler(this.timer_teah_progress_Tick);
            // 
            // timer_admin_progress
            // 
            this.timer_admin_progress.Enabled = true;
            this.timer_admin_progress.Interval = 2000;
            this.timer_admin_progress.Tick += new System.EventHandler(this.timer_admin_progress_Tick);
            // 
            // timer_child_progress
            // 
            this.timer_child_progress.Enabled = true;
            this.timer_child_progress.Interval = 2000;
            this.timer_child_progress.Tick += new System.EventHandler(this.timer_child_progress_Tick);
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
            this.chart1.Location = new System.Drawing.Point(1, 331);
            this.chart1.Name = "chart1";
            series1.BorderColor = System.Drawing.Color.Teal;
            series1.ChartArea = "ChartArea1";
            series1.Color = System.Drawing.Color.Orange;
            series1.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series1.Legend = "Legend1";
            series1.Name = "Teacher";
            series1.ShadowColor = System.Drawing.Color.Orange;
            series1.YValuesPerPoint = 4;
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(1279, 301);
            this.chart1.TabIndex = 31;
            this.chart1.Text = "chart1";
            // 
            // teacher_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::StudentManagementSystem.Properties.Resources.blurr_background_green;
            this.ClientSize = new System.Drawing.Size(1280, 700);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "teacher_form";
            this.Text = "teacher_form";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.teacher_form_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_teacher_log_out;
        private System.Windows.Forms.Button btn_teacher_result;
        private System.Windows.Forms.Button btn_teacher_pro;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private CircularProgressBar.CircularProgressBar teacher_pro;
        private CircularProgressBar.CircularProgressBar child_pro;
        private CircularProgressBar.CircularProgressBar admin_pro;
        private CircularProgressBar.CircularProgressBar stu_progress;
        private System.Windows.Forms.Timer timer_stu_progress;
        private System.Windows.Forms.Timer teacher_progress;
        private System.Windows.Forms.Timer admin_progress;
        private System.Windows.Forms.Timer child_progress;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Timer timer4;
        private System.Windows.Forms.Timer timer_teah_progress;
        private System.Windows.Forms.Timer timer_admin_progress;
        private System.Windows.Forms.Timer timer_child_progress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}