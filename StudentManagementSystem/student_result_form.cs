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
    public partial class student_result_form : Form
    {
        private string name;
        private string jsonFileResult = "../Json/result.json";
        private DataTable table = new DataTable();

        public student_result_form(string sname)
        {
            this.name = sname;
            InitializeComponent();
            load_table();
        }

        private void load_table() {

            dataGridView_result.DataSource = null;
            table.Rows.Clear();
            table.Columns.Clear();
            table.Columns.Add("Course Name", typeof(string));
            table.Columns.Add("SGPA", typeof(string));

            var json = File.ReadAllText(jsonFileResult);
            try
            {
                var jObject = JObject.Parse(json);

                if (jObject != null)
                {

                    JArray myArrary = (JArray)jObject["result"];

                    if (myArrary != null)
                    {
                        foreach (var item in myArrary)
                        {
                            var sname = item["student_name"].ToString();
                            var course = item["course_name"].ToString();
                            var sgpa = item["sgpa"].ToString();
                            
                            if (name.Equals(sname)) {
                                table.Rows.Add(course, sgpa);
                            }
                        }

                    }

                }
            }
            catch (Exception)
            {

                throw;
            }

            dataGridView_result.DataSource = table;
            dataGridView_result.Columns[0].HeaderCell.Style.ForeColor = Color.White;
            dataGridView_result.Columns[1].HeaderCell.Style.ForeColor = Color.White;

            dataGridView_result.Columns[0].HeaderCell.Style.BackColor = Color.CornflowerBlue;
            dataGridView_result.Columns[1].HeaderCell.Style.BackColor = Color.CornflowerBlue;

            dataGridView_result.EnableHeadersVisualStyles = false;
            dataGridView_result.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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
    }
}
