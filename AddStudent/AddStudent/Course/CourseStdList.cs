using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Word;
using DataTable = System.Data.DataTable;

namespace AddStudent
{
    public partial class CourseStdList : Form
    {
        public CourseStdList()
        {
            InitializeComponent();
        }
        Student student = new Student();
        DataBase mydb = new DataBase();
        public void hienThi(string label, string semester)
        {
            this.textBoxCourse.Text = label;
            this.labelSemester.Text = "Semester: " + semester;

            SqlCommand command = new SqlCommand("SELECT Id AS ID, fname AS N'Họ', lname AS N'Tên', bdate AS N'Ngày Sinh' FROM std WHERE selectCourse LIKE '%" + label + "%'", mydb.GetConnection);

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            table.Columns.Add("STT", typeof(Int32));
            adapter.Fill(table);
            int len = table.Rows.Count;
            for (int i = 0; i < len; i++)
            {
                table.Rows[i][0] = i + 1;
            }

            //this.dataGridViewStdList.ReadOnly = true;
            this.dataGridViewStdList.DataSource = table;
            dataGridViewStdList.Columns[4].DefaultCellStyle.Format = "yyyy - MM - dd";
            this.dataGridViewStdList.AllowUserToAddRows = false;
        }

        private void buttonPrint_Click(object sender, EventArgs e)
        {
            // Tạo đường dẫn đến word
            _Application oWord = new Microsoft.Office.Interop.Word.Application();
            //Tạo một Document
            _Document wordDoc = oWord.Documents.Add();
            int ColumnCount = dataGridViewStdList.Columns.Count;
            object missing = System.Reflection.Missing.Value;
            Paragraph para1 = wordDoc.Content.Paragraphs.Add(ref missing);
            string time = "Ngày " + DateTime.Today.Day.ToString("00") + " Tháng " + DateTime.Today.Month.ToString("00") + " Năm "
                + DateTime.Today.Year.ToString("0000");
            foreach (Microsoft.Office.Interop.Word.Section section in wordDoc.Sections)
            {
                //Get the header range and add the header details.
                Microsoft.Office.Interop.Word.Range headerRange = section.Headers[Microsoft.Office.Interop.Word.WdHeaderFooterIndex.wdHeaderFooterPrimary].Range;
                headerRange.Fields.Add(headerRange, Microsoft.Office.Interop.Word.WdFieldType.wdFieldPage);
                headerRange.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphCenter;
                headerRange.Font.ColorIndex = Microsoft.Office.Interop.Word.WdColorIndex.wdBlack;   // Màu
                headerRange.Font.Bold = 2;        // Độ Đậm Chữ
                headerRange.Font.Size = 14;
                headerRange.Text = "Trường Đại Học Sư Phạm Kỹ Thuật Tp Hồ Chí Minh\n" + time
                                + "\nMôn: Lập trình trên Windows\n\t\t Giáo viên hướng dẫn: Lê Vĩnh Thịnh\n\nCourse Select: " + this.textBoxCourse.Text + "\t Học Kì " + labelSemester.Text + "\n";

                para1.Range.Text = "Người thực hiện:";
                para1.Range.Font.Size = 12;
                para1.Range.Bold = 0;
                para1.Range.Underline = 0;
                para1.Range.Font.Name = "Times New Roman";
                para1.Range.InsertParagraphAfter();

                para1.Range.Text = "Họ và tên: Nguyễn Thái Hải";
                para1.Range.Font.Size = 12;
                para1.Range.Bold = 0;
                para1.Range.Underline = 0;
                para1.Range.Font.Name = "Times New Roman";
                para1.Range.InsertParagraphAfter();

                para1.Range.Text = "MSSV: 19110356";
                para1.Range.Font.Size = 12;
                para1.Range.Bold = 0;
                para1.Range.Underline = 0;
                para1.Range.Font.Name = "Times New Roman";
                para1.Range.InsertParagraphAfter();

                Microsoft.Office.Interop.Word.Range footersRange = section.Footers[Microsoft.Office.Interop.Word.WdHeaderFooterIndex.wdHeaderFooterPrimary].Range;
                footersRange.Fields.Add(footersRange, Microsoft.Office.Interop.Word.WdFieldType.wdFieldPage);
                footersRange.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphCenter;
                footersRange.Font.ColorIndex = Microsoft.Office.Interop.Word.WdColorIndex.wdBlack;   // Màu
                footersRange.Font.Bold = 2;        // Độ Đậm Chữ
                footersRange.Font.Size = 14;
                footersRange.Text = "TP.HCM, " + time;


                section.Borders.Enable = 1;
                section.Borders.OutsideLineStyle = WdLineStyle.wdLineStyleSingle;
                section.Borders.OutsideLineWidth = WdLineWidth.wdLineWidth300pt;
                section.Borders.OutsideColor = WdColor.wdColorBlack;

            }

            // Tạo bảng danh sách sinh viên
            Table tableST = wordDoc.Tables.Add(para1.Range, dataGridViewStdList.Rows.Count + 1, dataGridViewStdList.Columns.Count, ref missing, ref missing);
            //Xuất hiện khung table
            tableST.Borders.Enable = 1;
            for (int c = 0; c <= ColumnCount - 1; c++)
            {
                tableST.Rows[1].Cells[c + 1].Range.Text = dataGridViewStdList.Columns[c].HeaderText;
                tableST.Rows[1].Cells[c + 1].Range.Font.Name = "Times New Roman";
                tableST.Rows[1].Cells[c + 1].Range.Font.Bold = 1;
            }
            for (int i = 2; i <= tableST.Rows.Count; i++)
            {

                for (int j = 1; j < tableST.Columns.Count + 1; j++)
                {

                    //Lưu text
                    tableST.Rows[i].Cells[j].Range.Text = dataGridViewStdList.Rows[i - 2].Cells[j - 1].Value.ToString();
                    tableST.Rows[i].Cells[j].Range.Font.Name = "Times New Roman";
                }
            }
            // Lưu thông tin 
            object filename = @"D:\CourseStdList.docx";
            wordDoc.SaveAs2(ref filename);
            wordDoc.Close();
            oWord.Quit();
            MessageBox.Show("Data is Saved", "Thông báo", MessageBoxButtons.OK);

        }

    }
}
