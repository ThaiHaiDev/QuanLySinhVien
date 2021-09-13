
namespace AddStudent
{
    partial class AddCourse
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddCourse));
            this.labelCourseID = new System.Windows.Forms.Label();
            this.labelLable = new System.Windows.Forms.Label();
            this.labelPeriod = new System.Windows.Forms.Label();
            this.labelDecription = new System.Windows.Forms.Label();
            this.textBoxCourseID = new System.Windows.Forms.TextBox();
            this.textBoxLable = new System.Windows.Forms.TextBox();
            this.textBoxPeriod = new System.Windows.Forms.TextBox();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.comboBoxSemester = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonAddCourse = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBoxTeacherID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelCourseID
            // 
            this.labelCourseID.AutoSize = true;
            this.labelCourseID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCourseID.ForeColor = System.Drawing.SystemColors.Control;
            this.labelCourseID.Image = ((System.Drawing.Image)(resources.GetObject("labelCourseID.Image")));
            this.labelCourseID.Location = new System.Drawing.Point(23, 118);
            this.labelCourseID.Name = "labelCourseID";
            this.labelCourseID.Size = new System.Drawing.Size(116, 25);
            this.labelCourseID.TabIndex = 0;
            this.labelCourseID.Text = "Course ID:";
            // 
            // labelLable
            // 
            this.labelLable.AutoSize = true;
            this.labelLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLable.ForeColor = System.Drawing.SystemColors.Control;
            this.labelLable.Image = ((System.Drawing.Image)(resources.GetObject("labelLable.Image")));
            this.labelLable.Location = new System.Drawing.Point(23, 165);
            this.labelLable.Name = "labelLable";
            this.labelLable.Size = new System.Drawing.Size(72, 25);
            this.labelLable.TabIndex = 1;
            this.labelLable.Text = "Lable:";
            // 
            // labelPeriod
            // 
            this.labelPeriod.AutoSize = true;
            this.labelPeriod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPeriod.ForeColor = System.Drawing.SystemColors.Control;
            this.labelPeriod.Image = ((System.Drawing.Image)(resources.GetObject("labelPeriod.Image")));
            this.labelPeriod.Location = new System.Drawing.Point(23, 211);
            this.labelPeriod.Name = "labelPeriod";
            this.labelPeriod.Size = new System.Drawing.Size(81, 25);
            this.labelPeriod.TabIndex = 2;
            this.labelPeriod.Text = "Period:";
            // 
            // labelDecription
            // 
            this.labelDecription.AutoSize = true;
            this.labelDecription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDecription.ForeColor = System.Drawing.SystemColors.Control;
            this.labelDecription.Image = ((System.Drawing.Image)(resources.GetObject("labelDecription.Image")));
            this.labelDecription.Location = new System.Drawing.Point(23, 255);
            this.labelDecription.Name = "labelDecription";
            this.labelDecription.Size = new System.Drawing.Size(127, 25);
            this.labelDecription.TabIndex = 3;
            this.labelDecription.Text = "Description:";
            // 
            // textBoxCourseID
            // 
            this.textBoxCourseID.Location = new System.Drawing.Point(169, 122);
            this.textBoxCourseID.Name = "textBoxCourseID";
            this.textBoxCourseID.Size = new System.Drawing.Size(92, 22);
            this.textBoxCourseID.TabIndex = 4;
            // 
            // textBoxLable
            // 
            this.textBoxLable.Location = new System.Drawing.Point(169, 168);
            this.textBoxLable.Name = "textBoxLable";
            this.textBoxLable.Size = new System.Drawing.Size(186, 22);
            this.textBoxLable.TabIndex = 5;
            // 
            // textBoxPeriod
            // 
            this.textBoxPeriod.Location = new System.Drawing.Point(169, 211);
            this.textBoxPeriod.Name = "textBoxPeriod";
            this.textBoxPeriod.Size = new System.Drawing.Size(186, 22);
            this.textBoxPeriod.TabIndex = 6;
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(169, 259);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(186, 101);
            this.textBoxDescription.TabIndex = 7;
            // 
            // comboBoxSemester
            // 
            this.comboBoxSemester.FormattingEnabled = true;
            this.comboBoxSemester.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.comboBoxSemester.Location = new System.Drawing.Point(384, 120);
            this.comboBoxSemester.Name = "comboBoxSemester";
            this.comboBoxSemester.Size = new System.Drawing.Size(101, 24);
            this.comboBoxSemester.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(267, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 25);
            this.label1.TabIndex = 22;
            this.label1.Text = "Semester:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(90, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(418, 73);
            this.panel1.TabIndex = 35;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(42, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(334, 44);
            this.label4.TabIndex = 36;
            this.label4.Text = "Add Course Form";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.AliceBlue;
            this.pictureBox1.Image = global::AddStudent.Properties.Resources.icono_capacitacion_png_7;
            this.pictureBox1.Location = new System.Drawing.Point(10, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 73);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 34;
            this.pictureBox1.TabStop = false;
            // 
            // buttonAddCourse
            // 
            this.buttonAddCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddCourse.Image = global::AddStudent.Properties.Resources.add;
            this.buttonAddCourse.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAddCourse.Location = new System.Drawing.Point(169, 430);
            this.buttonAddCourse.Name = "buttonAddCourse";
            this.buttonAddCourse.Size = new System.Drawing.Size(130, 37);
            this.buttonAddCourse.TabIndex = 8;
            this.buttonAddCourse.Text = "   Add";
            this.buttonAddCourse.UseVisualStyleBackColor = true;
            this.buttonAddCourse.Click += new System.EventHandler(this.buttonAddCourse_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel2.Location = new System.Drawing.Point(0, -1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 73);
            this.panel2.TabIndex = 41;
            // 
            // textBoxTeacherID
            // 
            this.textBoxTeacherID.Location = new System.Drawing.Point(169, 378);
            this.textBoxTeacherID.Name = "textBoxTeacherID";
            this.textBoxTeacherID.Size = new System.Drawing.Size(186, 22);
            this.textBoxTeacherID.TabIndex = 43;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Image = global::AddStudent.Properties.Resources.e3982cc208873792337b423d9e7714b310;
            this.label6.Location = new System.Drawing.Point(24, 374);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 25);
            this.label6.TabIndex = 42;
            this.label6.Text = "Teacher ID:";
            // 
            // AddCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BackgroundImage = global::AddStudent.Properties.Resources.e3982cc208873792337b423d9e7714b3;
            this.ClientSize = new System.Drawing.Size(507, 491);
            this.Controls.Add(this.textBoxTeacherID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxSemester);
            this.Controls.Add(this.buttonAddCourse);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.textBoxPeriod);
            this.Controls.Add(this.textBoxLable);
            this.Controls.Add(this.textBoxCourseID);
            this.Controls.Add(this.labelDecription);
            this.Controls.Add(this.labelPeriod);
            this.Controls.Add(this.labelLable);
            this.Controls.Add(this.labelCourseID);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "AddCourse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddCourse";
            this.Load += new System.EventHandler(this.AddCourse_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCourseID;
        private System.Windows.Forms.Label labelLable;
        private System.Windows.Forms.Label labelPeriod;
        private System.Windows.Forms.Label labelDecription;
        private System.Windows.Forms.TextBox textBoxCourseID;
        private System.Windows.Forms.TextBox textBoxLable;
        private System.Windows.Forms.TextBox textBoxPeriod;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.Button buttonAddCourse;
        private System.Windows.Forms.ComboBox comboBoxSemester;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBoxTeacherID;
        private System.Windows.Forms.Label label6;
    }
}