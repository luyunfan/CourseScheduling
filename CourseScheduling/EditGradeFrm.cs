using CourseScheduling.dao;
using CourseScheduling.exceptions;
using CourseScheduling.model;
using System;
using System.Windows.Forms;

namespace CourseScheduling
{
    public partial class EditGradeFrm : Form
    {
        public EditGradeFrm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 窗体第一次被打开时执行的回调函数
        /// </summary>
        private void GradeEditFrm_Shown(object sender, EventArgs e)
        {
            InitDataFromDatabase();
            GradeDataGridView.ClearSelection(); //不选中第一行
            _isLoaded = true;
        }

        /// <summary>
        /// 代表当前点击DataGridView中元素时的数据
        /// </summary>
        private string _nowEditValue;

        /// <summary>
        /// 窗体是否加载完成
        /// </summary>
        private bool _isLoaded = false;

        /// <summary>
        /// 从数据库初始化年级数据
        /// </summary>
        private void InitDataFromDatabase()
        {
            GradeDAO.GetAllGrades().ForEach(grade =>
                {
                    var index = GradeDataGridView.Rows.Add();
                    GradeDataGridView.Rows[index].Cells[0].Value = grade.GradeName;
                });
        }

        /// <summary>
        /// 当元素编辑完成之后触发的事件
        /// </summary>
        private void GradeDataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 || !_isLoaded) //打开窗体时触发的事件
                return;
            try
            {
                var value = new Grade((string)GradeDataGridView.Rows[e.RowIndex].Cells[0].Value);
                if (value.GradeName == null) //值为null代表用户删除了这条数据
                {
                    GradeDAO.DeleteGrade(new Grade(_nowEditValue));
                    return;
                }
                if (GradeDAO.HasSameGrade(value)) //数据已经存在了，修改前后值相同
                {
                    GradeDataGridView.Rows[e.RowIndex].Cells[0].Value = null;
                    throw new HasSameGradeException($"已经存在数据：“{value.GradeName}”，不能添加相同的年级！");
                }
                GradeDAO.AddGrade(value);
            }
            catch (HasSameGradeException exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        /// <summary>
        /// 当元素开始被编辑时触发的事件
        /// </summary>
        private void GradeDataGridView_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            _nowEditValue = (string)GradeDataGridView.Rows[e.RowIndex].Cells[0].Value;
        }
    }
}
