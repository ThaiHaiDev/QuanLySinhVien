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
    public partial class AddCourseSemester : Form
    {
        public AddCourseSemester()
        {
            InitializeComponent();
        }
        Course course = new Course();
        Student student = new Student();
        private void AddCourseSemester_Load(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT id, lable FROM Course");
            this.showData(command);
        }
        public void showData(SqlCommand command)
        {
            DataTable table = course.getAll1Courses(command);

            foreach (DataRow row in table.Rows)
            {
                string label = row[1].ToString();
                this.listBoxCourse.Items.Add(label);
            }
        }
        private void buttonSave_Click(object sender, EventArgs e)
        {
            string MonChon = "";
            foreach (string item in this.listBoxSelect.Items)
            {
                MonChon += item + ", ";
            }
            try
            {
                int studentID = Convert.ToInt32(textBoxStudentID.Text);
                if (MonChon.Trim() != "")
                {
                    if (student.updateSelectedCourses(studentID, MonChon))
                    {
                        MessageBox.Show("Save Thanh Cong !!!", "Select Couse", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Khong The Save", "Select Couse", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    MessageBox.Show("Chua Chon Mon Hoc", "Select Course", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Select Course", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string item = this.listBoxCourse.SelectedItem.ToString();
            if (this.listBoxSelect.Items.Count == 0)
            {
                this.listBoxSelect.Items.Add(item);
            }
            else
            {
                int key = 0;   // Check Đã Có Tên Môn Học Đó chọn Chưa
                foreach (string CheckItem in this.listBoxSelect.Items)
                {
                    if (item == CheckItem)
                    {
                        key = 1;
                        MessageBox.Show("Môn Học Này Đã Được Đăng Kí!!!", "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        break;
                    }
                }
                if (key == 0)
                {
                    this.listBoxSelect.Items.Add(item);
                }

            }
        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            string tam = "";
            foreach (string item in this.listBoxSelect.SelectedItems)
            {
                tam = item.Trim();
            }
            this.listBoxSelect.Items.Remove(tam);
        }

        private void comboBoxSemester_SelectedIndexChanged(object sender, EventArgs e)
        {
            int sem = int.Parse(this.comboBoxSemester.SelectedItem.ToString());
            SqlCommand command = new SqlCommand("SELECT id, lable FROM Course WHERE semester = @se");
            command.Parameters.Add("@se", SqlDbType.Int).Value = sem;
            this.listBoxCourse.Items.Clear();   // Clear Khi Chọn lại Semester
            this.showData(command);
        }
        public void hienThi(string Id)
        {
            this.textBoxStudentID.Text = Id;
        }
    }
}
