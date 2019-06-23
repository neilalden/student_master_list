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
    public partial class Home : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Lb\source\repos\Student Master List\Student Master List\Classes.mdf;Integrated Security=True");
        string classs, gender;
        //byte[] imageBT = null;

        public static string passingText;

        public Home()
        {
            InitializeComponent();
        }


        

        private void Home_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'classesDataSet1._BSCS_IA' table. You can move, or remove it, as needed.
            //this.bSCS_IATableAdapter1.Fill(this.classesDataSet1._BSCS_IA);
            // TODO: This line of code loads data into the 'classesDataSet._BSCS_IA' table. You can move, or remove it, as needed.
            //DataSet ds = new DataSet();
            //SqlDataAdapter ada = new SqlDataAdapter("select * from sys.tables", con);

            // SqlCommand sqlCmd = new SqlCommand("SELECT * FROM sys.tables", con);
            // con.Open();
            // SqlDataReader sqlReader = sqlCmd.ExecuteReader();

            // while (sqlReader.Read())
            // {
            //     cbClass.Items.Add(sqlReader["name"].ToString());
            // }
            //con.Close();


            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd = new SqlCommand("select section From masterList", con);

            SqlDataReader Sdr = cmd.ExecuteReader();
            while (Sdr.Read())
            {
                for (int i = 0; i < Sdr.FieldCount; i++)
                {
                    cbClass.Items.Add(Sdr.GetString(i));

                }
            }
            Sdr.Close();
            con.Close();

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            createClass cc = new createClass();
            cc.Show();
            h.Hide();

        }

        private void btnClose_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Are you sure you want to close program?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
            else { }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        /*
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (tbSearch.Text == "")
            {
                MessageBox.Show("Please input a student name you want to search ", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                var a = cbClass.Items.ToString();
                label2.Text = a;


                groupBox2.Visible = true;
                groupBox1.Hide();
                con.Open();
                cmd.CommandText = "SELECT * FROM sys.tables where name LIKE'%" + tbSearch.Text + "%'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }
        }
        */

        private void btnOpen_Click(object sender, EventArgs e)
        {
            if (cbClass.Text == "")
            {
                MessageBox.Show("Please select a class to view", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                try
                {
                    groupBox2.Visible = true;

                    classs = cbClass.Text;
                    label2.Text = classs;
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "select Id, Name, Address, Gender, Contact_No from [dbo].[masterList] where section ='"+classs+"'";
                    cmd.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                    groupBox1.Hide();

                    con.Close();
                }
                catch(Exception)
                {
                    MessageBox.Show("class unavailable");
                }
            } 
        }

        public void dp()
        {
            string classs;
            classs = label2.Text;
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

        private void cbClass_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        /*
        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = false;
            gbAddStudent.Visible = true;
            btnSave.Visible = true;
            btnUpdate.Visible = false;
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
            gbProfileView.Visible = false;
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
            if (tbFirstName.Text == null || tbLastName.Text == null || tbMiddleName.Text == null || tbContactNo.Text == null || gender == null || tbImagePath.Text == null)
            {
                MessageBox.Show("Name, contact number, image and gender fields are required to be fill out ", "fill out the required forms", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string classs, name, id;
                classs = label2.Text;
                FileStream fstream = new FileStream(this.tbImagePath.Text, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fstream);
                imageBT = br.ReadBytes((int)fstream.Length);

                name = tbLastName.Text + ", " + tbFirstName.Text + " " + tbMiddleName.Text;
                id = "0418-" + tbID.Text + "";
                con.Open();


                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into [dbo ].[" + classs + "] values('" + id + "','" + name + "','" + tbContactNo.Text + "','" + tbAddress.Text + "','" + gender + "',@IMG)";

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
        */
        /*
        private void button1_Click(object sender, EventArgs e)
        {
            gbProfileView.Visible = false;
            btnUpdate.Visible = true;
            btnSave.Visible = false;
            gbAddStudent.Visible = true;
            pictureBox2.Visible = false;


            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from [dbo].[" + classs + "] where name LIKE'%" + tbSearch.Text + "%'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                tbID.Text = (dr["Id"].ToString());
                tbContactNo.Text = (dr["Contact_No"].ToString());
                tbAddress.Text = (dr["Address"].ToString());
                
                byte[] img = (byte[])(dr["Image"]);
                if (img == null)
                {
                    pictureBox1.Image = null;
                }
                else
                {
                    MemoryStream mstream = new MemoryStream(img);
                    pictureBox1.Image = System.Drawing.Image.FromStream(mstream);
                }

                con.Close();
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
        */
        private void btnSearch_Click(object sender, EventArgs e)
        {

            /*
         
            string classs;
            classs = label2.Text;

            if (gbProfileView.Visible == true && tbSearch.Text == "")
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select Id, Name, Address, Gender, Contact_No from [dbo].[" + classs + "] ";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                gbProfileView.Visible = false;
                gbAddStudent.Visible = false;
                con.Close();
            }
            else if (tbSearch.Text == "" && btnUpdate.Visible == true)
            {
                gbProfileView.Visible = false;
                gbAddStudent.Visible = false;
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select Id, Name, Address, Gender, Contact_No from [dbo].[" + classs + "] ";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }

            else if (tbSearch.Text == "" || gbProfileView.Visible == true || gbAddStudent.Visible == true)
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select Id, Name, Address, Gender, Contact_No from [dbo].[" + classs + "] ";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                gbProfileView.Visible = false;
                gbAddStudent.Visible = false;
                pictureBox2.Visible = true;
                con.Close();
            }

            else if (tbSearch.Text == "")
            {
                MessageBox.Show("please input student name", "unknown student", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    gbProfileView.Visible = true;
                   
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "select * from [dbo].[" + classs + "] where name LIKE'%" + tbSearch.Text + "%'";
                    cmd.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;

                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        label12.Text = (dr["Id"].ToString());
                        lblFirstName.Text = (dr["Name"].ToString());
                        lblContact.Text = (dr["Contact_No"].ToString());
                        lblCity.Text = (dr["Address"].ToString());
                        lblGender.Text = (dr["Gender"].ToString());

                        byte[] img = (byte[])(dr["Image"]);
                        if (img == null)
                        {
                            pictureBox3.Image = null;
                        }
                        else
                        {
                            MemoryStream mstream = new MemoryStream(img);
                            pictureBox3.Image = System.Drawing.Image.FromStream(mstream);
                        }

                        con.Close();
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("searched student might not yet exist yet", "unknown student", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            */

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        

        private void btnHome_Click(object sender, EventArgs e)
        {
            groupBox2.Visible = false;
            groupBox1.Visible = true;
           // gbProfileView.Visible = false;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (tbHomeSearch.Text == "")
            {
                MessageBox.Show("Please input a student name you want to search ", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                searchTab f = new searchTab();
                passingText = tbHomeSearch.Text;
                f.Show();
            }
        }

        private void label12_Click(object sender, EventArgs e)
        {
            label12.Visible = false;
            tbHomeSearch.Select();
        }

        private void tbHomeSearch_TextChanged(object sender, EventArgs e)
        {
            label12.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void cbClass_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        /*private void btnUpdate_Click(object sender, EventArgs e)
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
            if (tbFirstName.Text == null || tbLastName.Text == null || tbMiddleName.Text == null || tbContactNo.Text == null || gender == null || tbImagePath.Text == null)
            {
                MessageBox.Show("Name, contact number, image and gender fields are required to be fill out ", "fill out the required forms", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                classs = label2.Text;
                FileStream fstream = new FileStream(this.tbImagePath.Text, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fstream);
                imageBT = br.ReadBytes((int)fstream.Length);
                string name = tbLastName.Text + ", " + tbFirstName.Text + " " + tbMiddleName.Text;
                string id = tbID.Text;


                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "update [dbo].[" + classs + "]  set id ='" + id + "',name='" + name + "',contact_no='" + tbContactNo.Text + "',address='" + tbAddress.Text + "',gender='" + gender + "',image=@IMG where name='" + lblFirstName.Text + "'";
                cmd.Parameters.Add(new SqlParameter("@IMG", imageBT));

                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
                MessageBox.Show("student successfully updated", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }
        */
    }
}
