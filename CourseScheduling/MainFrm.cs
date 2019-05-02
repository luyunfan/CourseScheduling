using CourseScheduling.dao;
using CourseScheduling.model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CourseScheduling
{
    /// <summary>
    /// 主窗体逻辑类
    /// </summary>
    public partial class MainFrm : Form
    {
        public MainFrm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 用户选择的课程数据
        /// </summary>
        private List<Course> _selectedCourses = new List<Course>();

        /// <summary>
        /// 用户选择的教室数据
        /// </summary>
        private List<Classroom> _selectedClassrooms = new List<Classroom>();

        /// <summary>
        /// 添加课程信息
        /// </summary>
        private void AddCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new AddCourseFrm();
            form.ShowDialog();
        }

        /// <summary>
        /// 年级管理
        /// </summary>
        private void GradeEditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new EditGradeFrm();
            form.ShowDialog();
        }

        /// <summary>
        /// 添加教师按钮
        /// </summary>
        private void AddTeacherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new AddTeacherFrm();
            form.ShowDialog();
        }

        /// <summary>
        /// 添加教室按钮
        /// </summary>
        private void AddClassroomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new AddClassroomFrm();
            form.ShowDialog();
        }

        /// <summary>
        /// 编辑教室按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EditCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new EditCourseFrm();
            form.ShowDialog();
        }

        /// <summary>
        /// 编辑教师信息
        /// </summary>
        private void EditTeacherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new EditTeacherFrm();
            form.ShowDialog();
        }

        /// <summary>
        /// 编辑教室信息
        /// </summary>
        private void EditClassroomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new EditClassroomFrm();
            form.ShowDialog();
        }

        /// <summary>
        /// 清空所有数据
        /// </summary>
        private void ClearDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show(@"您确定要清空软件所有数据吗？这个操作不可恢复！", @"警告", MessageBoxButtons.OKCancel);
            if (result != DialogResult.OK) return;
            DatabaseManager.DeleteDatabase(); // 删除所有表
            DatabaseManager.CreateDatabase(); //建表初始化数据库
        }

        /// <summary>
        /// 添加课程按钮
        /// </summary>
        private void AddCourseBtn_Click(object sender, EventArgs e)
        {
            var form = new AddCourseFrm();
            form.ShowDialog();
        }

        /// <summary>
        /// 添加教师按钮
        /// </summary>
        private void AddTeacherBtn_Click(object sender, EventArgs e)
        {
            var form = new AddTeacherFrm();
            form.ShowDialog();
        }

        /// <summary>
        /// 添加教室按钮
        /// </summary>
        private void AddClassroomBtn_Click(object sender, EventArgs e)
        {
            var form = new AddClassroomFrm();
            form.ShowDialog();
        }

        /// <summary>
        /// 选择安排的课程
        /// </summary>
        private void ChooseCourseBtn_Click(object sender, EventArgs e)
        {
            var form = new ChooseCourseFrm();
            var result = form.ShowDialog();
            if (result != DialogResult.OK) return; //用户点击了确定才会执行下面的代码
            var courses = form.ChooseResult;
            ClearChooseCourse(); //清空原有数据
            courses.ForEach(AddCourseToChoose); //添加新数据
            NeedCourseDataGridView.ClearSelection(); //不选中第一行
        }

        /// <summary>
        /// 选择安排的教室
        /// </summary>
        private void ChooseClassroomBtn_Click(object sender, EventArgs e)
        {
            var form = new ChooseClassroomFrm();
            var result = form.ShowDialog();
            if (result != DialogResult.OK) return; //用户点击了确定才会执行下面的代码
            var classrooms = form.ChooseResult;
            ClearChooseClassroom(); //清空原有数据
            classrooms.ForEach(AddClassroomToChoose); //添加新数据
            NeedClassroomDataGridView.ClearSelection(); //不选中第一行
        }

        /// <summary>
        /// 排课按钮
        /// </summary>
        private void SchedulingBtn_Click(object sender, EventArgs e)
        {
            if (_selectedCourses.Count <= 0)
            {
                MessageBox.Show(@"请选择需要排的课程！");
                return;
            }
            if (_selectedClassrooms.Count <= 0)
            {
                MessageBox.Show(@"请选择需要安排的教室！");
                return;
            }
            var form = new SchedulingResultFrm(_selectedCourses, _selectedClassrooms);
            if (form.IsSchedulingSuccess) //排课遇到错误就不弹出界面了
            {
                form.Show();
            }
        }

        /// <summary>
        /// 清空界面上选择的课程
        /// </summary>
        private void ClearChooseCourse()
        {
            NeedCourseDataGridView.Rows.Clear();
            _selectedCourses.Clear();
        }

        /// <summary>
        /// 向界面上添加一门课程信息
        /// </summary>
        /// <param name="course">需要添加的课程对象</param>
        private void AddCourseToChoose(Course course)
        {
            var index = NeedCourseDataGridView.Rows.Add(); //产生新行index
            var row = NeedCourseDataGridView.Rows[index]; //获取一行
            row.Cells[0].Value = course.Name; //课程名
            _selectedCourses.Add(course);
        }

        /// <summary>
        /// 清空界面上选择的教室
        /// </summary>
        private void ClearChooseClassroom()
        {
            NeedClassroomDataGridView.Rows.Clear();
            _selectedClassrooms.Clear();
        }

        /// <summary>
        /// 向界面上添加一个教室信息
        /// </summary>
        /// <param name="classroom">需要添加的教室对象</param>
        private void AddClassroomToChoose(Classroom classroom)
        {
            var index = NeedClassroomDataGridView.Rows.Add(); //产生新行index
            var row = NeedClassroomDataGridView.Rows[index]; //获取一行
            row.Cells[0].Value = classroom.Name; //课程名
            _selectedClassrooms.Add(classroom);
        }

    }
}
