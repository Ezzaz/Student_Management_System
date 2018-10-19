using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagementSystem
{
    public partial class student_form : Form

    {
        public string name;

        public student_form(string sname)
        {
            this.name = sname;
            InitializeComponent();
        }

        private void btn_stu_pro_Click(object sender, EventArgs e)
        {
            student_profile_form stu_pro_form = new student_profile_form(name);
            stu_pro_form.Show();
        }

        private void btn_stu_result_Click(object sender, EventArgs e)
        {
            student_result_form stu_res_form = new student_result_form(name);
            stu_res_form.Show();
        }

        private void btn_stu_log_out_Click(object sender, EventArgs e)
        {
            login_form login = new login_form();
            login.Show();
            this.Hide();
        }

        private void timer_stu_progress_Tick(object sender, EventArgs e)
        {
            try
            {
                stu_progress.Value = 0;
                stu_progress.Minimum = 0;
                stu_progress.Maximum = 30;
                stu_progress.Text = stu_progress.Value.ToString();
            }
            catch (Exception)
            {

            }
        }

        private void timer_teach_progress_Tick(object sender, EventArgs e)
        {
            try
            {
                teacher_pro.Value = 0;
                teacher_pro.Minimum = 0;
                teacher_pro.Maximum = 50;
                teacher_pro.Text = teacher_pro.Value.ToString();
            }
            catch (Exception)
            {

            }
        }

        private void timer_admin_progress_Tick(object sender, EventArgs e)
        {
            try
            {
                admin_pro.Value = 0;
                admin_pro.Minimum = 0;
                admin_pro.Maximum = 80;
                admin_pro.Text = admin_pro.Value.ToString();
            }
            catch (Exception)
            {

            }
        }

        private void timer_child_progress_Tick(object sender, EventArgs e)
        {
            try
            {
                child_pro.Value = 0;
                child_pro.Minimum = 0;
                child_pro.Maximum = 90;
                child_pro.Text = child_pro.Value.ToString();
            }
            catch (Exception)
            {

            }
        }

        private void btn_teacher_pro_MouseHover(object sender, EventArgs e)
        {
            btn_teacher_pro.BackColor =Color.FromArgb(254,180,29);
        }

        private void btn_teacher_pro_MouseLeave(object sender, EventArgs e)
        {
            btn_teacher_pro.BackColor = Color.FromArgb(0, 142, 236);
        }

        private void btn_teacher_result_MouseHover(object sender, EventArgs e)
        {
            btn_teacher_result.BackColor = Color.FromArgb(254, 180, 29);
        }

        private void btn_teacher_result_MouseLeave(object sender, EventArgs e)
        {
            btn_teacher_result.BackColor = Color.FromArgb(91, 75, 200);
        }

        private void btn_teacher_log_out_MouseHover(object sender, EventArgs e)
        {
            btn_teacher_log_out.BackColor = Color.FromArgb(254, 180, 29);
        }

        private void btn_teacher_log_out_MouseLeave(object sender, EventArgs e)
        {
            btn_teacher_log_out.BackColor = Color.FromArgb(0,128,128);
        }

        private void student_form_Load(object sender, EventArgs e)
        {
            fill_chart();
        }

        private void fill_chart()
        {
            chart1.Series["Student"].Points.AddXY("Data Mining", 70);
            chart1.Series["Student"].Points.AddXY("Problem Solving", 50);
            chart1.Series["Student"].Points.AddXY("Software Engineering", 90);
            chart1.Series["Student"].Points.AddXY("Web Designing", 100);

        }
    }
    
}
