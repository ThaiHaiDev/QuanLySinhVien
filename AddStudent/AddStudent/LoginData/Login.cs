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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        User user = new User();
        DataBase mydb = new DataBase();
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            DataBase db = new DataBase();
            SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=AddStu;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            if (radioButtonStudent.Checked == true)
            {
                try
                {
                    con.Open();
                    string tk = textBoxUserName.Text;
                    string mk = textBoxPassWord.Text;
                    string sql = "select * from Login__ WHERE UserName ='" + tk + "'and PassWord='" + mk + "'";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    SqlDataReader dta = cmd.ExecuteReader();
                    if (dta.Read() == true)
                    {
                        //MessageBox.Show("dang nhap thanh cong");
                        Form1 MF = new Form1();
                        MF.Show(this);
                    }
                    else
                    {
                        MessageBox.Show("dang nhap that bai");

                    }
                }
                catch (Exception eww)
                {
                    MessageBox.Show("Lỗi " + eww.Message);
                }
            }
            else if (radioButtonHumanResourse.Checked == true)
            {
                try
                {
                    con.Open();

                    SqlCommand comand = new SqlCommand("Select * From User__ where uname = @Name and pwd = @pass", mydb.GetConnection);
                    comand.Parameters.Add("@Name", SqlDbType.VarChar).Value = textBoxUserName.Text;
                    comand.Parameters.Add("@pass", SqlDbType.VarChar).Value = textBoxPassWord.Text;
                    comand.Connection = db.GetConnection;
                    SqlDataAdapter adapter = new SqlDataAdapter(comand);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    if ((table.Rows.Count == 0))
                    {
                        MessageBox.Show("dang nhap ktc");
                    }
                    else
                    {
                        int userid = Convert.ToInt16(table.Rows[0][0].ToString());
                        Globals.SetGlobalUserId(userid);
                        ContactForm contactForm = new ContactForm();
                        contactForm.Show(this);

                    }

                }
                catch (Exception eww)
                {
                    MessageBox.Show("Lỗi " + eww.Message);
                }
            }
        }
        private void buttonRegister_Click(object sender, EventArgs e)
        {
            if (radioButtonStudent.Checked == true)
            {
                Register re = new Register();
                re.Show(this);
            }
            else if (radioButtonHumanResourse.Checked == true)
            {
                RegisterHumanResourse user = new RegisterHumanResourse();
                user.Show(this);
            }

        }
    }
}
