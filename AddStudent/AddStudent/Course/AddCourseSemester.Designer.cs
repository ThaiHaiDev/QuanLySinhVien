
namespace AddStudent
{
    partial class AddCourseSemester
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddCourseSemester));
            this.listBoxSelect = new System.Windows.Forms.ListBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.listBoxCourse = new System.Windows.Forms.ListBox();
            this.comboBoxSemester = new System.Windows.Forms.ComboBox();
            this.textBoxStudentID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonXoa = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxSelect
            // 
            this.listBoxSelect.FormattingEnabled = true;
            this.listBoxSelect.ItemHeight = 16;
            this.listBoxSelect.Location = new System.Drawing.Point(456, 170);
            this.listBoxSelect.Name = "listBoxSelect";
            this.listBoxSelect.Size = new System.Drawing.Size(245, 196);
            this.listBoxSelect.TabIndex = 22;
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(63)))), ((int)(((byte)(52)))));
            this.buttonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSave.Location = new System.Drawing.Point(310, 300);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(111, 39);
            this.buttonSave.TabIndex = 21;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // listBoxCourse
            // 
            this.listBoxCourse.FormattingEnabled = true;
            this.listBoxCourse.ItemHeight = 16;
            this.listBoxCourse.Location = new System.Drawing.Point(28, 170);
            this.listBoxCourse.Name = "listBoxCourse";
            this.listBoxCourse.Size = new System.Drawing.Size(245, 196);
            this.listBoxCourse.TabIndex = 19;
            // 
            // comboBoxSemester
            // 
            this.comboBoxSemester.FormattingEnabled = true;
            this.comboBoxSemester.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.comboBoxSemester.Location = new System.Drawing.Point(624, 96);
            this.comboBoxSemester.Name = "comboBoxSemester";
            this.comboBoxSemester.Size = new System.Drawing.Size(63, 24);
            this.comboBoxSemester.TabIndex = 18;
            this.comboBoxSemester.SelectedIndexChanged += new System.EventHandler(this.comboBoxSemester_SelectedIndexChanged);
            // 
            // textBoxStudentID
            // 
            this.textBoxStudentID.Location = new System.Drawing.Point(141, 98);
            this.textBoxStudentID.Name = "textBoxStudentID";
            this.textBoxStudentID.Size = new System.Drawing.Size(151, 22);
            this.textBoxStudentID.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Gray;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Image = ((System.Drawing.Image)(resources.GetObject("label4.Image")));
            this.label4.Location = new System.Drawing.Point(452, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "Select Course:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Gray;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Image = ((System.Drawing.Image)(resources.GetObject("label3.Image")));
            this.label3.Location = new System.Drawing.Point(452, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "Select Semester:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Gray;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.Location = new System.Drawing.Point(29, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Available Course:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Gray;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(30, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Student ID:";
            // 
            // buttonXoa
            // 
            this.buttonXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(95)))), ((int)(((byte)(207)))));
            this.buttonXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonXoa.Image = global::AddStudent.Properties.Resources.Button_Remove_icon;
            this.buttonXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonXoa.Location = new System.Drawing.Point(310, 238);
            this.buttonXoa.Name = "buttonXoa";
            this.buttonXoa.Size = new System.Drawing.Size(111, 39);
            this.buttonXoa.TabIndex = 23;
            this.buttonXoa.Text = "    Delete";
            this.buttonXoa.UseVisualStyleBackColor = false;
            this.buttonXoa.Click += new System.EventHandler(this.buttonXoa_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(87)))), ((int)(((byte)(119)))));
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.Image = global::AddStudent.Properties.Resources.Button_Add_icon1;
            this.buttonAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAdd.Location = new System.Drawing.Point(310, 184);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(111, 39);
            this.buttonAdd.TabIndex = 20;
            this.buttonAdd.Text = "   Add";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel2.Location = new System.Drawing.Point(0, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 73);
            this.panel2.TabIndex = 47;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(90, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(638, 73);
            this.panel1.TabIndex = 46;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(128, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(376, 44);
            this.label5.TabIndex = 36;
            this.label5.Text = "Select Course Form";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.AliceBlue;
            this.pictureBox1.Image = global::AddStudent.Properties.Resources.icono_capacitacion_png_7;
            this.pictureBox1.Location = new System.Drawing.Point(10, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 73);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 45;
            this.pictureBox1.TabStop = false;
            // 
            // AddCourseSemester
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.BackgroundImage = global::AddStudent.Properties.Resources.e3982cc208873792337b423d9e7714b310;
            this.ClientSize = new System.Drawing.Size(729, 393);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonXoa);
            this.Controls.Add(this.listBoxSelect);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.listBoxCourse);
            this.Controls.Add(this.comboBoxSemester);
            this.Controls.Add(this.textBoxStudentID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddCourseSemester";
            this.Text = "AddCourseSemerter";
            this.Load += new System.EventHandler(this.AddCourseSemester_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonXoa;
        private System.Windows.Forms.ListBox listBoxSelect;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.ListBox listBoxCourse;
        private System.Windows.Forms.ComboBox comboBoxSemester;
        private System.Windows.Forms.TextBox textBoxStudentID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}