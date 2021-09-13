
namespace AddStudent
{
    partial class ResultScoreForm
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
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.labelSub = new System.Windows.Forms.Label();
            this.textBoxLName = new System.Windows.Forms.TextBox();
            this.textBoxFName = new System.Windows.Forms.TextBox();
            this.textBoxSudentID = new System.Windows.Forms.TextBox();
            this.labelLName = new System.Windows.Forms.Label();
            this.labelFName = new System.Windows.Forms.Label();
            this.labelStudentID = new System.Windows.Forms.Label();
            this.labelSearch = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.dataGridViewScore = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.panelBore3 = new System.Windows.Forms.Panel();
            this.panelBore1 = new System.Windows.Forms.Panel();
            this.panelBore2 = new System.Windows.Forms.Panel();
            this.panelBore4 = new System.Windows.Forms.Panel();
            this.panelBore5 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewScore)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(158, 392);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(141, 22);
            this.textBoxSearch.TabIndex = 1;
            // 
            // labelSub
            // 
            this.labelSub.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSub.Location = new System.Drawing.Point(842, 86);
            this.labelSub.Name = "labelSub";
            this.labelSub.Size = new System.Drawing.Size(268, 45);
            this.labelSub.TabIndex = 3;
            this.labelSub.Text = "Student Result";
            this.labelSub.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxLName
            // 
            this.textBoxLName.Location = new System.Drawing.Point(158, 283);
            this.textBoxLName.Name = "textBoxLName";
            this.textBoxLName.Size = new System.Drawing.Size(141, 22);
            this.textBoxLName.TabIndex = 16;
            // 
            // textBoxFName
            // 
            this.textBoxFName.Location = new System.Drawing.Point(158, 228);
            this.textBoxFName.Name = "textBoxFName";
            this.textBoxFName.Size = new System.Drawing.Size(141, 22);
            this.textBoxFName.TabIndex = 15;
            // 
            // textBoxSudentID
            // 
            this.textBoxSudentID.Location = new System.Drawing.Point(158, 169);
            this.textBoxSudentID.Name = "textBoxSudentID";
            this.textBoxSudentID.Size = new System.Drawing.Size(141, 22);
            this.textBoxSudentID.TabIndex = 14;
            // 
            // labelLName
            // 
            this.labelLName.AutoSize = true;
            this.labelLName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLName.Location = new System.Drawing.Point(21, 283);
            this.labelLName.Name = "labelLName";
            this.labelLName.Size = new System.Drawing.Size(106, 20);
            this.labelLName.TabIndex = 13;
            this.labelLName.Text = "Last Name:";
            // 
            // labelFName
            // 
            this.labelFName.AutoSize = true;
            this.labelFName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFName.Location = new System.Drawing.Point(20, 225);
            this.labelFName.Name = "labelFName";
            this.labelFName.Size = new System.Drawing.Size(108, 20);
            this.labelFName.TabIndex = 12;
            this.labelFName.Text = "First Name:";
            // 
            // labelStudentID
            // 
            this.labelStudentID.AutoSize = true;
            this.labelStudentID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStudentID.Location = new System.Drawing.Point(23, 169);
            this.labelStudentID.Name = "labelStudentID";
            this.labelStudentID.Size = new System.Drawing.Size(104, 20);
            this.labelStudentID.TabIndex = 11;
            this.labelStudentID.Text = "Student ID:";
            // 
            // labelSearch
            // 
            this.labelSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSearch.Location = new System.Drawing.Point(20, 337);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(338, 25);
            this.labelSearch.TabIndex = 17;
            this.labelSearch.Text = "Search By ID, FName, LName:";
            // 
            // dataGridViewScore
            // 
            this.dataGridViewScore.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewScore.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewScore.Location = new System.Drawing.Point(355, 135);
            this.dataGridViewScore.Name = "dataGridViewScore";
            this.dataGridViewScore.RowHeadersWidth = 51;
            this.dataGridViewScore.RowTemplate.Height = 24;
            this.dataGridViewScore.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewScore.Size = new System.Drawing.Size(1128, 405);
            this.dataGridViewScore.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(23, 451);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(263, 25);
            this.label9.TabIndex = 30;
            this.label9.Text = "Nguyễn Thái Hải - 19110356";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1509, 66);
            this.panel1.TabIndex = 39;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AddStudent.Properties.Resources.bandicam_2021_05_16_23_48_09_4631;
            this.pictureBox1.Location = new System.Drawing.Point(531, 3);
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
            this.label1.Location = new System.Drawing.Point(617, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(354, 44);
            this.label1.TabIndex = 35;
            this.label1.Text = "Result Score Form";
            // 
            // buttonSearch
            // 
            this.buttonSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearch.Image = global::AddStudent.Properties.Resources.search_icon_vector_editable_eps10_260nw_12639249914;
            this.buttonSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSearch.Location = new System.Drawing.Point(28, 385);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(124, 35);
            this.buttonSearch.TabIndex = 2;
            this.buttonSearch.Text = "   Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.button1_Click);
            // 
            // panelBore3
            // 
            this.panelBore3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.panelBore3.Location = new System.Drawing.Point(328, 67);
            this.panelBore3.Name = "panelBore3";
            this.panelBore3.Size = new System.Drawing.Size(12, 505);
            this.panelBore3.TabIndex = 40;
            // 
            // panelBore1
            // 
            this.panelBore1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.panelBore1.Location = new System.Drawing.Point(1, 67);
            this.panelBore1.Name = "panelBore1";
            this.panelBore1.Size = new System.Drawing.Size(12, 505);
            this.panelBore1.TabIndex = 41;
            // 
            // panelBore2
            // 
            this.panelBore2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.panelBore2.Location = new System.Drawing.Point(12, 67);
            this.panelBore2.Name = "panelBore2";
            this.panelBore2.Size = new System.Drawing.Size(1490, 14);
            this.panelBore2.TabIndex = 42;
            // 
            // panelBore4
            // 
            this.panelBore4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.panelBore4.Location = new System.Drawing.Point(12, 560);
            this.panelBore4.Name = "panelBore4";
            this.panelBore4.Size = new System.Drawing.Size(1490, 11);
            this.panelBore4.TabIndex = 43;
            // 
            // panelBore5
            // 
            this.panelBore5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.panelBore5.Location = new System.Drawing.Point(1498, 67);
            this.panelBore5.Name = "panelBore5";
            this.panelBore5.Size = new System.Drawing.Size(12, 505);
            this.panelBore5.TabIndex = 44;
            // 
            // ResultScoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1511, 571);
            this.Controls.Add(this.panelBore5);
            this.Controls.Add(this.panelBore4);
            this.Controls.Add(this.panelBore2);
            this.Controls.Add(this.panelBore1);
            this.Controls.Add(this.panelBore3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dataGridViewScore);
            this.Controls.Add(this.labelSearch);
            this.Controls.Add(this.textBoxLName);
            this.Controls.Add(this.textBoxFName);
            this.Controls.Add(this.textBoxSudentID);
            this.Controls.Add(this.labelLName);
            this.Controls.Add(this.labelFName);
            this.Controls.Add(this.labelStudentID);
            this.Controls.Add(this.labelSub);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.textBoxSearch);
            this.Name = "ResultScoreForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ResultScoreForm";
            this.Load += new System.EventHandler(this.ResultScoreForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewScore)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Label labelSub;
        private System.Windows.Forms.TextBox textBoxLName;
        private System.Windows.Forms.TextBox textBoxFName;
        private System.Windows.Forms.TextBox textBoxSudentID;
        private System.Windows.Forms.Label labelLName;
        private System.Windows.Forms.Label labelFName;
        private System.Windows.Forms.Label labelStudentID;
        private System.Windows.Forms.Label labelSearch;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridView dataGridViewScore;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelBore3;
        private System.Windows.Forms.Panel panelBore1;
        private System.Windows.Forms.Panel panelBore2;
        private System.Windows.Forms.Panel panelBore4;
        private System.Windows.Forms.Panel panelBore5;
    }
}