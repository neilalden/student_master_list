using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace Student_Master_List
{
    public partial class NewClass : Form
    {
        byte[] imageBT = null;
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Lb\source\repos\Student Master List\Student Master List\Classes.mdf;Integrated Security=True");
        string gender;
        public NewClass()
        {
            InitializeComponent();
        }

        private void NewClass_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'classesDataSet._BSCS_IA' table. You can move, or remove it, as needed.
            //this.bSCS_IATableAdapter.Fill(this.classesDataSet._BSCS_IA);
        }
        /*
        private void cbCollege_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbCollege_SelectedIndexChanged_1(object sender, EventArgs e)
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

        private void cbYear_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    */

    }
}
      /*  public void dp()
        {
            string classs;
            classs = lblCourse.Text + "-" + lblYear.Text + lblSection.Text;
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select Id, Name, Address, Gender, Contact_No from [dbo].[" + classs + "]";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            con.Close();
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
            section = comboBox1.Text;
            lblSection.Text = section;
        }

        public void asd()
        {
            string classs;
            classs = lblCourse.Text +"-"+ lblYear.Text + lblSection.Text;


                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "CREATE TABLE [dbo].[" + classs + "] ( [Id] VARCHAR(50) NOT NULL PRIMARY KEY, [Name] VARCHAR(255) NOT NULL, [Contact_No] VARCHAR(255) NULL, [Address] VARCHAR(255) NULL, [Gender] VARCHAR(50) NOT NULL, [Image] IMAGE NULL )";
                cmd.ExecuteNonQuery();
                con.Close();

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (cbCollege.Text == "" ||  comboBox1.Text == "")
            {
                    MessageBox.Show("Please Fill in everything in the form to create a new class ", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {


                    qwe();
                    asd();

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
            if (radioButton1.Checked == true)
            {
                gender = "male";
            }
            else if (radioButton2.Checked == true)
            {
                gender = "female";
            }
            else { }
            if (tbFirstName.Text == null || tbLastName.Text == null || tbMiddleName.Text == null || tbContactNo.Text ==null || gender == null|| tbImagePath.Text== null)
            {
                MessageBox.Show("Name, contact number, image, gender fields are required to be fill out ", "fill out the required forms", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {

                FileStream fstream = new FileStream(this.tbImagePath.Text, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fstream);
                imageBT = br.ReadBytes((int)fstream.Length);

                string classs,name,id;
                classs = lblCourse.Text + "-" + lblYear.Text + lblSection.Text;
                name = tbLastName.Text + ", " + tbFirstName.Text + " " + tbMiddleName.Text;
                id = "0418-"+tbID.Text+"";
                con.Open();


                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into [dbo].[" + classs + "] values('" + id + "','" + name+ "','" + tbContactNo.Text + "','" + tbAddress.Text + "','" + gender + "',@IMG)";

                cmd.Parameters.Add(new SqlParameter("@IMG", imageBT));

                cmd.ExecuteNonQuery();
                con.Close();
                dp();
                MessageBox.Show("new student successfully added!");
                pictureBox1.Image = null;
                tbAddress.Text = "";
                tbContactNo.Text = "";
                tbFirstName.Text = "";
                tbID.Text = "";
                tbImagePath.Text = "";
                tbLastName.Text = "";
                tbMiddleName.Text = "";
                radioButton1.Checked = false;
                radioButton2.Checked = false;
            }
        }

        private void lblCourse_Click(object sender, EventArgs e)
        {

        }

        private void tbMiddleName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Home q = new Home();
            this.Hide();
            q.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Home q = new Home();
            this.Hide();
            q.Show();
        }
    }
    */

