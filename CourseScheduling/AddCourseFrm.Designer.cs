namespace CourseScheduling
{
    partial class AddCourseFrm
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
            this.lblCourseName = new System.Windows.Forms.Label();
            this.lblCourseGrade = new System.Windows.Forms.Label();
            this.lblCourseVipInfo = new System.Windows.Forms.Label();
            this.btnAddCourse = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.comboxCourseGrade = new System.Windows.Forms.ComboBox();
            this.txtCourseName = new System.Windows.Forms.TextBox();
            this.txtCourseVipInfo = new System.Windows.Forms.TextBox();
            this.lblTeacherInfo = new System.Windows.Forms.Label();
            this.comboxTeacherInfo = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblCourseName
            // 
            this.lblCourseName.AutoSize = true;
            this.lblCourseName.Location = new System.Drawing.Point(15, 33);
            this.lblCourseName.Name = "lblCourseName";
            this.lblCourseName.Size = new System.Drawing.Size(98, 18);
            this.lblCourseName.TabIndex = 0;
            this.lblCourseName.Text = "课程名称：";
            // 
            // lblCourseGrade
            // 
            this.lblCourseGrade.AutoSize = true;
            this.lblCourseGrade.Location = new System.Drawing.Point(15, 101);
            this.lblCourseGrade.Name = "lblCourseGrade";
            this.lblCourseGrade.Size = new System.Drawing.Size(98, 18);
            this.lblCourseGrade.TabIndex = 1;
            this.lblCourseGrade.Text = "课程年级：";
            // 
            // lblCourseVipInfo
            // 
            this.lblCourseVipInfo.AutoSize = true;
            this.lblCourseVipInfo.Location = new System.Drawing.Point(15, 67);
            this.lblCourseVipInfo.Name = "lblCourseVipInfo";
            this.lblCourseVipInfo.Size = new System.Drawing.Size(125, 18);
            this.lblCourseVipInfo.TabIndex = 2;
            this.lblCourseVipInfo.Text = "课程VIP信息：";
            // 
            // btnAddCourse
            // 
            this.btnAddCourse.Location = new System.Drawing.Point(38, 176);
            this.btnAddCourse.Name = "btnAddCourse";
            this.btnAddCourse.Size = new System.Drawing.Size(122, 48);
            this.btnAddCourse.TabIndex = 3;
            this.btnAddCourse.Text = "添加课程";
            this.btnAddCourse.UseVisualStyleBackColor = true;
            this.btnAddCourse.Click += new System.EventHandler(this.BtnAddCourse_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(180, 176);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(122, 48);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // comboxCourseGrade
            // 
            this.comboxCourseGrade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboxCourseGrade.FormattingEnabled = true;
            this.comboxCourseGrade.Location = new System.Drawing.Point(146, 98);
            this.comboxCourseGrade.Name = "comboxCourseGrade";
            this.comboxCourseGrade.Size = new System.Drawing.Size(174, 26);
            this.comboxCourseGrade.TabIndex = 5;
            // 
            // txtCourseName
            // 
            this.txtCourseName.Location = new System.Drawing.Point(146, 30);
            this.txtCourseName.Name = "txtCourseName";
            this.txtCourseName.Size = new System.Drawing.Size(175, 28);
            this.txtCourseName.TabIndex = 6;
            // 
            // txtCourseVipInfo
            // 
            this.txtCourseVipInfo.Location = new System.Drawing.Point(146, 64);
            this.txtCourseVipInfo.Name = "txtCourseVipInfo";
            this.txtCourseVipInfo.Size = new System.Drawing.Size(174, 28);
            this.txtCourseVipInfo.TabIndex = 7;
            // 
            // lblTeacherInfo
            // 
            this.lblTeacherInfo.AutoSize = true;
            this.lblTeacherInfo.Location = new System.Drawing.Point(15, 133);
            this.lblTeacherInfo.Name = "lblTeacherInfo";
            this.lblTeacherInfo.Size = new System.Drawing.Size(98, 18);
            this.lblTeacherInfo.TabIndex = 1;
            this.lblTeacherInfo.Text = "教师信息：";
            // 
            // comboxTeacherInfo
            // 
            this.comboxTeacherInfo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboxTeacherInfo.FormattingEnabled = true;
            this.comboxTeacherInfo.Location = new System.Drawing.Point(146, 130);
            this.comboxTeacherInfo.Name = "comboxTeacherInfo";
            this.comboxTeacherInfo.Size = new System.Drawing.Size(174, 26);
            this.comboxTeacherInfo.TabIndex = 5;
            // 
            // AddCourseFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 247);
            this.Controls.Add(this.txtCourseVipInfo);
            this.Controls.Add(this.txtCourseName);
            this.Controls.Add(this.comboxTeacherInfo);
            this.Controls.Add(this.comboxCourseGrade);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAddCourse);
            this.Controls.Add(this.lblCourseVipInfo);
            this.Controls.Add(this.lblTeacherInfo);
            this.Controls.Add(this.lblCourseGrade);
            this.Controls.Add(this.lblCourseName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddCourseFrm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "添加课程";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCourseName;
        private System.Windows.Forms.Label lblCourseGrade;
        private System.Windows.Forms.Label lblCourseVipInfo;
        private System.Windows.Forms.Button btnAddCourse;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ComboBox comboxCourseGrade;
        private System.Windows.Forms.TextBox txtCourseName;
        private System.Windows.Forms.TextBox txtCourseVipInfo;
        private System.Windows.Forms.Label lblTeacherInfo;
        private System.Windows.Forms.ComboBox comboxTeacherInfo;
    }
}