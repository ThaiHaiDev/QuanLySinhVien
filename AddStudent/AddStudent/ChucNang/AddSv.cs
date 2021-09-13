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
    public partial class AddSv : Form
    {
        public AddSv()
        {
            InitializeComponent();
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Student student = new Student();
            int id = Convert.ToInt32(textBoxSudentID.Text);
            string fname = textBoxFName.Text;
            string lname = textBoxLName.Text;
            DateTime bdate = dateTimePicker1.Value;
            string gender = "Male";
            string phone = textBoxPhone.Text;
            string address = textBoxAddress.Text;
            if (Female.Checked)
            {
                gender = "Female";
            }
            else
            {
                gender = "Male";
            }
            MemoryStream pic = new MemoryStream();
            int born_year = dateTimePicker1.Value.Year;
            int this_year = DateTime.Now.Year;
            if (((this_year - born_year) < 10) || ((this_year - born_year) > 100))
            {
                MessageBox.Show("The student Age Must Be Between 10 and 100 year", "Incalid Birth Day", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            else if (verif())
            {
                if (student.checkStudentId(id))
                {
                    pictureBoxStudent.Image.Save(pic, pictureBoxStudent.Image.RawFormat);
                    if (student.insertStudent(id, fname, lname, bdate, gender, phone, address, pic) == true ||
                        student.insertStudent(id, fname, lname, bdate, gender, phone, address, pic) == false)
                    {
                        MessageBox.Show("New Student Added", "Add Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error", "Add Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("ID Da Ton Tai", "Add Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Empty", "Add Student", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        bool verif()
        {
            if (
                 (textBoxFName.Text.Trim() == "")
                || (textBoxLName.Text.Trim() == "")
                || (textBoxPhone.Text.Trim() == "")
                || (textBoxAddress.Text.Trim() == "")
                || (pictureBoxStudent.Image == null))
            {
                return false;
            }
            else
            {
                return true;
            }

        }

        private void buttonUpImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image(*.jpg; *.png; *.gif)| *.jpg; *.png; *.gif";
            if ((opf.ShowDialog() == DialogResult.OK))
            {
                pictureBoxStudent.Image = Image.FromFile(opf.FileName);
            }
        }

        private void AddSv_Load(object sender, EventArgs e)
        {

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
