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
    public partial class AvgScoreByCourseForm : Form
    {
        public AvgScoreByCourseForm()
        {
            InitializeComponent();
        }
        Score score = new Score();

        private void AvgScoreByCourseForm_Load(object sender, EventArgs e)
        {
            dataGridViewAvgScore.DataSource = score.getAvgScoreCourse();
            dataGridViewAvgScore.AllowUserToAddRows = false;
            try
            {
                int len = this.dataGridViewAvgScore.Rows.Count;
                for (int i = 0; i < len; i++)
                {

                    string s = dataGridViewAvgScore.Rows[i].Cells[0].Value.ToString();
                    string k = dataGridViewAvgScore.Rows[i].Cells[1].Value.ToString();
                    double kq = Convert.ToDouble(k);
                    BieuDoCot.Series["Điểm"].Points.AddXY(s, k);
                }
            }
            catch (NullReferenceException ee)
            {
                ee.InnerException.ToString();
            }


        }

        private void dataGridViewAvgScore_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BieuDoCot_Click(object sender, EventArgs e)
        {

        }
    }
}
