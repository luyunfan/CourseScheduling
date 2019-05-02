namespace CourseScheduling
{
    partial class EditGradeFrm
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
            this.GradeDataGridView = new System.Windows.Forms.DataGridView();
            this.GradeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.GradeDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // GradeDataGridView
            // 
            this.GradeDataGridView.AllowUserToResizeColumns = false;
            this.GradeDataGridView.AllowUserToResizeRows = false;
            this.GradeDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GradeDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.GradeDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.GradeName});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GradeDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.GradeDataGridView.Location = new System.Drawing.Point(12, 12);
            this.GradeDataGridView.Name = "GradeDataGridView";
            this.GradeDataGridView.RowHeadersVisible = false;
            this.GradeDataGridView.RowTemplate.Height = 30;
            this.GradeDataGridView.Size = new System.Drawing.Size(587, 426);
            this.GradeDataGridView.TabIndex = 0;
            this.GradeDataGridView.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.GradeDataGridView_CellBeginEdit);
            this.GradeDataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.GradeDataGridView_CellValueChanged);
            // 
            // GradeName
            // 
            this.GradeName.HeaderText = "年级名称";
            this.GradeName.Name = "GradeName";
            this.GradeName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // EditGradeFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 450);
            this.Controls.Add(this.GradeDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditGradeFrm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "年级管理";
            this.Shown += new System.EventHandler(this.GradeEditFrm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.GradeDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView GradeDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn GradeName;
    }
}