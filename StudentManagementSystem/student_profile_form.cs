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
    public partial class student_profile_form : Form
    {
        private string jsonFileStudent = "../Json/student.json";
        private string jsonFile = "../Json/student.json";
        private string name;

        public student_profile_form(string sname)
        {
            this.name = sname;
            InitializeComponent();
            loadStudentProfile();
        }

        private void loadStudentProfile()
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
                            string sname = item["student_name"].ToString();
                            string id = item["id"].ToString();
                            string pass = item["password"].ToString();
                            string dept = item["department"].ToString();
                            string sup_name = item["Superviser_name"].ToString();
                            string phn_num = item["phone_num"].ToString();
                            string adress = item["Adress"].ToString();

                            if (name.Equals(sname))
                            {
                                txt_stu_name.Text = sname;
                                txt_stu_id_num.Text = id;
                                txt_stu_pass.Text = pass;
                                txt_stu_dept.Text = dept;
                                txt_stu_sup_name.Text = sup_name;
                                txt_stu_phn_num.Text = phn_num;
                                txt_stu_adress.Text = adress;
                            }

                        }

                    }

                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btn_stu_update_pro_Click(object sender, EventArgs e)
        {
            string json = File.ReadAllText(jsonFile);

            try
            {
                var jObject = JObject.Parse(json);
                JArray experiencesArrary = (JArray)jObject["student"];



                foreach (var company in experiencesArrary.Where(obj => obj["id"].Value<string>() == txt_stu_id_num.Text))
                {
                    company["student_name"] = !string.IsNullOrEmpty(txt_stu_name.Text) ? txt_stu_name.Text : "";
                    company["password"] = !string.IsNullOrEmpty(txt_stu_pass.Text) ? txt_stu_pass.Text : "";
                    company["department"] = !string.IsNullOrEmpty(txt_stu_dept.Text) ? txt_stu_dept.Text : "";
                    company["Superviser_name"] = !string.IsNullOrEmpty(txt_stu_sup_name.Text) ? txt_stu_sup_name.Text : "";
                    company["phone_num"] = !string.IsNullOrEmpty(txt_stu_phn_num.Text) ? txt_stu_phn_num.Text : "";
                    company["Adress"] = !string.IsNullOrEmpty(txt_stu_adress.Text) ? txt_stu_adress.Text : "";
                }

                jObject["student"] = experiencesArrary;
                string output = Newtonsoft.Json.JsonConvert.SerializeObject(jObject, Newtonsoft.Json.Formatting.Indented);

                File.WriteAllText(jsonFile, output);
                loadStudentProfile();
                MessageBox.Show("Update successfully student");

                txt_stu_adress.Text = "";
                txt_stu_phn_num.Text = " ";
                txt_stu_sup_name.Text = "";
                txt_stu_dept.Text = "";
                txt_stu_pass.Text = "";
                txt_stu_id_num.Text = "";
                txt_stu_name.Text = "";

            }
            catch (Exception ex)
            {

                Console.WriteLine("Update Error : " + ex.Message.ToString());
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
