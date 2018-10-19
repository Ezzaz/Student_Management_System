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
    public partial class teacher_result_form : Form
    {
        private string jsonFileStudent = "../Json/student.json";
        private string jsonFileCourse = "../Json/course.json";
        private string jsonFile = "../Json/result.json";
        private DataTable table = new DataTable();

        public teacher_result_form()
        {
            InitializeComponent();
            load_stu_name();
            load_course_name();
            load_table();
        }

        private void load_table()
        {
            dataGridResult.DataSource = null;
            table.Rows.Clear();
            table.Columns.Clear();
            table.Columns.Add("Student Name", typeof(string));
            table.Columns.Add("Course Name", typeof(string));
            table.Columns.Add("SGPA", typeof(string));

            var json = File.ReadAllText(jsonFile);
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

                            table.Rows.Add(sname, course, sgpa);

                        }

                    }

                }
            }
            catch (Exception)
            {

                throw;
            }

            dataGridResult.DataSource = table;
            dataGridResult.EnableHeadersVisualStyles = false;
            dataGridResult.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dataGridResult.Columns[0].HeaderCell.Style.ForeColor = Color.White;
            dataGridResult.Columns[1].HeaderCell.Style.ForeColor = Color.White;
            dataGridResult.Columns[2].HeaderCell.Style.ForeColor = Color.White;

            dataGridResult.Columns[0].HeaderCell.Style.BackColor = Color.CornflowerBlue;
            dataGridResult.Columns[1].HeaderCell.Style.BackColor = Color.CornflowerBlue;
            dataGridResult.Columns[2].HeaderCell.Style.BackColor = Color.CornflowerBlue;

        }

        private void load_course_name()
        {
            var json = File.ReadAllText(jsonFileCourse);
            try
            {
                var jObject = JObject.Parse(json);

                if (jObject != null)
                {

                    JArray myArrary = (JArray)jObject["course"];

                    if (myArrary != null)
                    {
                        foreach (var item in myArrary)
                        {
                            var course_name = item["name"].ToString();
                            cmb_teacher_course.Items.Add(course_name);
                        }

                    }

                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void load_stu_name()
        {
            var json = File.ReadAllText(jsonFileStudent);
            try
            {
                var jObject = JObject.Parse(json);

                if (jObject != null)
                {

                    JArray myArrary = (JArray)jObject["student"];

                    if (myArrary != null)
                    {
                        foreach (var item in myArrary)
                        {
                            var sname = item["student_name"].ToString();
                            cmb_student_name.Items.Add(sname);
                        }

                    }

                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btn_teacher_submit_Click(object sender, EventArgs e)
        {
            var sname = cmb_student_name.Text;
            var course = cmb_teacher_course.Text;
            var sgpa = txt_teacher_sgpa.Text;

            if (!sname.Equals("") && !course.Equals("") && !sgpa.Equals(""))
            {

                var newCompanyMember = "{ 'student_name': '" + sname + "','course_name': '" + course + "','sgpa': '" + sgpa + "'}";
                try
                {
                    var json = File.ReadAllText(jsonFile);
                    var jsonObj = JObject.Parse(json);
                    var experienceArrary = jsonObj.GetValue("result") as JArray;
                    var newCompany = JObject.Parse(newCompanyMember);
                    experienceArrary.Add(newCompany);

                    jsonObj["result"] = experienceArrary;
                    string newJsonResult = Newtonsoft.Json.JsonConvert.SerializeObject(jsonObj,
                                           Newtonsoft.Json.Formatting.Indented);
                    File.WriteAllText(jsonFile, newJsonResult);

                    load_table();
                    MessageBox.Show("Successfully added a new student result");

                    txt_teacher_sgpa.Text = "";
                    cmb_teacher_course.Text = "";
                    cmb_student_name.Text = "";
                }
                catch (Exception ex)
                {

                }

            }
            else
            {
                MessageBox.Show("Every filed can not be empty");
            }
        }


        private void dataGridResult_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_teacher_sgpa.Text = dataGridResult.CurrentRow.Cells[2].Value.ToString();
            cmb_teacher_course.Text = dataGridResult.CurrentRow.Cells[1].Value.ToString();
            cmb_student_name.Text = dataGridResult.CurrentRow.Cells[0].Value.ToString();
        }

        private void btn_teacher_update_Click(object sender, EventArgs e)
        {
            string json = File.ReadAllText(jsonFile);

            try
            {
                var jObject = JObject.Parse(json);
                JArray experiencesArrary = (JArray)jObject["result"];



                foreach (var company in experiencesArrary.Where(obj => obj["student_name"].Value<string>() == cmb_student_name.Text))
                {
                    company["course_name"] = !string.IsNullOrEmpty(cmb_teacher_course.Text) ? cmb_teacher_course.Text : "";
                    company["sgpa"] = !string.IsNullOrEmpty(txt_teacher_sgpa.Text) ? txt_teacher_sgpa.Text : "";
                }

                jObject["result"] = experiencesArrary;
                string output = Newtonsoft.Json.JsonConvert.SerializeObject(jObject, Newtonsoft.Json.Formatting.Indented);

                File.WriteAllText(jsonFile, output);
                load_table();
                MessageBox.Show("Update successfully student result");

                txt_teacher_sgpa.Text = "";
                cmb_teacher_course.Text = "";
                cmb_student_name.Text = "";

            }
            catch (Exception ex)
            {

                Console.WriteLine("Update Error : " + ex.Message.ToString());
            }
        }

        private void btn_teacher_delete_Click(object sender, EventArgs e)
        {
            var json = File.ReadAllText(jsonFile);
            try
            {
                var jObject = JObject.Parse(json);
                JArray experiencesArrary = (JArray)jObject["result"];


                var companyToDeleted = experiencesArrary.FirstOrDefault(obj => obj["student_name"].Value<string>() == cmb_student_name.Text);

                experiencesArrary.Remove(companyToDeleted);

                string output = Newtonsoft.Json.JsonConvert.SerializeObject(jObject, Newtonsoft.Json.Formatting.Indented);

                File.WriteAllText(jsonFile, output);
                load_table();
                MessageBox.Show("Delete Successfully student result");

                txt_teacher_sgpa.Text = "";
                cmb_teacher_course.Text = "";
                cmb_student_name.Text = "";


            }
            catch (Exception)
            {

                throw;
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
    }
}
