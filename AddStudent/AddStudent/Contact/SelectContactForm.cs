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
    public partial class SelectContactForm : Form
    {
        public SelectContactForm()
        {
            InitializeComponent();
        }
        DataBase mydb = new DataBase();
        private void SelectContactForm_Load(object sender, EventArgs e)
        {

            Contact contact = new Contact();
            SqlCommand command = new SqlCommand("SELECT  Id ,  fname  as'First Name',  lname  as 'Last Name',  group_id  as'Group Id' FROM  Contact  WHERE  userid  = @uid");
            command.Parameters.Add("@uid", SqlDbType.Int).Value = Globals.GlobalUserId;
            dataGridView2.DataSource = contact.SelectContactList(command);
            this.dataGridView2.AllowUserToAddRows = false;
        }

        private void dataGridView2_DoubleClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
