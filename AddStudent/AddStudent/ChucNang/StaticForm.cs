using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace AddStudent
{
    public partial class StaticForm : Form
    {
        public StaticForm()
        {
            InitializeComponent();
        }
        Color panTotalColor;
        Color panMaleColor;
        Color panFemaleColor;
        private void StaticForm_Load(object sender, EventArgs e)
        {
            panTotalColor = panelTotal.BackColor;
            panMaleColor = panelMale.BackColor;
            panFemaleColor = panelFemale.BackColor;
            Student student = new Student();
            double total = Convert.ToDouble(student.totalStudent());
            double totalMale = Convert.ToDouble(student.totalMaleStudent());
            double totalFemale = Convert.ToDouble(student.totalFemaleStudent());

            double maleStudentsPercentage = (totalMale * (100 / total));
            double femaleStudentsPercentage = (totalFemale * (100 / total));

            labelTotal.Text = ("Totals Students: " + total.ToString());
            labelMale.Text = ("Male : " + (maleStudentsPercentage.ToString("0.00") + "%"));
            labelFemale.Text = ("Female : " + (femaleStudentsPercentage.ToString("0.00") + "%"));

            this.Width = 720;
            panelTotal.Width = 700;
            panelMale.Width = Convert.ToInt32(panelTotal.Width * 62 / 100);
            panelFemale.Location = new Point(panelMale.Width + 1, 182);
            panelFemale.Width = Convert.ToInt32(panelTotal.Width - panelMale.Width);

            //panTotalColor = PanelTotal.BackColor;

            chart1.ChartAreas[0].AxisX.Maximum = 100;
            chart1.ChartAreas[0].AxisX.Minimum = 0;
            chart1.Series["%"].Points.AddXY("Male", maleStudentsPercentage.ToString());
            chart1.Series["%"].Points.AddXY("Female", femaleStudentsPercentage.ToString());
            chart1.Series[0].ChartType = SeriesChartType.Pie;
            fillChart();

        }

        private void fillChart()
        {
            Student student = new Student();
            int totalMale = student.totalMaleStudent();
            int totalFemale = student.totalFemaleStudent();
            BieuDoCot.Series["Male"].Points.AddXY("", totalMale);
            BieuDoCot.Series["Female"].Points.AddXY("", totalFemale);
        }

        private void VeBieuDoTron_Click(object sender, EventArgs e)
        {
            BieuDoCot.Series["Male"].XValueMember = "Male";
            BieuDoCot.Series["Female"].YValueMembers = "Female";

            BieuDoCot.Titles.Add("Salary Chart");
            //Chuyển kiểu biểu đồ hình tròn
            BieuDoCot.Series["Male"].ChartType = SeriesChartType.Pie;
            BieuDoCot.Series["Female"].ChartType = SeriesChartType.Pie;
        }


        private void panelTotal_MouseEnter(object sender, EventArgs e)
        {
            labelTotal.ForeColor = panTotalColor;
            panelTotal.BackColor = Color.White;
        }

        private void panelTotal_MouseLeave(object sender, EventArgs e)
        {
            labelTotal.ForeColor = Color.White;
            panelTotal.BackColor = panTotalColor;
        }

        private void panelMale_MouseEnter(object sender, EventArgs e)
        {
            labelMale.ForeColor = panTotalColor;
            panelMale.BackColor = Color.White;
        }

        private void panelMale_MouseLeave(object sender, EventArgs e)
        {
            labelMale.ForeColor = Color.White;
            panelMale.BackColor = Color.DarkGreen;
        }

        private void panelFemale_MouseEnter(object sender, EventArgs e)
        {
            labelFemale.ForeColor = panTotalColor;
            panelFemale.BackColor = Color.White;
        }

        private void panelFemale_MouseLeave(object sender, EventArgs e)
        {
            labelFemale.ForeColor = Color.White;
            panelFemale.BackColor = Color.Green;
        }
    }
}
