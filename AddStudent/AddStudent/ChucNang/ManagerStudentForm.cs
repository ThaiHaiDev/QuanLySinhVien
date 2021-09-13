using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddStudent
{
    public partial class ManagerStudentForm : Form
    {
        public ManagerStudentForm()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Student student = new Student();
            int id = Convert.ToInt32(textBoxID.Text);
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
                pictureBox1.Image.Save(pic, pictureBox1.Image.RawFormat);
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
                || (pictureBox1.Image == null))
            {
                return false;
            }
            else
            {
                return true;
            }

        }
        Student student = new Student();
        private void buttonRemove_Click(object sender, EventArgs e)
        {
            try
            {
                int studentId = Convert.ToInt32(textBoxID.Text);
                if ((MessageBox.Show("Are You Sure You Want To Delete This Studen", "Delete Student", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                {
                    if (student.deleteStudent(studentId))
                    {
                        MessageBox.Show("Student Deleted", "Delete Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        textBoxID.Text = "";
                        textBoxFName.Text = "";
                        textBoxLName.Text = "";
                        textBoxPhone.Text = "";
                        textBoxAddress.Text = "";
                        dateTimePicker1.Value = DateTime.Now;
                        pictureBox1.Image = null;
                    }
                    else
                    {
                        MessageBox.Show("Student Not Deleted", "Delete Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Please Enter A Valid ID", "Delete Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonUpImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image(*.jpg; *.png; *.gif)| *.jpg; *.png; *.gif";
            if ((opf.ShowDialog() == DialogResult.OK))
            {
                pictureBox1.Image = Image.FromFile(opf.FileName);
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            int id;
            string fname = textBoxFName.Text;
            string lname = textBoxLName.Text;
            DateTime bdate = dateTimePicker1.Value;
            string phone = textBoxPhone.Text;
            string address = textBoxAddress.Text;
            string gender = "Male";
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
                try
                {
                    id = Convert.ToInt32(textBoxID.Text);
                    pictureBox1.Image.Save(pic, pictureBox1.Image.RawFormat);
                    if (student.updateStudent(id, fname, lname, bdate, gender, phone, address, pic))
                    {
                        MessageBox.Show("Student Information Updated", "Edit Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error", "Edit Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Edit Student", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Empty Fields", "Edit Student", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void buttonDownLoad_Click(object sender, EventArgs e)
        {
            SaveFileDialog svf = new SaveFileDialog();
            svf.FileName = ("student_" + textBoxID.Text);
            if ((pictureBox1.Image == null))
            {
                MessageBox.Show("No Image In The PictureBox");
            }
            else if ((svf.ShowDialog() == DialogResult.OK))
            {
                pictureBox1.Image.Save((svf.FileName + ("." + ImageFormat.Jpeg.ToString())));
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string name = textBoxSearch.Text;
            SqlCommand command = new SqlCommand("SELECT Id as N'MSSV', lname as N'Họ', fname as N'Tên', bdate as N'Ngày Sinh', gender as N'Giới tính', phone as N'SDT', address as N'Địa Chỉ', picture as N'Hình ảnh',selectCourse AS N'Môn Chọn Học' FROM std WHERE CONCAT(fname,lname,Id,address) LIKE '%" + name + "%'");
            dataGridView1.ReadOnly = true;
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            dataGridView1.RowTemplate.Height = 80;
            dataGridView1.DataSource = student.getStudents(command);
            picCol = (DataGridViewImageColumn)dataGridView1.Columns[7];
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dataGridView1.AllowUserToAddRows = false;
            DataTable table = student.getStudents(command);
            if (table.Rows.Count > 0)
            {
                textBoxID.Text = table.Rows[0]["MSSV"].ToString();
                textBoxFName.Text = table.Rows[0]["Tên"].ToString();
                textBoxLName.Text = table.Rows[0]["Họ"].ToString();
                dateTimePicker1.Value = (DateTime)table.Rows[0]["Ngày Sinh"];
                if (table.Rows[0]["Giới tính"].ToString() == "Female    ")
                {
                    Female.Checked = true;
                }
                else
                {
                    Male.Checked = true;
                }
                textBoxPhone.Text = table.Rows[0]["SDT"].ToString();
                textBoxAddress.Text = table.Rows[0]["Địa Chỉ"].ToString();
                byte[] pic = (byte[])table.Rows[0]["Hình ảnh"];
                MemoryStream picture = new MemoryStream(pic);
                pictureBox1.Image = Image.FromStream(picture);
            }
            else
            {
                MessageBox.Show("No");
            }
        }

        private void ManagerStudentForm_Load(object sender, EventArgs e)
        {
            labelTotalStudent.Text = ("Total Student: " + 3);
            SqlCommand command = new SqlCommand("SELECT Id as N'MSSV', lname as N'Họ', fname as N'Tên', bdate as N'Ngày Sinh', gender as N'Giới tính', phone as N'SDT', address as N'Địa Chỉ', picture as N'Hình ảnh', selectCourse AS N'Môn Chọn Học' FROM std");
            dataGridView1.ReadOnly = true;
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            dataGridView1.RowTemplate.Height = 80;
            dataGridView1.DataSource = student.getStudents(command);
            picCol = (DataGridViewImageColumn)dataGridView1.Columns[7];
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dataGridView1.AllowUserToAddRows = false;
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            textBoxID.Text = "";
            textBoxLName.Text = "";
            textBoxPhone.Text = "";
            textBoxFName.Text = "";
            textBoxAddress.Text = "";
            Male.Checked = true;
            dateTimePicker1.Value = DateTime.Now;
            pictureBox1.Image = null;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
