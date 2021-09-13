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
    public partial class ResultScoreForm : Form
    {
        public ResultScoreForm()
        {
            InitializeComponent();
        }
        Score score = new Score();
        Course course = new Course();
        DataBase mydb = new DataBase();
        public DataTable showData(SqlCommand command)
        {

            //---------TAO CAU TRUC BANG--------------//

            //Bang loc student
            SqlDataAdapter adapterStd = new SqlDataAdapter(command);
            DataTable tableStd = new DataTable();
            adapterStd.Fill(tableStd);

            //Tạo table2 để lấy dữ liệu của lable để add thêm vào cột của table
            SqlCommand commandLabel = new SqlCommand("SELECT lable FROM Course", mydb.GetConnection);
            SqlDataAdapter adapterLabel = new SqlDataAdapter(commandLabel);
            DataTable tableLabel = new DataTable();
            adapterLabel.Fill(tableLabel);


            foreach (DataRow rowLabel in tableLabel.Rows)
            {
                string name = rowLabel[0].ToString();
                tableStd.Columns.Add(name, typeof(string));
            }

            tableStd.Columns.Add("AverageScore", typeof(string));
            tableStd.Columns.Add("Result", typeof(string));
            dataGridViewScore.DataSource = tableStd;


            //----THEM THONG TIN BANG ------//

            // Lay Bang Diem cua moi sinh vien
            SqlCommand commandScore = new SqlCommand("SELECT * FROM Score, (SELECT Student_Id, avg(Student_Score) as AverageScore FROM Score GROUP BY(Student_Id)) as AVGtable, Course WHERE Score.Student_Id = AVGtable.Student_Id and Course.Id = Score.Course_Id", mydb.GetConnection);
            SqlDataAdapter adapterScore = new SqlDataAdapter(commandScore);
            DataTable tableScore = new DataTable();
            adapterScore.Fill(tableScore);

            foreach (DataRow rowStd in tableStd.Rows)
            {
                foreach (DataRow rowScore in tableScore.Rows)
                {
                    if (rowStd["Id"].ToString().Trim() == rowScore["Student_Id"].ToString().Trim())
                    {
                        string tmp = rowScore["lable"].ToString().Trim();
                        rowStd[tmp] = rowScore["Student_Score"];
                        rowStd["AverageScore"] = rowScore["AverageScore"];
                    }
                }

                if (rowStd["AverageScore"].ToString().Trim() != "")
                {
                    if (Convert.ToDouble(rowStd["AverageScore"].ToString().Trim()) > 5)
                    {
                        rowStd["Result"] = "Pass";
                    }
                    else
                    {
                        rowStd["Result"] = "Fail";
                    }

                }
            }

            int col = tableStd.Columns.Count;
            foreach (DataRow rowStd in tableStd.Rows)
            {
                for (int i = 0; i < col; i++)
                {
                    if (rowStd[i].ToString().Trim() == "")
                        rowStd[i] = "###";
                }
            }
            return tableStd;

        }
        int plag = 0;
        private void button1_Click(object sender, EventArgs e)
        {

            string key = this.textBoxSearch.Text;
            SqlCommand command = new SqlCommand(" SELECT Id,fname as FirstName ,lname as LastName FROM std WHERE CONCAT(fname,Id,lname) LIKE '%" + key + "%'", mydb.GetConnection);
            this.dataGridViewScore.DataSource = this.showData(command);
            dataGridViewScore.AllowUserToAddRows = false;
            if (plag == 0)
            {
                this.panelBore1.BackColor = Color.Green;
                this.panelBore2.BackColor = Color.Green;
                this.panelBore3.BackColor = Color.Green;
                this.panelBore4.BackColor = Color.Green;
                this.panelBore5.BackColor = Color.Green;
                plag = 1;
            }
            else
            {
                this.panelBore1.BackColor = Color.Red;
                this.panelBore2.BackColor = Color.Red;
                this.panelBore3.BackColor = Color.Red;
                this.panelBore4.BackColor = Color.Red;
                this.panelBore5.BackColor = Color.Red;
                plag = 0;
            }

        }

        private void ResultScoreForm_Load(object sender, EventArgs e)
        {
            SqlCommand commandStd = new SqlCommand(" SELECT Id , fname as FirstName ,lname as LastName FROM std", mydb.GetConnection);
            this.dataGridViewScore.DataSource = this.showData(commandStd);
            dataGridViewScore.AllowUserToAddRows = false;

        }

    }
}

