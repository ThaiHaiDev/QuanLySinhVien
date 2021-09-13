using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddStudent
{
    class AddAcount
    {
        DataBase myDb = new DataBase();
        public bool insertLogin(string user, string pass)
        {
            SqlCommand command = new SqlCommand("INSERT INTO Login__(username, password)" +
                "VALUES (@user, @pass)", myDb.GetConnection);
            command.Parameters.Add("@user", SqlDbType.VarChar).Value = user;
            command.Parameters.Add("@pass", SqlDbType.VarChar).Value = pass;
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
