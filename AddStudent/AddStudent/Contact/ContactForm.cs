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
using System.Windows.Forms;

namespace AddStudent
{
    public partial class ContactForm : Form
    {
        public ContactForm()
        {
            InitializeComponent();
        }
        DataBase mydb = new DataBase();
        Contact contact = new Contact();
        public void getImageAndUsername()
        {

            SqlCommand command = new SqlCommand("SELECT * FROM User__ where Id=@uid", mydb.GetConnection);
            command.Parameters.Add("@uid", SqlDbType.Int).Value = Globals.GlobalUserId;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                byte[] pic = (byte[])table.Rows[0]["fig"];
                MemoryStream picture = new MemoryStream(pic);
                this.pictureBoxUser.Image = Image.FromStream(picture);

                this.labelTitle.Text = "Welcome (" + table.Rows[0]["uname"].ToString().Trim() + ")";
                this.labelName.Text = "(" + table.Rows[0]["f_name"].ToString().Trim() + " " + table.Rows[0]["l_name"].ToString().Trim() + ")";
            }
        }


        private void ContactForm_Load(object sender, EventArgs e)
        {
            getImageAndUsername();
            Group group = new Group();
            comboBoxEdit.DataSource = group.getGroups(Globals.GlobalUserId);
            comboBoxEdit.DisplayMember = "name";
            comboBoxEdit.ValueMember = "Id";
            comboBoxRemove.DataSource = group.getGroups(Globals.GlobalUserId);
            comboBoxRemove.DisplayMember = "name";
            comboBoxRemove.ValueMember = "Id";
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(textBoxID.Text);
                if ((MessageBox.Show("Ban Co Muon Xoa Contact Nay", "Delete Contact", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                {
                    if (contact.deleteContact(id))
                    {
                        MessageBox.Show("Da Xoa Contact", "Delete Contact", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        MessageBox.Show("Contact Not Delete", "Delete Contact", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Please Enter Valid ID", "Delete Contact", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonSelect_Click(object sender, EventArgs e)
        {
            SelectContactForm select = new SelectContactForm();
            select.Show(this);
            int contactId = Convert.ToInt32(select.dataGridView2.CurrentRow.Cells[0].Value.ToString());

            Contact contact = new Contact();
            DataTable table = contact.getContactById(contactId);

            textBoxID.Text = table.Rows[0]["Id"].ToString();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            EditContactForm editContactForm = new EditContactForm();
            editContactForm.Show(this);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            AddContactForm addcontact = new AddContactForm();
            addcontact.Show(this);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ContactShowFullList r = new ContactShowFullList();
            r.Show(this);
        }
        Group group = new Group();
        public void loadCombobox()
        {
            this.comboBoxEdit.DataSource = group.getGroups(Globals.GlobalUserId);
            this.comboBoxEdit.DisplayMember = "name";
            this.comboBoxEdit.ValueMember = "Id";

            this.comboBoxRemove.DataSource = group.getGroups(Globals.GlobalUserId);
            this.comboBoxRemove.DisplayMember = "name";
            this.comboBoxRemove.ValueMember = "Id";
        }
        private void buttonGAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.textBoxGAdd.Text.Trim() != "" && this.textBoxIDGroup.Text.Trim() != "")
                {
                    int id = Convert.ToInt32(this.textBoxIDGroup.Text);
                    string name = this.textBoxGAdd.Text;
                    int userid = Globals.GlobalUserId;

                    if (group.checkID(id) && group.groupExist(name, "add", Globals.GlobalUserId, 0))
                    {
                        if (group.insertGroup(id, name, userid))
                        {
                            this.loadCombobox();
                            MessageBox.Show("New Group Added", "Add Group", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Error", "Add Group", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("This ID Already Exists, Try Another One", "Invalid ID", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("One Or More Fields Are Empty", "Add Group", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("Loi", "Add Group", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        bool verif()
        {
            if ((textBoxGAdd.Text == null))
            {
                return false;
            }
            else
            {
                return true;
            }

        }

        private void buttonGEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.comboBoxEdit.SelectedValue != null && this.textBoxGEdit.Text.Trim() != "")
                {
                    int groupID = Convert.ToInt32(this.comboBoxEdit.SelectedValue.ToString().Trim());
                    string name = this.textBoxGEdit.Text;
                    int userid = Globals.GlobalUserId;
                    if (group.groupExist(name, "edit", Globals.GlobalUserId, groupID))
                    {
                        if (group.updateGroup(groupID, name, userid))
                        {
                            this.loadCombobox();
                            MessageBox.Show("Da Cap Nhap", "Edit Group", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("error", "Edit Group", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Exist Name", "Edit Group", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else
                {
                    MessageBox.Show("empty fieds", "Edit Group", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch
            {
                MessageBox.Show("Loi", "Edit Group", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void buttonGRemove_Click(object sender, EventArgs e)
        {
            try
            {
                int groupID = Convert.ToInt32(this.comboBoxRemove.SelectedValue.ToString().Trim());
                if (MessageBox.Show("Ban Chan Chac Muon Xoa Group Nay ", "Delete Group", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (group.deleteGroup(groupID))
                    {
                        this.loadCombobox();
                        MessageBox.Show("Xoa Thanh Cong", "Delete Group", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        MessageBox.Show("Khong Thanh Cong", "Delete Group", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Ban Da Huy Xoa", "Delete Group", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch
            {
                MessageBox.Show("Empty Fieds", "Delete Group", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void labelEditHuman_Click(object sender, EventArgs e)
        {
            EditHumanForm edit = new EditHumanForm();
            edit.Show();
            this.getImageAndUsername();
        }
    }
}
