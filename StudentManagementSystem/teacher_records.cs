using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagementSystem
{
    public partial class teacher_records : Form
    {
        private string jsonFileTeacher = "../Json/teacher.json";
        private DataTable table = new DataTable();

        public teacher_records()
        {
            InitializeComponent();
            load_table();
        }

        private void load_table()
        {
            dataGridView_teacher_record.DataSource = null;
            table.Rows.Clear();
            table.Columns.Clear();

            table.Columns.Add("Teacher Name", typeof(string));
            table.Columns.Add("Id", typeof(string));
            table.Columns.Add("Password", typeof(string));
            table.Columns.Add("Department", typeof(string));
            table.Columns.Add("Phone Number", typeof(string));
            table.Columns.Add("Adress", typeof(string));

            var json = File.ReadAllText(jsonFileTeacher);
            try
            {
                var jObject = JObject.Parse(json);

                if (jObject != null)
                {

                    JArray myArrary = (JArray)jObject["teacher"];

                    if (myArrary != null)
                    {
                        foreach (var item in myArrary)
                        {
                            var tname = item["teacher_name"].ToString();
                            var id = item["id"].ToString();
                            var pass = item["password"].ToString();
                            var dept = item["department"].ToString();
                            var phn_num = item["phone_num"].ToString();
                            var adress = item["Adress"].ToString();

                            table.Rows.Add(tname, id, pass, dept, phn_num, adress);
                        }

                    }

                }
            }
            catch (Exception)
            {

                throw;
            }

            dataGridView_teacher_record.DataSource = table;
            dataGridView_teacher_record.EnableHeadersVisualStyles = false;
            dataGridView_teacher_record.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dataGridView_teacher_record.Columns[0].HeaderCell.Style.ForeColor = Color.White;
            dataGridView_teacher_record.Columns[1].HeaderCell.Style.ForeColor = Color.White;
            dataGridView_teacher_record.Columns[2].HeaderCell.Style.ForeColor = Color.White;
            dataGridView_teacher_record.Columns[3].HeaderCell.Style.ForeColor = Color.White;
            dataGridView_teacher_record.Columns[4].HeaderCell.Style.ForeColor = Color.White;
            dataGridView_teacher_record.Columns[5].HeaderCell.Style.ForeColor = Color.White;
            
            dataGridView_teacher_record.Columns[0].HeaderCell.Style.BackColor = Color.CornflowerBlue;
            dataGridView_teacher_record.Columns[1].HeaderCell.Style.BackColor = Color.CornflowerBlue;
            dataGridView_teacher_record.Columns[2].HeaderCell.Style.BackColor = Color.CornflowerBlue;
            dataGridView_teacher_record.Columns[3].HeaderCell.Style.BackColor = Color.CornflowerBlue;
            dataGridView_teacher_record.Columns[4].HeaderCell.Style.BackColor = Color.CornflowerBlue;
            dataGridView_teacher_record.Columns[5].HeaderCell.Style.BackColor = Color.CornflowerBlue;

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
