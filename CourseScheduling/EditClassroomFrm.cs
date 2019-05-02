using CourseScheduling.dao;
using CourseScheduling.model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace CourseScheduling
{
    public partial class EditClassroomFrm : Form
    {
        public EditClassroomFrm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 代表所有教师信息的缓存
        /// </summary>
        private List<Tuple<Classroom, int>> _allClassrooms;

        /// <summary>
        /// 代表当前点击DataGridView中元素时的数据
        /// </summary>
        private string _nowEditValue;

        /// <summary>
        /// 窗体是否加载完成
        /// </summary>
        private bool _isLoaded = false;

        /// <summary>
        /// 初始化教室信息
        /// </summary>
        private void InitClassroomData()
        {
            var allClassroom = ClassroomDAO.GetAllClassroom();
            _allClassrooms = allClassroom.Select(classroom =>
            {
                var index = ClassroomDataGridView.Rows.Add(); //产生新行index
                var row = ClassroomDataGridView.Rows[index]; //获取一行
                row.Cells[0].Value = classroom.Name; //教室名
                var colorCell = (DataGridViewImageCell)row.Cells[1]; //获取颜色
                var image = new Bitmap(colorCell.Size.Width, colorCell.Size.Height); //生成纯色图片
                using (var graph = Graphics.FromImage(image))
                    graph.Clear(classroom.Color);
                colorCell.Value = image; //在单元格填充图片
                return new Tuple<Classroom, int>(classroom, index);
            }).ToList();
        }

        /// <summary>
        /// 添加新教室
        /// </summary>
        private void BtnAddClassroom_Click(object sender, EventArgs e)
        {
            var form = new AddClassroomFrm();
            var result = form.ShowDialog();
            if (result == DialogResult.Cancel) //用户取消了什么也不做
            {
                return;
            }
            var newCourse = form.AddedCourse;
            _isLoaded = false;
            AddClassroomToDataGrid(newCourse);
            _isLoaded = true;
        }

        /// <summary>
        /// 窗体第一次加载调用的回调函数
        /// </summary>
        private void EditClassroomFrm_Shown(object sender, EventArgs e)
        {
            InitClassroomData();
            ClassroomDataGridView.ClearSelection(); //不选中第一行
            _isLoaded = true;
        }

        /// <summary>
        /// 当元素开始被编辑时触发的事件
        /// </summary>
        private void ClassroomDataGridView_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            _nowEditValue = (string)ClassroomDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
        }

        /// <summary>
        /// 点击单元格内容时触发的事件
        /// </summary>
        private void ClassroomDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1) //点击的颜色按钮
            {
                var result = selectColor.ShowDialog();
                if (result == DialogResult.Cancel || selectColor.Color == Color.Black) return;
                var color = selectColor.Color;
                var srcClassroom = _allClassrooms.Find(tuple => tuple.Item2 == e.RowIndex).Item1;
                var updateClassroom = new Classroom(srcClassroom.Name, color);
                ClassroomDAO.UpdateClassroom(srcClassroom, updateClassroom);
                var colorCell = (DataGridViewImageCell)ClassroomDataGridView.Rows[e.RowIndex].Cells[1]; //获取颜色
                var image = new Bitmap(colorCell.Size.Width, colorCell.Size.Height); //生成纯色图片
                using (var graph = Graphics.FromImage(image))
                    graph.Clear(updateClassroom.Color);
                colorCell.Value = image; //在单元格填充图片
            }
            else if (e.ColumnIndex == 2) //点击的删除按钮
            {
                try
                {
                    var classroom = _allClassrooms.Find(tuple => tuple.Item2 == e.RowIndex).Item1;
                    ClassroomDAO.Delete(classroom);
                    ClassroomDataGridView.Rows.RemoveAt(e.RowIndex);
                }
                catch (Exception exception)
                {
                    MessageBox.Show($@"删除失败，发生了错误：{exception.Message}");
                }
            }
        }

        /// <summary>
        /// 当元素编辑完成之后触发的事件
        /// </summary>
        private void ClassroomDataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 || !_isLoaded) //打开窗体时触发的事件
                return;
            try
            {
                switch (e.ColumnIndex)
                {
                    case 0: //教室名
                        var value = (string)ClassroomDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                        if (value == null || "".Equals(value)) //值为null代表用户删除了这条数据
                        {
                            ClassroomDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = _nowEditValue;
                            throw new Exception("教室名不能为空！");
                        }
                        var sourceTuple = _allClassrooms.Find(tuple => tuple.Item2 == e.RowIndex); //修改原始Tuple
                        var sourceClassroom = sourceTuple.Item1; //修改原始课程
                        var updateClassroom = new Classroom(value, sourceClassroom.Color); //新修改的课程
                        ClassroomDAO.UpdateClassroom(sourceClassroom, updateClassroom);
                        _allClassrooms.Remove(sourceTuple);
                        _allClassrooms.Add(new Tuple<Classroom, int>(updateClassroom, sourceTuple.Item2)); //替换全局变量中修改的值
                        break;
                    case 1: //更改颜色逻辑不需要做任何处理
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
        /// 向界面中添加一个教室
        /// </summary>
        /// <param name="classroom">需要添加的教室对象</param>
        private void AddClassroomToDataGrid(Classroom classroom)
        {
            var index = ClassroomDataGridView.Rows.Add(); //产生新行index
            var row = ClassroomDataGridView.Rows[index]; //获取一行
            row.Cells[0].Value = classroom.Name; //教室名
            var colorCell = (DataGridViewImageCell)row.Cells[1]; //获取颜色
            var image = new Bitmap(colorCell.Size.Width, colorCell.Size.Height); //生成纯色图片
            using (var graph = Graphics.FromImage(image))
                graph.Clear(classroom.Color);
            colorCell.Value = image; //教室颜色
            _allClassrooms.Add(new Tuple<Classroom, int>(classroom, index));
        }
    }
}
