using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
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
            dtBd.Value = new DateTime(2000, 1, 1);
            cbGenderReport.SelectedIndex = 0;
        }

        private void btSeacrh_Click(object sender, EventArgs e)
        {
            int id = string.IsNullOrEmpty(tbIdSearch.Text) ? -1 : int.Parse(tbIdSearch.Text);
            gvStudent.DataSource = RefreshData(id);
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show("Добавить нового студента", "Добавление", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (confirm != DialogResult.OK)
            {
                MessageBox.Show("Отменено пользавателем", "Отмена", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if(tbFN.Text == "")
            {
                MessageBox.Show("Поле Имя обязатльно для заполнения");
                tbFN.Focus();
                return;
            }

            int diff = DateTime.Now.Year - dtBd.Value.Year;
            if (diff <= 17)
            {
                MessageBox.Show("Некорректная дата рождения");
                dtBd.Focus();
                return;
            }
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
            var confirm = MessageBox.Show("Удалить выделенного студента?", 
                "Удаление", 
                MessageBoxButtons.OKCancel, 
                MessageBoxIcon.Information);
            if (confirm != DialogResult.OK)
            {
                MessageBox.Show("Отменено пользователем", 
                    "Удаление", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Information);
                return;
            }
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

        private void btRepByGender_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["conStr"]))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("pStudentReport_GetStudentByGender @gender", con))
                {
                    string gender = null;
                    switch (cbGenderReport.SelectedIndex)
                    {
                        case 0:
                            gender = "a";
                            break;
                        case 1:
                            gender = "m";
                            break;
                        case 2:
                            gender = "f";
                            break;
                        default:
                            break;
                    }
                    cmd.Parameters.AddWithValue("gender", gender);
                    DataTable dt = new DataTable();
                    dt.Load(cmd.ExecuteReader());
                    StringBuilder sb = new StringBuilder();
                    sb.AppendLine("lastname;firstname;gender");
                    foreach (DataRow item in dt.Rows)
                    {
                        sb.AppendLine(item[1].ToString() + ";" + item[2].ToString() + ";" + item[4].ToString());
                    }
                    File.WriteAllText(DateTime.Now.ToString("yyyy_MM_dd HH_mm_ss") + ".csv", sb.ToString());                    
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



create proc pStudentUpd 
@id int, 
@firstName nvarchar(200), 
@lastName nvarchar(200), 
@dateBirth datetime, 
@gender char(1)
as
update Student
set 
firstName = @firstName, 
lastName = @lastName, 
dateBirth = @dateBirth, 
gender = @gender
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


create proc pStudentReport_GetStudentByGender --'a'
@gender char(1)
as
select	s.id,
		s.lastName,
		s.firstName,
		s.dateBirth,
		s.gender
from student s
where (@gender = 'a' or s.gender = @gender)


 */