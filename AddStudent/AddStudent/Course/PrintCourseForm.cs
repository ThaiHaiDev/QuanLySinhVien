using Microsoft.Office.Interop.Word;
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
namespace AddStudent
{
    public partial class PrintCourseForm : Form
    {
        public PrintCourseForm()
        {
            InitializeComponent();
        }
        Course course = new Course();
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

        private void PrintCourseForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = course.getAllCourses();
            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToAddRows = false;
        }

        private void buttonToFile_Click(object sender, EventArgs e)
        {
            // Tạo đường dẫn đến word
            _Application oWord = new Microsoft.Office.Interop.Word.Application();
            //Tạo một Document
            _Document wordDoc = oWord.Documents.Add();
            int ColumnCount = dataGridView1.Columns.Count;
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
                                + "\nMôn: Lập trình trên Windows\n\t\t Giáo viên hướng dẫn: Lê Vĩnh Thịnh\n\nCourse Semester\n";

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
            Table tableST = wordDoc.Tables.Add(para1.Range, dataGridView1.Rows.Count + 1, dataGridView1.Columns.Count, ref missing, ref missing);
            //Xuất hiện khung table
            tableST.Borders.Enable = 1;
            for (int c = 0; c <= ColumnCount - 1; c++)
            {
                tableST.Rows[1].Cells[c + 1].Range.Text = dataGridView1.Columns[c].HeaderText;
                tableST.Rows[1].Cells[c + 1].Range.Font.Name = "Times New Roman";
                tableST.Rows[1].Cells[c + 1].Range.Font.Bold = 1;
            }
            for (int i = 2; i <= tableST.Rows.Count; i++)
            {

                for (int j = 1; j < tableST.Columns.Count + 1; j++)
                {

                    //Lưu text
                    tableST.Rows[i].Cells[j].Range.Text = dataGridView1.Rows[i - 2].Cells[j - 1].Value.ToString();
                    //tableST.Rows[i].Cells[j].Range.Font.Bold = 1;
                    tableST.Rows[i].Cells[j].Range.Font.Name = "Times New Roman";
                }
            }
            // Lưu thông tin 
            object filename = @"D:\Course.docx";
            wordDoc.SaveAs2(ref filename);
            wordDoc.Close();
            oWord.Quit();
            MessageBox.Show("Data is Saved", "Thông báo", MessageBoxButtons.OK);


        }

    }
}

