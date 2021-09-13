
namespace AddStudent
{
    partial class PrintScoreForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxCourse = new System.Windows.Forms.ListBox();
            this.dataGridViewStudentScore = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewStudent = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonPrint = new System.Windows.Forms.Button();
            this.buttonToFile = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudentScore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudent)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Lime;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(22, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Courses List";
            // 
            // listBoxCourse
            // 
            this.listBoxCourse.BackColor = System.Drawing.Color.White;
            this.listBoxCourse.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxCourse.ForeColor = System.Drawing.Color.Black;
            this.listBoxCourse.FormattingEnabled = true;
            this.listBoxCourse.ItemHeight = 22;
            this.listBoxCourse.Location = new System.Drawing.Point(26, 149);
            this.listBoxCourse.Name = "listBoxCourse";
            this.listBoxCourse.Size = new System.Drawing.Size(148, 224);
            this.listBoxCourse.TabIndex = 1;
            this.listBoxCourse.Click += new System.EventHandler(this.listBoxCourse_Click);
            // 
            // dataGridViewStudentScore
            // 
            this.dataGridViewStudentScore.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewStudentScore.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewStudentScore.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStudentScore.Location = new System.Drawing.Point(180, 149);
            this.dataGridViewStudentScore.Name = "dataGridViewStudentScore";
            this.dataGridViewStudentScore.RowHeadersWidth = 51;
            this.dataGridViewStudentScore.RowTemplate.Height = 24;
            this.dataGridViewStudentScore.Size = new System.Drawing.Size(723, 224);
            this.dataGridViewStudentScore.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Lime;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(185, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 27);
            this.label2.TabIndex = 33;
            this.label2.Text = "Scores List";
            // 
            // dataGridViewStudent
            // 
            this.dataGridViewStudent.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewStudent.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStudent.Location = new System.Drawing.Point(909, 149);
            this.dataGridViewStudent.Name = "dataGridViewStudent";
            this.dataGridViewStudent.RowHeadersWidth = 51;
            this.dataGridViewStudent.RowTemplate.Height = 24;
            this.dataGridViewStudent.Size = new System.Drawing.Size(437, 224);
            this.dataGridViewStudent.TabIndex = 34;
            this.dataGridViewStudent.Click += new System.EventHandler(this.dataGridViewStudent_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Lime;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(905, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 27);
            this.label3.TabIndex = 35;
            this.label3.Text = "Students List";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1371, 66);
            this.panel1.TabIndex = 65;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AddStudent.Properties.Resources.bandicam_2021_05_16_23_48_09_4631;
            this.pictureBox1.Location = new System.Drawing.Point(492, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(62, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(578, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(324, 44);
            this.label4.TabIndex = 35;
            this.label4.Text = "Print Score Form";
            // 
            // buttonPrint
            // 
            this.buttonPrint.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.buttonPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPrint.Location = new System.Drawing.Point(673, 420);
            this.buttonPrint.Name = "buttonPrint";
            this.buttonPrint.Size = new System.Drawing.Size(158, 42);
            this.buttonPrint.TabIndex = 67;
            this.buttonPrint.Text = "Print";
            this.buttonPrint.UseVisualStyleBackColor = false;
            this.buttonPrint.Click += new System.EventHandler(this.buttonPrint_Click);
            // 
            // buttonToFile
            // 
            this.buttonToFile.BackColor = System.Drawing.Color.Blue;
            this.buttonToFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonToFile.ForeColor = System.Drawing.Color.White;
            this.buttonToFile.Image = global::AddStudent.Properties.Resources.Button_software_update_icon;
            this.buttonToFile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonToFile.Location = new System.Drawing.Point(493, 420);
            this.buttonToFile.Name = "buttonToFile";
            this.buttonToFile.Size = new System.Drawing.Size(160, 42);
            this.buttonToFile.TabIndex = 66;
            this.buttonToFile.Text = "   To File";
            this.buttonToFile.UseVisualStyleBackColor = false;
            this.buttonToFile.Click += new System.EventHandler(this.buttonToFile_Click);
            // 
            // PrintScoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lime;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1372, 493);
            this.Controls.Add(this.buttonPrint);
            this.Controls.Add(this.buttonToFile);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridViewStudent);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridViewStudentScore);
            this.Controls.Add(this.listBoxCourse);
            this.Controls.Add(this.label1);
            this.Name = "PrintScoreForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PrintScoresForm";
            this.Load += new System.EventHandler(this.PrintScoreForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudentScore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudent)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxCourse;
        private System.Windows.Forms.DataGridView dataGridViewStudentScore;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridViewStudent;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonPrint;
        private System.Windows.Forms.Button buttonToFile;
    }
}