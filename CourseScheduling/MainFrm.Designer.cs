namespace CourseScheduling
{
    partial class MainFrm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFrm));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.CourseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddCourseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditCourseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TeacherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddTeacherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditTeacherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ClassRoomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddClassroomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditClassroomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GradeEditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ClearDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddCourseBtn = new System.Windows.Forms.Button();
            this.AddTeacherBtn = new System.Windows.Forms.Button();
            this.AddClassroomBtn = new System.Windows.Forms.Button();
            this.ChooseCourseBtn = new System.Windows.Forms.Button();
            this.ChooseClassroomBtn = new System.Windows.Forms.Button();
            this.SchedulingBtn = new System.Windows.Forms.Button();
            this.NeedCourseDataGridView = new System.Windows.Forms.DataGridView();
            this.NeedCourse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NeedClassroomDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NeedCourseDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NeedClassroomDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CourseToolStripMenuItem,
            this.TeacherToolStripMenuItem,
            this.ClassRoomToolStripMenuItem,
            this.GradeEditToolStripMenuItem,
            this.ClearDataToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(800, 32);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "菜单栏";
            // 
            // CourseToolStripMenuItem
            // 
            this.CourseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddCourseToolStripMenuItem,
            this.EditCourseToolStripMenuItem});
            this.CourseToolStripMenuItem.Name = "CourseToolStripMenuItem";
            this.CourseToolStripMenuItem.Size = new System.Drawing.Size(58, 28);
            this.CourseToolStripMenuItem.Text = "课程";
            // 
            // AddCourseToolStripMenuItem
            // 
            this.AddCourseToolStripMenuItem.Name = "AddCourseToolStripMenuItem";
            this.AddCourseToolStripMenuItem.Size = new System.Drawing.Size(200, 30);
            this.AddCourseToolStripMenuItem.Text = "添加课程信息";
            this.AddCourseToolStripMenuItem.Click += new System.EventHandler(this.AddCourseToolStripMenuItem_Click);
            // 
            // EditCourseToolStripMenuItem
            // 
            this.EditCourseToolStripMenuItem.Name = "EditCourseToolStripMenuItem";
            this.EditCourseToolStripMenuItem.Size = new System.Drawing.Size(200, 30);
            this.EditCourseToolStripMenuItem.Text = "编辑课程信息";
            this.EditCourseToolStripMenuItem.Click += new System.EventHandler(this.EditCourseToolStripMenuItem_Click);
            // 
            // TeacherToolStripMenuItem
            // 
            this.TeacherToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddTeacherToolStripMenuItem,
            this.EditTeacherToolStripMenuItem});
            this.TeacherToolStripMenuItem.Name = "TeacherToolStripMenuItem";
            this.TeacherToolStripMenuItem.Size = new System.Drawing.Size(58, 28);
            this.TeacherToolStripMenuItem.Text = "教师";
            // 
            // AddTeacherToolStripMenuItem
            // 
            this.AddTeacherToolStripMenuItem.Name = "AddTeacherToolStripMenuItem";
            this.AddTeacherToolStripMenuItem.Size = new System.Drawing.Size(200, 30);
            this.AddTeacherToolStripMenuItem.Text = "添加教师信息";
            this.AddTeacherToolStripMenuItem.Click += new System.EventHandler(this.AddTeacherToolStripMenuItem_Click);
            // 
            // EditTeacherToolStripMenuItem
            // 
            this.EditTeacherToolStripMenuItem.Name = "EditTeacherToolStripMenuItem";
            this.EditTeacherToolStripMenuItem.Size = new System.Drawing.Size(200, 30);
            this.EditTeacherToolStripMenuItem.Text = "编辑教师信息";
            this.EditTeacherToolStripMenuItem.Click += new System.EventHandler(this.EditTeacherToolStripMenuItem_Click);
            // 
            // ClassRoomToolStripMenuItem
            // 
            this.ClassRoomToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddClassroomToolStripMenuItem,
            this.EditClassroomToolStripMenuItem});
            this.ClassRoomToolStripMenuItem.Name = "ClassRoomToolStripMenuItem";
            this.ClassRoomToolStripMenuItem.Size = new System.Drawing.Size(58, 28);
            this.ClassRoomToolStripMenuItem.Text = "教室";
            // 
            // AddClassroomToolStripMenuItem
            // 
            this.AddClassroomToolStripMenuItem.Name = "AddClassroomToolStripMenuItem";
            this.AddClassroomToolStripMenuItem.Size = new System.Drawing.Size(200, 30);
            this.AddClassroomToolStripMenuItem.Text = "添加教室信息";
            this.AddClassroomToolStripMenuItem.Click += new System.EventHandler(this.AddClassroomToolStripMenuItem_Click);
            // 
            // EditClassroomToolStripMenuItem
            // 
            this.EditClassroomToolStripMenuItem.Name = "EditClassroomToolStripMenuItem";
            this.EditClassroomToolStripMenuItem.Size = new System.Drawing.Size(200, 30);
            this.EditClassroomToolStripMenuItem.Text = "编辑教室信息";
            this.EditClassroomToolStripMenuItem.Click += new System.EventHandler(this.EditClassroomToolStripMenuItem_Click);
            // 
            // GradeEditToolStripMenuItem
            // 
            this.GradeEditToolStripMenuItem.Name = "GradeEditToolStripMenuItem";
            this.GradeEditToolStripMenuItem.Size = new System.Drawing.Size(94, 28);
            this.GradeEditToolStripMenuItem.Text = "年级管理";
            this.GradeEditToolStripMenuItem.Click += new System.EventHandler(this.GradeEditToolStripMenuItem_Click);
            // 
            // ClearDataToolStripMenuItem
            // 
            this.ClearDataToolStripMenuItem.Name = "ClearDataToolStripMenuItem";
            this.ClearDataToolStripMenuItem.Size = new System.Drawing.Size(130, 28);
            this.ClearDataToolStripMenuItem.Text = "清空所有数据";
            this.ClearDataToolStripMenuItem.Click += new System.EventHandler(this.ClearDataToolStripMenuItem_Click);
            // 
            // AddCourseBtn
            // 
            this.AddCourseBtn.Location = new System.Drawing.Point(29, 47);
            this.AddCourseBtn.Name = "AddCourseBtn";
            this.AddCourseBtn.Size = new System.Drawing.Size(216, 55);
            this.AddCourseBtn.TabIndex = 1;
            this.AddCourseBtn.Text = "添加新课程";
            this.AddCourseBtn.UseVisualStyleBackColor = true;
            this.AddCourseBtn.Click += new System.EventHandler(this.AddCourseBtn_Click);
            // 
            // AddTeacherBtn
            // 
            this.AddTeacherBtn.Location = new System.Drawing.Point(290, 46);
            this.AddTeacherBtn.Name = "AddTeacherBtn";
            this.AddTeacherBtn.Size = new System.Drawing.Size(216, 56);
            this.AddTeacherBtn.TabIndex = 2;
            this.AddTeacherBtn.Text = "添加新教师";
            this.AddTeacherBtn.UseVisualStyleBackColor = true;
            this.AddTeacherBtn.Click += new System.EventHandler(this.AddTeacherBtn_Click);
            // 
            // AddClassroomBtn
            // 
            this.AddClassroomBtn.Location = new System.Drawing.Point(551, 47);
            this.AddClassroomBtn.Name = "AddClassroomBtn";
            this.AddClassroomBtn.Size = new System.Drawing.Size(217, 55);
            this.AddClassroomBtn.TabIndex = 3;
            this.AddClassroomBtn.Text = "添加新教室";
            this.AddClassroomBtn.UseVisualStyleBackColor = true;
            this.AddClassroomBtn.Click += new System.EventHandler(this.AddClassroomBtn_Click);
            // 
            // ChooseCourseBtn
            // 
            this.ChooseCourseBtn.Location = new System.Drawing.Point(29, 126);
            this.ChooseCourseBtn.Name = "ChooseCourseBtn";
            this.ChooseCourseBtn.Size = new System.Drawing.Size(352, 55);
            this.ChooseCourseBtn.TabIndex = 4;
            this.ChooseCourseBtn.Text = "选择要安排的课程";
            this.ChooseCourseBtn.UseVisualStyleBackColor = true;
            this.ChooseCourseBtn.Click += new System.EventHandler(this.ChooseCourseBtn_Click);
            // 
            // ChooseClassroomBtn
            // 
            this.ChooseClassroomBtn.Location = new System.Drawing.Point(419, 126);
            this.ChooseClassroomBtn.Name = "ChooseClassroomBtn";
            this.ChooseClassroomBtn.Size = new System.Drawing.Size(352, 55);
            this.ChooseClassroomBtn.TabIndex = 4;
            this.ChooseClassroomBtn.Text = "选择要安排的教室";
            this.ChooseClassroomBtn.UseVisualStyleBackColor = true;
            this.ChooseClassroomBtn.Click += new System.EventHandler(this.ChooseClassroomBtn_Click);
            // 
            // SchedulingBtn
            // 
            this.SchedulingBtn.Location = new System.Drawing.Point(29, 434);
            this.SchedulingBtn.Name = "SchedulingBtn";
            this.SchedulingBtn.Size = new System.Drawing.Size(739, 55);
            this.SchedulingBtn.TabIndex = 4;
            this.SchedulingBtn.Text = "排课";
            this.SchedulingBtn.UseVisualStyleBackColor = true;
            this.SchedulingBtn.Click += new System.EventHandler(this.SchedulingBtn_Click);
            // 
            // NeedCourseDataGridView
            // 
            this.NeedCourseDataGridView.AllowUserToAddRows = false;
            this.NeedCourseDataGridView.AllowUserToDeleteRows = false;
            this.NeedCourseDataGridView.AllowUserToResizeColumns = false;
            this.NeedCourseDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.NeedCourseDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.NeedCourseDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NeedCourse});
            this.NeedCourseDataGridView.Location = new System.Drawing.Point(29, 197);
            this.NeedCourseDataGridView.Name = "NeedCourseDataGridView";
            this.NeedCourseDataGridView.ReadOnly = true;
            this.NeedCourseDataGridView.RowHeadersVisible = false;
            this.NeedCourseDataGridView.RowTemplate.Height = 30;
            this.NeedCourseDataGridView.Size = new System.Drawing.Size(352, 219);
            this.NeedCourseDataGridView.TabIndex = 5;
            // 
            // NeedCourse
            // 
            this.NeedCourse.HeaderText = "需要安排的课程";
            this.NeedCourse.Name = "NeedCourse";
            this.NeedCourse.ReadOnly = true;
            this.NeedCourse.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // NeedClassroomDataGridView
            // 
            this.NeedClassroomDataGridView.AllowUserToAddRows = false;
            this.NeedClassroomDataGridView.AllowUserToDeleteRows = false;
            this.NeedClassroomDataGridView.AllowUserToResizeColumns = false;
            this.NeedClassroomDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.NeedClassroomDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.NeedClassroomDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.NeedClassroomDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.NeedClassroomDataGridView.Location = new System.Drawing.Point(419, 197);
            this.NeedClassroomDataGridView.Name = "NeedClassroomDataGridView";
            this.NeedClassroomDataGridView.ReadOnly = true;
            this.NeedClassroomDataGridView.RowHeadersVisible = false;
            this.NeedClassroomDataGridView.RowTemplate.Height = 30;
            this.NeedClassroomDataGridView.Size = new System.Drawing.Size(352, 219);
            this.NeedClassroomDataGridView.TabIndex = 5;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "需要安排的教室";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 501);
            this.Controls.Add(this.NeedClassroomDataGridView);
            this.Controls.Add(this.NeedCourseDataGridView);
            this.Controls.Add(this.ChooseClassroomBtn);
            this.Controls.Add(this.SchedulingBtn);
            this.Controls.Add(this.ChooseCourseBtn);
            this.Controls.Add(this.AddClassroomBtn);
            this.Controls.Add(this.AddTeacherBtn);
            this.Controls.Add(this.AddCourseBtn);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.Name = "MainFrm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "智能排课";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NeedCourseDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NeedClassroomDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem CourseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddCourseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EditCourseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TeacherToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ClassRoomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddTeacherToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EditTeacherToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddClassroomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EditClassroomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem GradeEditToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ClearDataToolStripMenuItem;
        private System.Windows.Forms.Button AddCourseBtn;
        private System.Windows.Forms.Button AddTeacherBtn;
        private System.Windows.Forms.Button AddClassroomBtn;
        private System.Windows.Forms.Button ChooseCourseBtn;
        private System.Windows.Forms.Button ChooseClassroomBtn;
        private System.Windows.Forms.Button SchedulingBtn;
        private System.Windows.Forms.DataGridView NeedCourseDataGridView;
        private System.Windows.Forms.DataGridView NeedClassroomDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn NeedCourse;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    }
}