namespace CourseScheduling
{
    partial class EditTeacherFrm
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
            this.TeacherDataGridView = new System.Windows.Forms.DataGridView();
            this.BtnAddTeacher = new System.Windows.Forms.Button();
            this.teacherID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TeacherName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.TeacherDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // TeacherDataGridView
            // 
            this.TeacherDataGridView.AllowUserToAddRows = false;
            this.TeacherDataGridView.AllowUserToDeleteRows = false;
            this.TeacherDataGridView.AllowUserToResizeRows = false;
            this.TeacherDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TeacherDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.TeacherDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.teacherID,
            this.TeacherName,
            this.Delete});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.TeacherDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.TeacherDataGridView.Location = new System.Drawing.Point(13, 13);
            this.TeacherDataGridView.Name = "TeacherDataGridView";
            this.TeacherDataGridView.RowHeadersVisible = false;
            this.TeacherDataGridView.RowTemplate.Height = 30;
            this.TeacherDataGridView.Size = new System.Drawing.Size(542, 255);
            this.TeacherDataGridView.TabIndex = 0;
            this.TeacherDataGridView.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.TeacherDataGridView_CellBeginEdit);
            this.TeacherDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TeacherDataGridView_CellContentClick);
            this.TeacherDataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.TeacherDataGridView_CellValueChanged);
            // 
            // BtnAddTeacher
            // 
            this.BtnAddTeacher.Location = new System.Drawing.Point(13, 275);
            this.BtnAddTeacher.Name = "BtnAddTeacher";
            this.BtnAddTeacher.Size = new System.Drawing.Size(542, 46);
            this.BtnAddTeacher.TabIndex = 1;
            this.BtnAddTeacher.Text = "添加新教师";
            this.BtnAddTeacher.UseVisualStyleBackColor = true;
            this.BtnAddTeacher.Click += new System.EventHandler(this.BtnAddTeacher_Click);
            // 
            // teacherID
            // 
            this.teacherID.HeaderText = "教师ID";
            this.teacherID.Name = "teacherID";
            this.teacherID.ReadOnly = true;
            // 
            // TeacherName
            // 
            this.TeacherName.HeaderText = "教师姓名";
            this.TeacherName.Name = "TeacherName";
            this.TeacherName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Delete
            // 
            this.Delete.HeaderText = "删除教师";
            this.Delete.Name = "Delete";
            this.Delete.Text = "删除";
            this.Delete.UseColumnTextForButtonValue = true;
            // 
            // EditTeacherFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 334);
            this.Controls.Add(this.BtnAddTeacher);
            this.Controls.Add(this.TeacherDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditTeacherFrm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "编辑教师信息";
            this.Shown += new System.EventHandler(this.EditTeacherFrm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.TeacherDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView TeacherDataGridView;
        private System.Windows.Forms.Button BtnAddTeacher;
        private System.Windows.Forms.DataGridViewTextBoxColumn teacherID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TeacherName;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
    }
}