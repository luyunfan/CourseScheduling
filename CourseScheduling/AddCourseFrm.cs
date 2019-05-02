using CourseScheduling.dao;
using CourseScheduling.model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CourseScheduling
{
    /// <summary>
    /// 添加课程的窗体
    /// </summary>
    public partial class AddCourseFrm : Form
    {
        public AddCourseFrm()
        {
            InitializeComponent();
            InitInfo();
        }

        /// <summary>
        /// 初始化的所有年级信息
        /// </summary>
        private List<Grade> _allGrades;

        /// <summary>
        /// 初始化的所有老师信息
        /// </summary>
        private List<Teacher> _allTeachers;

        /// <summary>
        /// 添加成功后的Course对象
        /// </summary>
        private Course _addedCourse;

        /// <summary>
        /// 添加成功后的Course对象
        /// </summary>
        public Course AddedCourse => _addedCourse;

        /// <summary>
        /// 初始化年级信息
        /// </summary>
        private void InitInfo()
        {
            _allGrades = GradeDAO.GetAllGrades();
            _allGrades.ForEach(grade => comboxCourseGrade.Items.Add(grade.GradeName));
            _allTeachers = TeacherDAO.GetAllTeachers();
            _allTeachers.ForEach(teacher => comboxTeacherInfo.Items.Add(teacher.Name));
        }

        /// <summary>
        /// 添加课程信息
        /// </summary>
        private void BtnAddCourse_Click(object sender, EventArgs e)
        {
            AddCourse();
        }

        /// <summary>
        /// 添加课程的实际逻辑
        /// </summary>
        private void AddCourse()
        {
            if (txtCourseName.Text.Equals(""))
            {
                MessageBox.Show("输入的课程名称为空！");
                return;
            }
            if (comboxCourseGrade.Text.Equals(""))
            {
                MessageBox.Show("没有输入课程年级信息！");
                return;
            }
            if (comboxTeacherInfo.Text.Equals(""))
            {
                MessageBox.Show("没有输入教师信息！");
            }

            var course = new Course(-1, txtCourseName.Text,
                _allGrades.Find(grade => grade.GradeName.Equals(comboxCourseGrade.Text)),
                _allTeachers.Find(teacher => teacher.Name.Equals(comboxTeacherInfo.Text)),
                txtCourseVipInfo.Text);

            CourseDAO.AddCourse(course);
            DialogResult = DialogResult.OK;
            _addedCourse = course;
            Close();
        }

        /// <summary>
        /// 监控键盘按键
        /// </summary>
        protected override bool ProcessCmdKey(ref System.Windows.Forms.Message msg, System.Windows.Forms.Keys keyData)
        {
            if (keyData == (Keys.Enter))
            {
                AddCourse();
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
