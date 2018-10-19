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
    public partial class teacher_profile_form : Form
    {
        private string jsonFileTeacher = "../Json/teacher.json";
        private string jsonFile = "../Json/teacher.json";
        private string name;

        public teacher_profile_form(string tname)
        {
            this.name = tname;
            InitializeComponent();
            loadTeacherProfile();
        }

        private void loadTeacherProfile()
        {
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
                            string tname = item["teacher_name"].ToString();
                            string id = item["id"].ToString();
                            string pass = item["password"].ToString();
                            string dept = item["department"].ToString();
                            string phn_num = item["phone_num"].ToString();
                            string adress = item["Adress"].ToString();

                            if (name.Equals(tname))
                            {
                                txt_teacher_name.Text = tname;
                                txt_teacher_id_num.Text = id;
                                txt_teacher_pass.Text = pass;
                                txt_teacher_dept.Text = dept;
                                txt_teacher_phn_num.Text = phn_num;
                                txt_teacher_adress.Text = adress;
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

        private void btn_teacher_update_pro_Click(object sender, EventArgs e)
        {
            string json = File.ReadAllText(jsonFile);

            try
            {
                var jObject = JObject.Parse(json);
                JArray experiencesArrary = (JArray)jObject["teacher"];



                foreach (var company in experiencesArrary.Where(obj => obj["id"].Value<string>() == txt_teacher_id_num.Text))
                {
                    company["teacher_name"] = !string.IsNullOrEmpty(txt_teacher_name.Text) ? txt_teacher_name.Text : "";
                    company["password"] = !string.IsNullOrEmpty(txt_teacher_pass.Text) ? txt_teacher_pass.Text : "";
                    company["department"] = !string.IsNullOrEmpty(txt_teacher_dept.Text) ? txt_teacher_dept.Text : "";
                    company["phone_num"] = !string.IsNullOrEmpty(txt_teacher_phn_num.Text) ? txt_teacher_phn_num.Text : "";
                    company["Adress"] = !string.IsNullOrEmpty(txt_teacher_adress.Text) ? txt_teacher_adress.Text : "";
                }

                jObject["teacher"] = experiencesArrary;
                string output = Newtonsoft.Json.JsonConvert.SerializeObject(jObject, Newtonsoft.Json.Formatting.Indented);

                File.WriteAllText(jsonFile, output);
                loadTeacherProfile();
                MessageBox.Show("Update successfully teacher");

                txt_teacher_adress.Text = "";
                txt_teacher_phn_num.Text = " ";
                txt_teacher_dept.Text = "";
                txt_teacher_pass.Text = "";
                txt_teacher_id_num.Text = "";
                txt_teacher_name.Text = "";
                
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
