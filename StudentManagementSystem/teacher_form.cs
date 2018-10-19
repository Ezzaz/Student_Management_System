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
    public partial class teacher_form : Form
    {
        private string name;

        public teacher_form(string tname)
        {
            InitializeComponent();
            this.name = tname;
        }

        private void btn_teacher_pro_Click(object sender, EventArgs e)
        {
            teacher_profile_form teach_pro_form = new teacher_profile_form(name);
            teach_pro_form.Show();
        }

        private void btn_teacher_result_Click(object sender, EventArgs e)
        {
            teacher_result_form teach_res_form = new teacher_result_form();
            teach_res_form.Show();
        }

        private void btn_teacher_log_out_Click(object sender, EventArgs e)
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

        private void timer_teah_progress_Tick(object sender, EventArgs e)
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
            btn_teacher_pro.BackColor = Color.FromArgb(254, 180, 29);
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
            btn_teacher_log_out.BackColor = Color.FromArgb(0, 128, 128);
        }

        private void teacher_form_Load(object sender, EventArgs e)
        {
            fill_chart();
        }

        private void fill_chart()
        {
            chart1.Series["Teacher"].Points.AddXY("Biplab Chandra Nag", 70);
            chart1.Series["Teacher"].Points.AddXY("Faisal Mahmud", 50);
            chart1.Series["Teacher"].Points.AddXY("Shakil Ahmed", 90);
            chart1.Series["Teacher"].Points.AddXY("Ijajul Islam Ijaj", 100);

        }
    }
}
