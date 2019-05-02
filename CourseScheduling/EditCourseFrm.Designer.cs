namespace CourseScheduling
{
    partial class EditCourseFrm
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
            this.CourseName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Grade = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Teacher = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.VipInfo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.BtnAddCourse = new System.Windows.Forms.Button();
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
            this.VipInfo,
            this.Delete});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.CourseDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.CourseDataGridView.Location = new System.Drawing.Point(12, 12);
            this.CourseDataGridView.Name = "CourseDataGridView";
            this.CourseDataGridView.RowHeadersVisible = false;
            this.CourseDataGridView.RowTemplate.Height = 30;
            this.CourseDataGridView.Size = new System.Drawing.Size(1001, 426);
            this.CourseDataGridView.TabIndex = 0;
            this.CourseDataGridView.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.CourseDataGridView_CellBeginEdit);
            this.CourseDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CourseDataGridView_CellContentClick);
            this.CourseDataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.CourseDataGridView_CellValueChanged);
            this.CourseDataGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.CourseDataGridView_DataError);
            // 
            // CourseName
            // 
            this.CourseName.HeaderText = "课程名";
            this.CourseName.Name = "CourseName";
            this.CourseName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Grade
            // 
            this.Grade.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.Grade.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Grade.HeaderText = "年级";
            this.Grade.Name = "Grade";
            // 
            // Teacher
            // 
            this.Teacher.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.Teacher.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Teacher.HeaderText = "教师";
            this.Teacher.Name = "Teacher";
            // 
            // VipInfo
            // 
            this.VipInfo.HeaderText = "VIP信息";
            this.VipInfo.Name = "VipInfo";
            this.VipInfo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Delete
            // 
            this.Delete.HeaderText = "删除课程";
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Text = "删除";
            this.Delete.UseColumnTextForButtonValue = true;
            // 
            // BtnAddCourse
            // 
            this.BtnAddCourse.Location = new System.Drawing.Point(13, 445);
            this.BtnAddCourse.Name = "BtnAddCourse";
            this.BtnAddCourse.Size = new System.Drawing.Size(1000, 45);
            this.BtnAddCourse.TabIndex = 1;
            this.BtnAddCourse.Text = "添加新课程";
            this.BtnAddCourse.UseVisualStyleBackColor = true;
            this.BtnAddCourse.Click += new System.EventHandler(this.BtnAddCourse_Click);
            // 
            // EditCourseFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 502);
            this.Controls.Add(this.BtnAddCourse);
            this.Controls.Add(this.CourseDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditCourseFrm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "编辑课程信息";
            this.Shown += new System.EventHandler(this.EditCourseFrm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.CourseDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView CourseDataGridView;
        private System.Windows.Forms.Button BtnAddCourse;
        private System.Windows.Forms.DataGridViewTextBoxColumn CourseName;
        private System.Windows.Forms.DataGridViewComboBoxColumn Grade;
        private System.Windows.Forms.DataGridViewComboBoxColumn Teacher;
        private System.Windows.Forms.DataGridViewTextBoxColumn VipInfo;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
    }
}