
namespace AddStudent
{
    partial class EditCourse
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditCourse));
            this.comboBoxCource = new System.Windows.Forms.ComboBox();
            this.textBoxLable = new System.Windows.Forms.TextBox();
            this.numericUpDownHours = new System.Windows.Forms.NumericUpDown();
            this.textBoxDesciption = new System.Windows.Forms.TextBox();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.labelSelectID = new System.Windows.Forms.Label();
            this.labelLable = new System.Windows.Forms.Label();
            this.labelPeriod = new System.Windows.Forms.Label();
            this.labelDescription = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxSemester = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBoxTeacherID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHours)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxCource
            // 
            this.comboBoxCource.FormattingEnabled = true;
            this.comboBoxCource.Location = new System.Drawing.Point(208, 111);
            this.comboBoxCource.Name = "comboBoxCource";
            this.comboBoxCource.Size = new System.Drawing.Size(121, 24);
            this.comboBoxCource.TabIndex = 0;
            this.comboBoxCource.SelectedIndexChanged += new System.EventHandler(this.comboBoxCource_SelectedIndexChanged);
            // 
            // textBoxLable
            // 
            this.textBoxLable.Location = new System.Drawing.Point(208, 151);
            this.textBoxLable.Name = "textBoxLable";
            this.textBoxLable.Size = new System.Drawing.Size(185, 22);
            this.textBoxLable.TabIndex = 1;
            // 
            // numericUpDownHours
            // 
            this.numericUpDownHours.Location = new System.Drawing.Point(208, 189);
            this.numericUpDownHours.Name = "numericUpDownHours";
            this.numericUpDownHours.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownHours.TabIndex = 2;
            // 
            // textBoxDesciption
            // 
            this.textBoxDesciption.Location = new System.Drawing.Point(208, 233);
            this.textBoxDesciption.Multiline = true;
            this.textBoxDesciption.Name = "textBoxDesciption";
            this.textBoxDesciption.Size = new System.Drawing.Size(198, 85);
            this.textBoxDesciption.TabIndex = 3;
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEdit.Image = global::AddStudent.Properties.Resources.Edit_icon__the_Noun_Project_30184_1;
            this.buttonEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonEdit.Location = new System.Drawing.Point(159, 421);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(120, 38);
            this.buttonEdit.TabIndex = 4;
            this.buttonEdit.Text = "   Edit";
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // labelSelectID
            // 
            this.labelSelectID.AutoSize = true;
            this.labelSelectID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSelectID.ForeColor = System.Drawing.Color.White;
            this.labelSelectID.Image = ((System.Drawing.Image)(resources.GetObject("labelSelectID.Image")));
            this.labelSelectID.Location = new System.Drawing.Point(33, 107);
            this.labelSelectID.Name = "labelSelectID";
            this.labelSelectID.Size = new System.Drawing.Size(156, 25);
            this.labelSelectID.TabIndex = 5;
            this.labelSelectID.Text = "Select Course:";
            // 
            // labelLable
            // 
            this.labelLable.AutoSize = true;
            this.labelLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLable.ForeColor = System.Drawing.Color.White;
            this.labelLable.Image = ((System.Drawing.Image)(resources.GetObject("labelLable.Image")));
            this.labelLable.Location = new System.Drawing.Point(117, 147);
            this.labelLable.Name = "labelLable";
            this.labelLable.Size = new System.Drawing.Size(72, 25);
            this.labelLable.TabIndex = 6;
            this.labelLable.Text = "Lable:";
            // 
            // labelPeriod
            // 
            this.labelPeriod.AutoSize = true;
            this.labelPeriod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPeriod.ForeColor = System.Drawing.Color.White;
            this.labelPeriod.Image = ((System.Drawing.Image)(resources.GetObject("labelPeriod.Image")));
            this.labelPeriod.Location = new System.Drawing.Point(108, 189);
            this.labelPeriod.Name = "labelPeriod";
            this.labelPeriod.Size = new System.Drawing.Size(81, 25);
            this.labelPeriod.TabIndex = 7;
            this.labelPeriod.Text = "Period:";
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescription.ForeColor = System.Drawing.Color.White;
            this.labelDescription.Image = ((System.Drawing.Image)(resources.GetObject("labelDescription.Image")));
            this.labelDescription.Location = new System.Drawing.Point(72, 229);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(120, 25);
            this.labelDescription.TabIndex = 8;
            this.labelDescription.Text = "Desciption:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(89, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(361, 73);
            this.panel1.TabIndex = 37;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(34, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(289, 38);
            this.label4.TabIndex = 36;
            this.label4.Text = "Edit Course Form";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.AliceBlue;
            this.pictureBox1.Image = global::AddStudent.Properties.Resources.icono_capacitacion_png_7;
            this.pictureBox1.Location = new System.Drawing.Point(10, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 73);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 36;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(81, 331);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 25);
            this.label1.TabIndex = 39;
            this.label1.Text = "Semester:";
            // 
            // comboBoxSemester
            // 
            this.comboBoxSemester.FormattingEnabled = true;
            this.comboBoxSemester.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.comboBoxSemester.Location = new System.Drawing.Point(208, 331);
            this.comboBoxSemester.Name = "comboBoxSemester";
            this.comboBoxSemester.Size = new System.Drawing.Size(101, 24);
            this.comboBoxSemester.TabIndex = 38;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel2.Location = new System.Drawing.Point(1, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 73);
            this.panel2.TabIndex = 40;
            // 
            // textBoxTeacherID
            // 
            this.textBoxTeacherID.Location = new System.Drawing.Point(207, 372);
            this.textBoxTeacherID.Name = "textBoxTeacherID";
            this.textBoxTeacherID.Size = new System.Drawing.Size(186, 22);
            this.textBoxTeacherID.TabIndex = 45;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Image = global::AddStudent.Properties.Resources.e3982cc208873792337b423d9e7714b310;
            this.label6.Location = new System.Drawing.Point(66, 369);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 25);
            this.label6.TabIndex = 44;
            this.label6.Text = "Teacher ID:";
            // 
            // EditCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.BackgroundImage = global::AddStudent.Properties.Resources.e3982cc208873792337b423d9e7714b32;
            this.ClientSize = new System.Drawing.Size(448, 480);
            this.Controls.Add(this.textBoxTeacherID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxSemester);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.labelPeriod);
            this.Controls.Add(this.labelLable);
            this.Controls.Add(this.labelSelectID);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.textBoxDesciption);
            this.Controls.Add(this.numericUpDownHours);
            this.Controls.Add(this.textBoxLable);
            this.Controls.Add(this.comboBoxCource);
            this.Name = "EditCourse";
            this.Text = "EditCourse";
            this.Load += new System.EventHandler(this.EditCourse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHours)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxCource;
        private System.Windows.Forms.TextBox textBoxLable;
        private System.Windows.Forms.NumericUpDown numericUpDownHours;
        private System.Windows.Forms.TextBox textBoxDesciption;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Label labelSelectID;
        private System.Windows.Forms.Label labelLable;
        private System.Windows.Forms.Label labelPeriod;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxSemester;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBoxTeacherID;
        private System.Windows.Forms.Label label6;
    }
}