using CourseScheduling.dao;
using CourseScheduling.model;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CourseScheduling
{
    public partial class AddClassroomFrm : Form
    {
        public AddClassroomFrm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 选择得到的颜色值
        /// </summary>
        private Color _selectColor;

        /// <summary>
        /// 是否选择了颜色
        /// </summary>
        private bool _isSelectedColor = false;

        /// <summary>
        /// 添加成功后的Classroom对象
        /// </summary>
        private Classroom _addedClassroom;

        /// <summary>
        /// 添加成功后的Classroom对象
        /// </summary>
        public Classroom AddedCourse => _addedClassroom;

        /// <summary>
        /// 添加教室
        /// </summary>
        private void BtnAddClassroom_Click(object sender, EventArgs e)
        {
            AddClassroom();
        }

        /// <summary>
        /// 添加教室的实际动作
        /// </summary>
        private void AddClassroom()
        {
            if (txtClassroomName.Text.Equals(""))
            {
                MessageBox.Show("教室名称不能为空！");
                return;
            }
            if (!_isSelectedColor) //如果用户没有选择颜色，则随机一个颜色
            {
                _selectColor = RandomColor();
            }
            var classroom = new Classroom(txtClassroomName.Text, _selectColor);
            ClassroomDAO.AddClassroom(classroom);
            DialogResult = DialogResult.OK;
            _addedClassroom = classroom;
            Close();
        }

        /// <summary>
        /// 监控键盘按键
        /// </summary>
        protected override bool ProcessCmdKey(ref System.Windows.Forms.Message msg, System.Windows.Forms.Keys keyData)
        {
            if (keyData == (Keys.Enter))
            {
                AddClassroom();
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        /// <summary>
        /// 随机生成一个颜色
        /// </summary>
        /// <returns>随机生成的颜色</returns>
        private static Color RandomColor()
        {
            var tick = DateTime.Now.Ticks;
            var random = new Random((int)(tick & 0xffffffffL) | (int)(tick >> 32));
            var r = random.Next(255);
            var g = random.Next(255);
            var b = random.Next(255);
            b = (r + g > 400) ? r + g - 400 : b;//0 : 380 - R - G;
            b = (b > 255) ? 255 : b;
            return Color.FromArgb(r, g, b);
        }

        /// <summary>
        /// 取消
        /// </summary>
        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// 选择颜色
        /// </summary>
        private void BtnSelectColor_Click(object sender, EventArgs e)
        {
            var result = selectColor.ShowDialog();
            if (result != DialogResult.Cancel && selectColor.Color != Color.Black)
            {
                _isSelectedColor = true;
            }
            _selectColor = selectColor.Color;
        }
    }
}
