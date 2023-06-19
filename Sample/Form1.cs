using ClosedXML.Excel;
using ExcelDataReader;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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

        private void button2_Click(object sender, EventArgs e)
        {
            string fileName = @"C:\temp\срок аренды.xlsx";
            using (var excelWorkbook = new XLWorkbook(fileName))
            {
                var nonEmptyDataRows = excelWorkbook.Worksheet(1).RowsUsed();

                foreach (var dataRow in nonEmptyDataRows)
                {
                    //for row number check
                    //if (dataRow.RowNumber() >= 3 && dataRow.RowNumber() <= 20)
                    {
                        dataRow.Cell(10).Style.NumberFormat.Format = "dd.MM.yyyy";
                        DateTime dt;

                        if (DateTime.TryParse(dataRow.Cell(10).Value.ToString(), out dt))
                            Text = dt.ToString();


                        string st = $"{dataRow.Cell(8).Value.ToString()} " +
                            $"{dataRow.Cell(10).Value}  " +
                            $"{dataRow.Cell(11).Value.ToString()}";
                        Text = st;

                        //Thread.Sleep(3000);

                    }
                }
            }
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
    }
}
