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

namespace AddStudent
{
    public partial class StudentListForm : Form
    {
        public StudentListForm()
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
            picCol = (DataGridViewImageColumn)dataGridView1.Columns[7];
            dataGridView1.Columns[3].DefaultCellStyle.Format = "yyyy - MM - dd";
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dataGridView1.AllowUserToAddRows = false;
        }
        public void StudentListForm_Load(object sender, EventArgs e)
        {
            ketnoicsdl();
        }
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            UpdateDeteleStudent updateDeteleStudent = new UpdateDeteleStudent();
            updateDeteleStudent.textBoxID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            updateDeteleStudent.textBoxFName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            updateDeteleStudent.textBoxLName.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            updateDeteleStudent.dateTimePicker1.Value = (DateTime)dataGridView1.CurrentRow.Cells[3].Value;
            dataGridView1.Columns[3].DefaultCellStyle.Format = "yyyy - MM - dd";
            if ((dataGridView1.CurrentRow.Cells[4].Value.ToString() == "Female    "))
            {
                updateDeteleStudent.Female.Checked = true;
            }
            else
            {
                updateDeteleStudent.Male.Checked = true;
            }
            updateDeteleStudent.textBoxPhone.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            updateDeteleStudent.textBoxAddress.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            byte[] pic;
            pic = (byte[])dataGridView1.CurrentRow.Cells[7].Value;
            MemoryStream picture = new MemoryStream(pic);
            updateDeteleStudent.pictureBox1.Image = Image.FromStream(picture);
            updateDeteleStudent.Show();
        }
        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand(" SELECT Id as N'MSSV', lname as N'Họ', fname as N'Tên', bdate as N'Ngày Sinh', gender as N'Giới tính', phone as N'SDT', address as N'Địa Chỉ', picture as N'Hình ảnh'  FROM std");
            dataGridView1.ReadOnly = true;
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            dataGridView1.RowTemplate.Height = 80;
            dataGridView1.DataSource = student.getStudents(command);
            picCol = (DataGridViewImageColumn)dataGridView1.Columns[7];
            dataGridView1.Columns[3].DefaultCellStyle.Format = "yyyy - MM - dd";
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dataGridView1.AllowUserToAddRows = false;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
