using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Word;
using Font = System.Drawing.Font;
using Point = System.Drawing.Point;

namespace AddStudent
{
    public partial class PrintScoreForm : Form
    {
        public PrintScoreForm()
        {
            InitializeComponent();
        }
        Score score = new Score();
        Course course = new Course();
        Student student = new Student();
        DataBase mydb = new DataBase();
        private void PrintScoreForm_Load(object sender, EventArgs e)
        {
            dataGridViewStudent.DataSource = student.getStudents(new SqlCommand("SELECT Id, fname, lname FROM std"));
            dataGridViewStudent.AllowUserToAddRows = false;
            dataGridViewStudent.Columns[0].HeaderText = "Mã Số SV";
            dataGridViewStudent.Columns[1].HeaderText = "First Name";
            dataGridViewStudent.Columns[2].HeaderText = "Last Name";

            // populate datagridview with score data
            dataGridViewStudentScore.DataSource = score.getAllScore();
            dataGridViewStudentScore.AllowUserToAddRows = false;
            dataGridViewStudentScore.Columns[0].HeaderText = "Mã Số SV";

            dataGridViewStudentScore.Columns[1].HeaderText = "Mã Số MH";

            dataGridViewStudentScore.Columns[2].HeaderText = "Điểm Số";
            dataGridViewStudentScore.Columns[3].HeaderText = "Đánh Giá";

            // populate listbox with course data
            listBoxCourse.DataSource = course.getAllCourses();
            listBoxCourse.DisplayMember = "Tên Khóa Học";
            listBoxCourse.ValueMember = "Id Course";
        }

        private void listBoxCourse_Click(object sender, EventArgs e)
        {
            dataGridViewStudentScore.DataSource = score.getStudentCourseScore(int.Parse(listBoxCourse.SelectedValue.ToString()));
            dataGridViewStudentScore.AllowUserToAddRows = false;
        }

        private void dataGridViewStudent_Click(object sender, EventArgs e)
        {
            dataGridViewStudentScore.DataSource = score.getStudentsScore(int.Parse(dataGridViewStudent.CurrentRow.Cells[0].Value.ToString()));
            dataGridViewStudentScore.AllowUserToAddRows = false;
        }

        private void buttonToFile_Click(object sender, EventArgs e)
        {
            // Tạo đường dẫn đến word
            _Application oWord = new Microsoft.Office.Interop.Word.Application();
            //Tạo một Document
            _Document wordDoc = oWord.Documents.Add();
            int ColumnCount = dataGridViewStudentScore.Columns.Count;
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
                headerRange.Font.ColorIndex = Microsoft.Office.Interop.Word.WdColorIndex.wdBlack;
                headerRange.Font.Size = 16;
                headerRange.Text = "TRƯỜNG ĐẠI HỌC SỰ PHẠM KỸ THUẬT THÀNH PHỐ HỒ CHÍ MINH\n" + time
                                + "\n\n Môn: Lập trình trên Windows\nGiáo viên hướng dẫn: Lê Vĩnh Thịnh\n\n DANH SÁCH SINH VIÊN\n";
                section.Borders.Enable = 1;
                section.Borders.OutsideLineStyle = WdLineStyle.wdLineStyleSingle;
                section.Borders.OutsideLineWidth = WdLineWidth.wdLineWidth300pt;
                section.Borders.OutsideColor = WdColor.wdColorBlack;
            }
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

            // Tạo bảng danh sách sinh viên
            Table tableST = wordDoc.Tables.Add(para1.Range, dataGridViewStudentScore.Rows.Count + 1, dataGridViewStudentScore.Columns.Count, ref missing, ref missing);
            //Xuất hiện khung table
            tableST.Borders.Enable = 1;
            for (int c = 0; c <= ColumnCount - 1; c++)
            {
                tableST.Rows[1].Cells[c + 1].Range.Text = dataGridViewStudentScore.Columns[c].HeaderText;
                tableST.Rows[1].Cells[c + 1].Range.Font.Name = "Times New Roman";
                tableST.Rows[1].Cells[c + 1].Range.Font.Bold = 1;
            }
            for (int i = 2; i <= tableST.Rows.Count; i++)
            {

                for (int j = 1; j < tableST.Columns.Count + 1; j++)
                {

                    //Lưu text
                    tableST.Rows[i].Cells[j].Range.Text = dataGridViewStudentScore.Rows[i - 2].Cells[j - 1].Value.ToString();
                    tableST.Rows[i].Cells[j].Range.Font.Name = "Times New Roman";
                }
            }
            // Lưu thông tin 
            object filename = @"D:\ResultScore.docx";
            wordDoc.SaveAs2(ref filename);
            wordDoc.Close();
            oWord.Quit();
            MessageBox.Show("Data is Saved", "Thông báo", MessageBoxButtons.OK);
        }

        private void buttonPrint_Click(object sender, EventArgs e)
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
        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            string str = "";
            int row = dataGridViewStudentScore.Rows.Count;
            int cell = dataGridViewStudentScore.Rows[1].Cells.Count;
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < cell; j++)
                {
                    if (dataGridViewStudentScore.Rows[i].Cells[j].Value == null)
                    {
                        dataGridViewStudentScore.Rows[i].Cells[j].Value = "null";
                    }
                    str += dataGridViewStudentScore.Rows[i].Cells[j].Value.ToString().Trim() + " , ";
                }
                str += "\n";
            }

            e.Graphics.DrawString(str, new Font("Arial", 30), Brushes.Black, new Point(10, 10));
        }

    }
}
