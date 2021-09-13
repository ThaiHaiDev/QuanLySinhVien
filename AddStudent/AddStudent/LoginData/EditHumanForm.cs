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
    public partial class EditHumanForm : Form
    {
        public EditHumanForm()
        {
            InitializeComponent();
        }
        User user = new User();
        private void uploadImg_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image (*.jpg; *.png; *.gif)| *.jpg; *.png; *.gif";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                this.pictureBoxImage.Image = Image.FromFile(opf.FileName);
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (verif())
            {
                int ID = Convert.ToInt32(textBoxUserID.Text);
                string fname = textBoxFirstName.Text;
                string lname = textBoxLastName.Text;
                string username = textBoxUserName.Text;
                string password = textBoxPassword.Text;
                MemoryStream pic = new MemoryStream();
                pictureBoxImage.Image.Save(pic, pictureBoxImage.Image.RawFormat);

                if (user.usernameExist(username, "edit", Globals.GlobalUserId) == true)
                {

                    if (user.updatetUser(ID, fname, lname, username, password, pic))
                    {
                        MessageBox.Show("Update", "Register", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error", "Register", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Da ton tai ID hay Username", "Register", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Empty Fields", "Register", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        public bool verif()
        {
            if ((textBoxFirstName.Text.Trim() == "")
                      || (textBoxLastName.Text.Trim() == "")
                      || (textBoxUserID.Text.Trim() == "")
                      || (textBoxUserName.Text.Trim() == "")
                      || (textBoxPassword.Text.Trim() == "")
                      || (pictureBoxImage.Image == null))
            {
                return false;
            }
            else return true;
        }

        private void EditHumanForm_Load(object sender, EventArgs e)
        {
            DataTable table = user.getUserById(Globals.GlobalUserId);
            this.textBoxUserID.Text = table.Rows[0][0].ToString();
            this.textBoxFirstName.Text = table.Rows[0][1].ToString();
            this.textBoxLastName.Text = table.Rows[0][2].ToString();
            this.textBoxUserName.Text = table.Rows[0][3].ToString();
            this.textBoxPassword.Text = table.Rows[0][4].ToString();

            byte[] pic;
            pic = (byte[])table.Rows[0][5];
            MemoryStream picture = new MemoryStream(pic);
            this.pictureBoxImage.Image = Image.FromStream(picture);
        }
    }
}
