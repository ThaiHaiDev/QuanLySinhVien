
namespace AddStudent
{
    partial class EditHumanForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditHumanForm));
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.Label();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.uploadImg = new System.Windows.Forms.Button();
            this.pictureBoxImage = new System.Windows.Forms.PictureBox();
            this.textBoxUserName = new System.Windows.Forms.TextBox();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.textBoxUserID = new System.Windows.Forms.TextBox();
            this.Picture = new System.Windows.Forms.Label();
            this.Username = new System.Windows.Forms.Label();
            this.Lname = new System.Windows.Forms.Label();
            this.Fname = new System.Windows.Forms.Label();
            this.UserID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPassword.Location = new System.Drawing.Point(210, 316);
            this.textBoxPassword.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPassword.Multiline = true;
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(296, 22);
            this.textBoxPassword.TabIndex = 64;
            // 
            // Password
            // 
            this.Password.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password.Location = new System.Drawing.Point(31, 312);
            this.Password.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(148, 30);
            this.Password.TabIndex = 63;
            this.Password.Text = "Password";
            this.Password.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.Color.Red;
            this.buttonEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.buttonEdit.Location = new System.Drawing.Point(148, 581);
            this.buttonEdit.Margin = new System.Windows.Forms.Padding(4);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(196, 48);
            this.buttonEdit.TabIndex = 62;
            this.buttonEdit.Text = "Edit";
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // uploadImg
            // 
            this.uploadImg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(165)))), ((int)(((byte)(194)))));
            this.uploadImg.Location = new System.Drawing.Point(283, 528);
            this.uploadImg.Margin = new System.Windows.Forms.Padding(4);
            this.uploadImg.Name = "uploadImg";
            this.uploadImg.Size = new System.Drawing.Size(136, 30);
            this.uploadImg.TabIndex = 61;
            this.uploadImg.Text = "Upload Image";
            this.uploadImg.UseVisualStyleBackColor = false;
            this.uploadImg.Click += new System.EventHandler(this.uploadImg_Click);
            // 
            // pictureBoxImage
            // 
            this.pictureBoxImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(98)))), ((int)(((byte)(117)))));
            this.pictureBoxImage.Location = new System.Drawing.Point(263, 362);
            this.pictureBoxImage.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxImage.Name = "pictureBoxImage";
            this.pictureBoxImage.Size = new System.Drawing.Size(180, 158);
            this.pictureBoxImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxImage.TabIndex = 60;
            this.pictureBoxImage.TabStop = false;
            // 
            // textBoxUserName
            // 
            this.textBoxUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUserName.Location = new System.Drawing.Point(212, 260);
            this.textBoxUserName.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxUserName.Multiline = true;
            this.textBoxUserName.Name = "textBoxUserName";
            this.textBoxUserName.Size = new System.Drawing.Size(294, 22);
            this.textBoxUserName.TabIndex = 59;
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLastName.Location = new System.Drawing.Point(211, 204);
            this.textBoxLastName.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxLastName.Multiline = true;
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(295, 22);
            this.textBoxLastName.TabIndex = 58;
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFirstName.Location = new System.Drawing.Point(211, 159);
            this.textBoxFirstName.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxFirstName.Multiline = true;
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(295, 22);
            this.textBoxFirstName.TabIndex = 57;
            // 
            // textBoxUserID
            // 
            this.textBoxUserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUserID.Location = new System.Drawing.Point(210, 119);
            this.textBoxUserID.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxUserID.Multiline = true;
            this.textBoxUserID.Name = "textBoxUserID";
            this.textBoxUserID.Size = new System.Drawing.Size(296, 22);
            this.textBoxUserID.TabIndex = 56;
            // 
            // Picture
            // 
            this.Picture.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Picture.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Picture.Location = new System.Drawing.Point(31, 362);
            this.Picture.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Picture.Name = "Picture";
            this.Picture.Size = new System.Drawing.Size(148, 30);
            this.Picture.TabIndex = 55;
            this.Picture.Text = "Picture";
            this.Picture.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Username
            // 
            this.Username.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username.Location = new System.Drawing.Point(33, 256);
            this.Username.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(148, 30);
            this.Username.TabIndex = 54;
            this.Username.Text = "User name";
            this.Username.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Lname
            // 
            this.Lname.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Lname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lname.Location = new System.Drawing.Point(32, 200);
            this.Lname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lname.Name = "Lname";
            this.Lname.Size = new System.Drawing.Size(148, 30);
            this.Lname.TabIndex = 53;
            this.Lname.Text = "Last Name";
            this.Lname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Fname
            // 
            this.Fname.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Fname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fname.Location = new System.Drawing.Point(32, 155);
            this.Fname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Fname.Name = "Fname";
            this.Fname.Size = new System.Drawing.Size(148, 30);
            this.Fname.TabIndex = 52;
            this.Fname.Text = "Fist Name";
            this.Fname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UserID
            // 
            this.UserID.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.UserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserID.Location = new System.Drawing.Point(32, 111);
            this.UserID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.UserID.Name = "UserID";
            this.UserID.Size = new System.Drawing.Size(148, 30);
            this.UserID.TabIndex = 51;
            this.UserID.Text = "User ID";
            this.UserID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Image = global::AddStudent.Properties.Resources.bandicam_2021_05_16_14_45_05_670;
            this.label1.Location = new System.Drawing.Point(98, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(306, 38);
            this.label1.TabIndex = 67;
            this.label1.Text = "Register Resource";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(87, -1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(447, 85);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 66;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(92, 85);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 65;
            this.pictureBox1.TabStop = false;
            // 
            // EditHumanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 650);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.uploadImg);
            this.Controls.Add(this.pictureBoxImage);
            this.Controls.Add(this.textBoxUserName);
            this.Controls.Add(this.textBoxLastName);
            this.Controls.Add(this.textBoxFirstName);
            this.Controls.Add(this.textBoxUserID);
            this.Controls.Add(this.Picture);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.Lname);
            this.Controls.Add(this.Fname);
            this.Controls.Add(this.UserID);
            this.Name = "EditHumanForm";
            this.Text = "EditHumanForm";
            this.Load += new System.EventHandler(this.EditHumanForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button uploadImg;
        private System.Windows.Forms.PictureBox pictureBoxImage;
        private System.Windows.Forms.TextBox textBoxUserName;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.TextBox textBoxUserID;
        private System.Windows.Forms.Label Picture;
        private System.Windows.Forms.Label Username;
        private System.Windows.Forms.Label Lname;
        private System.Windows.Forms.Label Fname;
        private System.Windows.Forms.Label UserID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}