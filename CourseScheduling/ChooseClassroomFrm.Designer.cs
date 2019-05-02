namespace CourseScheduling
{
    partial class ChooseClassroomFrm
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
            this.ClassroomName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClassroomColor = new System.Windows.Forms.DataGridViewImageColumn();
            this.ChooseClassroomBtn = new System.Windows.Forms.Button();
            this.selectColor = new System.Windows.Forms.ColorDialog();
            this.CancelBtn = new System.Windows.Forms.Button();
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
            this.ClassroomColor});
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
            this.ClassroomDataGridView.ReadOnly = true;
            this.ClassroomDataGridView.RowHeadersVisible = false;
            this.ClassroomDataGridView.RowTemplate.Height = 30;
            this.ClassroomDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ClassroomDataGridView.Size = new System.Drawing.Size(775, 368);
            this.ClassroomDataGridView.TabIndex = 0;
            // 
            // ClassroomName
            // 
            this.ClassroomName.HeaderText = "教室名";
            this.ClassroomName.Name = "ClassroomName";
            this.ClassroomName.ReadOnly = true;
            this.ClassroomName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ClassroomColor
            // 
            this.ClassroomColor.HeaderText = "教室代表颜色";
            this.ClassroomColor.Name = "ClassroomColor";
            this.ClassroomColor.ReadOnly = true;
            // 
            // ChooseClassroomBtn
            // 
            this.ChooseClassroomBtn.Location = new System.Drawing.Point(13, 388);
            this.ChooseClassroomBtn.Name = "ChooseClassroomBtn";
            this.ChooseClassroomBtn.Size = new System.Drawing.Size(381, 50);
            this.ChooseClassroomBtn.TabIndex = 1;
            this.ChooseClassroomBtn.Text = "选择教室";
            this.ChooseClassroomBtn.UseVisualStyleBackColor = true;
            this.ChooseClassroomBtn.Click += new System.EventHandler(this.ChooseClassroomBtn_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.Location = new System.Drawing.Point(407, 388);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(381, 50);
            this.CancelBtn.TabIndex = 1;
            this.CancelBtn.Text = "取消";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // ChooseClassroomFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.ChooseClassroomBtn);
            this.Controls.Add(this.ClassroomDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChooseClassroomFrm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "选择教室";
            this.Shown += new System.EventHandler(this.EditClassroomFrm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.ClassroomDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ClassroomDataGridView;
        private System.Windows.Forms.Button ChooseClassroomBtn;
        private System.Windows.Forms.ColorDialog selectColor;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClassroomName;
        private System.Windows.Forms.DataGridViewImageColumn ClassroomColor;
    }
}