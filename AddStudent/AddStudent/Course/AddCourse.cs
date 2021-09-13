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
    public partial class AddCourse : Form
    {
        public AddCourse()
        {
            InitializeComponent();
        }


        private void buttonAddCourse_Click(object sender, EventArgs e)
        {
            if (verif())
            {
                Course course = new Course();
                int id = Convert.ToInt32(textBoxCourseID.Text);
                string name = textBoxLable.Text;
                int period = Convert.ToInt32(textBoxPeriod.Text);
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
            else
            {
                MessageBox.Show("Empty Fields", "Add course", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        public bool verif()
        {
            if (this.comboBoxSemester.SelectedItem == null)
                return false;
            if ((textBoxLable.Text.Trim() == "")
                    || (textBoxPeriod.Text.Trim() == "")
                    || (textBoxDescription.Text.Trim() == "")
                    || (textBoxCourseID.Text.Trim() == ""))
            {
                return false;
            }
            else return true;
        }
        Course course = new Course();
        private void AddCourse_Load(object sender, EventArgs e)
        {
            //this.comboBoxCource.DataSource = course.getAllCourses();
            //this.comboBoxCource.DisplayMember = "Học Kì";
            //this.comboBoxCource.ValueMember = "Id Course";
        }
    }
}
