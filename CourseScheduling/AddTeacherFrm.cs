using CourseScheduling.dao;
using CourseScheduling.model;
using System;
using System.Windows.Forms;

namespace CourseScheduling
{
    public partial class AddTeacherFrm : Form
    {
        public AddTeacherFrm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 添加成功的教师对象
        /// </summary>
        private Teacher _addedTeacher;

        /// <summary>
        /// 添加成功的教师对象
        /// </summary>
        public Teacher AddedTeacher => _addedTeacher;


        /// <summary>
        /// 添加教师按钮
        /// </summary>
        private void BtnAddTeacher_Click(object sender, EventArgs e)
        {
            AddTeacher();
        }

        /// <summary>
        /// 添加教师的实际动作
        /// </summary>
        private void AddTeacher()
        {
            if (txtTeacherName.Text.Equals(""))
            {
                MessageBox.Show(@"教师姓名不能为空！");
                return;
            }
            var teacher = new Teacher(-1, txtTeacherName.Text);
            TeacherDAO.AddTeacher(teacher);
            _addedTeacher = teacher;
            DialogResult = DialogResult.OK;
            Close();
        }


        /// <summary>
        /// 监控键盘按键
        /// </summary>
        protected override bool ProcessCmdKey(ref System.Windows.Forms.Message msg, System.Windows.Forms.Keys keyData)
        {
            if (keyData == (Keys.Enter))
            {
                AddTeacher();
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }


        /// <summary>
        /// 取消按钮
        /// </summary>
        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
