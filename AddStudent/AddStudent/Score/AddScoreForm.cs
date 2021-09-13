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
    public partial class AddScoreForm : Form
    {
        public AddScoreForm()
        {
            InitializeComponent();
        }
        Score score = new Score();
        Course course = new Course();
        Student student = new Student();

        private void AddScoreForm_Load(object sender, EventArgs e)
        {
            this.comboBoxCource.DataSource = course.getAllCourses();
            this.comboBoxCource.DisplayMember = "Tên Khóa Học";
            this.comboBoxCource.ValueMember = "Id Course";
            SqlCommand command = new SqlCommand("SELECT id AS N'MSSV', fname AS N'Tên', lname AS N'Họ' FROM std");
            this.dataGridViewScore.DataSource = student.getStudents(command);
            dataGridViewScore.AllowUserToAddRows = false;
        }

        private void dataGridViewScore_Click(object sender, EventArgs e)
        {
            textBoxStID.Text = dataGridViewScore.CurrentRow.Cells[0].Value.ToString();
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
    }
}
