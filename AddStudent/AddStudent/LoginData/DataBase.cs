using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddStudent
{
    class DataBase
    {
        SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=AddStu;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        public SqlConnection GetConnection
        {
            get
            {
                return con;
            }
        }
        // open the connection
        public void openConnection()
        {
            if ((con.State == ConnectionState.Closed))
            {
                con.Open();
            }

        }
        // close the connection
        public void closeConnection()
        {
            if ((con.State == ConnectionState.Open))
            {
                con.Close();
            }
        }
    }
}
