using System.Drawing;

namespace CourseScheduling.model
{
    /// <summary>
    /// 代表教室的模型层对象
    /// </summary>
    public class Classroom
    {
        /// <summary>
        /// 模型对应的数据库表名
        /// </summary>
        public static readonly string TableName = "Classroom";

        /// <summary>
        /// 教室的构造函数
        /// </summary>
        /// <param name="name">教室名</param>
        /// <param name="color">教室代表的颜色</param>
        public Classroom(string name, Color color)
        {
            _name = name;
            _color = color;
        }

        /// <summary>
        /// 教室的名称字段
        /// </summary>
        private readonly string _name;

        /// <summary>
        /// 教室的颜色字段
        /// </summary>
        private readonly Color _color;

        /// <summary>
        /// 教室名称
        /// </summary>
        public string Name => _name;

        /// <summary>
        /// 教室颜色
        /// </summary>
        public Color Color => _color;

        /// <summary>
        /// 教室重写ToString方法
        /// </summary>
        /// <returns>Classroom({Name},{Color})</returns>
        public override string ToString()
        {
            return $"Classroom({_name},{_color.Name})";
        }
    }
}
