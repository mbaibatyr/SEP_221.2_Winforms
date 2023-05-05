using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyWinForms
{
    public partial class fmStudent : Form
    {
        DataTable RefreshData(int id)
        {
            using (SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["conStr"]))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("pStudentsGetAll @id", con))
                {
                    cmd.Parameters.AddWithValue("id", id);
                    DataTable dt = new DataTable();
                    dt.Load(cmd.ExecuteReader());
                    return dt;
                }
            }
        }
        public fmStudent()
        {
            InitializeComponent();
        }

        private void fmStudent_Load(object sender, EventArgs e)
        {
            gvStudent.DataSource = RefreshData(-1);
        }

        private void btSeacrh_Click(object sender, EventArgs e)
        {
            int id = string.IsNullOrEmpty(tbIdSearch.Text) ? -1 : int.Parse(tbIdSearch.Text);
            gvStudent.DataSource = RefreshData(id);
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["conStr"]))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("pStudentsIns @lastName, @firstName, @dateBirth, @gender", con))
                {
                    cmd.Parameters.AddWithValue("lastName", tbLN.Text);
                    cmd.Parameters.AddWithValue("firstName", tbFN.Text);
                    cmd.Parameters.AddWithValue("dateBirth", dtBd.Value);
                    cmd.Parameters.AddWithValue("gender", cbGender.SelectedIndex == 0 ? "m" : "f");
                    var result = cmd.ExecuteScalar();
                    if (result.ToString() == "1")
                        MessageBox.Show("Успешно добавлен");
                    else
                        MessageBox.Show("Уже существует");                    
                }
            }
        }
    }
}
