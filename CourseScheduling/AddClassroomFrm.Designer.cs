namespace CourseScheduling
{
    partial class AddClassroomFrm
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
            this.lblClassroomName = new System.Windows.Forms.Label();
            this.txtClassroomName = new System.Windows.Forms.TextBox();
            this.BtnAddClassroom = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnSelectColor = new System.Windows.Forms.Button();
            this.selectColor = new System.Windows.Forms.ColorDialog();
            this.SuspendLayout();
            // 
            // lblClassroomName
            // 
            this.lblClassroomName.AutoSize = true;
            this.lblClassroomName.Location = new System.Drawing.Point(13, 24);
            this.lblClassroomName.Name = "lblClassroomName";
            this.lblClassroomName.Size = new System.Drawing.Size(98, 18);
            this.lblClassroomName.TabIndex = 0;
            this.lblClassroomName.Text = "教室名称：";
            // 
            // txtClassroomName
            // 
            this.txtClassroomName.Location = new System.Drawing.Point(117, 21);
            this.txtClassroomName.Name = "txtClassroomName";
            this.txtClassroomName.Size = new System.Drawing.Size(158, 28);
            this.txtClassroomName.TabIndex = 2;
            // 
            // BtnAddClassroom
            // 
            this.BtnAddClassroom.Location = new System.Drawing.Point(12, 138);
            this.BtnAddClassroom.Name = "BtnAddClassroom";
            this.BtnAddClassroom.Size = new System.Drawing.Size(121, 52);
            this.BtnAddClassroom.TabIndex = 3;
            this.BtnAddClassroom.Text = "添加教室";
            this.BtnAddClassroom.UseVisualStyleBackColor = true;
            this.BtnAddClassroom.Click += new System.EventHandler(this.BtnAddClassroom_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Location = new System.Drawing.Point(154, 138);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(121, 52);
            this.BtnCancel.TabIndex = 4;
            this.BtnCancel.Text = "取消";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // BtnSelectColor
            // 
            this.BtnSelectColor.Location = new System.Drawing.Point(16, 68);
            this.BtnSelectColor.Name = "BtnSelectColor";
            this.BtnSelectColor.Size = new System.Drawing.Size(259, 52);
            this.BtnSelectColor.TabIndex = 3;
            this.BtnSelectColor.Text = "选择教室颜色";
            this.BtnSelectColor.UseVisualStyleBackColor = true;
            this.BtnSelectColor.Click += new System.EventHandler(this.BtnSelectColor_Click);
            // 
            // selectColor
            // 
            this.selectColor.AnyColor = true;
            this.selectColor.FullOpen = true;
            // 
            // AddClassroomFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 212);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnSelectColor);
            this.Controls.Add(this.BtnAddClassroom);
            this.Controls.Add(this.txtClassroomName);
            this.Controls.Add(this.lblClassroomName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddClassroomFrm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "添加教室";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblClassroomName;
        private System.Windows.Forms.TextBox txtClassroomName;
        private System.Windows.Forms.Button BtnAddClassroom;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Button BtnSelectColor;
        private System.Windows.Forms.ColorDialog selectColor;
    }
}