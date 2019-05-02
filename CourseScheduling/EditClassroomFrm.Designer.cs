namespace CourseScheduling
{
    partial class EditClassroomFrm
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
            this.ClassroomDataGridView = new System.Windows.Forms.DataGridView();
            this.BtnAddClassroom = new System.Windows.Forms.Button();
            this.selectColor = new System.Windows.Forms.ColorDialog();
            this.ClassroomName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClassroomColor = new System.Windows.Forms.DataGridViewImageColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ClassroomDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ClassroomDataGridView
            // 
            this.ClassroomDataGridView.AllowUserToAddRows = false;
            this.ClassroomDataGridView.AllowUserToDeleteRows = false;
            this.ClassroomDataGridView.AllowUserToResizeColumns = false;
            this.ClassroomDataGridView.AllowUserToResizeRows = false;
            this.ClassroomDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ClassroomDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.ClassroomDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClassroomName,
            this.ClassroomColor,
            this.Delete});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ClassroomDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.ClassroomDataGridView.Location = new System.Drawing.Point(13, 13);
            this.ClassroomDataGridView.Name = "ClassroomDataGridView";
            this.ClassroomDataGridView.RowHeadersVisible = false;
            this.ClassroomDataGridView.RowTemplate.Height = 30;
            this.ClassroomDataGridView.Size = new System.Drawing.Size(775, 368);
            this.ClassroomDataGridView.TabIndex = 0;
            this.ClassroomDataGridView.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.ClassroomDataGridView_CellBeginEdit);
            this.ClassroomDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ClassroomDataGridView_CellContentClick);
            this.ClassroomDataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.ClassroomDataGridView_CellValueChanged);
            // 
            // BtnAddClassroom
            // 
            this.BtnAddClassroom.Location = new System.Drawing.Point(13, 388);
            this.BtnAddClassroom.Name = "BtnAddClassroom";
            this.BtnAddClassroom.Size = new System.Drawing.Size(775, 50);
            this.BtnAddClassroom.TabIndex = 1;
            this.BtnAddClassroom.Text = "添加新教室";
            this.BtnAddClassroom.UseVisualStyleBackColor = true;
            this.BtnAddClassroom.Click += new System.EventHandler(this.BtnAddClassroom_Click);
            // 
            // ClassroomName
            // 
            this.ClassroomName.HeaderText = "教室名";
            this.ClassroomName.Name = "ClassroomName";
            this.ClassroomName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ClassroomColor
            // 
            this.ClassroomColor.HeaderText = "教室代表颜色";
            this.ClassroomColor.Name = "ClassroomColor";
            // 
            // Delete
            // 
            this.Delete.HeaderText = "删除教室";
            this.Delete.Name = "Delete";
            this.Delete.Text = "删除";
            this.Delete.UseColumnTextForButtonValue = true;
            // 
            // EditClassroomFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnAddClassroom);
            this.Controls.Add(this.ClassroomDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditClassroomFrm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "编辑教室信息";
            this.Shown += new System.EventHandler(this.EditClassroomFrm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.ClassroomDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ClassroomDataGridView;
        private System.Windows.Forms.Button BtnAddClassroom;
        private System.Windows.Forms.ColorDialog selectColor;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClassroomName;
        private System.Windows.Forms.DataGridViewImageColumn ClassroomColor;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
    }
}