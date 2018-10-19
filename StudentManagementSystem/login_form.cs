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
    public partial class login_form : Form

    {
        private string jsonFileAdmin = "../Json/admin.json";
        private string jsonFileTeacher = "../Json/teacher.json";
        private string jsonFileStudent = "../Json/student.json";
        private bool status = false;

        private string user_id, user_pass;
        public login_form()
        {
            InitializeComponent();
            txt_pass.PasswordChar = '.';
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            user_id = txt_id.Text;
            user_pass = txt_pass.Text;

            if (rdb_admin.Checked == true)
            {

                var json = File.ReadAllText(jsonFileAdmin);
                try
                {
                    var jObject = JObject.Parse(json);

                    if (jObject != null)
                    {

                        JArray myArrary = (JArray)jObject["admin"];

                        if (myArrary != null)
                        {
                            foreach (var item in myArrary)
                            {
                                var id = item["id"].ToString();
                                var pass = item["password"].ToString();

                                if (id == user_id && pass == user_pass)
                                {
                                    MessageBox.Show("Successfull Login Admin");
                                    home_page admin_page = new home_page();
                                    admin_page.Show();
                                    status = true;
                                    this.Hide();
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
            if (rdb_teach.Checked == true)
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
                                var id = item["id"].ToString();
                                var pass = item["password"].ToString();
                                string tname = item["teacher_name"].ToString();

                                if (id == user_id && pass == user_pass)
                                {
                                    MessageBox.Show("Successfull Login Teacher");
                                    teacher_form teacher_page = new teacher_form(tname);
                                    teacher_page.Show();
                                    status = true;
                                    this.Hide();
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
            if (rdb_stu.Checked == true)
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
                                var id = item["id"].ToString();
                                var pass = item["password"].ToString();
                                string name = item["student_name"].ToString();

                                if (id == user_id && pass == user_pass)
                                {
                                    MessageBox.Show("Successfull Login Student");
                                    student_form student_page = new student_form(name);
                                    student_page.Show();
                                    status = true;
                                    this.Hide();
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
            if (status == false)
            {
                MessageBox.Show("Please Valid Id And Password !");
            }

        }
    }
}