
namespace AddStudent
{
    partial class AddSv
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddSv));
            this.textBoxSudentID = new System.Windows.Forms.TextBox();
            this.textBoxFName = new System.Windows.Forms.TextBox();
            this.textBoxLName = new System.Windows.Forms.TextBox();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.pictureBoxStudent = new System.Windows.Forms.PictureBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.Male = new System.Windows.Forms.RadioButton();
            this.Female = new System.Windows.Forms.RadioButton();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonUpImage = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelPicture = new System.Windows.Forms.Label();
            this.labelAddress = new System.Windows.Forms.Label();
            this.labelPhone = new System.Windows.Forms.Label();
            this.labelGender = new System.Windows.Forms.Label();
            this.labelBDate = new System.Windows.Forms.Label();
            this.labelLName = new System.Windows.Forms.Label();
            this.labelFName = new System.Windows.Forms.Label();
            this.labelStudentID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStudent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxSudentID
            // 
            this.textBoxSudentID.Location = new System.Drawing.Point(236, 101);
            this.textBoxSudentID.Name = "textBoxSudentID";
            this.textBoxSudentID.Size = new System.Drawing.Size(245, 22);
            this.textBoxSudentID.TabIndex = 8;
            // 
            // textBoxFName
            // 
            this.textBoxFName.Location = new System.Drawing.Point(236, 138);
            this.textBoxFName.Name = "textBoxFName";
            this.textBoxFName.Size = new System.Drawing.Size(245, 22);
            this.textBoxFName.TabIndex = 9;
            // 
            // textBoxLName
            // 
            this.textBoxLName.Location = new System.Drawing.Point(236, 175);
            this.textBoxLName.Name = "textBoxLName";
            this.textBoxLName.Size = new System.Drawing.Size(245, 22);
            this.textBoxLName.TabIndex = 10;
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Location = new System.Drawing.Point(236, 280);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(245, 22);
            this.textBoxPhone.TabIndex = 11;
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Location = new System.Drawing.Point(236, 319);
            this.textBoxAddress.Multiline = true;
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(245, 81);
            this.textBoxAddress.TabIndex = 12;
            // 
            // pictureBoxStudent
            // 
            this.pictureBoxStudent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.pictureBoxStudent.Location = new System.Drawing.Point(276, 406);
            this.pictureBoxStudent.Name = "pictureBoxStudent";
            this.pictureBoxStudent.Size = new System.Drawing.Size(169, 123);
            this.pictureBoxStudent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxStudent.TabIndex = 13;
            this.pictureBoxStudent.TabStop = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(236, 211);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(245, 22);
            this.dateTimePicker1.TabIndex = 14;
            // 
            // Male
            // 
            this.Male.AutoSize = true;
            this.Male.Checked = true;
            this.Male.Location = new System.Drawing.Point(260, 247);
            this.Male.Name = "Male";
            this.Male.Size = new System.Drawing.Size(59, 21);
            this.Male.TabIndex = 15;
            this.Male.TabStop = true;
            this.Male.Text = "Male";
            this.Male.UseVisualStyleBackColor = true;
            // 
            // Female
            // 
            this.Female.AutoSize = true;
            this.Female.Location = new System.Drawing.Point(350, 247);
            this.Female.Name = "Female";
            this.Female.Size = new System.Drawing.Size(75, 21);
            this.Female.TabIndex = 16;
            this.Female.Text = "Female";
            this.Female.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.Red;
            this.buttonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancel.Location = new System.Drawing.Point(483, 551);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(98, 34);
            this.buttonCancel.TabIndex = 17;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.ForestGreen;
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.Location = new System.Drawing.Point(151, 551);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(98, 34);
            this.buttonAdd.TabIndex = 18;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonUpImage
            // 
            this.buttonUpImage.BackColor = System.Drawing.Color.Yellow;
            this.buttonUpImage.Location = new System.Drawing.Point(294, 535);
            this.buttonUpImage.Name = "buttonUpImage";
            this.buttonUpImage.Size = new System.Drawing.Size(129, 38);
            this.buttonUpImage.TabIndex = 19;
            this.buttonUpImage.Text = "Up Image";
            this.buttonUpImage.UseVisualStyleBackColor = false;
            this.buttonUpImage.Click += new System.EventHandler(this.buttonUpImage_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Image = global::AddStudent.Properties.Resources.bandicam_2021_05_16_14_45_05_670;
            this.label1.Location = new System.Drawing.Point(158, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(297, 38);
            this.label1.TabIndex = 34;
            this.label1.Text = "Add Student Form";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(94, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(515, 77);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 33;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(96, 77);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.labelPicture);
            this.panel1.Controls.Add(this.labelAddress);
            this.panel1.Controls.Add(this.labelPhone);
            this.panel1.Controls.Add(this.labelGender);
            this.panel1.Controls.Add(this.labelBDate);
            this.panel1.Controls.Add(this.labelLName);
            this.panel1.Controls.Add(this.labelFName);
            this.panel1.Controls.Add(this.labelStudentID);
            this.panel1.Location = new System.Drawing.Point(0, 78);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(135, 518);
            this.panel1.TabIndex = 35;
            // 
            // labelPicture
            // 
            this.labelPicture.AutoSize = true;
            this.labelPicture.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPicture.Location = new System.Drawing.Point(39, 328);
            this.labelPicture.Name = "labelPicture";
            this.labelPicture.Size = new System.Drawing.Size(75, 20);
            this.labelPicture.TabIndex = 15;
            this.labelPicture.Text = "Picture:";
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddress.Location = new System.Drawing.Point(30, 233);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(84, 20);
            this.labelAddress.TabIndex = 14;
            this.labelAddress.Text = "Address:";
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPhone.Location = new System.Drawing.Point(47, 202);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(67, 20);
            this.labelPhone.TabIndex = 13;
            this.labelPhone.Text = "Phone:";
            // 
            // labelGender
            // 
            this.labelGender.AutoSize = true;
            this.labelGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGender.Location = new System.Drawing.Point(40, 168);
            this.labelGender.Name = "labelGender";
            this.labelGender.Size = new System.Drawing.Size(76, 20);
            this.labelGender.TabIndex = 12;
            this.labelGender.Text = "Gender:";
            // 
            // labelBDate
            // 
            this.labelBDate.AutoSize = true;
            this.labelBDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBDate.Location = new System.Drawing.Point(18, 133);
            this.labelBDate.Name = "labelBDate";
            this.labelBDate.Size = new System.Drawing.Size(96, 20);
            this.labelBDate.TabIndex = 11;
            this.labelBDate.Text = "BirthDate:";
            // 
            // labelLName
            // 
            this.labelLName.AutoSize = true;
            this.labelLName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLName.Location = new System.Drawing.Point(10, 97);
            this.labelLName.Name = "labelLName";
            this.labelLName.Size = new System.Drawing.Size(106, 20);
            this.labelLName.TabIndex = 10;
            this.labelLName.Text = "Last Name:";
            // 
            // labelFName
            // 
            this.labelFName.AutoSize = true;
            this.labelFName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFName.Location = new System.Drawing.Point(8, 60);
            this.labelFName.Name = "labelFName";
            this.labelFName.Size = new System.Drawing.Size(108, 20);
            this.labelFName.TabIndex = 9;
            this.labelFName.Text = "First Name:";
            // 
            // labelStudentID
            // 
            this.labelStudentID.AutoSize = true;
            this.labelStudentID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStudentID.Location = new System.Drawing.Point(12, 23);
            this.labelStudentID.Name = "labelStudentID";
            this.labelStudentID.Size = new System.Drawing.Size(104, 20);
            this.labelStudentID.TabIndex = 8;
            this.labelStudentID.Text = "Student ID:";
            // 
            // AddSv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(593, 597);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonUpImage);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.Female);
            this.Controls.Add(this.Male);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.pictureBoxStudent);
            this.Controls.Add(this.textBoxAddress);
            this.Controls.Add(this.textBoxPhone);
            this.Controls.Add(this.textBoxLName);
            this.Controls.Add(this.textBoxFName);
            this.Controls.Add(this.textBoxSudentID);
            this.Name = "AddSv";
            this.Text = "AddStudent";
            this.Load += new System.EventHandler(this.AddSv_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStudent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxSudentID;
        private System.Windows.Forms.TextBox textBoxFName;
        private System.Windows.Forms.TextBox textBoxLName;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.PictureBox pictureBoxStudent;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.RadioButton Male;
        private System.Windows.Forms.RadioButton Female;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonUpImage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelPicture;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.Label labelGender;
        private System.Windows.Forms.Label labelBDate;
        private System.Windows.Forms.Label labelLName;
        private System.Windows.Forms.Label labelFName;
        private System.Windows.Forms.Label labelStudentID;
    }
}