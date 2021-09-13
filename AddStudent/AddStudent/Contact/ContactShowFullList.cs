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
    public partial class ContactShowFullList : Form
    {
        public ContactShowFullList()
        {
            InitializeComponent();
        }
        Contact contact = new Contact();
        Group group = new Group();
        private void ContactShowFullList_Load(object sender, EventArgs e)
        {
            this.listBoxContact.DataSource = group.getGroups(Globals.GlobalUserId);
            this.listBoxContact.ValueMember = "Id";
            this.listBoxContact.DisplayMember = "name";
            this.listBoxContact.SelectedItem = null;
            SqlCommand command = new SqlCommand("SELECT Contact.Id,  lname as 'Last Name', fname as 'First Name', Group__.name as 'Group', phone as 'Phone', email as 'Email', address as 'Address', pic as 'Picture' FROM Contact INNER JOIN Group__ ON Contact.group_id = Group__.Id WHERE Contact.userid = " + Globals.GlobalUserId);
            this.loadDataGridView(command);
        }
        public void loadDataGridView(SqlCommand command)
        {
            this.dataGridViewContact.ReadOnly = true;

            DataGridViewImageColumn picol = new DataGridViewImageColumn();

            this.dataGridViewContact.RowTemplate.Height = 80;
            this.dataGridViewContact.DataSource = contact.getContact(command);
            picol = (DataGridViewImageColumn)dataGridViewContact.Columns[7];
            picol.ImageLayout = DataGridViewImageCellLayout.Zoom;
            this.dataGridViewContact.AllowUserToAddRows = false;

            for (int i = 0; i < this.dataGridViewContact.Rows.Count; i++)
            {
                if (i % 2 != 0)
                {
                    this.dataGridViewContact.Rows[i].DefaultCellStyle.BackColor = Color.WhiteSmoke;
                }
            }
        }

        private void listBoxContact_Click(object sender, EventArgs e)
        {
            int groupId = (Int32)this.listBoxContact.SelectedValue;
            SqlCommand command = new SqlCommand("SELECT Contact.Id,  lname as 'Last Name',fname as 'First Name', Group__.name as 'Group', phone as 'Phone', email as 'Email', address as 'Address', pic as 'Picture' FROM Contact INNER JOIN Group__ ON Contact.group_id = Group__.Id WHERE Contact.userid = @userid AND Contact.group_id = @groupid");
            command.Parameters.Add("@userid", SqlDbType.Int).Value = Globals.GlobalUserId;
            command.Parameters.Add("@groupid", SqlDbType.Int).Value = groupId;

            this.loadDataGridView(command);
        }

        private void buttonShow_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT Contact.Id,  lname as 'Last Name', fname as 'First Name', Group__.name as 'Group', phone as 'Phone', email as 'Email', address as 'Address', pic as 'Picture' FROM Contact INNER JOIN Group__ ON Contact.group_id = Group__.Id WHERE Contact.userid = " + Globals.GlobalUserId);
            this.loadDataGridView(command);
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            this.textBoxAddress.Text = this.dataGridViewContact.CurrentRow.Cells[6].Value.ToString().Trim();
        }

        private void dataGridViewContact_DoubleClick(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(this.dataGridViewContact.CurrentRow.Cells[0].Value.ToString());
            ListStudentCourseForm listStd = new ListStudentCourseForm();
            listStd.reloadListBoxData(id);
            listStd.Show();
        }
    }
}
