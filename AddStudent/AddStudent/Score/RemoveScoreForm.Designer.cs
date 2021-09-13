
namespace AddStudent
{
    partial class RemoveScoreForm
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
            this.label9 = new System.Windows.Forms.Label();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewScore)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewScore
            // 
            this.dataGridViewScore.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewScore.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewScore.Location = new System.Drawing.Point(28, 100);
            this.dataGridViewScore.Name = "dataGridViewScore";
            this.dataGridViewScore.RowHeadersWidth = 51;
            this.dataGridViewScore.RowTemplate.Height = 24;
            this.dataGridViewScore.Size = new System.Drawing.Size(1034, 327);
            this.dataGridViewScore.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(770, 472);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(263, 25);
            this.label9.TabIndex = 21;
            this.label9.Text = "Nguyễn Thái Hải - 19110356";
            // 
            // buttonLoad
            // 
            this.buttonLoad.BackColor = System.Drawing.Color.Cyan;
            this.buttonLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLoad.Image = global::AddStudent.Properties.Resources.button_round_end_icon;
            this.buttonLoad.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonLoad.Location = new System.Drawing.Point(356, 455);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(146, 42);
            this.buttonLoad.TabIndex = 2;
            this.buttonLoad.Text = "   Load";
            this.buttonLoad.UseVisualStyleBackColor = false;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // buttonRemove
            // 
            this.buttonRemove.BackColor = System.Drawing.Color.Red;
            this.buttonRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRemove.Image = global::AddStudent.Properties.Resources.Button_Delete_icon__1_1;
            this.buttonRemove.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonRemove.Location = new System.Drawing.Point(117, 455);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(221, 42);
            this.buttonRemove.TabIndex = 1;
            this.buttonRemove.Text = "   Remove Score";
            this.buttonRemove.UseVisualStyleBackColor = false;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1087, 66);
            this.panel1.TabIndex = 38;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AddStudent.Properties.Resources.bandicam_2021_05_16_23_48_09_4631;
            this.pictureBox1.Location = new System.Drawing.Point(359, 4);
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
            this.label1.Location = new System.Drawing.Point(445, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(388, 44);
            this.label1.TabIndex = 35;
            this.label1.Text = "Remove Score Form";
            // 
            // RemoveScoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1088, 518);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.buttonLoad);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.dataGridViewScore);
            this.Name = "RemoveScoreForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RemoveScoreForm";
            this.Load += new System.EventHandler(this.RemoveScoreForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewScore)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewScore;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}