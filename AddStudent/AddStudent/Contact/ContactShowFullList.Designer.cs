
namespace AddStudent
{
    partial class ContactShowFullList
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
            this.listBoxContact = new System.Windows.Forms.ListBox();
            this.dataGridViewContact = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonShow = new System.Windows.Forms.Button();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewContact)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxContact
            // 
            this.listBoxContact.FormattingEnabled = true;
            this.listBoxContact.ItemHeight = 16;
            this.listBoxContact.Location = new System.Drawing.Point(12, 110);
            this.listBoxContact.Name = "listBoxContact";
            this.listBoxContact.Size = new System.Drawing.Size(214, 308);
            this.listBoxContact.TabIndex = 19;
            this.listBoxContact.Click += new System.EventHandler(this.listBoxContact_Click);
            // 
            // dataGridViewContact
            // 
            this.dataGridViewContact.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewContact.Location = new System.Drawing.Point(249, 110);
            this.dataGridViewContact.Name = "dataGridViewContact";
            this.dataGridViewContact.RowHeadersWidth = 51;
            this.dataGridViewContact.RowTemplate.Height = 24;
            this.dataGridViewContact.Size = new System.Drawing.Size(995, 308);
            this.dataGridViewContact.TabIndex = 20;
            this.dataGridViewContact.Click += new System.EventHandler(this.dataGridView1_Click);
            this.dataGridViewContact.DoubleClick += new System.EventHandler(this.dataGridViewContact_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 32);
            this.label1.TabIndex = 21;
            this.label1.Text = "Full Contact";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 32);
            this.label2.TabIndex = 22;
            this.label2.Text = "Group";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(243, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 32);
            this.label3.TabIndex = 23;
            this.label3.Text = "All Contact";
            // 
            // buttonShow
            // 
            this.buttonShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonShow.Location = new System.Drawing.Point(426, 65);
            this.buttonShow.Name = "buttonShow";
            this.buttonShow.Size = new System.Drawing.Size(130, 32);
            this.buttonShow.TabIndex = 24;
            this.buttonShow.Text = "Show Full";
            this.buttonShow.UseVisualStyleBackColor = true;
            this.buttonShow.Click += new System.EventHandler(this.buttonShow_Click);
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Location = new System.Drawing.Point(860, 65);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(247, 22);
            this.textBoxAddress.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(930, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 20);
            this.label4.TabIndex = 26;
            this.label4.Text = "Full Address";
            // 
            // ContactShowFullList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::AddStudent.Properties.Resources.tải_xuống3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1270, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxAddress);
            this.Controls.Add(this.buttonShow);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewContact);
            this.Controls.Add(this.listBoxContact);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "ContactShowFullList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ContactShowFullList";
            this.Load += new System.EventHandler(this.ContactShowFullList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewContact)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxContact;
        private System.Windows.Forms.DataGridView dataGridViewContact;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonShow;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.Label label4;
    }
}