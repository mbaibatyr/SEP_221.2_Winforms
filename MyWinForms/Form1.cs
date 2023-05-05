using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyWinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("id", typeof(string));
            dt.Columns.Add("name", typeof(string));
            dt.Rows.Add(new object[] { "1", "asd" });
            dt.Rows.Add(new object[] { "2", "ased" });
            dt.Rows.Add(new object[] { "3", "aserd" });
            
            cbCIty.DataSource = dt;
        }

        private void cbCIty_SelectedIndexChanged(object sender, EventArgs e)
        {
            //int selectedValue = (int)cbCIty.SelectedValue;
            //using (SqlCommand cmd = new SqlCommand("select * from city where CountryId = " + selectedValue, conStr))

            //    Text = cbCIty.Text + " " + selectedValue + " " + cbCIty.SelectedIndex;


        }

        private void button2_Click(object sender, EventArgs e)
        {
            //using (SqlConnection conStr = new SqlConnection(ConfigurationManager.AppSettings["conStr"]))
            using (SqlConnection conStr = new SqlConnection(ConfigurationManager.ConnectionStrings["conStr"].ToString()))
            {
                conStr.Open();
                using (SqlCommand cmd = new SqlCommand("select * from city", conStr))
                {
                    DataTable dt = new DataTable();
                    dt.Load(cmd.ExecuteReader());
                    cbCIty.DataSource = dt;

                }
                
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void fghfgToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

       

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            cbCIty.Items.Add((sender as ToolStripMenuItem).Text); 
        }

       

        private void button1_Click_1(object sender, EventArgs e)
        {
            using (SqlConnection conStr = new SqlConnection(ConfigurationManager.ConnectionStrings["conStr"].ToString()))
            {
                conStr.Open();
                using (SqlCommand cmd = new SqlCommand("select * from city", conStr))
                {
                    DataTable dt = new DataTable();
                    //dt.Load(cmd.ExecuteReader());
                    //.DataSource = dt;

                }

            }
        }

        private void gvCity_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["conStr"]))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("pUsers @login, @last_name, @first_name, @password", con))
                {
                    cmd.Parameters.AddWithValue("@login", "tbLogin.text");
                    cmd.Parameters.AddWithValue("@last_name", "tblast_name.text");
                    cmd.Parameters.AddWithValue("@first_name", "tbfirst_name.text");
                    cmd.Parameters.AddWithValue("@password", "tbpassword.text");
                    var obj = cmd.ExecuteScalar();
                    if (obj.ToString() == "0")
                        MessageBox.Show("такой логин уже существует");
                    else
                        MessageBox.Show("логин успешно добавлен");
                }
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (textBox1.Left > 0)
                textBox1.Left -= 5;
            else
                timer1.Stop();
        }

        private void btCityLoad_Click(object sender, EventArgs e)
        {
            using (SqlConnection conStr = new SqlConnection(ConfigurationManager.ConnectionStrings["conStr"].ToString()))
            {
                conStr.Open();
                using (SqlCommand cmd = new SqlCommand("select * from city", conStr))
                {
                    DataTable dt = new DataTable();
                    dt.Load(cmd.ExecuteReader());
                    dgCity.DataSource = dt;

                }

            }
        }
    }

    class City
    {
        public int id { get; set; }
        public string name { get; set; }
    }
}


/*
 
city_id
CityId
cityIdNameId

 */