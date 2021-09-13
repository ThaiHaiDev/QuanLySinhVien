
namespace AddStudent
{
    partial class ManageCourseForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageCourseForm));
            this.buttonAddCourse = new System.Windows.Forms.Button();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.textBoxLable = new System.Windows.Forms.TextBox();
            this.textBoxCourseID = new System.Windows.Forms.TextBox();
            this.labelDecription = new System.Windows.Forms.Label();
            this.labelPeriod = new System.Windows.Forms.Label();
            this.labelLable = new System.Windows.Forms.Label();
            this.labelCourseID = new System.Windows.Forms.Label();
            this.listBoxCourse = new System.Windows.Forms.ListBox();
            this.buttonFirst = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonPrevious = new System.Windows.Forms.Button();
            this.buttonLast = new System.Windows.Forms.Button();
            this.labelTotalCourse = new System.Windows.Forms.Label();
            this.numericUpDownHours = new System.Windows.Forms.NumericUpDown();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonRemoveCourse = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxSemester = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBoxTeacherID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHours)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAddCourse
            // 
            this.buttonAddCourse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.buttonAddCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddCourse.Location = new System.Drawing.Point(121, 536);
            this.buttonAddCourse.Name = "buttonAddCourse";
            this.buttonAddCourse.Size = new System.Drawing.Size(111, 37);
            this.buttonAddCourse.TabIndex = 17;
            this.buttonAddCourse.Text = "Add";
            this.buttonAddCourse.UseVisualStyleBackColor = false;
            this.buttonAddCourse.Click += new System.EventHandler(this.buttonAddCourse_Click);
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(174, 214);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(204, 132);
            this.textBoxDescription.TabIndex = 16;
            // 
            // textBoxLable
            // 
            this.textBoxLable.Location = new System.Drawing.Point(174, 144);
            this.textBoxLable.Name = "textBoxLable";
            this.textBoxLable.Size = new System.Drawing.Size(186, 22);
            this.textBoxLable.TabIndex = 14;
            // 
            // textBoxCourseID
            // 
            this.textBoxCourseID.Location = new System.Drawing.Point(174, 108);
            this.textBoxCourseID.Name = "textBoxCourseID";
            this.textBoxCourseID.Size = new System.Drawing.Size(186, 22);
            this.textBoxCourseID.TabIndex = 13;
            // 
            // labelDecription
            // 
            this.labelDecription.AutoSize = true;
            this.labelDecription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDecription.ForeColor = System.Drawing.SystemColors.Control;
            this.labelDecription.Image = ((System.Drawing.Image)(resources.GetObject("labelDecription.Image")));
            this.labelDecription.Location = new System.Drawing.Point(36, 211);
            this.labelDecription.Name = "labelDecription";
            this.labelDecription.Size = new System.Drawing.Size(127, 25);
            this.labelDecription.TabIndex = 12;
            this.labelDecription.Text = "Description:";
            // 
            // labelPeriod
            // 
            this.labelPeriod.AutoSize = true;
            this.labelPeriod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPeriod.ForeColor = System.Drawing.SystemColors.Control;
            this.labelPeriod.Image = ((System.Drawing.Image)(resources.GetObject("labelPeriod.Image")));
            this.labelPeriod.Location = new System.Drawing.Point(82, 178);
            this.labelPeriod.Name = "labelPeriod";
            this.labelPeriod.Size = new System.Drawing.Size(81, 25);
            this.labelPeriod.TabIndex = 11;
            this.labelPeriod.Text = "Period:";
            // 
            // labelLable
            // 
            this.labelLable.AutoSize = true;
            this.labelLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLable.ForeColor = System.Drawing.SystemColors.Control;
            this.labelLable.Image = ((System.Drawing.Image)(resources.GetObject("labelLable.Image")));
            this.labelLable.Location = new System.Drawing.Point(91, 142);
            this.labelLable.Name = "labelLable";
            this.labelLable.Size = new System.Drawing.Size(72, 25);
            this.labelLable.TabIndex = 10;
            this.labelLable.Text = "Lable:";
            // 
            // labelCourseID
            // 
            this.labelCourseID.AutoSize = true;
            this.labelCourseID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCourseID.ForeColor = System.Drawing.SystemColors.Control;
            this.labelCourseID.Image = ((System.Drawing.Image)(resources.GetObject("labelCourseID.Image")));
            this.labelCourseID.Location = new System.Drawing.Point(47, 105);
            this.labelCourseID.Name = "labelCourseID";
            this.labelCourseID.Size = new System.Drawing.Size(116, 25);
            this.labelCourseID.TabIndex = 9;
            this.labelCourseID.Text = "Course ID:";
            // 
            // listBoxCourse
            // 
            this.listBoxCourse.FormattingEnabled = true;
            this.listBoxCourse.ItemHeight = 16;
            this.listBoxCourse.Location = new System.Drawing.Point(469, 105);
            this.listBoxCourse.Name = "listBoxCourse";
            this.listBoxCourse.Size = new System.Drawing.Size(366, 356);
            this.listBoxCourse.TabIndex = 18;
            this.listBoxCourse.Click += new System.EventHandler(this.listBoxCourse_Click);
            this.listBoxCourse.DoubleClick += new System.EventHandler(this.listBoxCourse_DoubleClick);
            // 
            // buttonFirst
            // 
            this.buttonFirst.BackColor = System.Drawing.Color.SlateGray;
            this.buttonFirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFirst.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonFirst.Image = global::AddStudent.Properties.Resources.Button_First_icon;
            this.buttonFirst.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonFirst.Location = new System.Drawing.Point(14, 481);
            this.buttonFirst.Name = "buttonFirst";
            this.buttonFirst.Size = new System.Drawing.Size(148, 37);
            this.buttonFirst.TabIndex = 19;
            this.buttonFirst.Text = "   First";
            this.buttonFirst.UseVisualStyleBackColor = false;
            this.buttonFirst.Click += new System.EventHandler(this.buttonFirst_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.BackColor = System.Drawing.Color.SlateGray;
            this.buttonNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNext.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonNext.Image = global::AddStudent.Properties.Resources.Button_Next_icon;
            this.buttonNext.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonNext.Location = new System.Drawing.Point(168, 481);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(148, 37);
            this.buttonNext.TabIndex = 20;
            this.buttonNext.Text = "   Next";
            this.buttonNext.UseVisualStyleBackColor = false;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // buttonPrevious
            // 
            this.buttonPrevious.BackColor = System.Drawing.Color.SlateGray;
            this.buttonPrevious.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPrevious.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonPrevious.Image = global::AddStudent.Properties.Resources.Button_Previous_icon;
            this.buttonPrevious.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonPrevious.Location = new System.Drawing.Point(322, 481);
            this.buttonPrevious.Name = "buttonPrevious";
            this.buttonPrevious.Size = new System.Drawing.Size(148, 37);
            this.buttonPrevious.TabIndex = 21;
            this.buttonPrevious.Text = "   Previous";
            this.buttonPrevious.UseVisualStyleBackColor = false;
            this.buttonPrevious.Click += new System.EventHandler(this.buttonPrevious_Click);
            // 
            // buttonLast
            // 
            this.buttonLast.BackColor = System.Drawing.Color.SlateGray;
            this.buttonLast.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLast.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonLast.Image = global::AddStudent.Properties.Resources.Button_Last_icon;
            this.buttonLast.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonLast.Location = new System.Drawing.Point(476, 481);
            this.buttonLast.Name = "buttonLast";
            this.buttonLast.Size = new System.Drawing.Size(148, 37);
            this.buttonLast.TabIndex = 22;
            this.buttonLast.Text = "Last   ";
            this.buttonLast.UseVisualStyleBackColor = false;
            this.buttonLast.Click += new System.EventHandler(this.buttonLast_Click);
            // 
            // labelTotalCourse
            // 
            this.labelTotalCourse.BackColor = System.Drawing.SystemColors.ControlDark;
            this.labelTotalCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalCourse.Location = new System.Drawing.Point(659, 481);
            this.labelTotalCourse.Name = "labelTotalCourse";
            this.labelTotalCourse.Size = new System.Drawing.Size(176, 41);
            this.labelTotalCourse.TabIndex = 23;
            this.labelTotalCourse.Text = "Total Course:";
            this.labelTotalCourse.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numericUpDownHours
            // 
            this.numericUpDownHours.Location = new System.Drawing.Point(174, 179);
            this.numericUpDownHours.Name = "numericUpDownHours";
            this.numericUpDownHours.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownHours.TabIndex = 24;
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEdit.Location = new System.Drawing.Point(254, 535);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(120, 38);
            this.buttonEdit.TabIndex = 25;
            this.buttonEdit.Text = "Edit";
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonRemoveCourse
            // 
            this.buttonRemoveCourse.BackColor = System.Drawing.Color.Red;
            this.buttonRemoveCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRemoveCourse.ForeColor = System.Drawing.Color.Black;
            this.buttonRemoveCourse.Location = new System.Drawing.Point(397, 535);
            this.buttonRemoveCourse.Name = "buttonRemoveCourse";
            this.buttonRemoveCourse.Size = new System.Drawing.Size(112, 38);
            this.buttonRemoveCourse.TabIndex = 26;
            this.buttonRemoveCourse.Text = "Remove";
            this.buttonRemoveCourse.UseVisualStyleBackColor = false;
            this.buttonRemoveCourse.Click += new System.EventHandler(this.buttonRemoveCourse_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(47, 359);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 25);
            this.label1.TabIndex = 28;
            this.label1.Text = "Semester:";
            // 
            // comboBoxSemester
            // 
            this.comboBoxSemester.FormattingEnabled = true;
            this.comboBoxSemester.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.comboBoxSemester.Location = new System.Drawing.Point(174, 360);
            this.comboBoxSemester.Name = "comboBoxSemester";
            this.comboBoxSemester.Size = new System.Drawing.Size(101, 24);
            this.comboBoxSemester.TabIndex = 27;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 73);
            this.panel2.TabIndex = 44;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(90, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(786, 73);
            this.panel1.TabIndex = 43;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(159, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(407, 44);
            this.label4.TabIndex = 36;
            this.label4.Text = "Manage Course Form";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.AliceBlue;
            this.pictureBox1.Image = global::AddStudent.Properties.Resources.icono_capacitacion_png_7;
            this.pictureBox1.Location = new System.Drawing.Point(10, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 73);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 42;
            this.pictureBox1.TabStop = false;
            // 
            // textBoxTeacherID
            // 
            this.textBoxTeacherID.Location = new System.Drawing.Point(179, 403);
            this.textBoxTeacherID.Name = "textBoxTeacherID";
            this.textBoxTeacherID.Size = new System.Drawing.Size(181, 22);
            this.textBoxTeacherID.TabIndex = 46;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Image = global::AddStudent.Properties.Resources.e3982cc208873792337b423d9e7714b310;
            this.label6.Location = new System.Drawing.Point(32, 399);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 25);
            this.label6.TabIndex = 45;
            this.label6.Text = "Teacher ID:";
            // 
            // ManageCourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.BackgroundImage = global::AddStudent.Properties.Resources.e3982cc208873792337b423d9e7714b34;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(877, 593);
            this.Controls.Add(this.textBoxTeacherID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxSemester);
            this.Controls.Add(this.buttonRemoveCourse);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.numericUpDownHours);
            this.Controls.Add(this.labelTotalCourse);
            this.Controls.Add(this.buttonLast);
            this.Controls.Add(this.buttonPrevious);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.buttonFirst);
            this.Controls.Add(this.listBoxCourse);
            this.Controls.Add(this.buttonAddCourse);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.textBoxLable);
            this.Controls.Add(this.textBoxCourseID);
            this.Controls.Add(this.labelDecription);
            this.Controls.Add(this.labelPeriod);
            this.Controls.Add(this.labelLable);
            this.Controls.Add(this.labelCourseID);
            this.Name = "ManageCourseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageCourseForm";
            this.Load += new System.EventHandler(this.ManageCourseForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHours)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAddCourse;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.TextBox textBoxLable;
        private System.Windows.Forms.TextBox textBoxCourseID;
        private System.Windows.Forms.Label labelDecription;
        private System.Windows.Forms.Label labelPeriod;
        private System.Windows.Forms.Label labelLable;
        private System.Windows.Forms.Label labelCourseID;
        private System.Windows.Forms.ListBox listBoxCourse;
        private System.Windows.Forms.Button buttonFirst;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonPrevious;
        private System.Windows.Forms.Button buttonLast;
        private System.Windows.Forms.Label labelTotalCourse;
        private System.Windows.Forms.NumericUpDown numericUpDownHours;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonRemoveCourse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxSemester;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBoxTeacherID;
        private System.Windows.Forms.Label label6;
    }
}