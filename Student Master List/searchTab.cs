using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.IO;

namespace Student_Master_List
{
    public partial class searchTab : Form
    {


        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Lb\source\repos\Student Master List\Student Master List\Classes.mdf;Integrated Security=True");
        Home z = new Home();


        public searchTab()
        {
            InitializeComponent();
        }

        public void searchTables()
        {

            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM masterList where name LIKE'%" + tbSearch.Text + "%'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                lblSection.Text = (dr["Section"].ToString());
                lblName.Text = (dr["Name"].ToString());
                lblId.Text = (dr["Id"].ToString());
                lblCity.Text = (dr["Address"].ToString());
                lblGender.Text = (dr["Gender"].ToString());
                byte[] img = (byte[])(dr["Image"]);
                MemoryStream mstream = new MemoryStream(img);
                pictureBox.Image = System.Drawing.Image.FromStream(mstream);
            }
            con.Close();

        }
        

        private void searchTab_Load(object sender, EventArgs e)
        {
            z.Close();
            searchTables();
            tbSearch.Text = Home.passingText;

            //string strColumn = "section"; // In your case your column
            //string[] strSplitValues = strColumn.Split(','); //Whatever separator you use e.g comma 

            //lblSection.Text = strSplitValues[0].ToString();
            //lblSection1.Text = strSplitValues[1].ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        //    con.Open();
        //    SqlDataReader myReader = null;
        //    SqlCommand myCommand = new SqlCommand("select * from masterList", con);
        //    myReader = myCommand.ExecuteReader();
        //    while (myReader.Read())
        //    {
        //        lblName.Text = myReader["Name"].ToString();
        //    }
        //    con.Close();

            searchTables();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
        }
    }
}
     /*
 

    public void za()
        {
            if (gb1.Visible == true)
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM [dbo].[" + gb1.Text + "] where name LIKE'%" + tbSearch.Text + "%'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                SqlDataReader dr = cmd.ExecuteReader();
                int RecordCount = 0;

                try
                {

                    
                    while (dr.Read())
                    {
                        //Write logic to process data for the first result.
                        RecordCount = RecordCount + 1;
                    }
                    MessageBox.Show("Total number of Authors: " + RecordCount.ToString());
                    

                    dr.NextResult();
                        RecordCount = 0;

                        while (dr.Read())
                        {
                            //Write logic to process data for the second result.
                            RecordCount = RecordCount + 1;
                        }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                finally
                {
                    con.Close();
                }

                    /*
                    if (dr.Read())
                    {
                        lblName.Text = (dr["Name"].ToString());
                        lblId.Text = (dr["Id"].ToString());
                        lblCity.Text = (dr["Address"].ToString());
                    }
                    con.Close();
            }
        }







            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM sys.tables where name LIKE'%" + tbSearch.Text + "%'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                gb1.Visible = true;
                gb1.Text = (dr["Name"].ToString());
            }
            con.Close();
            za();




     */