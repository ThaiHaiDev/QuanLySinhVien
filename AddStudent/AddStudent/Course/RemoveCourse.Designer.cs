
namespace AddStudent
{
    partial class RemoveCourse
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
            this.buttonRemoveCourse = new System.Windows.Forms.Button();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.labelID = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonRemoveCourse
            // 
            this.buttonRemoveCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRemoveCourse.ForeColor = System.Drawing.Color.Coral;
            this.buttonRemoveCourse.Location = new System.Drawing.Point(205, 93);
            this.buttonRemoveCourse.Name = "buttonRemoveCourse";
            this.buttonRemoveCourse.Size = new System.Drawing.Size(105, 33);
            this.buttonRemoveCourse.TabIndex = 0;
            this.buttonRemoveCourse.Text = "Remove";
            this.buttonRemoveCourse.UseVisualStyleBackColor = true;
            this.buttonRemoveCourse.Click += new System.EventHandler(this.buttonRemoveCourse_Click);
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(259, 47);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(231, 22);
            this.textBoxID.TabIndex = 1;
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelID.Image = global::AddStudent.Properties.Resources.e3982cc208873792337b423d9e7714b37;
            this.labelID.Location = new System.Drawing.Point(12, 44);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(217, 25);
            this.labelID.TabIndex = 2;
            this.labelID.Text = "Enter The Course ID:";
            // 
            // RemoveCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BackgroundImage = global::AddStudent.Properties.Resources.e3982cc208873792337b423d9e7714b36;
            this.ClientSize = new System.Drawing.Size(522, 162);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.buttonRemoveCourse);
            this.Name = "RemoveCourse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RemoveCourse";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonRemoveCourse;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Label labelID;
    }
}