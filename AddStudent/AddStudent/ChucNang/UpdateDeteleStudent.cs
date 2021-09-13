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
    public partial class UpdateDeteleStudent : Form
    {
        public UpdateDeteleStudent()
        {
            InitializeComponent();
        }
        Student student = new Student();


        //private void UpdateDeteleStudent_Load(object sender, EventArgs e)
        //{

        //    SqlCommand command = new SqlCommand("SELECT * FROM std");
        //    DataGridView1.ReadOnly = true;
        //    DataGridViewImageColumn picCol = new DataGridViewImageColumn();
        //    DataGridView1.RowTemplate.Height = 80;
        //    DataGridView1.DataSource = student.getStudents(command);
        //    picCol = (DataGridViewImageColumn)DataGridView1.Columns[7];
        //    picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
        //    DataGridView1.AllowUserToAddRows = false;

        //}
        //private void DataGridView1_DoubleClick(object sender, EventArgs e)
        //{
        //    UpdateDeteleStudent updateDeteleStudent = new UpdateDeteleStudent();
        //    updateDeteleStudent.textBox1.Text = DataGridView1.CurrentRow.Cells[0].Value.ToString();
        //    updateDeteleStudent.textBox2.Text = DataGridView1.CurrentRow.Cells[1].Value.ToString();
        //    updateDeteleStudent.Show();
        //}
        private void UpdateDeteleStudent_Load(object sender, EventArgs e)
        {
            SetMyCustomFormat();
        }

        private void buttonFind_Click(object sender, EventArgs e)
        {
            if (textBoxID.Text.Trim() != "")
            {
                int id = int.Parse(textBoxID.Text);
                SqlCommand command = new SqlCommand("SELECT id, fname, lname, bdate, gender, phone, address, picture FROM std WHERE id = " + id);
                DataTable table = student.getStudents(command);
                if (table.Rows.Count > 0)
                {
                    textBoxFName.Text = table.Rows[0]["fname"].ToString();
                    textBoxLName.Text = table.Rows[0]["lname"].ToString();
                    dateTimePicker1.Value = (DateTime)table.Rows[0]["bdate"];
                    if (table.Rows[0]["gender"].ToString() == "Female    ")
                    {
                        Female.Checked = true;
                    }
                    else
                    {
                        Male.Checked = true;
                    }
                    textBoxPhone.Text = table.Rows[0]["phone"].ToString();
                    textBoxAddress.Text = table.Rows[0]["address"].ToString();
                    byte[] pic = (byte[])table.Rows[0]["picture"];
                    MemoryStream picture = new MemoryStream(pic);
                    pictureBox1.Image = Image.FromStream(picture);
                }
                else
                {
                    MessageBox.Show("No");
                }
            }
            else
            {
                MessageBox.Show("Nhập Id");
            }
        }

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
        bool verif()
        {
            if ((textBoxID.Text.Trim() == "") ||
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
                    if (student.checkStudentId(id))
                    {
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
                    else
                    {
                        MessageBox.Show("ID Da Ton Tai", "Add Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        private void buttonUpImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image(*.jpg; *.png; *.gif)| *.jpg; *.png; *.gif";
            if ((opf.ShowDialog() == DialogResult.OK))
            {
                pictureBox1.Image = Image.FromFile(opf.FileName);
            }
        }
        public void SetMyCustomFormat()
        {
            // Set the Format type and the CustomFormat string.
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "yyyy - MM - dd";

        }

        private void buttonAddCourse_Click(object sender, EventArgs e)
        {
            AddCourseSemester r = new AddCourseSemester();
            r.hienThi(this.textBoxID.Text);
            r.Show(this);
        }

        private void buttonSearch_Click_1(object sender, EventArgs e)
        {
            string name = textBoxSearch.Text;
            SqlCommand command = new SqlCommand(" SELECT * FROM std WHERE CONCAT(fname,lname,Id) LIKE '%" + name + "%'");
            //string phone = (textBoxFind.Text);
            //SqlCommand command = new SqlCommand("SELECT id, fname, lname, bdate, gender, phone, address, picture FROM std WHERE phone = " + phone);
            DataTable table = student.getStudents(command);
            if (table.Rows.Count > 0)
            {
                textBoxID.Text = table.Rows[0]["id"].ToString();
                textBoxFName.Text = table.Rows[0]["fname"].ToString();
                textBoxLName.Text = table.Rows[0]["lname"].ToString();
                dateTimePicker1.Value = (DateTime)table.Rows[0]["bdate"];
                if (table.Rows[0]["gender"].ToString() == "Female    ")
                {
                    Female.Checked = true;
                }
                else
                {
                    Male.Checked = true;
                }
                textBoxAddress.Text = table.Rows[0]["address"].ToString();
                byte[] pic = (byte[])table.Rows[0]["picture"];
                MemoryStream picture = new MemoryStream(pic);
                pictureBox1.Image = Image.FromStream(picture);
            }
            else
            {
                MessageBox.Show("No");
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        int plag = 0;
        // Ẩn hiện thanh Menu
        private void buttonMenu_Click(object sender, EventArgs e)
        {
            if (plag == 0)
            {
                this.panel3.Visible = false;  //Hiện ra chức năng
                this.panel4.Visible = false;
                this.panelLoad.Location = new Point(150, 80);
                plag = 1;
            }
            else
            {
                this.panel3.Visible = true;
                this.panel4.Visible = true;
                this.panelLoad.Location = new Point(230, 80);
                plag = 0;
            }
        }
    }
}
