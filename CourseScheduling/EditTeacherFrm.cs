using CourseScheduling.dao;
using CourseScheduling.model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace CourseScheduling
{
    public partial class EditTeacherFrm : Form
    {
        public EditTeacherFrm()
        {
            InitializeComponent();
            InitTeacherData();
        }

        /// <summary>
        /// 代表所有教师信息的缓存
        /// </summary>
        private List<Tuple<Teacher, int>> _allTeachers;

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
        private void InitTeacherData()
        {
            var allTeachers = TeacherDAO.GetAllTeachers();
            _allTeachers = allTeachers.Select(teacher =>
            {
                var index = TeacherDataGridView.Rows.Add(); //产生新行index
                var row = TeacherDataGridView.Rows[index]; //获取一行
                row.Cells[0].Value = teacher.Id; //教师ID
                row.Cells[1].Value = teacher.Name;
                return new Tuple<Teacher, int>(teacher, index);
            }).ToList();
        }

        /// <summary>
        /// 添加新教师
        /// </summary>
        private void BtnAddTeacher_Click(object sender, EventArgs e)
        {
            var form = new AddTeacherFrm();
            var result = form.ShowDialog();
            if (result == DialogResult.Cancel) //用户取消了什么也不做
            {
                return;
            }
            var newTeacher = form.AddedTeacher;
            _isLoaded = false;
            AddTeacherToDataGrid(newTeacher);
            _isLoaded = true;
        }

        /// <summary>
        /// 窗体第一次加载调用的回调函数
        /// </summary>
        private void EditTeacherFrm_Shown(object sender, EventArgs e)
        {
            TeacherDataGridView.ClearSelection(); //不选中第一行
            _isLoaded = true;
        }

        /// <summary>
        /// 点击单元格内容时触发的事件
        /// </summary>
        private void TeacherDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != 2) return; //不是点击的Button就直接返回
            try
            {
                var teacher = _allTeachers.Find(tuple => tuple.Item2 == e.RowIndex).Item1;
                TeacherDAO.Delete(teacher);
                TeacherDataGridView.Rows.RemoveAt(e.RowIndex);
            }
            catch (Exception exception)
            {
                MessageBox.Show($@"删除失败，发生了错误：{exception.Message}");
            }
        }

        /// <summary>
        /// 当元素开始被编辑时触发的事件
        /// </summary>
        private void TeacherDataGridView_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            _nowEditValue = (string)TeacherDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
        }

        /// <summary>
        /// 当元素编辑完成之后触发的事件
        /// </summary>
        private void TeacherDataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 || !_isLoaded) //打开窗体时触发的事件
                return;
            try
            {
                var value = (string)TeacherDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                switch (e.ColumnIndex)
                {
                    case 1: //教师姓名
                        if (value == null || "".Equals(value)) //值为null代表用户删除了这条数据
                        {
                            TeacherDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = _nowEditValue;
                            throw new Exception("教师姓名不能为空！");
                        }
                        var sourceTuple = _allTeachers.Find(tuple => tuple.Item2 == e.RowIndex); //修改原始Tuple
                        var sourceTeacher = sourceTuple.Item1; //修改原始课程
                        var updateTeacher = new Teacher(sourceTeacher.Id, value); //新修改的课程
                        TeacherDAO.UpdateTeacher(sourceTeacher, updateTeacher);
                        _allTeachers.Remove(sourceTuple);
                        _allTeachers.Add(new Tuple<Teacher, int>(updateTeacher, sourceTuple.Item2)); //替换全局变量中修改的值
                        break;
                    default:
                        throw new Exception("检测到编辑了未知或非法数据！系统不能识别！");
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        /// <summary>
        /// 向界面上添加一个教师信息
        /// </summary>
        /// <param name="teacher">要添加的教师</param>
        private void AddTeacherToDataGrid(Teacher teacher)
        {
            var index = TeacherDataGridView.Rows.Add(); //产生新行index
            var row = TeacherDataGridView.Rows[index]; //获取一行
            row.Cells[0].Value = teacher.Id; //教师ID
            row.Cells[1].Value = teacher.Name; //教师姓名
            _allTeachers.Add(new Tuple<Teacher, int>(teacher, index));
        }
    }
}
