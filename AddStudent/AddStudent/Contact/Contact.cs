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
    class Contact
    {
        DataBase mydb = new DataBase();
        public bool insertContact(int id, string fname, string lname, int groupid, string phone, string email, string address, MemoryStream picture, int userid)
        {
            SqlCommand comand = new SqlCommand("INSERT INTO Contact (Id, fname, lname, group_id, phone,email, address, pic,userid)" +
                " VALUES (@id, @fn, @ln, @gri,@phn,@em, @adrs, @pic,@ui)", mydb.GetConnection);
            comand.Parameters.Add("@id", SqlDbType.Int).Value = id;
            comand.Parameters.Add("@fn", SqlDbType.VarChar).Value = fname;
            comand.Parameters.Add("@ln", SqlDbType.VarChar).Value = lname;
            comand.Parameters.Add("@phn", SqlDbType.VarChar).Value = phone;
            comand.Parameters.Add("@em", SqlDbType.VarChar).Value = email;
            comand.Parameters.Add("@adrs", SqlDbType.VarChar).Value = address;
            comand.Parameters.Add("@pic", SqlDbType.Image).Value = picture.ToArray();
            comand.Parameters.Add("@ui", SqlDbType.Int).Value = Globals.GlobalUserId;
            comand.Parameters.Add("@gri", SqlDbType.Int).Value = groupid;
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
        public bool UpdateContact(int id, string fname, string lname, int groupid, string phone, string email, string address, MemoryStream picture)
        {
            SqlCommand comand = new SqlCommand("UPDATE Contact SET fname=@fn,lname=@ln,group_id=@gri,phone=@phn,email=@em,ad" +
                "dress=@adrs,pic=@pic WHERE id=" + id, mydb.GetConnection);

            comand.Parameters.Add("@fn", SqlDbType.VarChar).Value = fname;
            comand.Parameters.Add("@ln", SqlDbType.VarChar).Value = lname;
            comand.Parameters.Add("@gri", SqlDbType.Int).Value = groupid;
            comand.Parameters.Add("@phn", SqlDbType.VarChar).Value = phone;
            comand.Parameters.Add("@em", SqlDbType.VarChar).Value = email;
            comand.Parameters.Add("@adrs", SqlDbType.VarChar).Value = address;
            comand.Parameters.Add("@pic", SqlDbType.Image).Value = picture.ToArray();
            comand.Parameters.Add("@ui", SqlDbType.Int).Value = Globals.GlobalUserId;
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

        public bool deleteContact(int id)
        {
            SqlCommand command = new SqlCommand("DELETE FROM Contact WHERE id= @id", mydb.GetConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            mydb.openConnection();
            if ((command.ExecuteNonQuery() == 1))
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
        public DataTable getContactById(int id)
        {
            SqlCommand command = new SqlCommand("select * from Contact where id=@id", mydb.GetConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public DataTable getContact(SqlCommand command)
        {
            command.Connection = mydb.GetConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public DataTable SelectContactList(SqlCommand command)
        {
            command.Connection = mydb.GetConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public bool checkId(int courseId)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM Contact WHERE Id=@cId", mydb.GetConnection);
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
    }
}
