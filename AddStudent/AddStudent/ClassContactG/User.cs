using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddStudent
{
    class User
    {
        DataBase mydb = new DataBase();
        public bool insertUSer(int Id, string fname, string lname, string username, string pass, MemoryStream picture)
        {
            SqlCommand comand = new SqlCommand("INSERT INTO User__ (Id,f_name,l_name,uname,pwd, fig)" +
                " VALUES (@cid, @fn,@ln,@una,@pass,@pic)", mydb.GetConnection);

            comand.Parameters.Add("@cid", SqlDbType.Int).Value = Id;
            comand.Parameters.Add("@fn", SqlDbType.VarChar).Value = fname;
            comand.Parameters.Add("@ln", SqlDbType.VarChar).Value = lname;
            comand.Parameters.Add("@una", SqlDbType.VarChar).Value = username;
            comand.Parameters.Add("@pass", SqlDbType.VarChar).Value = pass;
            comand.Parameters.Add("@pic", SqlDbType.Image).Value = picture.ToArray();
            mydb.openConnection();
            if ((comand.ExecuteNonQuery() == 1))
            {
                mydb.closeConnection();
                return true;
            }
            else
            {
                mydb.closeConnection();
                return false;
            }
        }
        public bool UserNameScoreExist(int userID, string username)
        {
            SqlCommand command = new SqlCommand("SELECT Id,uname FROM User__ WHERE Id = @id or uname = @name", mydb.GetConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = userID;
            command.Parameters.Add("@name", SqlDbType.VarChar).Value = username;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            if (table.Rows.Count == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public DataTable getUserById(Int32 userid)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            SqlCommand command = new SqlCommand("SELECT * FROM User__ WHERE Id = @uid", mydb.GetConnection);
            command.Parameters.Add("@uid", SqlDbType.Int).Value = userid;
            adapter.SelectCommand = command;
            adapter.Fill(table);
            return table;
        }
        public bool updatetUser(int userid, string fname, string lname, string username, string password, MemoryStream picture)
        {
            SqlCommand command = new SqlCommand("Update User__ set f_name = @fn, l_name = @ln, uname = @un, pwd = @pass, fig = @pic where Id = @uid", mydb.GetConnection);
            command.Parameters.Add("@fn", SqlDbType.VarChar).Value = fname;
            command.Parameters.Add("@ln", SqlDbType.VarChar).Value = lname;
            command.Parameters.Add("@un", SqlDbType.VarChar).Value = username;
            command.Parameters.Add("@pass", SqlDbType.VarChar).Value = password;
            command.Parameters.Add("@pic", SqlDbType.Image).Value = picture.ToArray();
            command.Parameters.Add("@uid", SqlDbType.Int).Value = userid;

            mydb.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                mydb.closeConnection();
                return true;
            }
            else
            {
                mydb.closeConnection();
                return false;
            }
        }
        public bool usernameExist(string username, string operation, int userid)
        {
            string query = "";
            if (operation == "register")
            {
                query = "Select * from User__ where uname = @un";
            }
            else if (operation == "edit")
            {
                query = "Select * from User__ where uname = @un and id <> @uid";
            }

            SqlCommand command = new SqlCommand(query, mydb.GetConnection);
            command.Parameters.Add("@un", SqlDbType.VarChar).Value = username;
            command.Parameters.Add("@uid", SqlDbType.Int).Value = userid;
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            adapter.SelectCommand = command;
            adapter.Fill(table);


            if (table.Rows.Count > 0)
            {
                return false;        //Da ton tai

            }
            else
            {
                return true;       // Khong ton tai
            }
        }
    }
}
