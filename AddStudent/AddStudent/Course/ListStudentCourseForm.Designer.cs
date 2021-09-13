
namespace AddStudent
{
    partial class ListStudentCourseForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewListContact = new System.Windows.Forms.DataGridView();
            this.listBoxCourse = new System.Windows.Forms.ListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListContact)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(280, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(225, 32);
            this.label3.TabIndex = 35;
            this.label3.Text = "STUDENT LIST";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 32);
            this.label2.TabIndex = 34;
            this.label2.Text = "COURSE";
            // 
            // dataGridViewListContact
            // 
            this.dataGridViewListContact.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewListContact.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(207)))), ((int)(((byte)(250)))));
            this.dataGridViewListContact.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewListContact.Location = new System.Drawing.Point(286, 149);
            this.dataGridViewListContact.Name = "dataGridViewListContact";
            this.dataGridViewListContact.RowHeadersWidth = 51;
            this.dataGridViewListContact.RowTemplate.Height = 24;
            this.dataGridViewListContact.Size = new System.Drawing.Size(995, 269);
            this.dataGridViewListContact.TabIndex = 33;
            // 
            // listBoxCourse
            // 
            this.listBoxCourse.FormattingEnabled = true;
            this.listBoxCourse.ItemHeight = 16;
            this.listBoxCourse.Location = new System.Drawing.Point(21, 149);
            this.listBoxCourse.Name = "listBoxCourse";
            this.listBoxCourse.Size = new System.Drawing.Size(214, 276);
            this.listBoxCourse.TabIndex = 32;
            this.listBoxCourse.Click += new System.EventHandler(this.listBoxCourse_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel2.Location = new System.Drawing.Point(-3, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 73);
            this.panel2.TabIndex = 44;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(87, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1194, 73);
            this.panel1.TabIndex = 43;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(331, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(477, 44);
            this.label4.TabIndex = 36;
            this.label4.Text = "List Student Course Form";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.AliceBlue;
            this.pictureBox1.Image = global::AddStudent.Properties.Resources.icono_capacitacion_png_7;
            this.pictureBox1.Location = new System.Drawing.Point(7, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 73);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 42;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(255, 75);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(14, 374);
            this.panel3.TabIndex = 45;
            // 
            // ListStudentCourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AddStudent.Properties.Resources.e3982cc208873792337b423d9e7714b39;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1282, 450);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridViewListContact);
            this.Controls.Add(this.listBoxCourse);
            this.Name = "ListStudentCourseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListStudentCourseForm";
            this.Load += new System.EventHandler(this.ListStudentCourseForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListContact)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridViewListContact;
        private System.Windows.Forms.ListBox listBoxCourse;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
    }
}