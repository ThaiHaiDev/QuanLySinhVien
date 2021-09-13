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

namespace AddStudent
{
    public partial class ListStudentCourseForm : Form
    {
        public ListStudentCourseForm()
        {
            InitializeComponent();
        }
        Course course = new Course();
        Student student = new Student();
        public static int key = 0;
        public void reloadListBoxData(int teacherid)
        {
            key = teacherid;
            SqlCommand command = new SqlCommand("SELECT * FROM Course WHERE teacherId = " + teacherid);
            this.listBoxCourse.DataSource = course.getAll1Courses(command);
            this.listBoxCourse.ValueMember = "Lable";
            this.listBoxCourse.DisplayMember = "Label";
            this.listBoxCourse.SelectedItem = null;
        }
        public void loadDataGridView(SqlCommand command)
        {
            this.dataGridViewListContact.ReadOnly = true;

            DataGridViewImageColumn picol = new DataGridViewImageColumn();

            this.dataGridViewListContact.RowTemplate.Height = 80;
            this.dataGridViewListContact.DataSource = student.getStudents(command);
            picol = (DataGridViewImageColumn)dataGridViewListContact.Columns[7];
            picol.ImageLayout = DataGridViewImageCellLayout.Zoom;
            this.dataGridViewListContact.AllowUserToAddRows = false;

            for (int i = 0; i < this.dataGridViewListContact.Rows.Count; i++)
            {
                if (i % 2 != 0)
                {
                    this.dataGridViewListContact.Rows[i].DefaultCellStyle.BackColor = Color.WhiteSmoke;
                }
            }
        }

        private void listBoxCourse_Click(object sender, EventArgs e)
        {
            // int id = (int)this.listBoxCourse.SelectedValue;
            string name = this.listBoxCourse.SelectedValue.ToString().Trim();
            SqlCommand command = new SqlCommand("SELECT Id as N'MSSV',lname as N'Họ', fname as N'Tên', bdate as N'Ngày Sinh', gender as N'Giới tính', phone as N'SDT', address as N'Địa Chỉ', picture as N'Hình ảnh' FROM std WHERE selectCourse LIKE '%" + name + "%'");
            this.loadDataGridView(command);
        }

        private void ListStudentCourseForm_Load(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT Id as N'MSSV', lname as N'Họ', fname as N'Tên', bdate as N'Ngày Sinh', gender as N'Giới tính', phone as N'SDT', address as N'Địa Chỉ', picture as N'Hình ảnh' FROM std  WHERE selectCourse LIKE '%" + key + "%'");
            this.loadDataGridView(command);
        }
    }
}
