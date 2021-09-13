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
    public partial class EditCourse : Form
    {
        public EditCourse()
        {
            InitializeComponent();
        }
        Course course = new Course();
        private void EditCourse_Load(object sender, EventArgs e)
        {
            comboBoxCource.DataSource = course.getAllCourses();
            comboBoxCource.DisplayMember = "Id Course";
            comboBoxCource.ValueMember = "Id Course";
            comboBoxCource.SelectedItem = null;
        }

        private void comboBoxCource_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(comboBoxCource.SelectedValue);
                DataTable table = new DataTable();
                table = course.getCoursesById(id);
                textBoxLable.Text = table.Rows[0][1].ToString();
                numericUpDownHours.Value = Int32.Parse(table.Rows[0][2].ToString());
                textBoxDesciption.Text = table.Rows[0][3].ToString();
                this.comboBoxSemester.SelectedItem = table.Rows[0][4].ToString();
                textBoxTeacherID.Text = table.Rows[0][5].ToString();
            }
            catch
            {

            }
        }
        public void fillCombo(int index)
        {
            comboBoxCource.DataSource = course.getAllCourses();
            comboBoxCource.DisplayMember = "Id Course";
            comboBoxCource.ValueMember = "Id Course";
            comboBoxCource.SelectedItem = index;
        }
        private void buttonEdit_Click(object sender, EventArgs e)
        {
            string name = textBoxLable.Text;
            int hrs = (int)numericUpDownHours.Value;
            string descr = textBoxDesciption.Text;
            int id = (int)comboBoxCource.SelectedValue;
            int semester = Convert.ToInt32(this.comboBoxSemester.SelectedItem.ToString());
            int teacher = Convert.ToInt32(this.textBoxTeacherID.Text.Trim());
            if (hrs < 10)
            {
                MessageBox.Show("The Period Must > 10", "Khong Hop Le", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!course.checkCourseName(name, Convert.ToInt32(comboBoxCource.SelectedValue)) && !course.checkCourseId(id))
            {
                MessageBox.Show("This Course Name Already Exist", "Edit Course", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (course.updateCourse(id, name, hrs, descr, semester, teacher))
            {
                MessageBox.Show("Course Updated", "Edit Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
                fillCombo(comboBoxCource.SelectedIndex);
            }
        }
    }
}
