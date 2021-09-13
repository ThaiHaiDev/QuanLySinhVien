
namespace AddStudent
{
    partial class CourseStdList
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
            this.buttonPrint = new System.Windows.Forms.Button();
            this.dataGridViewStdList = new System.Windows.Forms.DataGridView();
            this.textBoxCourse = new System.Windows.Forms.TextBox();
            this.labelSemester = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStdList)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonPrint
            // 
            this.buttonPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(168)))), ((int)(((byte)(1)))));
            this.buttonPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPrint.Image = global::AddStudent.Properties.Resources.print2;
            this.buttonPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonPrint.Location = new System.Drawing.Point(327, 450);
            this.buttonPrint.Name = "buttonPrint";
            this.buttonPrint.Size = new System.Drawing.Size(146, 46);
            this.buttonPrint.TabIndex = 9;
            this.buttonPrint.Text = "    Print";
            this.buttonPrint.UseVisualStyleBackColor = false;
            this.buttonPrint.Click += new System.EventHandler(this.buttonPrint_Click);
            // 
            // dataGridViewStdList
            // 
            this.dataGridViewStdList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewStdList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStdList.Location = new System.Drawing.Point(24, 160);
            this.dataGridViewStdList.Name = "dataGridViewStdList";
            this.dataGridViewStdList.RowHeadersWidth = 51;
            this.dataGridViewStdList.RowTemplate.Height = 24;
            this.dataGridViewStdList.Size = new System.Drawing.Size(806, 262);
            this.dataGridViewStdList.TabIndex = 8;
            // 
            // textBoxCourse
            // 
            this.textBoxCourse.Enabled = false;
            this.textBoxCourse.Location = new System.Drawing.Point(187, 111);
            this.textBoxCourse.Name = "textBoxCourse";
            this.textBoxCourse.Size = new System.Drawing.Size(130, 22);
            this.textBoxCourse.TabIndex = 7;
            // 
            // labelSemester
            // 
            this.labelSemester.AutoSize = true;
            this.labelSemester.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSemester.Image = global::AddStudent.Properties.Resources.e3982cc208873792337b423d9e7714b310;
            this.labelSemester.Location = new System.Drawing.Point(402, 111);
            this.labelSemester.Name = "labelSemester";
            this.labelSemester.Size = new System.Drawing.Size(95, 20);
            this.labelSemester.TabIndex = 6;
            this.labelSemester.Text = "Semester:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Image = global::AddStudent.Properties.Resources.e3982cc208873792337b423d9e7714b310;
            this.label1.Location = new System.Drawing.Point(40, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Course Name:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel2.Location = new System.Drawing.Point(1, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 73);
            this.panel2.TabIndex = 47;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(91, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(765, 73);
            this.panel1.TabIndex = 46;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(159, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(402, 44);
            this.label4.TabIndex = 36;
            this.label4.Text = "Course Student Form";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.AliceBlue;
            this.pictureBox1.Image = global::AddStudent.Properties.Resources.icono_capacitacion_png_7;
            this.pictureBox1.Location = new System.Drawing.Point(11, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 73);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 45;
            this.pictureBox1.TabStop = false;
            // 
            // CourseStdList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AddStudent.Properties.Resources.e3982cc208873792337b423d9e7714b310;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(856, 523);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonPrint);
            this.Controls.Add(this.dataGridViewStdList);
            this.Controls.Add(this.textBoxCourse);
            this.Controls.Add(this.labelSemester);
            this.Controls.Add(this.label1);
            this.Name = "CourseStdList";
            this.Text = "CourseStdList";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStdList)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonPrint;
        private System.Windows.Forms.DataGridView dataGridViewStdList;
        private System.Windows.Forms.TextBox textBoxCourse;
        private System.Windows.Forms.Label labelSemester;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}