
namespace AddStudent
{
    partial class AddScoreForm
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
            this.labelDescription = new System.Windows.Forms.Label();
            this.labelScore = new System.Windows.Forms.Label();
            this.labelSelectCourse = new System.Windows.Forms.Label();
            this.labelStudentID = new System.Windows.Forms.Label();
            this.textBoxDesciption = new System.Windows.Forms.TextBox();
            this.textBoxStID = new System.Windows.Forms.TextBox();
            this.comboBoxCource = new System.Windows.Forms.ComboBox();
            this.textBoxScore = new System.Windows.Forms.TextBox();
            this.buttonAddScore = new System.Windows.Forms.Button();
            this.dataGridViewScore = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewScore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescription.ForeColor = System.Drawing.Color.White;
            this.labelDescription.Location = new System.Drawing.Point(50, 211);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(120, 25);
            this.labelDescription.TabIndex = 16;
            this.labelDescription.Text = "Desciption:";
            // 
            // labelScore
            // 
            this.labelScore.AutoSize = true;
            this.labelScore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelScore.ForeColor = System.Drawing.Color.White;
            this.labelScore.Location = new System.Drawing.Point(94, 172);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(76, 25);
            this.labelScore.TabIndex = 15;
            this.labelScore.Text = "Score:";
            // 
            // labelSelectCourse
            // 
            this.labelSelectCourse.AutoSize = true;
            this.labelSelectCourse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelSelectCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSelectCourse.ForeColor = System.Drawing.Color.White;
            this.labelSelectCourse.Location = new System.Drawing.Point(14, 135);
            this.labelSelectCourse.Name = "labelSelectCourse";
            this.labelSelectCourse.Size = new System.Drawing.Size(156, 25);
            this.labelSelectCourse.TabIndex = 14;
            this.labelSelectCourse.Text = "Select Course:";
            // 
            // labelStudentID
            // 
            this.labelStudentID.AutoSize = true;
            this.labelStudentID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelStudentID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStudentID.ForeColor = System.Drawing.Color.White;
            this.labelStudentID.Location = new System.Drawing.Point(49, 100);
            this.labelStudentID.Name = "labelStudentID";
            this.labelStudentID.Size = new System.Drawing.Size(121, 25);
            this.labelStudentID.TabIndex = 13;
            this.labelStudentID.Text = "Student ID:";
            // 
            // textBoxDesciption
            // 
            this.textBoxDesciption.Location = new System.Drawing.Point(184, 215);
            this.textBoxDesciption.Multiline = true;
            this.textBoxDesciption.Name = "textBoxDesciption";
            this.textBoxDesciption.Size = new System.Drawing.Size(200, 126);
            this.textBoxDesciption.TabIndex = 12;
            // 
            // textBoxStID
            // 
            this.textBoxStID.Location = new System.Drawing.Point(184, 100);
            this.textBoxStID.Name = "textBoxStID";
            this.textBoxStID.Size = new System.Drawing.Size(200, 22);
            this.textBoxStID.TabIndex = 10;
            // 
            // comboBoxCource
            // 
            this.comboBoxCource.FormattingEnabled = true;
            this.comboBoxCource.Location = new System.Drawing.Point(184, 135);
            this.comboBoxCource.Name = "comboBoxCource";
            this.comboBoxCource.Size = new System.Drawing.Size(121, 24);
            this.comboBoxCource.TabIndex = 9;
            // 
            // textBoxScore
            // 
            this.textBoxScore.Location = new System.Drawing.Point(184, 175);
            this.textBoxScore.Name = "textBoxScore";
            this.textBoxScore.Size = new System.Drawing.Size(200, 22);
            this.textBoxScore.TabIndex = 17;
            // 
            // buttonAddScore
            // 
            this.buttonAddScore.BackColor = System.Drawing.Color.Lime;
            this.buttonAddScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddScore.Location = new System.Drawing.Point(184, 379);
            this.buttonAddScore.Name = "buttonAddScore";
            this.buttonAddScore.Size = new System.Drawing.Size(130, 37);
            this.buttonAddScore.TabIndex = 18;
            this.buttonAddScore.Text = "Add";
            this.buttonAddScore.UseVisualStyleBackColor = false;
            this.buttonAddScore.Click += new System.EventHandler(this.buttonAddScore_Click);
            // 
            // dataGridViewScore
            // 
            this.dataGridViewScore.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewScore.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewScore.Location = new System.Drawing.Point(426, 100);
            this.dataGridViewScore.Name = "dataGridViewScore";
            this.dataGridViewScore.RowHeadersWidth = 51;
            this.dataGridViewScore.RowTemplate.Height = 24;
            this.dataGridViewScore.Size = new System.Drawing.Size(422, 333);
            this.dataGridViewScore.TabIndex = 19;
            this.dataGridViewScore.Click += new System.EventHandler(this.dataGridViewScore_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AddStudent.Properties.Resources.bandicam_2021_05_16_23_48_09_4631;
            this.pictureBox1.Location = new System.Drawing.Point(252, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(62, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(338, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(310, 44);
            this.label1.TabIndex = 35;
            this.label1.Text = "Add Score Form";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(870, 66);
            this.panel1.TabIndex = 36;
            // 
            // AddScoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(868, 463);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridViewScore);
            this.Controls.Add(this.buttonAddScore);
            this.Controls.Add(this.textBoxScore);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.labelScore);
            this.Controls.Add(this.labelSelectCourse);
            this.Controls.Add(this.labelStudentID);
            this.Controls.Add(this.textBoxDesciption);
            this.Controls.Add(this.textBoxStID);
            this.Controls.Add(this.comboBoxCource);
            this.Name = "AddScoreForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddScoreForm";
            this.Load += new System.EventHandler(this.AddScoreForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewScore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Label labelScore;
        private System.Windows.Forms.Label labelSelectCourse;
        private System.Windows.Forms.Label labelStudentID;
        private System.Windows.Forms.TextBox textBoxDesciption;
        private System.Windows.Forms.TextBox textBoxStID;
        private System.Windows.Forms.ComboBox comboBoxCource;
        private System.Windows.Forms.TextBox textBoxScore;
        private System.Windows.Forms.Button buttonAddScore;
        private System.Windows.Forms.DataGridView dataGridViewScore;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
    }
}