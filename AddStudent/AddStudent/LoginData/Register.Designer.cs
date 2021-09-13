
namespace AddStudent
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            this.labelUser = new System.Windows.Forms.Label();
            this.labelPass = new System.Windows.Forms.Label();
            this.textBoxUserName = new System.Windows.Forms.TextBox();
            this.textBoxPassWord = new System.Windows.Forms.TextBox();
            this.buttonRegister = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUser.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelUser.Location = new System.Drawing.Point(70, 117);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(120, 25);
            this.labelUser.TabIndex = 0;
            this.labelUser.Text = "UserName:";
            // 
            // labelPass
            // 
            this.labelPass.AutoSize = true;
            this.labelPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPass.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelPass.Location = new System.Drawing.Point(72, 160);
            this.labelPass.Name = "labelPass";
            this.labelPass.Size = new System.Drawing.Size(119, 25);
            this.labelPass.TabIndex = 1;
            this.labelPass.Text = "PassWord:";
            // 
            // textBoxUserName
            // 
            this.textBoxUserName.Location = new System.Drawing.Point(216, 117);
            this.textBoxUserName.Name = "textBoxUserName";
            this.textBoxUserName.Size = new System.Drawing.Size(216, 22);
            this.textBoxUserName.TabIndex = 2;
            // 
            // textBoxPassWord
            // 
            this.textBoxPassWord.Location = new System.Drawing.Point(216, 160);
            this.textBoxPassWord.Name = "textBoxPassWord";
            this.textBoxPassWord.Size = new System.Drawing.Size(216, 22);
            this.textBoxPassWord.TabIndex = 3;
            // 
            // buttonRegister
            // 
            this.buttonRegister.BackColor = System.Drawing.Color.Lime;
            this.buttonRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRegister.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.buttonRegister.Location = new System.Drawing.Point(74, 223);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(147, 44);
            this.buttonRegister.TabIndex = 6;
            this.buttonRegister.Text = "Register";
            this.buttonRegister.UseVisualStyleBackColor = false;
            this.buttonRegister.Click += new System.EventHandler(this.buttonRegister_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Image = global::AddStudent.Properties.Resources.bandicam_2021_05_16_14_45_05_670;
            this.label1.Location = new System.Drawing.Point(118, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 38);
            this.label1.TabIndex = 34;
            this.label1.Text = "Account Register";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(94, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(397, 77);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 33;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(0, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(94, 77);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 32;
            this.pictureBox3.TabStop = false;
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.Red;
            this.buttonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancel.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.buttonCancel.Location = new System.Drawing.Point(275, 223);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(147, 44);
            this.buttonCancel.TabIndex = 35;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = false;
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(493, 299);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.buttonRegister);
            this.Controls.Add(this.textBoxPassWord);
            this.Controls.Add(this.textBoxUserName);
            this.Controls.Add(this.labelPass);
            this.Controls.Add(this.labelUser);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Register";
            this.Text = "Register";
            this.Load += new System.EventHandler(this.Register_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.Label labelPass;
        private System.Windows.Forms.TextBox textBoxUserName;
        private System.Windows.Forms.TextBox textBoxPassWord;
        private System.Windows.Forms.Button buttonRegister;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button buttonCancel;
    }
}