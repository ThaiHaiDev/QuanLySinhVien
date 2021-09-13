
namespace AddStudent
{
    partial class StaticForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label9 = new System.Windows.Forms.Label();
            this.BieuDoCot = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panelFemale = new System.Windows.Forms.Panel();
            this.labelFemale = new System.Windows.Forms.Label();
            this.panelMale = new System.Windows.Forms.Panel();
            this.labelMale = new System.Windows.Forms.Label();
            this.panelTotal = new System.Windows.Forms.Panel();
            this.labelTotal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.BieuDoCot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.panelFemale.SuspendLayout();
            this.panelMale.SuspendLayout();
            this.panelTotal.SuspendLayout();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(539, 101);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(263, 25);
            this.label9.TabIndex = 28;
            this.label9.Text = "Nguyễn Thái Hải - 19110356";
            // 
            // BieuDoCot
            // 
            chartArea1.Name = "ChartArea1";
            this.BieuDoCot.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.BieuDoCot.Legends.Add(legend1);
            this.BieuDoCot.Location = new System.Drawing.Point(101, 467);
            this.BieuDoCot.Name = "BieuDoCot";
            this.BieuDoCot.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series1.ChartArea = "ChartArea1";
            series1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series1.Legend = "Legend1";
            series1.Name = "Male";
            series2.ChartArea = "ChartArea1";
            series2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series2.Legend = "Legend1";
            series2.Name = "Female";
            this.BieuDoCot.Series.Add(series1);
            this.BieuDoCot.Series.Add(series2);
            this.BieuDoCot.Size = new System.Drawing.Size(318, 296);
            this.BieuDoCot.TabIndex = 29;
            this.BieuDoCot.Text = "BieuDoCot";
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(508, 467);
            this.chart1.Name = "chart1";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "%";
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(290, 296);
            this.chart1.TabIndex = 30;
            this.chart1.Text = "chart1";
            // 
            // panelFemale
            // 
            this.panelFemale.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(90)))), ((int)(((byte)(36)))));
            this.panelFemale.Controls.Add(this.labelFemale);
            this.panelFemale.Location = new System.Drawing.Point(401, 229);
            this.panelFemale.Name = "panelFemale";
            this.panelFemale.Size = new System.Drawing.Size(231, 222);
            this.panelFemale.TabIndex = 33;
            this.panelFemale.MouseEnter += new System.EventHandler(this.panelFemale_MouseEnter);
            this.panelFemale.MouseLeave += new System.EventHandler(this.panelFemale_MouseLeave);
            // 
            // labelFemale
            // 
            this.labelFemale.AutoSize = true;
            this.labelFemale.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFemale.Location = new System.Drawing.Point(22, 82);
            this.labelFemale.Name = "labelFemale";
            this.labelFemale.Size = new System.Drawing.Size(79, 29);
            this.labelFemale.TabIndex = 5;
            this.labelFemale.Text = "label3";
            // 
            // panelMale
            // 
            this.panelMale.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(128)))), ((int)(((byte)(250)))));
            this.panelMale.Controls.Add(this.labelMale);
            this.panelMale.Location = new System.Drawing.Point(2, 226);
            this.panelMale.Name = "panelMale";
            this.panelMale.Size = new System.Drawing.Size(257, 222);
            this.panelMale.TabIndex = 32;
            this.panelMale.MouseEnter += new System.EventHandler(this.panelMale_MouseEnter);
            this.panelMale.MouseLeave += new System.EventHandler(this.panelMale_MouseLeave);
            // 
            // labelMale
            // 
            this.labelMale.AutoSize = true;
            this.labelMale.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMale.Location = new System.Drawing.Point(29, 82);
            this.labelMale.Name = "labelMale";
            this.labelMale.Size = new System.Drawing.Size(79, 29);
            this.labelMale.TabIndex = 4;
            this.labelMale.Text = "label2";
            // 
            // panelTotal
            // 
            this.panelTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(137)))), ((int)(((byte)(167)))));
            this.panelTotal.Controls.Add(this.labelTotal);
            this.panelTotal.Location = new System.Drawing.Point(2, 2);
            this.panelTotal.Name = "panelTotal";
            this.panelTotal.Size = new System.Drawing.Size(796, 221);
            this.panelTotal.TabIndex = 31;
            this.panelTotal.MouseEnter += new System.EventHandler(this.panelTotal_MouseEnter);
            this.panelTotal.MouseLeave += new System.EventHandler(this.panelTotal_MouseLeave);
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotal.Location = new System.Drawing.Point(258, 87);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(79, 29);
            this.labelTotal.TabIndex = 3;
            this.labelTotal.Text = "label1";
            // 
            // StaticForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 784);
            this.Controls.Add(this.panelFemale);
            this.Controls.Add(this.panelMale);
            this.Controls.Add(this.panelTotal);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.BieuDoCot);
            this.Controls.Add(this.label9);
            this.Name = "StaticForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StaticForm";
            this.Load += new System.EventHandler(this.StaticForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BieuDoCot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.panelFemale.ResumeLayout(false);
            this.panelFemale.PerformLayout();
            this.panelMale.ResumeLayout(false);
            this.panelMale.PerformLayout();
            this.panelTotal.ResumeLayout(false);
            this.panelTotal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataVisualization.Charting.Chart BieuDoCot;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Panel panelFemale;
        private System.Windows.Forms.Label labelFemale;
        private System.Windows.Forms.Panel panelMale;
        private System.Windows.Forms.Label labelMale;
        private System.Windows.Forms.Panel panelTotal;
        private System.Windows.Forms.Label labelTotal;
    }
}