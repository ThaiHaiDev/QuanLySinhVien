using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddStudent
{
    public partial class ManageCourseForm : Form
    {
        public ManageCourseForm()
        {
            InitializeComponent();
        }
        Course course = new Course();
        int pos;

        private void ManageCourseForm_Load(object sender, EventArgs e)
        {
            reloadListBoxData();
        }
        void reloadListBoxData()
        {
            listBoxCourse.DataSource = course.getAllCourses();
            listBoxCourse.ValueMember = "Id Course";
            listBoxCourse.DisplayMember = "Tên Khóa Học";
            listBoxCourse.SelectedItem = null;
            labelTotalCourse.Text = ("Total Course: " + course.totalCourses());
        }
        void showData(int index)
        {
            DataRow dr = course.getAllCourses().Rows[index];
            listBoxCourse.SelectedIndex = index;
            textBoxCourseID.Text = dr.ItemArray[0].ToString();
            textBoxLable.Text = dr.ItemArray[1].ToString();
            numericUpDownHours.Value = int.Parse(dr.ItemArray[2].ToString());
            textBoxDescription.Text = dr.ItemArray[3].ToString();
            this.comboBoxSemester.SelectedItem = dr.ItemArray[4].ToString();
            textBoxTeacherID.Text = dr.ItemArray[5].ToString();
        }

        private void listBoxCourse_Click(object sender, EventArgs e)
        {
            DataRowView drv = (DataRowView)listBoxCourse.SelectedItem;
            pos = listBoxCourse.SelectedIndex;
            showData(pos);
        }

        private void buttonAddCourse_Click(object sender, EventArgs e)
        {
            Course course = new Course();
            int id = Convert.ToInt32(textBoxCourseID.Text);
            string name = textBoxLable.Text;
            int period = (int)numericUpDownHours.Value;
            string description = textBoxDescription.Text;
            int semester = Convert.ToInt32(this.comboBoxSemester.SelectedItem.ToString());
            int teacher = Convert.ToInt32(this.textBoxTeacherID.Text.Trim());
            if (name.Trim() == "")
            {
                MessageBox.Show("Add A Course Name", "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (course.checkCourseName(name) && course.checkCourseId(id))
            {
                if (course.insertCourse(id, name, period, description, semester, teacher))
                {
                    MessageBox.Show("New Course Inserted", "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Course Not Inserted", "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("This Courser Name Already Exists", "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            string name = textBoxLable.Text;
            int hrs = (int)numericUpDownHours.Value;
            string descr = textBoxDescription.Text;
            int id = int.Parse(textBoxCourseID.Text);
            int sem = Convert.ToInt32(this.comboBoxSemester.SelectedItem.ToString());
            int teacher = Convert.ToInt32(this.textBoxTeacherID.Text.Trim());
            if (hrs < 10)
            {
                MessageBox.Show("The Period Must > 10", "Khong Hop Le", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!course.checkCourseName(name, Convert.ToInt32(textBoxCourseID.Text)))
            {
                MessageBox.Show("This Course Name Already Exist", "Edit Course", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (course.updateCourse(id, name, hrs, descr, sem, teacher))
            {
                MessageBox.Show("Course Updated", "Edit Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
                reloadListBoxData();
            }
            pos = 0;
        }

        private void buttonRemoveCourse_Click(object sender, EventArgs e)
        {
            try
            {
                int CourseId = Convert.ToInt32(textBoxCourseID.Text);
                if ((MessageBox.Show("Are You Sure You Want To Delete This Studen", "Delete Student", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                {
                    if (course.deleteCourse(CourseId))
                    {
                        MessageBox.Show("Student Deleted", "Delete Student", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        MessageBox.Show("Student Not Deleted", "Delete Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Please Enter A Valid ID", "Delete Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            pos = 0;
        }

        private void buttonFirst_Click(object sender, EventArgs e)
        {
            pos = 0;
            showData(pos);
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            if (pos < (course.getAllCourses().Rows.Count - 1))
            {
                pos = pos + 1;
                showData(pos);
            }
        }

        private void buttonPrevious_Click(object sender, EventArgs e)
        {
            if (pos > 0)
            {
                pos = pos - 1;
                showData(pos);
            }
        }

        private void buttonLast_Click(object sender, EventArgs e)
        {
            pos = course.getAllCourses().Rows.Count - 1;
            showData(pos);
        }

        private void listBoxCourse_DoubleClick(object sender, EventArgs e)
        {

            int index = listBoxCourse.SelectedIndex;
            DataRow dr = course.getAllCourses().Rows[index];
            string id = dr.ItemArray[0].ToString();
            string label = dr.ItemArray[1].ToString();
            string semester = dr.ItemArray[4].ToString();
            CourseStdList stdList = new CourseStdList();
            stdList.hienThi(label, semester);
            stdList.Show();
        }
    }
}
