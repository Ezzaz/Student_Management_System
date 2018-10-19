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
    public partial class records : Form
    {
        public records()
        {
            InitializeComponent();
        }

        private void btn_student_Click(object sender, EventArgs e)
        {
            student_records stu_rec = new student_records();
            stu_rec.Show();
            this.Hide();
        }

        private void btn_teacher_Click(object sender, EventArgs e)
        {
            teacher_records teach_rec = new teacher_records();
            teach_rec.Show();
            this.Hide();
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

        private void button6_MouseHover(object sender, EventArgs e)
        {
            button6.BackColor = Color.FromArgb(254, 180, 29);
        }

        private void button6_MouseLeave(object sender, EventArgs e)
        {
            button6.BackColor = Color.FromArgb(0, 128, 128);
        }
    }
}
