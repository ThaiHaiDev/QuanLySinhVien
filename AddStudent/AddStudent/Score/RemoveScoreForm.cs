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
    public partial class RemoveScoreForm : Form
    {
        public RemoveScoreForm()
        {
            InitializeComponent();
        }
        Score score = new Score();
        private void RemoveScoreForm_Load(object sender, EventArgs e)
        {
            dataGridViewScore.DataSource = score.getDeleteAllScore();
            dataGridViewScore.AllowUserToAddRows = false;
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            try
            {
                int studentID = Convert.ToInt32(dataGridViewScore.CurrentRow.Cells[0].Value.ToString());
                int courseID = Convert.ToInt32(dataGridViewScore.CurrentRow.Cells[4].Value.ToString());
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

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            this.dataGridViewScore.DataSource = score.getDeleteAllScore();
        }

    }
}
