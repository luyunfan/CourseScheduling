namespace CourseScheduling.model
{
    /// <summary>
    /// 年级实体类
    /// </summary>
    public class Grade
    {
        /// <summary>
        /// 模型对应的数据库表名
        /// </summary>
        public static readonly string TableName = "Grade";

        /// <summary>
        /// 年级的名称
        /// </summary>
        private readonly string _gradeName;

        /// <summary>
        /// 年级的构造函数
        /// </summary>
        /// <param name="gradeName">年级的名称</param>
        public Grade(string gradeName)
        {
            _gradeName = gradeName;
        }

        /// <summary>
        /// 年级的名称的get属性
        /// </summary>
        public string GradeName => _gradeName;

        /// <summary>
        /// 重写ToString方法
        /// </summary>
        /// <returns>年级存储的字符串数据</returns>
        public override string ToString()
        {
            return _gradeName;
        }

        public override bool Equals(object obj)
        {
            return obj is Grade grade && grade._gradeName.Equals(_gradeName);
        }

        public override int GetHashCode()
        {
            return _gradeName.GetHashCode();
        }
    }
}
