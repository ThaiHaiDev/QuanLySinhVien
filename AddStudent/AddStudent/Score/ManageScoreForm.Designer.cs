
namespace AddStudent
{
    partial class ManageScoreForm
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
            this.dataGridViewScore = new System.Windows.Forms.DataGridView();
            this.textBoxScore = new System.Windows.Forms.TextBox();
            this.labelDescription = new System.Windows.Forms.Label();
            this.labelScore = new System.Windows.Forms.Label();
            this.labelSelectCourse = new System.Windows.Forms.Label();
            this.labelStudentID = new System.Windows.Forms.Label();
            this.textBoxDesciption = new System.Windows.Forms.TextBox();
            this.textBoxStID = new System.Windows.Forms.TextBox();
            this.comboBoxCource = new System.Windows.Forms.ComboBox();
            this.buttonShowSt = new System.Windows.Forms.Button();
            this.buttonShowScore = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonAvg = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.buttonAddScore = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewScore)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewScore
            // 
            this.dataGridViewScore.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewScore.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewScore.Location = new System.Drawing.Point(486, 165);
            this.dataGridViewScore.Name = "dataGridViewScore";
            this.dataGridViewScore.RowHeadersWidth = 51;
            this.dataGridViewScore.RowTemplate.Height = 24;
            this.dataGridViewScore.Size = new System.Drawing.Size(664, 269);
            this.dataGridViewScore.TabIndex = 29;
            this.dataGridViewScore.Click += new System.EventHandler(this.dataGridViewScore_Click);
            this.dataGridViewScore.DoubleClick += new System.EventHandler(this.dataGridViewScore_DoubleClick);
            // 
            // textBoxScore
            // 
            this.textBoxScore.Location = new System.Drawing.Point(190, 191);
            this.textBoxScore.Name = "textBoxScore";
            this.textBoxScore.Size = new System.Drawing.Size(185, 22);
            this.textBoxScore.TabIndex = 27;
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.labelDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescription.ForeColor = System.Drawing.Color.White;
            this.labelDescription.Location = new System.Drawing.Point(56, 228);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(120, 25);
            this.labelDescription.TabIndex = 26;
            this.labelDescription.Text = "Desciption:";
            // 
            // labelScore
            // 
            this.labelScore.AutoSize = true;
            this.labelScore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.labelScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelScore.ForeColor = System.Drawing.Color.White;
            this.labelScore.Location = new System.Drawing.Point(101, 187);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(76, 25);
            this.labelScore.TabIndex = 25;
            this.labelScore.Text = "Score:";
            // 
            // labelSelectCourse
            // 
            this.labelSelectCourse.AutoSize = true;
            this.labelSelectCourse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.labelSelectCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSelectCourse.ForeColor = System.Drawing.Color.White;
            this.labelSelectCourse.Location = new System.Drawing.Point(21, 147);
            this.labelSelectCourse.Name = "labelSelectCourse";
            this.labelSelectCourse.Size = new System.Drawing.Size(156, 25);
            this.labelSelectCourse.TabIndex = 24;
            this.labelSelectCourse.Text = "Select Course:";
            // 
            // labelStudentID
            // 
            this.labelStudentID.AutoSize = true;
            this.labelStudentID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.labelStudentID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStudentID.ForeColor = System.Drawing.Color.White;
            this.labelStudentID.Location = new System.Drawing.Point(56, 101);
            this.labelStudentID.Name = "labelStudentID";
            this.labelStudentID.Size = new System.Drawing.Size(121, 25);
            this.labelStudentID.TabIndex = 23;
            this.labelStudentID.Text = "Student ID:";
            // 
            // textBoxDesciption
            // 
            this.textBoxDesciption.Location = new System.Drawing.Point(190, 228);
            this.textBoxDesciption.Multiline = true;
            this.textBoxDesciption.Name = "textBoxDesciption";
            this.textBoxDesciption.Size = new System.Drawing.Size(240, 150);
            this.textBoxDesciption.TabIndex = 22;
            // 
            // textBoxStID
            // 
            this.textBoxStID.Location = new System.Drawing.Point(190, 101);
            this.textBoxStID.Name = "textBoxStID";
            this.textBoxStID.Size = new System.Drawing.Size(185, 22);
            this.textBoxStID.TabIndex = 21;
            // 
            // comboBoxCource
            // 
            this.comboBoxCource.FormattingEnabled = true;
            this.comboBoxCource.Location = new System.Drawing.Point(190, 148);
            this.comboBoxCource.Name = "comboBoxCource";
            this.comboBoxCource.Size = new System.Drawing.Size(121, 24);
            this.comboBoxCource.TabIndex = 20;
            // 
            // buttonShowSt
            // 
            this.buttonShowSt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonShowSt.Location = new System.Drawing.Point(663, 95);
            this.buttonShowSt.Name = "buttonShowSt";
            this.buttonShowSt.Size = new System.Drawing.Size(174, 37);
            this.buttonShowSt.TabIndex = 32;
            this.buttonShowSt.Text = "Show Student";
            this.buttonShowSt.UseVisualStyleBackColor = true;
            this.buttonShowSt.Click += new System.EventHandler(this.buttonShowSt_Click);
            // 
            // buttonShowScore
            // 
            this.buttonShowScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonShowScore.Location = new System.Drawing.Point(873, 95);
            this.buttonShowScore.Name = "buttonShowScore";
            this.buttonShowScore.Size = new System.Drawing.Size(174, 37);
            this.buttonShowScore.TabIndex = 33;
            this.buttonShowScore.Text = "Show Score";
            this.buttonShowScore.UseVisualStyleBackColor = true;
            this.buttonShowScore.Click += new System.EventHandler(this.buttonShowScore_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(851, 457);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(263, 25);
            this.label9.TabIndex = 34;
            this.label9.Text = "Nguyễn Thái Hải - 19110356";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1165, 66);
            this.panel1.TabIndex = 37;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AddStudent.Properties.Resources.bandicam_2021_05_16_23_48_09_4631;
            this.pictureBox1.Location = new System.Drawing.Point(394, 3);
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
            this.label1.Location = new System.Drawing.Point(480, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(383, 44);
            this.label1.TabIndex = 35;
            this.label1.Text = "Manage Score Form";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(454, 74);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 430);
            this.panel2.TabIndex = 38;
            // 
            // buttonAvg
            // 
            this.buttonAvg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAvg.Image = global::AddStudent.Properties.Resources.Clothing_Button_icon;
            this.buttonAvg.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAvg.Location = new System.Drawing.Point(77, 451);
            this.buttonAvg.Name = "buttonAvg";
            this.buttonAvg.Size = new System.Drawing.Size(275, 37);
            this.buttonAvg.TabIndex = 31;
            this.buttonAvg.Text = "Avg Score By Course";
            this.buttonAvg.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonAvg.UseVisualStyleBackColor = true;
            this.buttonAvg.Click += new System.EventHandler(this.buttonAvg_Click);
            // 
            // buttonRemove
            // 
            this.buttonRemove.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRemove.Image = global::AddStudent.Properties.Resources.Button_Delete_icon__1_;
            this.buttonRemove.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonRemove.Location = new System.Drawing.Point(225, 397);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(150, 38);
            this.buttonRemove.TabIndex = 30;
            this.buttonRemove.Text = "Remove";
            this.buttonRemove.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // buttonAddScore
            // 
            this.buttonAddScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddScore.Image = global::AddStudent.Properties.Resources.Button_Add_icon;
            this.buttonAddScore.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAddScore.Location = new System.Drawing.Point(61, 397);
            this.buttonAddScore.Name = "buttonAddScore";
            this.buttonAddScore.Size = new System.Drawing.Size(130, 37);
            this.buttonAddScore.TabIndex = 28;
            this.buttonAddScore.Text = "Add";
            this.buttonAddScore.UseVisualStyleBackColor = true;
            this.buttonAddScore.Click += new System.EventHandler(this.buttonAddScore_Click);
            // 
            // ManageScoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1162, 509);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.buttonShowScore);
            this.Controls.Add(this.buttonShowSt);
            this.Controls.Add(this.buttonAvg);
            this.Controls.Add(this.buttonRemove);
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
            this.Name = "ManageScoreForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageScoreForm";
            this.Load += new System.EventHandler(this.ManageScoreForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewScore)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewScore;
        private System.Windows.Forms.Button buttonAddScore;
        private System.Windows.Forms.TextBox textBoxScore;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Label labelScore;
        private System.Windows.Forms.Label labelSelectCourse;
        private System.Windows.Forms.Label labelStudentID;
        private System.Windows.Forms.TextBox textBoxDesciption;
        private System.Windows.Forms.TextBox textBoxStID;
        private System.Windows.Forms.ComboBox comboBoxCource;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Button buttonAvg;
        private System.Windows.Forms.Button buttonShowSt;
        private System.Windows.Forms.Button buttonShowScore;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
    }
}