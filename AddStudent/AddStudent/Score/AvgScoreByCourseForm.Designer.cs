
namespace AddStudent
{
    partial class AvgScoreByCourseForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.dataGridViewAvgScore = new System.Windows.Forms.DataGridView();
            this.BieuDoCot = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAvgScore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BieuDoCot)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewAvgScore
            // 
            this.dataGridViewAvgScore.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewAvgScore.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAvgScore.Location = new System.Drawing.Point(24, 120);
            this.dataGridViewAvgScore.Name = "dataGridViewAvgScore";
            this.dataGridViewAvgScore.RowHeadersWidth = 51;
            this.dataGridViewAvgScore.RowTemplate.Height = 24;
            this.dataGridViewAvgScore.Size = new System.Drawing.Size(469, 195);
            this.dataGridViewAvgScore.TabIndex = 0;
            this.dataGridViewAvgScore.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAvgScore_CellContentClick);
            // 
            // BieuDoCot
            // 
            chartArea1.Name = "ChartArea1";
            this.BieuDoCot.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.BieuDoCot.Legends.Add(legend1);
            this.BieuDoCot.Location = new System.Drawing.Point(60, 334);
            this.BieuDoCot.Name = "BieuDoCot";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Điểm";
            this.BieuDoCot.Series.Add(series1);
            this.BieuDoCot.Size = new System.Drawing.Size(408, 214);
            this.BieuDoCot.TabIndex = 1;
            this.BieuDoCot.Text = "BieuDoCot";
            this.BieuDoCot.Click += new System.EventHandler(this.BieuDoCot_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(110, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Điểm Trung Bình Khóa Học";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(520, 66);
            this.panel1.TabIndex = 37;
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
            this.label2.Size = new System.Drawing.Size(268, 38);
            this.label2.TabIndex = 35;
            this.label2.Text = "Avg Score Form";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(136, 567);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(199, 25);
            this.label3.TabIndex = 38;
            this.label3.Text = "Biểu Đồ Theo Điểm";
            // 
            // AvgScoreByCourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 601);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BieuDoCot);
            this.Controls.Add(this.dataGridViewAvgScore);
            this.Name = "AvgScoreByCourseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AvgScoreByCourseForm";
            this.Load += new System.EventHandler(this.AvgScoreByCourseForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAvgScore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BieuDoCot)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewAvgScore;
        private System.Windows.Forms.DataVisualization.Charting.Chart BieuDoCot;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}