namespace CourseScheduling
{
    partial class ChooseCourseFrm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.CourseDataGridView = new System.Windows.Forms.DataGridView();
            this.ChooseCourse = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.CourseName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Grade = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Teacher = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.VipInfo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.CourseDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // CourseDataGridView
            // 
            this.CourseDataGridView.AllowUserToAddRows = false;
            this.CourseDataGridView.AllowUserToDeleteRows = false;
            this.CourseDataGridView.AllowUserToResizeRows = false;
            this.CourseDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CourseDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.CourseDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CourseName,
            this.Grade,
            this.Teacher,
            this.VipInfo});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.CourseDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.CourseDataGridView.Location = new System.Drawing.Point(12, 12);
            this.CourseDataGridView.Name = "CourseDataGridView";
            this.CourseDataGridView.ReadOnly = true;
            this.CourseDataGridView.RowHeadersVisible = false;
            this.CourseDataGridView.RowTemplate.Height = 30;
            this.CourseDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CourseDataGridView.Size = new System.Drawing.Size(1001, 426);
            this.CourseDataGridView.TabIndex = 0;
            // 
            // ChooseCourse
            // 
            this.ChooseCourse.Location = new System.Drawing.Point(13, 445);
            this.ChooseCourse.Name = "ChooseCourse";
            this.ChooseCourse.Size = new System.Drawing.Size(491, 45);
            this.ChooseCourse.TabIndex = 1;
            this.ChooseCourse.Text = "确定";
            this.ChooseCourse.UseVisualStyleBackColor = true;
            this.ChooseCourse.Click += new System.EventHandler(this.ChooseCourse_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.Location = new System.Drawing.Point(522, 445);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(491, 45);
            this.CancelBtn.TabIndex = 1;
            this.CancelBtn.Text = "取消";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // CourseName
            // 
            this.CourseName.HeaderText = "课程名";
            this.CourseName.Name = "CourseName";
            this.CourseName.ReadOnly = true;
            this.CourseName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Grade
            // 
            this.Grade.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.Grade.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Grade.HeaderText = "年级";
            this.Grade.Name = "Grade";
            this.Grade.ReadOnly = true;
            this.Grade.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Teacher
            // 
            this.Teacher.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.Teacher.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Teacher.HeaderText = "教师";
            this.Teacher.Name = "Teacher";
            this.Teacher.ReadOnly = true;
            this.Teacher.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // VipInfo
            // 
            this.VipInfo.HeaderText = "VIP信息";
            this.VipInfo.Name = "VipInfo";
            this.VipInfo.ReadOnly = true;
            this.VipInfo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ChooseCourseFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 502);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.ChooseCourse);
            this.Controls.Add(this.CourseDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChooseCourseFrm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "选择课程";
            this.Shown += new System.EventHandler(this.EditCourseFrm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.CourseDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView CourseDataGridView;
        private System.Windows.Forms.Button ChooseCourse;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CourseName;
        private System.Windows.Forms.DataGridViewComboBoxColumn Grade;
        private System.Windows.Forms.DataGridViewComboBoxColumn Teacher;
        private System.Windows.Forms.DataGridViewTextBoxColumn VipInfo;
    }
}