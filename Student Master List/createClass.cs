using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Student_Master_List
{
    public partial class createClass : Form
    {

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Lb\source\repos\Student Master List\Student Master List\Classes.mdf;Integrated Security=True");
        byte[] imageBT = null;
        string sectionn, classs, id, name, gender;

        public createClass()
        {
            InitializeComponent();
        }




        public void qwe()
        {
            string year, section;

            if (cbCourse.Text == "Bachelor of Science in Psychology")
            {
                lblCourse.Text = "BsPsy";
            }
            else if (cbCourse.Text == "Bachelor of Secondary Education")
            {
                lblCourse.Text = "BSED";
            }
            else if (cbCourse.Text == "Bachelor of Elementary Education")
            {
                lblCourse.Text = "BEEd";
            }
            else if (cbCourse.Text == "Bachelor of Science in Accountancy")
            {
                lblCourse.Text = "BSA";
            }
            else if (cbCourse.Text == "Bachelor of Science in Business Administration")
            {
                lblCourse.Text = "BSBA";
            }
            else if (cbCourse.Text == "Bachelor of Science in Criminology")
            {
                lblCourse.Text = "BSCrim";
            }
            else if (cbCourse.Text == "Bachelor of Science in Information Technology")
            {
                lblCourse.Text = "BSIT";
            }
            else if (cbCourse.Text == "Bachelor of Science in Computer Science")
            {
                lblCourse.Text = "BSCS";
            }
            else if (cbCourse.Text == "Bachelor of Science in Food Technology")
            {
                lblCourse.Text = "BSFT";
            }
            else if (cbCourse.Text == "Bachelor of Science in Nutrition and Dietetics")
            {
                lblCourse.Text = "BSND";
            }
            else if (cbCourse.Text == "Bachelor of Science in Hotel and Restaurant Management")
            {
                lblCourse.Text = "BSHRM";
            }
            else if (cbCourse.Text == "Bachelor of Science in Tourism")
            {
                lblCourse.Text = "BSTM";
            }
            else if (cbCourse.Text == "Bachelor of Science in Fisheries")
            {
                lblCourse.Text = "BSFi";
            }
            else if (cbCourse.Text == "Bachelor of Science in Agri- Fisheries Business Management")
            {
                lblCourse.Text = "BSAgriFiBM";
            }
            else if (cbCourse.Text == "Bachelor of Science in Fishery Education")
            {
                lblCourse.Text = "BSFiEd";
            }
            year = cbYear.Text;
            section = comboBox1.Text;
            lblYear.Text = cbYear.Text;
            lblSection.Text = section;

        }

        private void cbCollege_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbCollege.Text == "(CAS) COLLEGE OF ARTS AND SCIENCES")
            {
                this.cbCourse.Items.AddRange(new object[] { "Bachelor of Science in Psychology" });
            }
            else if (cbCollege.Text == "(CTE) COLLEGE OF TEACHER EDUCATION")
            {
                this.cbCourse.Items.AddRange(new object[] { "Bachelor of Secondary Education",
                "Bachelor of Elementary Education","SPECIAL PROGRAM - Intensive Course in English Proficiency",
                "SPECIAL PROGRAM - Bachelor of Elementary Education"
                ,"AREA OF SPECIALIZATION - General Elementary Education"
                ,"AREA OF SPECIALIZATION - Pre-Elementary Education"
                ,"AREA OF SPECIALIZATION - Certificate in Teaching Proficiency (CTP)"});
            }
            else if (cbCollege.Text == "(CBMA) COLLEGE OF BUSINESS MANAGEMENT AND ACCOUNTANCY")
            {
                this.cbCourse.Items.AddRange(new object[] { "Bachelor of Science in Accountancy",
                "Bachelor of Science in Business Administration" });
            }
            else if (cbCollege.Text == "(CCJE) COLLEGE OF CRIMINAL JUSTICE EDUCATION")
            {
                this.cbCourse.Items.AddRange(new object[] { "Bachelor of Science in Criminology" });
            }
            else if (cbCollege.Text == "(CCS) COLLEGE OF COMPUTER STUDIES")
            {
                this.cbCourse.Items.AddRange(new object[] { "Bachelor of Science in Information Technology",
                "Bachelor of Science in Computer Science" });
            }
            else if (cbCollege.Text == "(CFND) COLLEGE OF FOOD NUTRITION AND DIETETICS")
            {
                this.cbCourse.Items.AddRange(new object[] { "Bachelor of Science in Food Technology",
                "Bachelor of Science in Nutrition and Dietetics" });
            }
            else if (cbCollege.Text == "(CHMT) COLLEGE OF HOSPITALITY MANAGEMENT AND TOURISM")
            {
                this.cbCourse.Items.AddRange(new object[] { "Bachelor of Science in Hotel and Restaurant Management",
                "Bachelor of Science in Tourism" });
            }
            else if (cbCollege.Text == "(COF) COLLEGE OF FISHERIES")
            {
                this.cbCourse.Items.AddRange(new object[] { "Bachelor of Science in Fisheries",
                "Bachelor of Science in Agri- Fisheries Business Management"
                ,"Bachelor of Science in Fishery Education" });
            }

        }

        public void asd()
        {
            classs = lblCourse.Text + " - " + lblYear.Text  + lblSection.Text;

            lblClass.Visible = true;
            lblClass.Text = classs;

        }



        private void btnCreate_Click(object sender, EventArgs e)
        {

            if (cbCollege.Text == "" || cbYear.Text == "" || comboBox1.Text == "")
            {
                MessageBox.Show("Please Fill in everything in the form to create a new class ", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {


                    qwe();
                    asd();

                    gbCreateClass.Visible = false;
                    gbAddStudent.Visible = true;
                    dataGridView1.Visible = true;


                }
                catch (Exception)
                {
                    MessageBox.Show("this class already exist ", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }


            }
        }

        private void btnLoadImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "JPG Files(*.jpg)|*.jpg|PNG Files(*.png)|*.png|All Files(*.*)|*.*";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                string picPath = dlg.FileName.ToString();
                tbImagePath.Text = picPath;
                pictureBox1.ImageLocation = picPath;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true
                )
            {
                gender = "male";
            }
            else if (radioButton2.Checked == true)
            {
                gender = "female";
            }
            else { }
            if (tbFirstName.Text == null || tbLastName.Text == null || tbContactNo.Text == null || gender == null || tbImagePath.Text == null)
            {
                MessageBox.Show("Name, contact number, image, gender fields are required to be fill out ", "fill out the required forms", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {

                FileStream fstream = new FileStream(this.tbImagePath.Text, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fstream);
                imageBT = br.ReadBytes((int)fstream.Length);

                sectionn = lblClass.Text;
                name = tbLastName.Text + ", " + tbFirstName.Text;
                id = "0418-" + tbID.Text + "";

                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into [dbo].[masterList] values('" + id + "','" + name + "','" + tbContactNo.Text + "','" + tbAddress.Text + "','" + gender + "','" + sectionn + "',@IMG)";

                cmd.Parameters.Add(new SqlParameter("@IMG", imageBT));

                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("new student successfully added!");
                pictureBox1.Image = null;
                tbAddress.Text = "";
                tbContactNo.Text = "";
                tbFirstName.Text = "";
                tbID.Text = "";
                tbImagePath.Text = "";
                tbLastName.Text = "";
                radioButton1.Checked = false;
                radioButton2.Checked = false;
            }
        }
    }
}
