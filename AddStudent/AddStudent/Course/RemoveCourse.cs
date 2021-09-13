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
    public partial class RemoveCourse : Form
    {
        public RemoveCourse()
        {
            InitializeComponent();
        }
        Course course = new Course();
        private void buttonRemoveCourse_Click(object sender, EventArgs e)
        {
            try
            {
                int CourseId = Convert.ToInt32(textBoxID.Text);
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
        }
    }
}
