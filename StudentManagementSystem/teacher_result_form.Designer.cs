namespace StudentManagementSystem
{
    partial class teacher_result_form
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(teacher_result_form));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_teacher_delete = new System.Windows.Forms.Button();
            this.btn_teacher_update = new System.Windows.Forms.Button();
            this.cmb_student_name = new System.Windows.Forms.ComboBox();
            this.cmb_teacher_course = new System.Windows.Forms.ComboBox();
            this.btn_teacher_submit = new System.Windows.Forms.Button();
            this.txt_teacher_sgpa = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridResult = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btn_teacher_log_out = new System.Windows.Forms.Button();
            this.btn_teacher_result = new System.Windows.Forms.Button();
            this.btn_teacher_pro = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridResult)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.groupBox2.Controls.Add(this.btn_teacher_delete);
            this.groupBox2.Controls.Add(this.btn_teacher_update);
            this.groupBox2.Controls.Add(this.cmb_student_name);
            this.groupBox2.Controls.Add(this.cmb_teacher_course);
            this.groupBox2.Controls.Add(this.btn_teacher_submit);
            this.groupBox2.Controls.Add(this.txt_teacher_sgpa);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(87)))), ((int)(((byte)(87)))));
            this.groupBox2.Location = new System.Drawing.Point(31, 259);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(596, 324);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Result Publish";
            // 
            // btn_teacher_delete
            // 
            this.btn_teacher_delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(89)))), ((int)(((byte)(44)))));
            this.btn_teacher_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_teacher_delete.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_teacher_delete.ForeColor = System.Drawing.Color.White;
            this.btn_teacher_delete.Location = new System.Drawing.Point(419, 248);
            this.btn_teacher_delete.Name = "btn_teacher_delete";
            this.btn_teacher_delete.Size = new System.Drawing.Size(143, 44);
            this.btn_teacher_delete.TabIndex = 42;
            this.btn_teacher_delete.Text = "Delete";
            this.btn_teacher_delete.UseVisualStyleBackColor = false;
            this.btn_teacher_delete.Click += new System.EventHandler(this.btn_teacher_delete_Click);
            // 
            // btn_teacher_update
            // 
            this.btn_teacher_update.BackColor = System.Drawing.Color.Teal;
            this.btn_teacher_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_teacher_update.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_teacher_update.ForeColor = System.Drawing.Color.White;
            this.btn_teacher_update.Location = new System.Drawing.Point(238, 249);
            this.btn_teacher_update.Name = "btn_teacher_update";
            this.btn_teacher_update.Size = new System.Drawing.Size(143, 43);
            this.btn_teacher_update.TabIndex = 41;
            this.btn_teacher_update.Text = "Update";
            this.btn_teacher_update.UseVisualStyleBackColor = false;
            this.btn_teacher_update.Click += new System.EventHandler(this.btn_teacher_update_Click);
            // 
            // cmb_student_name
            // 
            this.cmb_student_name.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_student_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.cmb_student_name.FormattingEnabled = true;
            this.cmb_student_name.Location = new System.Drawing.Point(205, 61);
            this.cmb_student_name.Name = "cmb_student_name";
            this.cmb_student_name.Size = new System.Drawing.Size(297, 26);
            this.cmb_student_name.TabIndex = 40;
            // 
            // cmb_teacher_course
            // 
            this.cmb_teacher_course.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_teacher_course.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.cmb_teacher_course.FormattingEnabled = true;
            this.cmb_teacher_course.Location = new System.Drawing.Point(205, 118);
            this.cmb_teacher_course.Name = "cmb_teacher_course";
            this.cmb_teacher_course.Size = new System.Drawing.Size(297, 26);
            this.cmb_teacher_course.TabIndex = 39;
            // 
            // btn_teacher_submit
            // 
            this.btn_teacher_submit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(138)))), ((int)(((byte)(2)))));
            this.btn_teacher_submit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_teacher_submit.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_teacher_submit.ForeColor = System.Drawing.Color.White;
            this.btn_teacher_submit.Location = new System.Drawing.Point(56, 249);
            this.btn_teacher_submit.Name = "btn_teacher_submit";
            this.btn_teacher_submit.Size = new System.Drawing.Size(143, 43);
            this.btn_teacher_submit.TabIndex = 18;
            this.btn_teacher_submit.Text = "Submit";
            this.btn_teacher_submit.UseVisualStyleBackColor = false;
            this.btn_teacher_submit.Click += new System.EventHandler(this.btn_teacher_submit_Click);
            // 
            // txt_teacher_sgpa
            // 
            this.txt_teacher_sgpa.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_teacher_sgpa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.txt_teacher_sgpa.Location = new System.Drawing.Point(205, 172);
            this.txt_teacher_sgpa.Multiline = true;
            this.txt_teacher_sgpa.Name = "txt_teacher_sgpa";
            this.txt_teacher_sgpa.Size = new System.Drawing.Size(297, 41);
            this.txt_teacher_sgpa.TabIndex = 15;
            this.txt_teacher_sgpa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(87)))), ((int)(((byte)(87)))));
            this.label4.Location = new System.Drawing.Point(132, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "SGPA :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(87)))), ((int)(((byte)(87)))));
            this.label5.Location = new System.Drawing.Point(123, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Course :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(87)))), ((int)(((byte)(87)))));
            this.label7.Location = new System.Drawing.Point(63, 61);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(133, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "Student Name :";
            // 
            // dataGridResult
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Bookman Old Style", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridResult.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridResult.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridResult.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Bookman Old Style", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridResult.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Bookman Old Style", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridResult.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridResult.Location = new System.Drawing.Point(633, 259);
            this.dataGridResult.Name = "dataGridResult";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Bookman Old Style", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridResult.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridResult.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridResult.Size = new System.Drawing.Size(627, 324);
            this.dataGridResult.TabIndex = 13;
            this.dataGridResult.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridResult_CellClick);
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
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1280, 169);
            this.panel1.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bookman Old Style", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(584, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(285, 21);
            this.label3.TabIndex = 22;
            this.label3.Text = "Student Management System";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::StudentManagementSystem.Properties.Resources.student_home;
            this.pictureBox2.Location = new System.Drawing.Point(513, 6);
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
            this.btn_teacher_log_out.Image = ((System.Drawing.Image)(resources.GetObject("btn_teacher_log_out.Image")));
            this.btn_teacher_log_out.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_teacher_log_out.Location = new System.Drawing.Point(1109, 85);
            this.btn_teacher_log_out.Name = "btn_teacher_log_out";
            this.btn_teacher_log_out.Size = new System.Drawing.Size(151, 61);
            this.btn_teacher_log_out.TabIndex = 6;
            this.btn_teacher_log_out.Text = "Sign-Out";
            this.btn_teacher_log_out.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_teacher_log_out.UseVisualStyleBackColor = false;
            this.btn_teacher_log_out.MouseLeave += new System.EventHandler(this.btn_teacher_log_out_MouseLeave);
            this.btn_teacher_log_out.MouseHover += new System.EventHandler(this.btn_teacher_log_out_MouseHover);
            // 
            // btn_teacher_result
            // 
            this.btn_teacher_result.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(75)))), ((int)(((byte)(200)))));
            this.btn_teacher_result.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_teacher_result.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_teacher_result.ForeColor = System.Drawing.Color.White;
            this.btn_teacher_result.Image = ((System.Drawing.Image)(resources.GetObject("btn_teacher_result.Image")));
            this.btn_teacher_result.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_teacher_result.Location = new System.Drawing.Point(167, 85);
            this.btn_teacher_result.Name = "btn_teacher_result";
            this.btn_teacher_result.Size = new System.Drawing.Size(128, 61);
            this.btn_teacher_result.TabIndex = 4;
            this.btn_teacher_result.Text = "Result";
            this.btn_teacher_result.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_teacher_result.UseVisualStyleBackColor = false;
            this.btn_teacher_result.MouseLeave += new System.EventHandler(this.btn_teacher_result_MouseLeave);
            this.btn_teacher_result.MouseHover += new System.EventHandler(this.btn_teacher_result_MouseHover);
            // 
            // btn_teacher_pro
            // 
            this.btn_teacher_pro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(142)))), ((int)(((byte)(236)))));
            this.btn_teacher_pro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_teacher_pro.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_teacher_pro.ForeColor = System.Drawing.Color.White;
            this.btn_teacher_pro.Image = ((System.Drawing.Image)(resources.GetObject("btn_teacher_pro.Image")));
            this.btn_teacher_pro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_teacher_pro.Location = new System.Drawing.Point(21, 85);
            this.btn_teacher_pro.Name = "btn_teacher_pro";
            this.btn_teacher_pro.Size = new System.Drawing.Size(125, 61);
            this.btn_teacher_pro.TabIndex = 1;
            this.btn_teacher_pro.Text = "Profile";
            this.btn_teacher_pro.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_teacher_pro.UseVisualStyleBackColor = false;
            this.btn_teacher_pro.MouseLeave += new System.EventHandler(this.btn_teacher_pro_MouseLeave);
            this.btn_teacher_pro.MouseHover += new System.EventHandler(this.btn_teacher_pro_MouseHover);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Teal;
            this.panel4.Location = new System.Drawing.Point(426, 63);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(515, 2);
            this.panel4.TabIndex = 25;
            // 
            // teacher_result_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::StudentManagementSystem.Properties.Resources.blurr_background_green;
            this.ClientSize = new System.Drawing.Size(1280, 700);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridResult);
            this.Controls.Add(this.groupBox2);
            this.MaximizeBox = false;
            this.Name = "teacher_result_form";
            this.Text = "teacher_result_form";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridResult)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_teacher_sgpa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_teacher_submit;
        private System.Windows.Forms.DataGridView dataGridResult;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_teacher_log_out;
        private System.Windows.Forms.Button btn_teacher_result;
        private System.Windows.Forms.Button btn_teacher_pro;
        private System.Windows.Forms.ComboBox cmb_student_name;
        private System.Windows.Forms.ComboBox cmb_teacher_course;
        private System.Windows.Forms.Button btn_teacher_update;
        private System.Windows.Forms.Button btn_teacher_delete;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel4;
    }
}