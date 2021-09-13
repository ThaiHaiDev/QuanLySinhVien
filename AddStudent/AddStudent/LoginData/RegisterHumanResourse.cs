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
    public partial class RegisterHumanResourse : Form
    {
        public RegisterHumanResourse()
        {
            InitializeComponent();
        }
        DataBase mydb = new DataBase();
        User user = new User();
        private void btRegister_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtStudentID.Text);
            string fname = TextBoxFname.Text;
            string lname = TextBoxlname.Text;

            string uname = TextBoxUserName.Text;
            string pass = TextBoxPass.Text;

            MemoryStream pic = new MemoryStream();
            bool verif()
            {
                if ((TextBoxFname.Text.Trim() == "")
                    || (TextBoxlname.Text.Trim() == "")
                    || (TextBoxUserName.Text.Trim() == "")
                    || (TextBoxPass.Text.Trim() == "")
                    || (PictureBoxHumanResourse.Image == null))
                {
                    return false;
                }
                else
                {
                    return true;
                }

            }

            if (verif())
            {
                PictureBoxHumanResourse.Image.Save(pic, PictureBoxHumanResourse.Image.RawFormat);
                if (!user.UserNameScoreExist(id, uname))
                {
                    if (user.insertUSer(id, fname, lname, uname, pass, pic))
                    {
                        MessageBox.Show("new st add", "add student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("error", "add student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("the Id or uname already exists", "add score", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("empty fieds", "add student", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void upload_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            if ((opf.ShowDialog() == DialogResult.OK))
            {
                PictureBoxHumanResourse.Image = Image.FromFile(opf.FileName);
            }
        }
    }
}
