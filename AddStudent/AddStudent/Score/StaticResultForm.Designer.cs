
namespace AddStudent
{
    partial class StaticResultForm
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
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.flowLayoutPanelCourse = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanelResult = new System.Windows.Forms.FlowLayoutPanel();
            this.BieuDo = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panelBore3 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.BieuDo)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Static by Course";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(330, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Static by Result";
            // 
            // flowLayoutPanelCourse
            // 
            this.flowLayoutPanelCourse.AutoScroll = true;
            this.flowLayoutPanelCourse.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.flowLayoutPanelCourse.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanelCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flowLayoutPanelCourse.Location = new System.Drawing.Point(55, 199);
            this.flowLayoutPanelCourse.Name = "flowLayoutPanelCourse";
            this.flowLayoutPanelCourse.Size = new System.Drawing.Size(226, 262);
            this.flowLayoutPanelCourse.TabIndex = 2;
            // 
            // flowLayoutPanelResult
            // 
            this.flowLayoutPanelResult.AutoScroll = true;
            this.flowLayoutPanelResult.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.flowLayoutPanelResult.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanelResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flowLayoutPanelResult.Location = new System.Drawing.Point(335, 199);
            this.flowLayoutPanelResult.Name = "flowLayoutPanelResult";
            this.flowLayoutPanelResult.Size = new System.Drawing.Size(226, 262);
            this.flowLayoutPanelResult.TabIndex = 3;
            // 
            // BieuDo
            // 
            chartArea1.Name = "ChartArea1";
            this.BieuDo.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.BieuDo.Legends.Add(legend1);
            this.BieuDo.Location = new System.Drawing.Point(670, 137);
            this.BieuDo.Name = "BieuDo";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Tong";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Pass";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Fall";
            this.BieuDo.Series.Add(series1);
            this.BieuDo.Series.Add(series2);
            this.BieuDo.Series.Add(series3);
            this.BieuDo.Size = new System.Drawing.Size(532, 392);
            this.BieuDo.TabIndex = 5;
            this.BieuDo.Text = "chart1";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(121, 498);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(263, 25);
            this.label9.TabIndex = 31;
            this.label9.Text = "Nguyễn Thái Hải - 19110356";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(644, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(522, 25);
            this.label3.TabIndex = 32;
            this.label3.Text = "Biểu Đồ Sinh Viên Đậu / Rớt Theo Từng Khóa Học %";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(1, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1236, 66);
            this.panel1.TabIndex = 40;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AddStudent.Properties.Resources.bandicam_2021_05_16_23_48_09_4631;
            this.pictureBox1.Location = new System.Drawing.Point(371, 2);
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
            this.label4.Location = new System.Drawing.Point(457, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(467, 44);
            this.label4.TabIndex = 35;
            this.label4.Text = "Static Result Score Form";
            // 
            // panelBore3
            // 
            this.panelBore3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.panelBore3.Location = new System.Drawing.Point(613, 69);
            this.panelBore3.Name = "panelBore3";
            this.panelBore3.Size = new System.Drawing.Size(12, 509);
            this.panelBore3.TabIndex = 41;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(83, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(422, 25);
            this.label5.TabIndex = 42;
            this.label5.Text = "Thống Kê Tình Trạng Của Từng Khóa Học";
            // 
            // StaticResultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1239, 582);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panelBore3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.BieuDo);
            this.Controls.Add(this.flowLayoutPanelResult);
            this.Controls.Add(this.flowLayoutPanelCourse);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "StaticResultForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StaticResultForm";
            this.Load += new System.EventHandler(this.StaticResultForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BieuDo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelCourse;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelResult;
        private System.Windows.Forms.DataVisualization.Charting.Chart BieuDo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panelBore3;
        private System.Windows.Forms.Label label5;
    }



}
