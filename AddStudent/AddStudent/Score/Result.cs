using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddStudent
{
    class Result
    {
        DataBase mydb = new DataBase();

        public DataTable getDataResult()
        {
            string strGetCourse = "Select label from course";
            SqlCommand com = new SqlCommand(strGetCourse, mydb.GetConnection);
            SqlDataAdapter ad = new SqlDataAdapter(com);
            DataTable d = new DataTable();
            ad.Fill(d);
            string str = " SELECT dbo.std.Id AS MSSV, fname AS Họ, lname AS Tên ";
            for (int i = 0; i < d.Rows.Count; i++)
            {
                string s = "s" + i.ToString();
                string s1 = d.Rows[i][0].ToString();
                str += ", ISNULL(" + s.Trim() + ".[" + s1.Trim() + "],0) AS '" + s1.Trim() + "' ";
            }

            str += ", ISNULL(E.AVG,0) AS 'Trung Bình', ISNULL(XepLoai,'Rớt') AS 'Xếp Loại'  FROM dbo.std ";

            for (int i = 0; i < d.Rows.Count; i++)
            {
                string s = "s" + i.ToString();
                string s1 = d.Rows[i][0].ToString();
                str += " LEFT JOIN (SELECT Student_Id, Student_Score AS '" + s1.Trim() + "' FROM dbo.Score WHERE Course_Id = " + (i + 1).ToString() + " ) AS " + s + " ON " + s + ".Student_Id = dbo.std.Id ";
            }
            str += " left JOIN ( SELECT L.sId, AVG(L.AVG) AS 'AVG' FROM( SELECT H.sID, H.cID,ISNULL(Student_Score,0) AS 'AVG' FROM (SELECT std.Id AS sID, dbo.Course.Id AS cID FROM dbo.std, dbo.Course) AS H LEFT JOIN dbo.Score ON Course_id = H.cID AND h.sID = Student_Id )AS L GROUP BY L.sId) AS E ON E.sID = dbo.std.Id LEFT JOIN dbo.Diem ON Diem.Tu <= E.AVG AND diem.Den >=E.AVG ";

            SqlDataAdapter adapter = new SqlDataAdapter(str, mydb.GetConnection);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }


        public DataTable getDataResultCommand(SqlCommand comm)
        {
            comm.Connection = mydb.GetConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(comm);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }
    }
}
