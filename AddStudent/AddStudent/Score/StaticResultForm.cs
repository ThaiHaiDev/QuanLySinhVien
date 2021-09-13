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
    public partial class StaticResultForm : Form
    {
        public StaticResultForm()
        {
            InitializeComponent();
        }
        Score score = new Score();

        private void buttonDeatail_Click(object sender, EventArgs e)
        {

        }
        public DataTable TaoBangThongKe()
        {
            SqlCommand command = new SqlCommand(" SELECT Tong.Course_Id, lable, SLSV, SLSVPass, SLSVFail FROM(SELECT Course_Id, Count(Student_Id) as SLSV FROM Score GROUP BY Course_Id) as Tong LEFT OUTER JOIN (SELECT Course_Id, Count(Student_Id) as SLSVPass FROM Score WHERE Student_Score >= 5 GROUP BY Course_Id) as Pass ON Tong.Course_Id = Pass.Course_Id LEFT OUTER JOIN (SELECT Course_Id, Count(Student_Id) as SLSVFail FROM Score WHERE Student_Score < 5 GROUP BY Course_Id) as Fail on Tong.Course_Id = Fail.Course_Id INNER JOIN Course on Tong.Course_Id = Course.Id");
            DataTable thongKeTable = score.getScore(command);

            thongKeTable.Columns.Add("Result", typeof(string));
            int col = thongKeTable.Columns.Count;

            foreach (DataRow row in thongKeTable.Rows)
            {
                for (int i = 0; i < col; i++)
                {
                    if (row[i].ToString().Trim() == "")
                        row[i] = 0;
                }

                double tong = Convert.ToDouble(row["SLSV"]);
                double pass = Convert.ToDouble(row["SLSVPass"]);
                double fail = Convert.ToDouble(row["SLSVFail"]);

                if (pass > fail)
                    row["Result"] = "Pass";
                else
                    row["Result"] = "Fail";
                BieuDo.Series["Pass"].Points.AddXY(row["lable"].ToString(), (pass / tong) * 100);
                BieuDo.Series["Fall"].Points.AddXY(row["lable"].ToString(), (fail / tong) * 100);
                BieuDo.Series["Tong"].Points.AddXY(row["lable"].ToString(), 100);
            }
            return thongKeTable;
        }

        private void StaticResultForm_Load(object sender, EventArgs e)
        {
            DataTable table = this.TaoBangThongKe();
            //this.dataGridView1.DataSource = table;

            foreach (DataRow row in table.Rows)
            {
                Label course = new Label();
                Label result = new Label();
                course.Text = row["lable"].ToString();
                result.Text = row["result"].ToString();

                this.flowLayoutPanelCourse.Controls.Add(course);
                this.flowLayoutPanelResult.Controls.Add(result);
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
