using ClosedXML.Excel;
using ExcelDataReader;
using NLog;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sample
{
    public partial class Form1 : Form
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();
        List<Data> lst;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //using (var stream = File.Open(@"C:\temp\срок аренды.xlsx", FileMode.Open, FileAccess.Read))
            using (var stream = File.Open(@"C:\temp\книга1.xlsx", FileMode.Open, FileAccess.Read))
            {
                using (var reader = ExcelReaderFactory.CreateReader(stream))
                {
                    var result = reader.AsDataSet();
                    dgAgents.DataSource = result.Tables[0];
                    DateTime dt;
                    foreach (DataRow row in result.Tables[0].Rows)
                    {
                        if (DateTime.TryParse(row[4].ToString(), out dt))
                            MessageBox.Show(dt.ToString());
                        else
                            MessageBox.Show(row[4].ToString());
                    }
                }
            }
        }

        private static string GetConnectionString(string file)
        {
            Dictionary<string, string> props = new Dictionary<string, string>();

            string extension = file.Split('.').Last();

            if (extension == "xls")
            {
                //Excel 2003 and Older
                props["Provider"] = "Microsoft.Jet.OLEDB.4.0";
                props["Extended Properties"] = "Excel 8.0";
            }
            else if (extension == "xlsx")
            {
                //Excel 2007, 2010, 2012, 2013
                props["Provider"] = "Microsoft.ACE.OLEDB.12.0;";
                props["Extended Properties"] = "Excel 12.0 XML";
            }
            else
                throw new Exception(string.Format("error file: {0}", file));

            props["Data Source"] = file;

            StringBuilder sb = new StringBuilder();

            foreach (KeyValuePair<string, string> prop in props)
            {
                sb.Append(prop.Key);
                sb.Append('=');
                sb.Append(prop.Value);
                sb.Append(';');
            }

            return sb.ToString();
        }

        DataTable getData()
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.AppSettings["conStr"]))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("select firstname, dt from Data", conn))
                {
                    dt.Load(cmd.ExecuteReader());
                }
                conn.Close();
            }

            return dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //DateTime date = DateTime.Parse("2015-01-01");
            //DataTable dt = new DataTable();
            //dt.Columns.Add("firstname", typeof(string));
            //dt.Columns.Add("dt", typeof(DateTime));
            //dt.Rows.Add(new object[] { "murat", DateTime.Parse("2015-01-05") });
            //dt.Rows.Add(new object[] { "Arman", DateTime.Parse("2015-01-05") });

            DataTable dt = getData();

            string fileName = @"C:\Users\байбатыровм\Documents\Книга2.xlsx";
            using (var excelWorkbook = new XLWorkbook(fileName))
            {
                var Rows = excelWorkbook.Worksheet(1).RowsUsed().Skip(1);
                foreach (IXLRow row in Rows)
                {
                    var dt1 = DateTime.Parse(row.Cell(1).GetString());
                    var dt2 = DateTime.Parse(row.Cell(3).GetString());
                    DataRow[] result = dt.Select("firstname = '" + row.Cell(2).GetString() +
                        "' and dt >= '" + dt1 + "' and dt <= '" + dt2 + "'");
                    if (result.Count() > 0)
                        row.Cell(4).SetValue("ok");
                    else
                        row.Cell(4).SetValue("-");
                    //Insert(row.Cell(1).GetString(), row.Cell(2).GetString());

                }
                excelWorkbook.Save();
            }
            MessageBox.Show("done");
        }
        private void button3_Click(object sender, EventArgs e)
        {

            DataSet ds = new DataSet();

            string connectionString = GetConnectionString(@"C:\temp\срок аренды.xlsx");

            using (OleDbConnection conn = new OleDbConnection(connectionString))
            {
                conn.Open();
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = conn;

                // Get all Sheets in Excel File
                DataTable dtSheet = conn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);

                // Loop through all Sheets to get data
                foreach (DataRow dr in dtSheet.Rows)
                {
                    string sheetName = dr["TABLE_NAME"].ToString();

                    if (!sheetName.EndsWith("$"))
                        continue;

                    // Get all rows from the Sheet
                    cmd.CommandText = "SELECT * FROM [" + sheetName + "]";

                    DataTable dt = new DataTable();
                    dt.TableName = sheetName;

                    OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                    da.Fill(dt);

                    ds.Tables.Add(dt);
                }

                cmd = null;
                conn.Close();
            }


        }

        private void button4_Click(object sender, EventArgs e)
        {
            DataTable dtExcel = new DataTable();
            DataTable dtDB = new DataTable();
            using (var stream = File.Open(@"C:\temp\книга1.xlsx", FileMode.Open, FileAccess.Read))
            {
                using (var reader = ExcelReaderFactory.CreateReader(stream))
                {
                    var result = reader.AsDataSet();
                    dtExcel = result.Tables[0];
                    dtExcel.Rows[0].Delete();
                }
            }

            using (SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\байбатыровм\Documents\testDB.mdf;Integrated Security=True;Connect Timeout=30"))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("select lastName, [month], factSales from sales", con))
                {
                    dtDB.Load(cmd.ExecuteReader());
                }
                con.Close();
            }

            foreach (DataRow item in dtDB.Rows)
            {
                var dr = dtExcel.Select("f2 = '" + item[0].ToString() + "'");
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            lst = new List<Data>();
            DataTable dt = getData();
            string fileName = @"C:\Users\байбатыровм\Documents\Книга2.xlsx";
            using (var excelWorkbook = new XLWorkbook(fileName))
            {
                var Rows = excelWorkbook.Worksheet(1).RowsUsed().Skip(1);
                foreach (IXLRow row in Rows)
                {

                    DataRow[] result = dt.Select("firstname = '" + row.Cell(2).GetString() + "'");
                    if (result.Count() > 0)
                        continue;
                    else
                        lst.Add
                            (
                                new Data
                                {
                                    firstname = row.Cell(2).GetString(),
                                    dt = DateTime.Parse(row.Cell(1).GetString())
                                }
                            );

                }
                Insert(lst);

            }
            MessageBox.Show("done");
        }

        private void Insert(List<Data> lst)
        {
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.AppSettings["conStr"]))
            {
                conn.Open();
                string sql = "insert into Data (firstname, dt) values (N'{0}', '{1}')";
                foreach (var item in lst)
                {
                    using (SqlCommand cmd = new SqlCommand(string.Format(sql, item.firstname, item.dt), conn))
                    {
                        cmd.ExecuteNonQuery();
                    }
                }

                conn.Close();
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            DataTable dt = getData();
            string fileName = @"C:\Users\байбатыровм\Documents\Книга2.xlsx";
            using (var excelWorkbook = new XLWorkbook(fileName))
            {
                excelWorkbook.AddWorksheet(dt, "Лист2");
                excelWorkbook.Save();
            }
            MessageBox.Show("done");
        }

        private void btLog_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = getData();
                //var array = new string[1];
                //array[10] = "";
                //logger.Info("btLog_Click:getData:rowCount: " + dt.Rows.Count);
                Text = addLog("INFO", "btLog_Click: getData:rowCount: " + dt.Rows.Count, "User1");
            }
            catch (Exception err)
            {
                //logger.Error("btLog_Click: " + err.Message);
                Text = addLog("ERROR", "btLog_Click: " + err.Message, "User1");
            }
        }

        string addLog(string logType, string logText, string user)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["conStr"]))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand("pMyLog", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@logType", logType);
                        cmd.Parameters.AddWithValue("@logText", logText);
                        cmd.Parameters.AddWithValue("@user", user);
                        cmd.ExecuteNonQuery();
                        con.Close();
                        return "ok";
                    }
                }
            }
            catch (Exception err)
            {
                return "error: " + err.Message;
            }
        }
    }

    public class Data
    {
        public string firstname { get; set; }
        public DateTime dt { get; set; }
    }
}
