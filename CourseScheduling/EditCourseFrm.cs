using CourseScheduling.dao;
using CourseScheduling.model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace CourseScheduling
{
    public partial class EditCourseFrm : Form
    {
        public EditCourseFrm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 代表所有课程信息的缓存（课程,界面行索引）
        /// </summary>
        private List<Tuple<Course, int>> _allCourses;

        /// <summary>
        /// 代表所有年级信息的缓存
        /// </summary>
        private List<Grade> _allGrades;

        /// <summary>
        /// 代表所有教师信息的缓存
        /// </summary>
        private List<Teacher> _allTeachers;

        /// <summary>
        /// 代表当前点击DataGridView中元素时的数据
        /// </summary>
        private string _nowEditValue;

        /// <summary>
        /// 窗体是否加载完成
        /// </summary>
        private bool _isLoaded = false;

        /// <summary>
        /// 初始化数据到界面
        /// </summary>
        private void InitCourseData()
        {
            var allCourses = CourseDAO.GetAllCourses();
            _allGrades = GradeDAO.GetAllGrades();
            _allTeachers = TeacherDAO.GetAllTeachers();
            _allCourses = allCourses.Select(course =>
            {
                var index = CourseDataGridView.Rows.Add(); //产生新行index
                var row = CourseDataGridView.Rows[index]; //获取一行
                row.Cells[0].Value = course.Name; //课程名
                var gradeCell = (DataGridViewComboBoxCell)row.Cells[1]; //获取年级
                gradeCell.Value = course.Grade.GradeName;
                _allGrades.ForEach(grade => gradeCell.Items.Add(grade.GradeName));
                var teacherCell = (DataGridViewComboBoxCell)row.Cells[2]; //获取教师
                teacherCell.Value = course.Teacher.Name;
                _allTeachers.ForEach(teacher => teacherCell.Items.Add(teacher.Name));
                row.Cells[3].Value = course.VipInfo; //vip信息
                return new Tuple<Course, int>(course, index);
            }).ToList();
        }

        /// <summary>
        /// 当元素开始被编辑时触发的事件
        /// </summary>
        private void CourseDataGridView_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            _nowEditValue = (string)CourseDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
        }

        /// <summary>
        /// 当元素编辑完成之后触发的事件
        /// </summary>
        private void CourseDataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 || !_isLoaded) //打开窗体时触发的事件
                return;
            try
            {
                var value = (string)CourseDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                Tuple<Course, int> sourceTuple; //修改原始Tuple
                Course sourceCourse; //修改原始课程
                Course updateCourse; //新修改的课程
                switch (e.ColumnIndex)
                {
                    case 0: //课程名
                        if (value == null || "".Equals(value)) //值为null代表用户删除了这条数据
                        {
                            CourseDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = _nowEditValue;
                            throw new Exception("课程名不能为空！");
                        }
                        sourceTuple = _allCourses.Find(tuple => tuple.Item2 == e.RowIndex);
                        sourceCourse = sourceTuple.Item1;
                        updateCourse = new Course(sourceCourse.Id, value, sourceCourse.Grade, sourceCourse.Teacher, sourceCourse.VipInfo);
                        CourseDAO.UpdateCourseValues(sourceCourse, updateCourse);
                        _allCourses.Remove(sourceTuple);
                        _allCourses.Add(new Tuple<Course, int>(updateCourse, sourceTuple.Item2)); //替换全局变量中修改的值
                        break;
                    case 1: //年级
                        if (value == null || "".Equals(value)) //值为null代表用户删除了这条数据
                        {
                            CourseDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = _nowEditValue;
                            throw new Exception("年级信息不能为空！");
                        }
                        sourceTuple = _allCourses.Find(tuple => tuple.Item2 == e.RowIndex);
                        sourceCourse = sourceTuple.Item1;
                        updateCourse = new Course(sourceCourse.Id, sourceCourse.Name, new Grade(value), sourceCourse.Teacher, sourceCourse.VipInfo);
                        CourseDAO.UpdateCourseValues(sourceCourse, updateCourse);
                        _allCourses.Remove(sourceTuple);
                        _allCourses.Add(new Tuple<Course, int>(updateCourse, sourceTuple.Item2)); //替换全局变量中修改的值
                        break;
                    case 2: //教师
                        if (value == null || "".Equals(value)) //值为null代表用户删除了这条数据
                        {
                            CourseDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = _nowEditValue;
                            throw new Exception("教师信息不能为空！");
                        }
                        sourceTuple = _allCourses.Find(tuple => tuple.Item2 == e.RowIndex);
                        sourceCourse = sourceTuple.Item1;
                        updateCourse = new Course(sourceCourse.Id, sourceCourse.Name, sourceCourse.Grade, new Teacher(-1, value), sourceCourse.VipInfo);
                        CourseDAO.UpdateCourseValues(sourceCourse, updateCourse);
                        _allCourses.Remove(sourceTuple);
                        _allCourses.Add(new Tuple<Course, int>(updateCourse, sourceTuple.Item2)); //替换全局变量中修改的值
                        break;
                    case 3: //vip信息
                        if (value == null || "".Equals(value)) //值为null代表用户删除了这条数据
                        {
                            sourceTuple = _allCourses.Find(tuple => tuple.Item2 == e.RowIndex);
                            sourceCourse = sourceTuple.Item1;
                            updateCourse = new Course(sourceCourse.Id, sourceCourse.Name, sourceCourse.Grade, sourceCourse.Teacher, "");
                            CourseDAO.UpdateCourseValues(sourceCourse, updateCourse);
                            _allCourses.Remove(sourceTuple);
                            _allCourses.Add(new Tuple<Course, int>(updateCourse, sourceTuple.Item2)); //替换全局变量中修改的值
                        }
                        sourceTuple = _allCourses.Find(tuple => tuple.Item2 == e.RowIndex);
                        sourceCourse = sourceTuple.Item1;
                        updateCourse = new Course(sourceCourse.Id, sourceCourse.Name, sourceCourse.Grade, sourceCourse.Teacher, value);
                        CourseDAO.UpdateCourseValues(sourceCourse, updateCourse);
                        _allCourses.Remove(sourceTuple);
                        _allCourses.Add(new Tuple<Course, int>(updateCourse, sourceTuple.Item2)); //替换全局变量中修改的值
                        break;
                    default:
                        throw new Exception("检测到编辑了未知数据！系统不能识别！");
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        /// <summary>
        /// 窗体第一次加载调用的回调函数
        /// </summary>
        private void EditCourseFrm_Shown(object sender, EventArgs e)
        {
            InitCourseData();
            CourseDataGridView.ClearSelection(); //不选中第一行
            _isLoaded = true;
        }

        /// <summary>
        /// 添加新课程按钮
        /// </summary>
        private void BtnAddCourse_Click(object sender, EventArgs e)
        {
            var form = new AddCourseFrm();
            var result = form.ShowDialog();
            if (result == DialogResult.Cancel) //用户取消了什么也不做
            {
                return;
            }
            var newCourse = form.AddedCourse;
            _isLoaded = false;
            AddCourseToDataGrid(newCourse);
            _isLoaded = true;
        }

        /// <summary>
        /// 点击单元格内容时触发的事件
        /// </summary>
        private void CourseDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != 4) return; //不是点击的Button就直接返回
            try
            {
                var course = _allCourses.Find(tuple => tuple.Item2 == e.RowIndex).Item1;
                CourseDAO.DeleteCourse(course);
                CourseDataGridView.Rows.RemoveAt(e.RowIndex);
            }
            catch (Exception exception)
            {
                MessageBox.Show($@"删除失败，发生了错误：{exception.Message}");
            }
        }

        /// <summary>
        /// 向显示控件添加一个课程信息
        /// </summary>
        /// <param name="course">需要添加的课程信息</param>
        private void AddCourseToDataGrid(Course course)
        {
            var index = CourseDataGridView.Rows.Add(); //产生新行index
            var row = CourseDataGridView.Rows[index]; //获取一行
            row.Cells[0].Value = course.Name; //课程名
            var gradeCell = (DataGridViewComboBoxCell)row.Cells[1]; //获取年级
            _allGrades.ForEach(grade => gradeCell.Items.Add(grade.GradeName));
            gradeCell.Value = course.Grade.GradeName;
            var teacherCell = (DataGridViewComboBoxCell)row.Cells[2]; //获取教师
            _allTeachers.ForEach(teacher => teacherCell.Items.Add(teacher.Name));
            teacherCell.Value = course.Teacher.Name;
            row.Cells[3].Value = course.VipInfo; //vip信息
            _allCourses.Add(new Tuple<Course, int>(course, index));
        }

        private void CourseDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            //未知第0行有信息，导致错误
        }
    }
}
