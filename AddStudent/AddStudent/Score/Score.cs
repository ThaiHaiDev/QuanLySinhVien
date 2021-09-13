using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddStudent
{
    class Score
    {
        DataBase mydb = new DataBase();
        // them diem
        public bool insertScore(int studentID, int courseID, float scoreValue, string description)
        {
            SqlCommand command = new SqlCommand("INSERT INTO Score (student_id, course_id, student_score, description) " +
                "VALUES (@sid, @cid, @scr, @desrc)", mydb.GetConnection);
            command.Parameters.Add("@sid", SqlDbType.Int).Value = studentID;
            command.Parameters.Add("@cid", SqlDbType.Int).Value = courseID;
            command.Parameters.Add("@scr", SqlDbType.Float).Value = scoreValue;
            command.Parameters.Add("@desrc", SqlDbType.VarChar).Value = description;
            mydb.openConnection();
            if ((command.ExecuteNonQuery() == 1))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // Ktra trung
        public bool studentScoreExist(int studentId, int courseId)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM Score WHERE student_id = @sid AND course_id = @cid", mydb.GetConnection);
            command.Parameters.Add("@sid", SqlDbType.Int).Value = studentId;
            command.Parameters.Add("@cid", SqlDbType.Int).Value = courseId;

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            if (table.Rows.Count == 0)
                return false;            // k bi trung
            else
                return true;            //bi trung
        }


        public DataTable getAvgScoreCourse()
        {
            SqlCommand command = new SqlCommand();
            command.Connection = mydb.GetConnection;
            command.CommandText = "SELECT Course.lable AS N'Tên Khóa Học', AVG(Score.Student_Score) AS N'Điểm Trung Bình' FROM Course, Score WHERE Course.Id = " +
                "Score.Course_Id GROUP BY Course.lable";
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public bool deleteScore(int studentID, int courseID)
        {
            SqlCommand command = new SqlCommand("DELETE FROM Score WHERE Student_Id = @sid AND Course_Id = @cid", mydb.GetConnection);

            command.Parameters.Add("@sid", SqlDbType.Int).Value = studentID;
            command.Parameters.Add("@cid", SqlDbType.Int).Value = courseID;

            mydb.openConnection();
            if (command.ExecuteNonQuery() == 1)
                return true;
            else return false;
        }

        public DataTable getAllScore()
        {
            SqlCommand command = new SqlCommand("SELECT * FROM Score");
            command.Connection = mydb.GetConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public DataTable getDeleteAllScore()
        {
            //SqlCommand command = new SqlCommand("SELECT Course.lable, Score.Course_Id FROM Course, Score WHERE Course.Id = " +
            //"Score.Course_Id GROUP BY Course.lable,Score.Course_Id");
            SqlCommand command = new SqlCommand("SELECT Score.Student_Id AS N'MSSV', std.fname AS N'Tên', std.lname AS N'Họ', lable AS N'Tên Khóa Học', Course.Id AS 'Id Khóa Học', Score.Student_Score AS 'Điểm SV', Score.Description AS 'Ghi Chú' FROM std,Score,Course WHERE std.Id =  Score.Student_Id AND Score.Course_Id= Course.Id");
            command.Connection = mydb.GetConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public DataTable getScore(SqlCommand command)
        {
            command.Connection = mydb.GetConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public DataTable getStudentCourseScore(int a)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = mydb.GetConnection;
            command.CommandText = "SELECT Score.Student_Id, std.fname AS N'Tên', std.lname AS N'Họ', Score.Course_Id, Course.lable AS N'Tên Môn', Score.Student_Score FROM std INNER JOIN Score ON std.Id = Score.Student_Id INNER JOIN Course ON Score.Course_Id = Course.Id WHERE Score.Course_Id = " + a;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;


        }
        public DataTable getStudentsScore(int studentId)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = mydb.GetConnection;
            command.CommandText = "SELECT Score.Student_Id, std.fname AS N'Tên', std.lname AS N'Họ', Score.Course_Id, Course.lable AS N'Tên Môn', Score.Student_Score FROM std INNER JOIN Score ON std.Id = Score.Student_Id INNER JOIN Course ON Score.Course_Id = Course.Id WHERE Score.Student_Id = " + studentId;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
    }
}
