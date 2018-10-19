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
    public partial class teacher_reg_form : Form
    {
        private string jsonFileDepartment = "../Json/dept.json";
        private string jsonFile = "../Json/teacher.json";
        private DataTable table = new DataTable();

        public teacher_reg_form()
        {
            InitializeComponent();
            load_dept();
            LoadTeacherData();
        }

        private void LoadTeacherData()
        {
            dataGridView_teacher_info.DataSource = null;
            table.Rows.Clear();
            table.Columns.Clear();

            table.Columns.Add("Teacher Name", typeof(string));
            table.Columns.Add("Id", typeof(string));
            table.Columns.Add("Password", typeof(string));
            table.Columns.Add("Department", typeof(string));
            table.Columns.Add("Phone Number", typeof(string));
            table.Columns.Add("Adress", typeof(string));

            var json = File.ReadAllText(jsonFile);
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

            dataGridView_teacher_info.DataSource = table;
            dataGridView_teacher_info.EnableHeadersVisualStyles = false;
            dataGridView_teacher_info.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dataGridView_teacher_info.Columns[0].HeaderCell.Style.ForeColor = Color.White;
            dataGridView_teacher_info.Columns[1].HeaderCell.Style.ForeColor = Color.White;
            dataGridView_teacher_info.Columns[2].HeaderCell.Style.ForeColor = Color.White;
            dataGridView_teacher_info.Columns[3].HeaderCell.Style.ForeColor = Color.White;
            dataGridView_teacher_info.Columns[4].HeaderCell.Style.ForeColor = Color.White;
            dataGridView_teacher_info.Columns[5].HeaderCell.Style.ForeColor = Color.White;

            dataGridView_teacher_info.Columns[0].HeaderCell.Style.BackColor = Color.CornflowerBlue;
            dataGridView_teacher_info.Columns[1].HeaderCell.Style.BackColor = Color.CornflowerBlue;
            dataGridView_teacher_info.Columns[2].HeaderCell.Style.BackColor = Color.CornflowerBlue;
            dataGridView_teacher_info.Columns[3].HeaderCell.Style.BackColor = Color.CornflowerBlue;
            dataGridView_teacher_info.Columns[4].HeaderCell.Style.BackColor = Color.CornflowerBlue;
            dataGridView_teacher_info.Columns[5].HeaderCell.Style.BackColor = Color.CornflowerBlue;
        }

        private void load_dept()
        {
            var json = File.ReadAllText(jsonFileDepartment);
            try
            {
                var jObject = JObject.Parse(json);

                if (jObject != null)
                {

                    JArray myArrary = (JArray)jObject["dept"];

                    if (myArrary != null)
                    {
                        foreach (var item in myArrary)
                        {
                            var dname = item["name"].ToString();
                            cmb_teacher_dept.Items.Add(dname);
                        }

                    }

                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btn_teacher_view_Click(object sender, EventArgs e)
        {
            teacher_records teach_view = new teacher_records();
            teach_view.Show();
            this.Hide();
        }

        private void btn_teacher_save_Click(object sender, EventArgs e)
        {
            var name = txt_teacher_name.Text;
            var id = txt_teacher_id_num.Text;
            var pass = txt_teacher_pass.Text;
            var dept = cmb_teacher_dept.Text;
            var phn_num = txt_teacher_phn_num.Text;
            var adress = txt_teacher_adress.Text;

            if (!name.Equals("") && !id.Equals("") && !pass.Equals("") && !dept.Equals("") && !phn_num.Equals("") && !adress.Equals(""))
            {

                var newCompanyMember = "{ 'teacher_name': '" + name + "','id': '" + id + "','password': '" + pass + "','department': '" + dept + "','phone_num': '" + phn_num + "','Adress': '" + adress + "'}";
                try
                {
                    var json = File.ReadAllText(jsonFile);
                    var jsonObj = JObject.Parse(json);
                    var experienceArrary = jsonObj.GetValue("teacher") as JArray;
                    var newCompany = JObject.Parse(newCompanyMember);
                    experienceArrary.Add(newCompany);

                    jsonObj["teacher"] = experienceArrary;
                    string newJsonResult = Newtonsoft.Json.JsonConvert.SerializeObject(jsonObj,
                                           Newtonsoft.Json.Formatting.Indented);

                    File.WriteAllText(jsonFile, newJsonResult);
                    LoadTeacherData();
                    MessageBox.Show("Successfully added a new teacher");

                    txt_teacher_adress.Text = "";
                    txt_teacher_phn_num.Text = "";
                    cmb_teacher_dept.Text = "";
                    txt_teacher_pass.Text = "";
                    txt_teacher_id_num.Text = "";
                    txt_teacher_name.Text = "";

                }
                catch (Exception ex)
                {

                }

            }
            else
            {
                MessageBox.Show("Every field can not be emply!");
            }
        }

        private void dataGridView_teacher_info_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_teacher_adress.Text = dataGridView_teacher_info.CurrentRow.Cells[5].Value.ToString();
            txt_teacher_phn_num.Text = dataGridView_teacher_info.CurrentRow.Cells[4].Value.ToString();
            cmb_teacher_dept.Text = dataGridView_teacher_info.CurrentRow.Cells[3].Value.ToString();
            txt_teacher_pass.Text = dataGridView_teacher_info.CurrentRow.Cells[2].Value.ToString();
            txt_teacher_id_num.Text = dataGridView_teacher_info.CurrentRow.Cells[1].Value.ToString();
            txt_teacher_name.Text = dataGridView_teacher_info.CurrentRow.Cells[0].Value.ToString();

        }

        private void btn_teacher_update_Click(object sender, EventArgs e)
        {
            string json = File.ReadAllText(jsonFile);

            try
            {
                var jObject = JObject.Parse(json);
                JArray experiencesArrary = (JArray)jObject["teacher"];

                foreach (var company in experiencesArrary.Where(obj => obj["id"].Value<string>() == txt_teacher_id_num.Text))
                {
                    company["student_name"] = !string.IsNullOrEmpty(txt_teacher_name.Text) ? txt_teacher_name.Text : "";
                    company["password"] = !string.IsNullOrEmpty(txt_teacher_pass.Text) ? txt_teacher_pass.Text : "";
                    company["department"] = !string.IsNullOrEmpty(cmb_teacher_dept.Text) ? cmb_teacher_dept.Text : "";
                    company["phone_num"] = !string.IsNullOrEmpty(txt_teacher_phn_num.Text) ? txt_teacher_phn_num.Text : "";
                    company["Adress"] = !string.IsNullOrEmpty(txt_teacher_adress.Text) ? txt_teacher_adress.Text : "";
                }

                jObject["teacher"] = experiencesArrary;
                string output = Newtonsoft.Json.JsonConvert.SerializeObject(jObject, Newtonsoft.Json.Formatting.Indented);

                File.WriteAllText(jsonFile, output);
                LoadTeacherData();
                MessageBox.Show("Update successfully teacher");

                txt_teacher_adress.Text = "";
                txt_teacher_phn_num.Text = "";
                cmb_teacher_dept.Text = "";
                txt_teacher_pass.Text = "";
                txt_teacher_id_num.Text = "";
                txt_teacher_name.Text = "";

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
                JArray experiencesArrary = (JArray)jObject["teacher"];


                var companyToDeleted = experiencesArrary.FirstOrDefault(obj => obj["id"].Value<string>() == txt_teacher_id_num.Text);

                experiencesArrary.Remove(companyToDeleted);

                string output = Newtonsoft.Json.JsonConvert.SerializeObject(jObject, Newtonsoft.Json.Formatting.Indented);

                File.WriteAllText(jsonFile, output);
                LoadTeacherData();
                MessageBox.Show("Delete Successfully teacher");

                txt_teacher_adress.Text = "";
                txt_teacher_phn_num.Text = "";
                cmb_teacher_dept.Text = "";
                txt_teacher_pass.Text = "";
                txt_teacher_id_num.Text = "";
                txt_teacher_name.Text = "";


            }
            catch (Exception)
            {

                throw;
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
