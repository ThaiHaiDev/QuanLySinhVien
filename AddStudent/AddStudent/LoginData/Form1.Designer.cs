
namespace AddStudent
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.studentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentsListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.staticsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editRemoveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageStudentFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.courseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addCourseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeCourseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editCourseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.scoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addScoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeScoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageScoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.avgScoreByCourseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.resuitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resultToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.avgResultByScoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.staticToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.studentToolStripMenuItem,
            this.courseToolStripMenuItem,
            this.scoreToolStripMenuItem,
            this.resultToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(652, 44);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // studentToolStripMenuItem
            // 
            this.studentToolStripMenuItem.AutoSize = false;
            this.studentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addStudentToolStripMenuItem,
            this.studentsListToolStripMenuItem,
            this.staticsToolStripMenuItem,
            this.editRemoveToolStripMenuItem,
            this.manageStudentFormToolStripMenuItem,
            this.printToolStripMenuItem});
            this.studentToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentToolStripMenuItem.Image = global::AddStudent.Properties.Resources.student_icon_graduation_with_mortar_board_vector_19676166;
            this.studentToolStripMenuItem.Name = "studentToolStripMenuItem";
            this.studentToolStripMenuItem.Size = new System.Drawing.Size(120, 40);
            this.studentToolStripMenuItem.Text = "Student";
            // 
            // addStudentToolStripMenuItem
            // 
            this.addStudentToolStripMenuItem.AutoSize = false;
            this.addStudentToolStripMenuItem.Image = global::AddStudent.Properties.Resources.student_add_512;
            this.addStudentToolStripMenuItem.Name = "addStudentToolStripMenuItem";
            this.addStudentToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.addStudentToolStripMenuItem.Size = new System.Drawing.Size(272, 30);
            this.addStudentToolStripMenuItem.Text = "Add New Student";
            this.addStudentToolStripMenuItem.Click += new System.EventHandler(this.addStudentToolStripMenuItem_Click);
            // 
            // studentsListToolStripMenuItem
            // 
            this.studentsListToolStripMenuItem.AutoSize = false;
            this.studentsListToolStripMenuItem.Image = global::AddStudent.Properties.Resources.tải_xuống;
            this.studentsListToolStripMenuItem.Name = "studentsListToolStripMenuItem";
            this.studentsListToolStripMenuItem.Size = new System.Drawing.Size(272, 30);
            this.studentsListToolStripMenuItem.Text = "Students List";
            this.studentsListToolStripMenuItem.Click += new System.EventHandler(this.studentsListToolStripMenuItem_Click);
            // 
            // staticsToolStripMenuItem
            // 
            this.staticsToolStripMenuItem.AutoSize = false;
            this.staticsToolStripMenuItem.Image = global::AddStudent.Properties.Resources.pngtree_vector_marketing_statics_icon_png_image_926347;
            this.staticsToolStripMenuItem.Name = "staticsToolStripMenuItem";
            this.staticsToolStripMenuItem.Size = new System.Drawing.Size(272, 30);
            this.staticsToolStripMenuItem.Text = "Statics";
            this.staticsToolStripMenuItem.Click += new System.EventHandler(this.staticsToolStripMenuItem_Click);
            // 
            // editRemoveToolStripMenuItem
            // 
            this.editRemoveToolStripMenuItem.AutoSize = false;
            this.editRemoveToolStripMenuItem.Image = global::AddStudent.Properties.Resources._88288_200;
            this.editRemoveToolStripMenuItem.Name = "editRemoveToolStripMenuItem";
            this.editRemoveToolStripMenuItem.Size = new System.Drawing.Size(272, 30);
            this.editRemoveToolStripMenuItem.Text = "Edit / Remove";
            this.editRemoveToolStripMenuItem.Click += new System.EventHandler(this.editRemoveToolStripMenuItem_Click);
            // 
            // manageStudentFormToolStripMenuItem
            // 
            this.manageStudentFormToolStripMenuItem.AutoSize = false;
            this.manageStudentFormToolStripMenuItem.Image = global::AddStudent.Properties.Resources._109861283_student_icon_education_concept_icon_with_settings_sign_student_icon_and_customize_setup_manage_proce;
            this.manageStudentFormToolStripMenuItem.Name = "manageStudentFormToolStripMenuItem";
            this.manageStudentFormToolStripMenuItem.Size = new System.Drawing.Size(272, 30);
            this.manageStudentFormToolStripMenuItem.Text = "Manage Student Form";
            this.manageStudentFormToolStripMenuItem.Click += new System.EventHandler(this.manageStudentFormToolStripMenuItem_Click);
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.AutoSize = false;
            this.printToolStripMenuItem.Image = global::AddStudent.Properties.Resources.print;
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.Size = new System.Drawing.Size(272, 30);
            this.printToolStripMenuItem.Text = "Print";
            this.printToolStripMenuItem.Click += new System.EventHandler(this.printToolStripMenuItem_Click);
            // 
            // courseToolStripMenuItem
            // 
            this.courseToolStripMenuItem.AutoSize = false;
            this.courseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addCourseToolStripMenuItem,
            this.removeCourseToolStripMenuItem,
            this.editCourseToolStripMenuItem,
            this.manageToolStripMenuItem,
            this.printToolStripMenuItem1});
            this.courseToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseToolStripMenuItem.Image = global::AddStudent.Properties.Resources.online_course_line_icon_e_learning_and_education_vector_20224492;
            this.courseToolStripMenuItem.Name = "courseToolStripMenuItem";
            this.courseToolStripMenuItem.Size = new System.Drawing.Size(120, 40);
            this.courseToolStripMenuItem.Text = "Course";
            // 
            // addCourseToolStripMenuItem
            // 
            this.addCourseToolStripMenuItem.AutoSize = false;
            this.addCourseToolStripMenuItem.Image = global::AddStudent.Properties.Resources.tải_xuống__1_;
            this.addCourseToolStripMenuItem.Name = "addCourseToolStripMenuItem";
            this.addCourseToolStripMenuItem.Size = new System.Drawing.Size(224, 30);
            this.addCourseToolStripMenuItem.Text = "Add Course";
            this.addCourseToolStripMenuItem.Click += new System.EventHandler(this.addCourseToolStripMenuItem_Click);
            // 
            // removeCourseToolStripMenuItem
            // 
            this.removeCourseToolStripMenuItem.AutoSize = false;
            this.removeCourseToolStripMenuItem.Image = global::AddStudent.Properties.Resources.delete_list_318_9871;
            this.removeCourseToolStripMenuItem.Name = "removeCourseToolStripMenuItem";
            this.removeCourseToolStripMenuItem.Size = new System.Drawing.Size(224, 30);
            this.removeCourseToolStripMenuItem.Text = "Remove Course";
            this.removeCourseToolStripMenuItem.Click += new System.EventHandler(this.removeCourseToolStripMenuItem_Click);
            // 
            // editCourseToolStripMenuItem
            // 
            this.editCourseToolStripMenuItem.AutoSize = false;
            this.editCourseToolStripMenuItem.Image = global::AddStudent.Properties.Resources.Edit_icon__the_Noun_Project_30184__svg;
            this.editCourseToolStripMenuItem.Name = "editCourseToolStripMenuItem";
            this.editCourseToolStripMenuItem.Size = new System.Drawing.Size(224, 30);
            this.editCourseToolStripMenuItem.Text = "Edit Course";
            this.editCourseToolStripMenuItem.Click += new System.EventHandler(this.editCourseToolStripMenuItem_Click);
            // 
            // manageToolStripMenuItem
            // 
            this.manageToolStripMenuItem.AutoSize = false;
            this.manageToolStripMenuItem.Image = global::AddStudent.Properties.Resources.tải_xuống__2_;
            this.manageToolStripMenuItem.Name = "manageToolStripMenuItem";
            this.manageToolStripMenuItem.Size = new System.Drawing.Size(224, 30);
            this.manageToolStripMenuItem.Text = "Manage  Course";
            this.manageToolStripMenuItem.Click += new System.EventHandler(this.manageToolStripMenuItem_Click);
            // 
            // printToolStripMenuItem1
            // 
            this.printToolStripMenuItem1.AutoSize = false;
            this.printToolStripMenuItem1.Image = global::AddStudent.Properties.Resources.course_folder_edit_icon_outline_style_vector_30268672;
            this.printToolStripMenuItem1.Name = "printToolStripMenuItem1";
            this.printToolStripMenuItem1.Size = new System.Drawing.Size(224, 30);
            this.printToolStripMenuItem1.Text = "Print";
            this.printToolStripMenuItem1.Click += new System.EventHandler(this.printToolStripMenuItem1_Click);
            // 
            // scoreToolStripMenuItem
            // 
            this.scoreToolStripMenuItem.AutoSize = false;
            this.scoreToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addScoreToolStripMenuItem,
            this.removeScoreToolStripMenuItem,
            this.manageScoreToolStripMenuItem,
            this.avgScoreByCourseToolStripMenuItem,
            this.printToolStripMenuItem2,
            this.resuitToolStripMenuItem});
            this.scoreToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreToolStripMenuItem.Image = global::AddStudent.Properties.Resources.score_5_133904;
            this.scoreToolStripMenuItem.Name = "scoreToolStripMenuItem";
            this.scoreToolStripMenuItem.Size = new System.Drawing.Size(120, 40);
            this.scoreToolStripMenuItem.Text = "Score";
            // 
            // addScoreToolStripMenuItem
            // 
            this.addScoreToolStripMenuItem.AutoSize = false;
            this.addScoreToolStripMenuItem.Image = global::AddStudent.Properties.Resources._2727129;
            this.addScoreToolStripMenuItem.Name = "addScoreToolStripMenuItem";
            this.addScoreToolStripMenuItem.Size = new System.Drawing.Size(236, 30);
            this.addScoreToolStripMenuItem.Text = "Add Score";
            this.addScoreToolStripMenuItem.Click += new System.EventHandler(this.addScoreToolStripMenuItem_Click);
            // 
            // removeScoreToolStripMenuItem
            // 
            this.removeScoreToolStripMenuItem.AutoSize = false;
            this.removeScoreToolStripMenuItem.Image = global::AddStudent.Properties.Resources.Weaknesses_report_clipboard_cross_weaknesses_512;
            this.removeScoreToolStripMenuItem.Name = "removeScoreToolStripMenuItem";
            this.removeScoreToolStripMenuItem.Size = new System.Drawing.Size(236, 30);
            this.removeScoreToolStripMenuItem.Text = "Remove Score";
            this.removeScoreToolStripMenuItem.Click += new System.EventHandler(this.removeScoreToolStripMenuItem_Click);
            // 
            // manageScoreToolStripMenuItem
            // 
            this.manageScoreToolStripMenuItem.AutoSize = false;
            this.manageScoreToolStripMenuItem.Image = global::AddStudent.Properties.Resources.icon_manage_score;
            this.manageScoreToolStripMenuItem.Name = "manageScoreToolStripMenuItem";
            this.manageScoreToolStripMenuItem.Size = new System.Drawing.Size(236, 30);
            this.manageScoreToolStripMenuItem.Text = "Manage Score";
            this.manageScoreToolStripMenuItem.Click += new System.EventHandler(this.manageScoreToolStripMenuItem_Click);
            // 
            // avgScoreByCourseToolStripMenuItem
            // 
            this.avgScoreByCourseToolStripMenuItem.AutoSize = false;
            this.avgScoreByCourseToolStripMenuItem.Image = global::AddStudent.Properties.Resources.images;
            this.avgScoreByCourseToolStripMenuItem.Name = "avgScoreByCourseToolStripMenuItem";
            this.avgScoreByCourseToolStripMenuItem.Size = new System.Drawing.Size(236, 30);
            this.avgScoreByCourseToolStripMenuItem.Text = "Avg Score By Course";
            this.avgScoreByCourseToolStripMenuItem.Click += new System.EventHandler(this.avgScoreByCourseToolStripMenuItem_Click);
            // 
            // printToolStripMenuItem2
            // 
            this.printToolStripMenuItem2.AutoSize = false;
            this.printToolStripMenuItem2.Image = global::AddStudent.Properties.Resources.style_icons_system_intro_principles_intuitive;
            this.printToolStripMenuItem2.Name = "printToolStripMenuItem2";
            this.printToolStripMenuItem2.Size = new System.Drawing.Size(236, 30);
            this.printToolStripMenuItem2.Text = "Print";
            this.printToolStripMenuItem2.Click += new System.EventHandler(this.printToolStripMenuItem2_Click);
            // 
            // resuitToolStripMenuItem
            // 
            this.resuitToolStripMenuItem.AutoSize = false;
            this.resuitToolStripMenuItem.Image = global::AddStudent.Properties.Resources.star_rating_credit_score_icon_260nw_1726501390;
            this.resuitToolStripMenuItem.Name = "resuitToolStripMenuItem";
            this.resuitToolStripMenuItem.Size = new System.Drawing.Size(236, 30);
            this.resuitToolStripMenuItem.Text = "Result";
            this.resuitToolStripMenuItem.Click += new System.EventHandler(this.resuitToolStripMenuItem_Click);
            // 
            // resultToolStripMenuItem
            // 
            this.resultToolStripMenuItem.AutoSize = false;
            this.resultToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.avgResultByScoreToolStripMenuItem,
            this.staticToolStripMenuItem});
            this.resultToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultToolStripMenuItem.Image = global::AddStudent.Properties.Resources._2196166;
            this.resultToolStripMenuItem.Name = "resultToolStripMenuItem";
            this.resultToolStripMenuItem.Size = new System.Drawing.Size(120, 40);
            this.resultToolStripMenuItem.Text = "Result";
            // 
            // avgResultByScoreToolStripMenuItem
            // 
            this.avgResultByScoreToolStripMenuItem.AutoSize = false;
            this.avgResultByScoreToolStripMenuItem.Image = global::AddStudent.Properties.Resources.podium;
            this.avgResultByScoreToolStripMenuItem.Name = "avgResultByScoreToolStripMenuItem";
            this.avgResultByScoreToolStripMenuItem.Size = new System.Drawing.Size(232, 30);
            this.avgResultByScoreToolStripMenuItem.Text = "Avg Result By Score";
            this.avgResultByScoreToolStripMenuItem.Click += new System.EventHandler(this.avgResultByScoreToolStripMenuItem_Click);
            // 
            // staticToolStripMenuItem
            // 
            this.staticToolStripMenuItem.AutoSize = false;
            this.staticToolStripMenuItem.Image = global::AddStudent.Properties.Resources.scoring_chart_board_presentation_chart_512;
            this.staticToolStripMenuItem.Name = "staticToolStripMenuItem";
            this.staticToolStripMenuItem.Size = new System.Drawing.Size(232, 30);
            this.staticToolStripMenuItem.Text = "Statics Result";
            this.staticToolStripMenuItem.Click += new System.EventHandler(this.staticToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(652, 284);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem studentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addStudentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentsListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem staticsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editRemoveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageStudentFormToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem courseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addCourseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeCourseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editCourseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem scoreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addScoreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeScoreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageScoreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem avgScoreByCourseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem resuitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resultToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem avgResultByScoreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem staticToolStripMenuItem;
    }
}

