using CourseScheduling.dao;
using CourseScheduling.model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace CourseScheduling
{
    public partial class ChooseClassroomFrm : Form
    {
        public ChooseClassroomFrm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 代表所有教师信息的缓存
        /// </summary>
        private List<Classroom> _allClassrooms;

        /// <summary>
        /// 返回的结果
        /// </summary>
        private readonly List<Classroom> _result = new List<Classroom>();

        /// <summary>
        /// 用户选择得到的结果
        /// </summary>
        public List<Classroom> ChooseResult => _result;


        /// <summary>
        /// 初始化教室信息
        /// </summary>
        private void InitClassroomData()
        {
            _allClassrooms = ClassroomDAO.GetAllClassroom();
            _allClassrooms.ForEach(classroom =>
            {
                var index = ClassroomDataGridView.Rows.Add(); //产生新行index
                var row = ClassroomDataGridView.Rows[index]; //获取一行
                row.Cells[0].Value = classroom.Name; //教室名
                var colorCell = (DataGridViewImageCell)row.Cells[1]; //获取颜色
                var image = new Bitmap(colorCell.Size.Width, colorCell.Size.Height); //生成纯色图片
                using (var graph = Graphics.FromImage(image))
                    graph.Clear(classroom.Color);
                colorCell.Value = image; //在单元格填充图片
            });
        }

        /// <summary>
        /// 窗体第一次加载调用的回调函数
        /// </summary>
        private void EditClassroomFrm_Shown(object sender, EventArgs e)
        {
            InitClassroomData();
            ClassroomDataGridView.ClearSelection(); //默认不选中
        }

        /// <summary>
        /// 选择教室按钮
        /// </summary>
        private void ChooseClassroomBtn_Click(object sender, EventArgs e)
        {
            for (var i = 0; i < ClassroomDataGridView.SelectedRows.Count; i++)
            {
                var row = ClassroomDataGridView.SelectedRows[i];
                _result.Add(_allClassrooms.Find(classroom => classroom.Name.Equals(row.Cells[0].Value)));
            }
            DialogResult = DialogResult.OK;
            Close();
        }

        /// <summary>
        /// 取消按钮
        /// </summary>
        private void CancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
