
namespace AddStudent
{
    partial class PrintScore
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
            this.dataGridViewAvgScore = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonPrint = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAvgScore)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewAvgScore
            // 
            this.dataGridViewAvgScore.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewAvgScore.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAvgScore.Location = new System.Drawing.Point(15, 135);
            this.dataGridViewAvgScore.Name = "dataGridViewAvgScore";
            this.dataGridViewAvgScore.RowHeadersWidth = 51;
            this.dataGridViewAvgScore.RowTemplate.Height = 24;
            this.dataGridViewAvgScore.Size = new System.Drawing.Size(469, 195);
            this.dataGridViewAvgScore.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(114, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Điểm Trung Bình Khóa Học";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(495, 66);
            this.panel1.TabIndex = 38;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AddStudent.Properties.Resources.bandicam_2021_05_16_23_48_09_4631;
            this.pictureBox1.Location = new System.Drawing.Point(79, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(62, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(151, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(280, 38);
            this.label2.TabIndex = 35;
            this.label2.Text = "Print Score Form";
            // 
            // buttonPrint
            // 
            this.buttonPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPrint.Image = global::AddStudent.Properties.Resources.print1;
            this.buttonPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonPrint.Location = new System.Drawing.Point(184, 349);
            this.buttonPrint.Name = "buttonPrint";
            this.buttonPrint.Size = new System.Drawing.Size(118, 46);
            this.buttonPrint.TabIndex = 5;
            this.buttonPrint.Text = "   Print";
            this.buttonPrint.UseVisualStyleBackColor = false;
            this.buttonPrint.Click += new System.EventHandler(this.buttonPrint_Click);
            // 
            // PrintScore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 423);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonPrint);
            this.Controls.Add(this.dataGridViewAvgScore);
            this.Name = "PrintScore";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PrintScore";
            this.Load += new System.EventHandler(this.PrintScore_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAvgScore)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewAvgScore;
        private System.Windows.Forms.Button buttonPrint;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
    }
}