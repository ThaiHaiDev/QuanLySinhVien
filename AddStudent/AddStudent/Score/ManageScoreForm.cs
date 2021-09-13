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
    public partial class ManageScoreForm : Form
    {
        public ManageScoreForm()
        {
            InitializeComponent();
        }

        Score score = new Score();
        Course course = new Course();
        Student student = new Student();
        private void ManageScoreForm_Load(object sender, EventArgs e)
        {
            this.comboBoxCource.DataSource = course.getAllCourses();
            this.comboBoxCource.DisplayMember = "Tên Khóa Học";
            this.comboBoxCource.ValueMember = "Id Course";
        }
        private int flag = -1;

        private void buttonShowSt_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT Id AS N'MSSV', fname AS N'Tên', lname AS N'Họ', bdate AS N'Ngày Sinh' FROM std");
            this.dataGridViewScore.DataSource = student.getStudents(command);
            dataGridViewScore.Columns[3].DefaultCellStyle.Format = "yyyy - MM - dd";
            dataGridViewScore.AllowUserToAddRows = false;
            this.flag = 0;
        }

        private void buttonShowScore_Click(object sender, EventArgs e)
        {
            this.dataGridViewScore.DataSource = score.getDeleteAllScore();
            dataGridViewScore.AllowUserToAddRows = false;
            this.flag = 1;
        }

        private void dataGridViewScore_DoubleClick(object sender, EventArgs e)
        {
            if (this.flag == 1)
            {

                this.textBoxStID.Text = this.dataGridViewScore.CurrentRow.Cells[0].Value.ToString();
                this.comboBoxCource.SelectedValue = this.dataGridViewScore.CurrentRow.Cells[4].Value.ToString();
                this.textBoxScore.Text = dataGridViewScore.CurrentRow.Cells[5].Value.ToString();
                this.textBoxDesciption.Text = dataGridViewScore.CurrentRow.Cells[6].Value.ToString();
            }
            else
            {
                int temp = Convert.ToInt32(dataGridViewScore.CurrentRow.Cells[0].Value.ToString());
                ResultScoreForm res = new ResultScoreForm();

            }
        }

        private void buttonAddScore_Click(object sender, EventArgs e)
        {
            try
            {
                int studentID = Convert.ToInt32(textBoxStID.Text);
                int courseID = Convert.ToInt32(comboBoxCource.SelectedValue);
                float scoreValue = Convert.ToInt32(textBoxScore.Text);
                string description = textBoxDesciption.Text;

                if (!score.studentScoreExist(studentID, courseID))
                {
                    if (score.insertScore(studentID, courseID, scoreValue, description))
                    {
                        MessageBox.Show("Student Score Inserted", "Add Score", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Student Score Not Inserted", "Add Score", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    MessageBox.Show("The Score For This Course Are Already Set", "Add Score", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Add Score", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            try
            {
                int studentID = Convert.ToInt32(textBoxStID.Text);
                int courseID = Convert.ToInt32(this.comboBoxCource.SelectedValue);
                if (MessageBox.Show("Are you sure you want to delete this score ", "Delete score", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (score.deleteScore(studentID, courseID))
                    {
                        MessageBox.Show("Score delete", "Delete Score", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Score not delete", "Delete Score", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Can't delete", "Delete Score", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dataGridViewScore_Click(object sender, EventArgs e)
        {
            this.textBoxStID.Text = dataGridViewScore.CurrentRow.Cells[0].Value.ToString();
            this.textBoxScore.Text = "";
            this.textBoxDesciption.Text = "";
        }

        private void buttonAvg_Click(object sender, EventArgs e)
        {
            AvgScoreByCourseForm avg = new AvgScoreByCourseForm();
            avg.Show();
        }
    }
}
