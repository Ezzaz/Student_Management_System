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
    public partial class admin_reg_form : Form
    {
        private string jsonFile = "../Json/admin.json";
        private DataTable table = new DataTable();

        public admin_reg_form()
        {
            InitializeComponent();
            txt_admin_pass.PasswordChar = '.';
            LoadAdminData();
        }

        private void LoadAdminData()
        {

            dataGridView_admin.DataSource = null;
            table.Rows.Clear();
            table.Columns.Clear();
            table.Columns.Add("Id", typeof(string));
            table.Columns.Add("Password", typeof(string));

            var json = File.ReadAllText(jsonFile);
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

                            table.Rows.Add(id, pass);

                        }

                    }

                }
            }
            catch (Exception)
            {

                throw;
            }

            dataGridView_admin.DataSource = table;
            dataGridView_admin.EnableHeadersVisualStyles = false;
            dataGridView_admin.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dataGridView_admin.Columns[0].HeaderCell.Style.ForeColor = Color.White;
            dataGridView_admin.Columns[1].HeaderCell.Style.ForeColor = Color.White;

            dataGridView_admin.Columns[0].HeaderCell.Style.BackColor = Color.CornflowerBlue;
            dataGridView_admin.Columns[1].HeaderCell.Style.BackColor = Color.CornflowerBlue;
        }

        private void btn_admin_save_Click(object sender, EventArgs e)
        {
            var id = txt_admin_user_name.Text;
            var pass = txt_admin_pass.Text;

            if (!id.Equals("") && !pass.Equals(""))
            {

                var newCompanyMember = "{ 'id': '" + id + "','password': '" + pass + "'}";
                try
                {
                    var json = File.ReadAllText(jsonFile);
                    var jsonObj = JObject.Parse(json);
                    var experienceArrary = jsonObj.GetValue("admin") as JArray;
                    var newCompany = JObject.Parse(newCompanyMember);
                    experienceArrary.Add(newCompany);

                    jsonObj["admin"] = experienceArrary;
                    string newJsonResult = Newtonsoft.Json.JsonConvert.SerializeObject(jsonObj,
                                           Newtonsoft.Json.Formatting.Indented);

                    File.WriteAllText(jsonFile, newJsonResult);
                    LoadAdminData();
                    MessageBox.Show("Successfully added a new admin");

                    txt_admin_pass.Text = "";
                    txt_admin_user_name.Text = " ";
                }
                catch (Exception ex)
                {

                }

            }
            else {
                MessageBox.Show("Id or Password can not be empty");
            }

        }

        private void dataGridView_admin_CellClick(object sender, DataGridViewCellEventArgs e)
        {
                txt_admin_pass.Text = dataGridView_admin.CurrentRow.Cells[1].Value.ToString();
                txt_admin_user_name.Text = dataGridView_admin.CurrentRow.Cells[0].Value.ToString();

        }

        private void btn_admin_update_Click(object sender, EventArgs e)
        {
            string json = File.ReadAllText(jsonFile);

            try
            {
                var jObject = JObject.Parse(json);
                JArray experiencesArrary = (JArray)jObject["admin"];

                   

                    foreach (var company in experiencesArrary.Where(obj => obj["id"].Value<string>() == txt_admin_user_name.Text))
                    {
                        company["password"] = !string.IsNullOrEmpty(txt_admin_pass.Text) ? txt_admin_pass.Text : "";
                    }

                    jObject["admin"] = experiencesArrary;
                    string output = Newtonsoft.Json.JsonConvert.SerializeObject(jObject, Newtonsoft.Json.Formatting.Indented);
                    File.WriteAllText(jsonFile, output);
                     LoadAdminData();

                MessageBox.Show("Update successfully admin");
                txt_admin_pass.Text = "";
                txt_admin_user_name.Text = " ";

            }
            catch (Exception ex)
            {

                Console.WriteLine("Update Error : " + ex.Message.ToString());
            }

        }

        private void btn_admin_delete_Click(object sender, EventArgs e)
        {
            var json = File.ReadAllText(jsonFile);
            try
            {
                var jObject = JObject.Parse(json);
                JArray experiencesArrary = (JArray)jObject["admin"];

                
                    var companyToDeleted = experiencesArrary.FirstOrDefault(obj => obj["id"].Value<string>() == txt_admin_user_name.Text);

                    experiencesArrary.Remove(companyToDeleted);

                    string output = Newtonsoft.Json.JsonConvert.SerializeObject(jObject, Newtonsoft.Json.Formatting.Indented);
                    File.WriteAllText(jsonFile, output);

                LoadAdminData();

                MessageBox.Show("Delete Successfully admin");
                txt_admin_pass.Text = "";
                txt_admin_user_name.Text = " ";


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
