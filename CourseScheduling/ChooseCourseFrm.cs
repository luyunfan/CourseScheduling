using CourseScheduling.dao;
using CourseScheduling.model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CourseScheduling
{
    public partial class ChooseCourseFrm : Form
    {
        public ChooseCourseFrm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 代表所有课程信息的缓存（课程,界面行索引）
        /// </summary>
        private List<Course> _allCourses;

        /// <summary>
        /// 返回的结果
        /// </summary>
        private readonly List<Course> _result = new List<Course>();

        /// <summary>
        /// 用户选择得到的结果
        /// </summary>
        public List<Course> ChooseResult => _result;

        /// <summary>
        /// 初始化数据到界面
        /// </summary>
        private void InitCourseData()
        {
            _allCourses = CourseDAO.GetAllCourses();
            _allCourses.ForEach(course =>
           {
               var index = CourseDataGridView.Rows.Add(); //产生新行index
               var row = CourseDataGridView.Rows[index]; //获取一行
               row.Cells[0].Value = course.Name; //课程名
               var gradeCell = (DataGridViewComboBoxCell)row.Cells[1]; //获取年级
               gradeCell.Items.Add(course.Grade.GradeName);
               gradeCell.Value = course.Grade.GradeName;
               var teacherCell = (DataGridViewComboBoxCell)row.Cells[2]; //获取教师
               teacherCell.Items.Add(course.Teacher.Name);
               teacherCell.Value = course.Teacher.Name;
               row.Cells[3].Value = course.VipInfo; //vip信息
           });
        }

        /// <summary>
        /// 窗体第一次加载调用的回调函数
        /// </summary>
        private void EditCourseFrm_Shown(object sender, EventArgs e)
        {
            InitCourseData();
            CourseDataGridView.ClearSelection(); //默认不选中
        }

        /// <summary>
        /// 确定按钮
        /// </summary>
        private void ChooseCourse_Click(object sender, EventArgs e)
        {
            for (var i = 0; i < CourseDataGridView.SelectedRows.Count; i++)
            {
                var row = CourseDataGridView.SelectedRows[i];
                _result.Add(_allCourses.Find(course =>
                    course.Name.Equals(row.Cells[0].Value) &&
                    course.Grade.GradeName.Equals(row.Cells[1].Value) &&
                    course.Teacher.Name.Equals(row.Cells[2].Value) &&
                    course.VipInfo.Equals(row.Cells[3].Value)));
            }
            DialogResult = DialogResult.OK;
            Close();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
