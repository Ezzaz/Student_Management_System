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
    public partial class home_page : Form
    {
        public home_page()
        {
            InitializeComponent();
        }

        private void btn_stu_reg_Click(object sender, EventArgs e)
        {
            student_reg_form stu_form = new student_reg_form();
            stu_form.Show();
        }

        private void btn_teach_reg_Click(object sender, EventArgs e)
        {
            teacher_reg_form teacher_form = new teacher_reg_form();
            teacher_form.Show();
        }

        private void btn_report_Click(object sender, EventArgs e)
        {
            records rcd = new records();
            rcd.Show();
        }

        private void btn_admin_reg_Click(object sender, EventArgs e)
        {
            admin_reg_form admin_form = new admin_reg_form();
            admin_form.Show();
        }

        private void btn_log_out_Click(object sender, EventArgs e)
        {
            login_form login = new login_form();
            login.Show();
            this.Hide();
        }

        private void timer_stu_progress_Tick(object sender, EventArgs e)
        {
            try {
                stu_progress.Value = 0;
                stu_progress.Minimum = 0;
                stu_progress.Maximum = 30;
                stu_progress.Text = stu_progress.Value.ToString();
            }
            catch (Exception) {

            }

        }

        private void teacher_progress_Tick(object sender, EventArgs e)
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

        private void admin_progress_Tick(object sender, EventArgs e)
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

        private void child_progress_Tick(object sender, EventArgs e)
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

        private void btn_stu_reg_MouseHover(object sender, EventArgs e)
        {
            btn_stu_reg.BackColor = Color.FromArgb(254, 180, 29);
        }

        private void btn_stu_reg_MouseLeave(object sender, EventArgs e)
        {
            btn_stu_reg.BackColor = Color.FromArgb(0, 142, 236);
        }

        private void btn_teach_reg_MouseHover(object sender, EventArgs e)
        {
            btn_teach_reg.BackColor = Color.FromArgb(254, 180, 29);
        }

        private void btn_teach_reg_MouseLeave(object sender, EventArgs e)
        {
            btn_teach_reg.BackColor = Color.FromArgb(96, 159, 28);
        }

        private void btn_report_MouseHover(object sender, EventArgs e)
        {
            btn_report.BackColor = Color.FromArgb(254, 180, 29);
        }

        private void btn_report_MouseLeave(object sender, EventArgs e)
        {
            btn_report.BackColor = Color.FromArgb(91, 75, 200);
        }

        private void btn_admin_reg_MouseHover(object sender, EventArgs e)
        {
            btn_admin_reg.BackColor = Color.FromArgb(254, 180, 29);
        }

        private void btn_admin_reg_MouseLeave(object sender, EventArgs e)
        {
            btn_admin_reg.BackColor = Color.FromArgb(222, 89, 44);
        }

        private void btn_log_out_MouseHover(object sender, EventArgs e)
        {
            btn_log_out.BackColor = Color.FromArgb(254, 180, 29);
        }

        private void btn_log_out_MouseLeave(object sender, EventArgs e)
        {
            btn_log_out.BackColor = Color.FromArgb(0, 128, 128);
        }

        private void home_page_Load(object sender, EventArgs e)
        {
            fill_chart();
        }

        private void fill_chart()
        {
            chart1.Series["Admin"].Points.AddXY("Male Student", 70);
            chart1.Series["Admin"].Points.AddXY("Female Student", 50);
            chart1.Series["Admin"].Points.AddXY("Teacher", 90);
            chart1.Series["Admin"].Points.AddXY("Admin", 100);

        }
    }
}
