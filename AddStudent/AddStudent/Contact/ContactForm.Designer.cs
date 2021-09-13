
namespace AddStudent
{
    partial class ContactForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.buttonSelect = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.pictureBoxUser = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBoxIDGroup = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonGAdd = new System.Windows.Forms.Button();
            this.textBoxGAdd = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.comboBoxEdit = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.buttonGEdit = new System.Windows.Forms.Button();
            this.textBoxGEdit = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.comboBoxRemove = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.buttonGRemove = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.labelEditHuman = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUser)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(184, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Contact";
            // 
            // buttonRemove
            // 
            this.buttonRemove.BackColor = System.Drawing.Color.Yellow;
            this.buttonRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRemove.Location = new System.Drawing.Point(28, 52);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(416, 34);
            this.buttonRemove.TabIndex = 13;
            this.buttonRemove.Text = "Remove";
            this.buttonRemove.UseVisualStyleBackColor = false;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // buttonSelect
            // 
            this.buttonSelect.BackColor = System.Drawing.Color.Red;
            this.buttonSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSelect.Location = new System.Drawing.Point(313, 13);
            this.buttonSelect.Name = "buttonSelect";
            this.buttonSelect.Size = new System.Drawing.Size(148, 32);
            this.buttonSelect.TabIndex = 12;
            this.buttonSelect.Text = "Select Contact";
            this.buttonSelect.UseVisualStyleBackColor = false;
            this.buttonSelect.Click += new System.EventHandler(this.buttonSelect_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBoxID);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.buttonSelect);
            this.panel1.Controls.Add(this.buttonRemove);
            this.panel1.Location = new System.Drawing.Point(16, 376);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(476, 96);
            this.panel1.TabIndex = 5;
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(177, 14);
            this.textBoxID.Multiline = true;
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(130, 30);
            this.textBoxID.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(3, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(216, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Enter Contact Id:";
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.Location = new System.Drawing.Point(23, 217);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(125, 36);
            this.buttonAdd.TabIndex = 0;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buttonEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEdit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonEdit.Location = new System.Drawing.Point(23, 280);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(125, 43);
            this.buttonEdit.TabIndex = 1;
            this.buttonEdit.Text = "Edit";
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Magenta;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button5.Location = new System.Drawing.Point(23, 506);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(174, 42);
            this.button5.TabIndex = 6;
            this.button5.Text = "Show full List";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // pictureBoxUser
            // 
            this.pictureBoxUser.Location = new System.Drawing.Point(804, 0);
            this.pictureBoxUser.Name = "pictureBoxUser";
            this.pictureBoxUser.Size = new System.Drawing.Size(137, 124);
            this.pictureBoxUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxUser.TabIndex = 1;
            this.pictureBoxUser.TabStop = false;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(494, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(11, 458);
            this.label4.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(692, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 29);
            this.label5.TabIndex = 8;
            this.label5.Text = "Group";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.textBoxIDGroup);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.buttonGAdd);
            this.panel2.Controls.Add(this.textBoxGAdd);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Location = new System.Drawing.Point(522, 190);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(439, 122);
            this.panel2.TabIndex = 9;
            // 
            // textBoxIDGroup
            // 
            this.textBoxIDGroup.Location = new System.Drawing.Point(213, 47);
            this.textBoxIDGroup.Name = "textBoxIDGroup";
            this.textBoxIDGroup.Size = new System.Drawing.Size(211, 22);
            this.textBoxIDGroup.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(16, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "ID Group:";
            // 
            // buttonGAdd
            // 
            this.buttonGAdd.BackColor = System.Drawing.Color.Orange;
            this.buttonGAdd.ForeColor = System.Drawing.Color.SeaShell;
            this.buttonGAdd.Location = new System.Drawing.Point(17, 75);
            this.buttonGAdd.Name = "buttonGAdd";
            this.buttonGAdd.Size = new System.Drawing.Size(411, 34);
            this.buttonGAdd.TabIndex = 3;
            this.buttonGAdd.Text = "Add";
            this.buttonGAdd.UseVisualStyleBackColor = false;
            this.buttonGAdd.Click += new System.EventHandler(this.buttonGAdd_Click);
            // 
            // textBoxGAdd
            // 
            this.textBoxGAdd.Location = new System.Drawing.Point(213, 15);
            this.textBoxGAdd.Name = "textBoxGAdd";
            this.textBoxGAdd.Size = new System.Drawing.Size(211, 22);
            this.textBoxGAdd.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(15, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(171, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Enter Group Name:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.comboBoxEdit);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.buttonGEdit);
            this.panel3.Controls.Add(this.textBoxGEdit);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Location = new System.Drawing.Point(522, 326);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(439, 134);
            this.panel3.TabIndex = 10;
            // 
            // comboBoxEdit
            // 
            this.comboBoxEdit.FormattingEnabled = true;
            this.comboBoxEdit.Location = new System.Drawing.Point(213, 9);
            this.comboBoxEdit.Name = "comboBoxEdit";
            this.comboBoxEdit.Size = new System.Drawing.Size(211, 24);
            this.comboBoxEdit.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(14, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(125, 20);
            this.label8.TabIndex = 4;
            this.label8.Text = "Select Group:";
            // 
            // buttonGEdit
            // 
            this.buttonGEdit.BackColor = System.Drawing.Color.Orange;
            this.buttonGEdit.ForeColor = System.Drawing.Color.SeaShell;
            this.buttonGEdit.Location = new System.Drawing.Point(17, 84);
            this.buttonGEdit.Name = "buttonGEdit";
            this.buttonGEdit.Size = new System.Drawing.Size(411, 34);
            this.buttonGEdit.TabIndex = 3;
            this.buttonGEdit.Text = "Edit";
            this.buttonGEdit.UseVisualStyleBackColor = false;
            this.buttonGEdit.Click += new System.EventHandler(this.buttonGEdit_Click);
            // 
            // textBoxGEdit
            // 
            this.textBoxGEdit.Location = new System.Drawing.Point(213, 43);
            this.textBoxGEdit.Name = "textBoxGEdit";
            this.textBoxGEdit.Size = new System.Drawing.Size(211, 22);
            this.textBoxGEdit.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(14, 45);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(156, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Enter New Name:";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.comboBoxRemove);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.buttonGRemove);
            this.panel4.Location = new System.Drawing.Point(522, 473);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(439, 120);
            this.panel4.TabIndex = 11;
            // 
            // comboBoxRemove
            // 
            this.comboBoxRemove.FormattingEnabled = true;
            this.comboBoxRemove.Location = new System.Drawing.Point(213, 17);
            this.comboBoxRemove.Name = "comboBoxRemove";
            this.comboBoxRemove.Size = new System.Drawing.Size(211, 24);
            this.comboBoxRemove.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(14, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(125, 20);
            this.label9.TabIndex = 4;
            this.label9.Text = "Select Group:";
            // 
            // buttonGRemove
            // 
            this.buttonGRemove.BackColor = System.Drawing.Color.Orange;
            this.buttonGRemove.ForeColor = System.Drawing.Color.SeaShell;
            this.buttonGRemove.Location = new System.Drawing.Point(19, 68);
            this.buttonGRemove.Name = "buttonGRemove";
            this.buttonGRemove.Size = new System.Drawing.Size(405, 34);
            this.buttonGRemove.TabIndex = 3;
            this.buttonGRemove.Text = "Remove";
            this.buttonGRemove.UseVisualStyleBackColor = false;
            this.buttonGRemove.Click += new System.EventHandler(this.buttonGRemove_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel5.Controls.Add(this.labelEditHuman);
            this.panel5.Controls.Add(this.labelName);
            this.panel5.Controls.Add(this.label10);
            this.panel5.Controls.Add(this.labelTitle);
            this.panel5.Controls.Add(this.pictureBoxUser);
            this.panel5.Location = new System.Drawing.Point(19, 13);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(953, 127);
            this.panel5.TabIndex = 25;
            // 
            // labelEditHuman
            // 
            this.labelEditHuman.AutoSize = true;
            this.labelEditHuman.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEditHuman.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(57)))), ((int)(((byte)(82)))));
            this.labelEditHuman.Location = new System.Drawing.Point(715, 80);
            this.labelEditHuman.Name = "labelEditHuman";
            this.labelEditHuman.Size = new System.Drawing.Size(81, 17);
            this.labelEditHuman.TabIndex = 37;
            this.labelEditHuman.Text = "Edit my info";
            this.labelEditHuman.Click += new System.EventHandler(this.labelEditHuman_Click);
            // 
            // labelName
            // 
            this.labelName.Location = new System.Drawing.Point(619, 39);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(177, 24);
            this.labelName.TabIndex = 16;
            this.labelName.Text = "label11";
            this.labelName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Location = new System.Drawing.Point(370, 39);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(248, 32);
            this.label10.TabIndex = 14;
            this.label10.Text = "Human Resource";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelTitle
            // 
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelTitle.Location = new System.Drawing.Point(586, 4);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(210, 35);
            this.labelTitle.TabIndex = 13;
            this.labelTitle.Text = "label1";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label11.Location = new System.Drawing.Point(980, -1);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(11, 615);
            this.label11.TabIndex = 26;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label12.Location = new System.Drawing.Point(-1, 1);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(11, 615);
            this.label12.TabIndex = 27;
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label13.Location = new System.Drawing.Point(10, 605);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(971, 10);
            this.label13.TabIndex = 28;
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label14.Location = new System.Drawing.Point(10, 142);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(971, 10);
            this.label14.TabIndex = 29;
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label15.Location = new System.Drawing.Point(8, 1);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(971, 10);
            this.label15.TabIndex = 30;
            // 
            // ContactForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(993, 615);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "ContactForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ContactForm";
            this.Load += new System.EventHandler(this.ContactForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUser)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBoxUser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Button buttonSelect;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonGAdd;
        private System.Windows.Forms.TextBox textBoxGAdd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox comboBoxEdit;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button buttonGEdit;
        private System.Windows.Forms.TextBox textBoxGEdit;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ComboBox comboBoxRemove;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button buttonGRemove;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label labelEditHuman;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.TextBox textBoxIDGroup;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
    }
}