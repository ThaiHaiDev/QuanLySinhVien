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
    public partial class Register : Form
    {
        DataBase myDb = new DataBase();
        public Register()
        {
            InitializeComponent();
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }
        private void buttonRegister_Click(object sender, EventArgs e)
        {
            AddAcount tk = new AddAcount();

            string username = textBoxUserName.Text;
            string password = textBoxPassWord.Text;
            SqlCommand commandCheckUsername = new SqlCommand("SELECT id FROM Login__ WHERE username = @username");
            commandCheckUsername.Parameters.Add("@username", SqlDbType.VarChar).Value = textBoxUserName.Text;
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            commandCheckUsername.Connection = myDb.GetConnection;
            adapter.SelectCommand = commandCheckUsername;
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Username đã tồn tại", "Username Exist", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            if (tk.insertLogin(username, password))
            {
                MessageBox.Show("New Account Add", "Add Account", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error", "Add Account", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }
        bool verif()
        {
            if ((textBoxUserName.Text.Trim() == "") || (textBoxPassWord.Text.Trim() == ""))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        //public bool insertLogin(string user, string pass)
        //{
        //    SqlCommand command = new SqlCommand("INSERT INTO Login__(username, password)" +
        //        "VALUES (@user, @pass)", myDb.GetConnection);
        //    command.Parameters.Add("@user", SqlDbType.VarChar).Value = user;
        //    command.Parameters.Add("@pass", SqlDbType.VarChar).Value = pass;
        //    myDb.openConnection();
        //    if ((command.ExecuteNonQuery() == 1))
        //    {
        //        myDb.closeConnection();
        //        return true;
        //    }
        //    else
        //    {
        //        myDb.closeConnection();
        //        return false;
        //    }

        //}


    }
}
