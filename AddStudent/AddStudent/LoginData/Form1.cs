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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void addStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddSv AddstdF = new AddSv();
            AddstdF.Show(this);
        }

        private void studentsListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StudentListForm StList = new StudentListForm();
            StList.Show(this);
        }

        private void staticsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StaticForm re = new StaticForm();
            re.Show(this);
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Print re = new Print();
            re.Show(this);
        }

        private void editRemoveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateDeteleStudent re = new UpdateDeteleStudent();
            re.Show(this);
        }

        private void manageStudentFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManagerStudentForm re = new ManagerStudentForm();
            re.Show(this);
        }

        private void addCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddCourse re = new AddCourse();
            re.Show(this);
        }

        private void removeCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemoveCourse re = new RemoveCourse();
            re.Show(this);
        }

        private void editCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditCourse re = new EditCourse();
            re.Show(this);
        }

        private void manageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageCourseForm re = new ManageCourseForm();
            re.Show(this);
        }

        private void addScoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddScoreForm re = new AddScoreForm();
            re.Show(this);
        }

        private void avgScoreByCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AvgScoreByCourseForm re = new AvgScoreByCourseForm();
            re.Show(this);
        }

        private void manageScoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageScoreForm re = new ManageScoreForm();
            re.Show();
        }

        private void removeScoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemoveScoreForm re = new RemoveScoreForm();
            re.Show();
        }

        private void printToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            PrintScore re = new PrintScore();
            re.Show();
        }

        private void printToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PrintCourseForm re = new PrintCourseForm();
            re.Show();
        }

        private void avgResultByScoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResultScoreForm re = new ResultScoreForm();
            re.Show();
        }

        private void staticToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StaticResultForm re = new StaticResultForm();
            re.Show();
        }

        private void resuitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintScoreForm re = new PrintScoreForm();
            re.Show();
        }
    }
}
