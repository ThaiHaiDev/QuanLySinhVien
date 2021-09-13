using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddStudent
{
    class Course
    {
        DataBase myDb = new DataBase();
        public bool checkCourseName(string courseName, int courseId = 0)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM Course WHERE lable=@cName And Id <> @cID", myDb.GetConnection);
            command.Parameters.Add("@cName", SqlDbType.VarChar).Value = courseName;
            command.Parameters.Add("@cID", SqlDbType.Int).Value = courseId;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            if ((table.Rows.Count > 0))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public bool checkCourseId(int courseId)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM Course WHERE Id=@cId", myDb.GetConnection);
            command.Parameters.Add("@cId", SqlDbType.VarChar).Value = courseId;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            if ((table.Rows.Count > 0))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public bool insertCourse(int ID, string name, int per, string des, int semeter, int teacherid)
        {
            SqlCommand command = new SqlCommand("INSERT INTO Course(Id, lable, period, description, semester, teacherId)" +
                "VALUES (@id, @fn, @period, @descrip, @se, @te)", myDb.GetConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = ID;
            command.Parameters.Add("@fn", SqlDbType.VarChar).Value = name;
            command.Parameters.Add("@period", SqlDbType.Int).Value = per;
            command.Parameters.Add("@descrip", SqlDbType.Text).Value = des;
            command.Parameters.Add("@se", SqlDbType.Int).Value = semeter;
            command.Parameters.Add("@te", SqlDbType.Int).Value = teacherid;

            myDb.openConnection();
            if ((command.ExecuteNonQuery() == 1))
            {
                myDb.closeConnection();
                return true;
            }
            else
            {
                myDb.closeConnection();
                return false;
            }

        }
        public bool deleteCourse(int id)
        {

            SqlCommand command = new SqlCommand("DELETE FROM Course WHERE id = @id", myDb.GetConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            myDb.openConnection();
            if ((command.ExecuteNonQuery() == 1))
            {
                myDb.closeConnection();
                return true;
            }
            else
            {
                myDb.closeConnection();
                return false;
            }
        }
        public DataTable getAllCourses()
        {
            SqlCommand command = new SqlCommand("SELECT Id AS N'Id Course', lable AS N'Tên Khóa Học', period AS N'Giai Đoạn', description AS N'Ghi Chú', semester AS 'Học Kì', teacherId AS N'Mã GV' FROM Course ", myDb.GetConnection);
            command.Connection = myDb.GetConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public DataTable getAll1Courses(SqlCommand command)
        {
            command.Connection = myDb.GetConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public DataTable getCoursesById(int id)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM Course WHERE Id = '" + id + "'", myDb.GetConnection);
            command.Connection = myDb.GetConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public bool updateCourse(int ID, string name, int per, string des, int sem, int tec)
        {
            SqlCommand command = new SqlCommand("UPDATE Course SET lable=@fn, period=@ln, description=@bdt, semester=@se , teacherId=@te WHERE Id=@ID", myDb.GetConnection);
            command.Parameters.Add("@ID", SqlDbType.Int).Value = ID;
            command.Parameters.Add("@fn", SqlDbType.VarChar).Value = name;
            command.Parameters.Add("@ln", SqlDbType.Int).Value = per;
            command.Parameters.Add("@bdt", SqlDbType.Text).Value = des;
            command.Parameters.Add("@se", SqlDbType.Int).Value = sem;
            command.Parameters.Add("@te", SqlDbType.Int).Value = tec;
            myDb.openConnection();
            if ((command.ExecuteNonQuery() == 1))
            {
                myDb.closeConnection();
                return true;
            }
            else
            {
                myDb.closeConnection();
                return false;
            }

        }
        public int totalCourses()
        {
            SqlCommand command = new SqlCommand("SELECT COUNT(Id) FROM Course", myDb.GetConnection);
            myDb.openConnection();

            int count = (int)command.ExecuteScalar();
            return count;
        }
    }
}
