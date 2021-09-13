using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;       // Thư viện Save to Excel

using DataTable = System.Data.DataTable;
using System.Drawing.Printing;

namespace AddStudent
{
    public partial class Print : Form
    {
        public Print()
        {
            InitializeComponent();
        }
        SqlConnection cnn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=AddStu;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        Student student = new Student();
        public void ketnoicsdl()
        {

            SqlCommand command = new SqlCommand("SELECT Id as N'MSSV', lname as N'Họ', fname as N'Tên', bdate as N'Ngày Sinh', gender as N'Giới tính', phone as N'SDT', address as N'Địa Chỉ', picture as N'Hình ảnh', selectCourse AS N'Môn Chọn Học' FROM std");
            dataGridView1.ReadOnly = true;
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            dataGridView1.RowTemplate.Height = 80;
            dataGridView1.DataSource = student.getStudents(command);
            dataGridView1.Columns[3].DefaultCellStyle.Format = "yyyy - MM - dd";
            picCol = (DataGridViewImageColumn)dataGridView1.Columns[7];
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dataGridView1.AllowUserToAddRows = false;
        }
        private void Print_Load(object sender, EventArgs e)
        {
            SetMyCustomFormat();     // Chạy customs Date
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButtonYes.Checked == false)
            {
                if (radioButtonAll.Checked == true)
                {
                    ketnoicsdl();
                }
                if (radioButtonMale.Checked == true)
                {
                    SearchResult();
                }
                if (radioButtonFemale.Checked == true)
                {
                    SearchResult1();
                }
            }
            else
            {
                string date1 = dateTimePicker1.Value.ToString("yyyy-MM-dd");
                string date2 = dateTimePicker2.Value.ToString("yyyy-MM-dd");
                if (radioButtonMale.Checked == true)
                {
                    SqlCommand command = new SqlCommand("SELECT * FROM std WHERE bdate BETWEEN '" + date1 + "' AND '" + date2 + "' AND gender = 'Male'");
                    dataGridView1.ReadOnly = true;
                    DataGridViewImageColumn picCol = new DataGridViewImageColumn();
                    dataGridView1.RowTemplate.Height = 80;
                    dataGridView1.DataSource = student.getStudents(command);
                    picCol = (DataGridViewImageColumn)dataGridView1.Columns[7];
                    dataGridView1.Columns[3].DefaultCellStyle.Format = "yyyy - MM - dd";
                    picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
                    dataGridView1.AllowUserToAddRows = false;
                }
                if (radioButtonAll.Checked == true)
                {
                    SqlCommand command = new SqlCommand("SELECT * FROM std WHERE bdate BETWEEN '" + date1 + "' AND '" + date2 + "'");
                    dataGridView1.ReadOnly = true;
                    DataGridViewImageColumn picCol = new DataGridViewImageColumn();
                    dataGridView1.RowTemplate.Height = 80;
                    dataGridView1.DataSource = student.getStudents(command);
                    picCol = (DataGridViewImageColumn)dataGridView1.Columns[7];
                    dataGridView1.Columns[3].DefaultCellStyle.Format = "yyyy - MM - dd";
                    picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
                    dataGridView1.AllowUserToAddRows = false;
                }
                if (radioButtonFemale.Checked == true)
                {
                    SqlCommand command = new SqlCommand("SELECT * FROM std WHERE bdate BETWEEN '" + date1 + "' AND '" + date2 + "' AND gender = 'Female'");
                    dataGridView1.ReadOnly = true;
                    DataGridViewImageColumn picCol = new DataGridViewImageColumn();
                    dataGridView1.RowTemplate.Height = 80;
                    dataGridView1.DataSource = student.getStudents(command);
                    picCol = (DataGridViewImageColumn)dataGridView1.Columns[7];
                    dataGridView1.Columns[3].DefaultCellStyle.Format = "yyyy - MM - dd";
                    picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
                    dataGridView1.AllowUserToAddRows = false;
                }

            }
        }
        public void SearchResult()
        {
            string s = "Male";
            SqlCommand command = new SqlCommand("SELECT * FROM std where gender = '" + s + "'");
            dataGridView1.ReadOnly = true;
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            dataGridView1.RowTemplate.Height = 80;
            dataGridView1.DataSource = student.getStudents(command);
            picCol = (DataGridViewImageColumn)dataGridView1.Columns[7];
            dataGridView1.Columns[3].DefaultCellStyle.Format = "yyyy - MM - dd";
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dataGridView1.AllowUserToAddRows = false;
        }
        public void SearchResult1()
        {
            SqlCommand command = new SqlCommand("SELECT * FROM std where gender = 'Female'");
            dataGridView1.ReadOnly = true;
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            dataGridView1.RowTemplate.Height = 80;
            dataGridView1.DataSource = student.getStudents(command);
            picCol = (DataGridViewImageColumn)dataGridView1.Columns[7];
            dataGridView1.Columns[3].DefaultCellStyle.Format = "yyyy - MM - dd";
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dataGridView1.AllowUserToAddRows = false;
        }
        SaveDocx saveDocx = new SaveDocx();
        private void buttonSaveWord_Click(object sender, EventArgs e)
        {
            DataTable data = (DataTable)this.dataGridView1.DataSource;
            List<string> header = new List<string>();
            for (int i = 0; i < 8; i++)
            {
                header.Add(data.Columns[i].ColumnName);
            }
            List<Student> listStu = new List<Student>();
            for (int i = 0; i < data.Rows.Count; i++)
            {
                DataGridViewRow row = this.dataGridView1.Rows[i];
                int Id = int.Parse(row.Cells[0].Value.ToString().Trim());
                string fname = row.Cells[1].Value.ToString().Trim();
                string lname = row.Cells[2].Value.ToString().Trim();
                DateTime bdate = DateTime.Parse(row.Cells[3].Value.ToString());
                bool gender = (row.Cells[4].Value.ToString().Trim() == "Male");
                string phone = row.Cells[5].Value.ToString().Trim();
                string address = row.Cells[6].Value.ToString().Trim();
                Image pic = this.ConvertToImage((Byte[])row.Cells[7].Value);
                listStu.Add(new Student(Id, fname, lname, bdate, gender, phone, address, pic));
            }
            saveDocx.createTable(header, listStu);
            MessageBox.Show("Save Thanh Cong. Vi tri luu tai D:| Nam 2 - Hk2 | WinForm | AddStudent | Addstudent | bin | Debug.");

        }
        //Conver dữ liệu trong database sang kiểu dữ liệu Image
        private Image ConvertToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }
        public void SetMyCustomFormat()   // Customs Date theo ý muốn của mình, bỏ thứ và hiện giao diện Date theo ý
        {
            // Set the Format type and the CustomFormat string.
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "yyyy - MM - dd";
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.CustomFormat = "yyyy - MM - dd";
        }
        // Save to Excel
        //private void export2Excel(DataGridView g, string duongDan, string tenTap)
        //{
        //    app obj = new app();
        //    obj.Application.Workbooks.Add(Type.Missing);
        //    obj.Columns.ColumnWidth = 25;
        //    for (int i = 1; i < g.Columns.Count + 1; i++)
        //    {
        //        obj.Cells[1, i] = g.Columns[i - 1].HeaderText;
        //    }
        //    for (int i = 0; i < g.Rows.Count; i++)
        //    {
        //        for (int j = 0; j < g.Columns.Count; j++)
        //        {
        //            if (g.Rows[i].Cells[j].Value != null)
        //            {
        //                obj.Cells[i + 2, j + 1] = g.Rows[i].Cells[j].Value.ToString();
        //            }
        //        }
        //    }
        //    obj.ActiveWorkbook.SaveCopyAs(duongDan + tenTap + ".xlsx");
        //    obj.ActiveWorkbook.Saved = true;
        //}
        //private void buttonSaveExcel_Click(object sender, EventArgs e)
        //{
        //    export2Excel(dataGridView1, @"D:\Nam 2 - HK2\WinForm\AddStudent\AddStudent\bin\Debug", "AddStudent");
        //    MessageBox.Show("Save Thanh Cong. Vi tri luu tai D:| Nam 2 - Hk2 | WinForm | AddStudent | Addstudent | bin.");
        //}

        private void buttonPrinter_Click(object sender, EventArgs e)
        {
            PrintPreviewDialog printPreviewDialog1 = new PrintPreviewDialog();
            PrintDialog pDlg = new PrintDialog();
            PrintDocument pDoc = new PrintDocument();
            pDoc.DocumentName = "Print Document";
            pDlg.Document = pDoc;
            pDlg.AllowSelection = true;
            pDlg.AllowSomePages = true;
            pDoc.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);
            if (pDlg.ShowDialog() == DialogResult.OK)
            {
                printPreviewDialog1.Document = pDoc;
                printPreviewDialog1.ShowDialog();
                pDoc.Print();
            }
            else
            {
                MessageBox.Show("Ðã huy in");
            }
        }
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            string str = "";
            int row = dataGridView1.Rows.Count;
            int cell = dataGridView1.Rows[1].Cells.Count;
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < cell; j++)
                {
                    if (dataGridView1.Rows[i].Cells[j].Value == null)
                    {
                        dataGridView1.Rows[i].Cells[j].Value = "null";
                    }
                    str += dataGridView1.Rows[i].Cells[j].Value.ToString().Trim() + " , ";
                }
                str += "\n";
            }

            e.Graphics.DrawString(str, new System.Drawing.Font("Arial", 30), Brushes.Black, new System.Drawing.Point(10, 10));
        }
    }
}
