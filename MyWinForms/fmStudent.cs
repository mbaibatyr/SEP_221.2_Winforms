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
                using (SqlCommand cmd = new SqlCommand("pStudentGetAll @id", con))
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
                using (SqlCommand cmd = new SqlCommand("pStudentIns @firstName, @lastName, @dateBirth, @gender", con))
                {
                    cmd.Parameters.AddWithValue("firstName", tbFN.Text);
                    cmd.Parameters.AddWithValue("lastName", tbLN.Text);                    
                    cmd.Parameters.AddWithValue("dateBirth", dtBd.Value.Date);
                    cmd.Parameters.AddWithValue("gender", cbGender.SelectedIndex == 0 ? "m" : "f");
                    var result = cmd.ExecuteScalar();
                    if (result.ToString() == "1")
                        MessageBox.Show("Успешно добавлен");
                    else
                        MessageBox.Show("Уже существует");                    
                }
            }
        }

        private void gvStudent_CellClick(object sender, DataGridViewCellEventArgs e)
        {            
            tbLN.Text = (sender as DataGridView).SelectedCells[2].Value.ToString();
            tbFN.Text = (sender as DataGridView).SelectedCells[1].Value.ToString();
            dtBd.Text = gvStudent.SelectedCells[3].Value.ToString();
            cbGender.SelectedIndex = 
                (sender as DataGridView).SelectedCells[4].Value.ToString() == "m" ? 0 : 1;
        }

        private void btUpd_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["conStr"]))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("pStudentUpd @id, @firstName, @lastName, @dateBirth, @gender", con))
                {
                    int id = int.Parse(gvStudent.SelectedCells[0].Value.ToString());
                    cmd.Parameters.AddWithValue("id", id);
                    cmd.Parameters.AddWithValue("firstName", tbFN.Text);
                    cmd.Parameters.AddWithValue("lastName", tbLN.Text);
                    cmd.Parameters.AddWithValue("dateBirth", dtBd.Value.Date);
                    cmd.Parameters.AddWithValue("gender", cbGender.SelectedIndex == 0 ? "m" : "f");
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Успешно обновлено");
                    gvStudent.DataSource = RefreshData(-1);
                }
            }
        }

        private void btDel_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["conStr"]))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("pStudentDel @id", con))
                {
                    int id = int.Parse(gvStudent.SelectedCells[0].Value.ToString());
                    cmd.Parameters.AddWithValue("id", id);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Успешно удалено");
                    gvStudent.DataSource = RefreshData(-1);
                }
            }
        }
    }
}


/*
 https://github.com/mbaibatyr/SEP_221.2_Winforms.git

CREATE proc pStudentGetAll
@id int
as
select * from student
where (@id = -1 or id = @id)
order by lastName



CREATE proc pStudentDel --2
@id int
as
delete from student
where id = @id



create proc pStudentIns
@firstName NVARCHAR (200),
@lastName  NVARCHAR (200),
@dateBirth DATETIME,
@gender    CHAR (1)
as
if exists (select 1 from student s 
			where s.firstName = @firstName
			and s.lastName = @lastName)
begin
	select 0 status
end
else
begin
	insert into student
	(firstName,
	lastName,
	dateBirth,
	gender
	)
	values
	(
	@firstName,
	@lastName,
	@dateBirth,
	@gender
	)
	select 1 status
end
 */