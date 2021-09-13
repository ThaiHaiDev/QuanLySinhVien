using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddStudent
{
    public partial class AddContactForm : Form
    {
        public AddContactForm()
        {
            InitializeComponent();
        }
        Contact contact = new Contact();
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (verif())
            {
                int id = Convert.ToInt32(textBoxId.Text);
                string fname = TextBoxFname.Text;
                string lname = TextBoxlname.Text;
                string phone = TextBoxPhone.Text;
                string address = TextBoxAdress.Text;
                string email = textboxEmail.Text;
                int userid = Globals.GlobalUserId;
                int groupid = (int)comboBoxGroup.SelectedValue;
                MemoryStream pic = new MemoryStream();
                PictureBoxStudentImage.Image.Save(pic, PictureBoxStudentImage.Image.RawFormat);
                if (contact.checkId(Convert.ToInt32(textBoxId.Text)))
                {
                    Contact contact = new Contact();
                    if (contact.insertContact(id, fname, lname, groupid, phone, email, address, pic, userid))
                    {
                        MessageBox.Show("New Contact Added", "Add Contact", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error", "Add Contact", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("This ID Already Exists, Try Another One", "Invalid ID", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("empty fieds", "add student", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        bool verif()
        {
            if ((TextBoxFname.Text.Trim() == "")
                || (TextBoxlname.Text.Trim() == "")
                || (textboxGroup.Text.Trim() == "")
                || (TextBoxPhone.Text.Trim() == "")
                || (textboxEmail.Text.Trim() == "")
                || (TextBoxAdress.Text.Trim() == "")
                || (textBoxId.Text.Trim() == "")
                || (PictureBoxStudentImage.Image == null))
            {
                return false;
            }
            else
            {
                return true;
            }

        }

        private void AddContactForm_Load(object sender, EventArgs e)
        {
            Group group = new Group();
            comboBoxGroup.DataSource = group.getGroups(Globals.GlobalUserId);
            comboBoxGroup.DisplayMember = "name";
            comboBoxGroup.ValueMember = "Id";
        }
        private void upload_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            if ((opf.ShowDialog() == DialogResult.OK))
            {
                PictureBoxStudentImage.Image = Image.FromFile(opf.FileName);
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}



