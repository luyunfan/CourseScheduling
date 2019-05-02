namespace CourseScheduling.model
{
    /// <summary>
    /// 教师的模型对象
    /// </summary>
    public class Teacher
    {
        /// <summary>
        /// 模型对应的数据库表名
        /// </summary>
        public static readonly string TableName = "Teacher";

        /// <summary>
        /// 教师的构造函数
        /// </summary>
        /// <param name="id">教师数据库表ID</param>
        /// <param name="name">教师的姓名</param>
        public Teacher(int id, string name)
        {
            Id = id;
            _name = name;
        }

        /// <summary>
        /// 教师姓名
        /// </summary>
        private readonly string _name;

        /// <summary>
        /// 教师姓名
        /// </summary>
        public string Name => _name;

        /// <summary>
        /// 教师数据库表ID
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// 重写的ToString方法，输出教师姓名
        /// </summary>
        /// <returns>Teacher({ID,{Name}})</returns>
        public override string ToString()
        {
            return $"Teacher({Id},{_name})";
        }
    }
}
