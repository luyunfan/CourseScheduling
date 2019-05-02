namespace CourseScheduling
{
    partial class SchedulingResultFrm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ResultDataGridView = new System.Windows.Forms.DataGridView();
            this.OKBtn = new System.Windows.Forms.Button();
            this.ExportExcelBtn = new System.Windows.Forms.Button();
            this.ClassroomDataGridView = new System.Windows.Forms.DataGridView();
            this.ClassroomInfo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LblShowCount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ResultDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClassroomDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ResultDataGridView
            // 
            this.ResultDataGridView.AllowUserToAddRows = false;
            this.ResultDataGridView.AllowUserToDeleteRows = false;
            this.ResultDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ResultDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.ResultDataGridView.ColumnHeadersHeight = 50;
            this.ResultDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ResultDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.ResultDataGridView.Location = new System.Drawing.Point(12, 59);
            this.ResultDataGridView.Name = "ResultDataGridView";
            this.ResultDataGridView.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ResultDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.ResultDataGridView.RowHeadersWidth = 160;
            this.ResultDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.ResultDataGridView.RowTemplate.Height = 30;
            this.ResultDataGridView.Size = new System.Drawing.Size(1082, 446);
            this.ResultDataGridView.TabIndex = 0;
            // 
            // OKBtn
            // 
            this.OKBtn.Location = new System.Drawing.Point(11, 522);
            this.OKBtn.Name = "OKBtn";
            this.OKBtn.Size = new System.Drawing.Size(655, 61);
            this.OKBtn.TabIndex = 1;
            this.OKBtn.Text = "确定";
            this.OKBtn.UseVisualStyleBackColor = true;
            this.OKBtn.Click += new System.EventHandler(this.OKBtn_Click);
            // 
            // ExportExcelBtn
            // 
            this.ExportExcelBtn.Location = new System.Drawing.Point(685, 522);
            this.ExportExcelBtn.Name = "ExportExcelBtn";
            this.ExportExcelBtn.Size = new System.Drawing.Size(655, 61);
            this.ExportExcelBtn.TabIndex = 1;
            this.ExportExcelBtn.Text = "导出到Excel";
            this.ExportExcelBtn.UseVisualStyleBackColor = true;
            this.ExportExcelBtn.Click += new System.EventHandler(this.ExportExcelBtn_Click);
            // 
            // ClassroomDataGridView
            // 
            this.ClassroomDataGridView.AllowUserToAddRows = false;
            this.ClassroomDataGridView.AllowUserToDeleteRows = false;
            this.ClassroomDataGridView.AllowUserToResizeColumns = false;
            this.ClassroomDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ClassroomDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.ClassroomDataGridView.ColumnHeadersHeight = 50;
            this.ClassroomDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.ClassroomDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClassroomInfo});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ClassroomDataGridView.DefaultCellStyle = dataGridViewCellStyle5;
            this.ClassroomDataGridView.Location = new System.Drawing.Point(1100, 59);
            this.ClassroomDataGridView.Name = "ClassroomDataGridView";
            this.ClassroomDataGridView.ReadOnly = true;
            this.ClassroomDataGridView.RowHeadersVisible = false;
            this.ClassroomDataGridView.RowTemplate.Height = 30;
            this.ClassroomDataGridView.Size = new System.Drawing.Size(240, 446);
            this.ClassroomDataGridView.TabIndex = 2;
            // 
            // ClassroomInfo
            // 
            this.ClassroomInfo.HeaderText = "教室";
            this.ClassroomInfo.Name = "ClassroomInfo";
            this.ClassroomInfo.ReadOnly = true;
            this.ClassroomInfo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // LblShowCount
            // 
            this.LblShowCount.AutoSize = true;
            this.LblShowCount.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LblShowCount.Location = new System.Drawing.Point(12, 19);
            this.LblShowCount.Name = "LblShowCount";
            this.LblShowCount.Size = new System.Drawing.Size(180, 28);
            this.LblShowCount.TabIndex = 3;
            this.LblShowCount.Text = "排课数目统计";
            // 
            // SchedulingResultFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1353, 596);
            this.Controls.Add(this.LblShowCount);
            this.Controls.Add(this.ClassroomDataGridView);
            this.Controls.Add(this.ExportExcelBtn);
            this.Controls.Add(this.OKBtn);
            this.Controls.Add(this.ResultDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "SchedulingResultFrm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "排课结果";
            ((System.ComponentModel.ISupportInitialize)(this.ResultDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClassroomDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ResultDataGridView;
        private System.Windows.Forms.Button OKBtn;
        private System.Windows.Forms.Button ExportExcelBtn;
        private System.Windows.Forms.DataGridView ClassroomDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClassroomInfo;
        private System.Windows.Forms.Label LblShowCount;
    }
}