using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Imaging;
using System.Drawing.Text;
using System.Drawing.Drawing2D;
namespace AddStudent
{
    class Student
    {
        DataBase myDb = new DataBase();
        public int Id { get; set; }
        public string fname { get; set; }
        public string lname { get; set; }
        public DateTime bdate { get; set; }
        public bool gender { get; set; }
        public string phone { get; set; }
        public string address { get; set; }
        public Image pic { get; set; }
        public Student()   //Tạo student rỗng để chạy k lỗi với khởi tạo Student để add vào List
        {

        }
        public Student(int a, string b, string c, DateTime d, bool e, string f, string k, Image n)
        {
            this.Id = a;
            this.fname = b;
            this.lname = c;
            this.bdate = d;
            this.gender = e;
            this.phone = f;
            this.address = k;
            this.pic = n;
        }
        public bool insertStudent(int Id, string fname, string lname, DateTime bdate, string gender, string phone, string address, MemoryStream picture)
        {
            SqlCommand command = new SqlCommand("INSERT INTO std(Id, fname, lname, bdate, gender, phone, address, picture)" +
                "VALUES (@id, @fn, @ln, @bdt, @ge, @pho, @add, @pic)", myDb.GetConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = Id;
            command.Parameters.Add("@fn", SqlDbType.VarChar).Value = fname;
            command.Parameters.Add("@ln", SqlDbType.VarChar).Value = lname;
            command.Parameters.Add("@bdt", SqlDbType.DateTime).Value = bdate;
            command.Parameters.Add("@ge", SqlDbType.VarChar).Value = gender;
            command.Parameters.Add("@pho", SqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@add", SqlDbType.VarChar).Value = address;
            command.Parameters.Add("@pic", SqlDbType.Image).Value = picture.ToArray();
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
        public DataTable getStudents(SqlCommand command)
        {
            command.Connection = myDb.GetConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public bool deleteStudent(int id)
        {

            SqlCommand command = new SqlCommand("DELETE FROM std WHERE id = @id", myDb.GetConnection);
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
        public bool updateStudent(int Id, string fname, string lname, DateTime bdate, string gender, string phone, string address, MemoryStream picture)
        {
            SqlCommand command = new SqlCommand("UPDATE std SET fname=@fn, lname=@ln, bdate=@bdt, gender=@ge, phone=@pho,address=@add, picture=@pic WHERE id=@Id", myDb.GetConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = Id;
            command.Parameters.Add("@fn", SqlDbType.VarChar).Value = fname;
            command.Parameters.Add("@ln", SqlDbType.VarChar).Value = lname;
            command.Parameters.Add("@bdt", SqlDbType.DateTime).Value = bdate;
            command.Parameters.Add("@ge", SqlDbType.VarChar).Value = gender;
            command.Parameters.Add("@pho", SqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@add", SqlDbType.VarChar).Value = address;
            command.Parameters.Add("@pic", SqlDbType.Image).Value = picture.ToArray();
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
        public int totalStudent()
        {
            SqlCommand command = new SqlCommand("SELECT COUNT(Id) FROM std", myDb.GetConnection);
            myDb.openConnection();

            int count = (int)command.ExecuteScalar();
            return count;
        }

        public int totalMaleStudent()
        {
            SqlCommand command = new SqlCommand("SELECT COUNT(Id) FROM std WHERE gender = 'male  '", myDb.GetConnection);
            myDb.openConnection();
            int count = (int)command.ExecuteScalar();
            return count;
        }

        public int totalFemaleStudent()
        {
            SqlCommand command = new SqlCommand("SELECT COUNT(Id) FROM std WHERE gender = 'Female'", myDb.GetConnection);
            myDb.openConnection();
            int count = (int)command.ExecuteScalar();
            return count;
        }
        public List<string> convert()  // Convert dữ liệu trong List Student sang String, từ Id Gender đều sang String 
        {
            List<string> stnew = new List<string>(); // Create new list of strings
            string a = Convert.ToString(Id);
            string b = Convert.ToString(fname);
            string c = Convert.ToString(lname);
            string d = Convert.ToString(bdate);
            string e = Convert.ToString(gender);
            string f = Convert.ToString(phone);
            string g = Convert.ToString(address);

            if (e == "False")
            {
                e = "Female";
            }
            if (e == "True")
            {
                e = "Male";
            }
            stnew.Add(a);
            stnew.Add(b); stnew.Add(c); stnew.Add(d); stnew.Add(e); stnew.Add(f); stnew.Add(g);
            return stnew;
        }
        public bool checkStudentId(int courseId)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM std WHERE Id=@cId", myDb.GetConnection);
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
        public bool checkMonHoc(int courseId, int stdID)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM std WHERE selectCourse LIKE '%" + courseId + "%' AND Id = " + stdID);
            DataTable table = this.getStudents(command);

            if (table.Rows.Count > 0)
                return true;
            else return false;
        }
        public bool updateSelectedCourses(int id, string course)
        {
            SqlCommand command = new SqlCommand("UPDATE std SET selectCourse = @course WHERE id = @ID", myDb.GetConnection);

            command.Parameters.Add("@ID", SqlDbType.Int).Value = id;
            command.Parameters.Add("@course", SqlDbType.NVarChar).Value = course;

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
    }
}


