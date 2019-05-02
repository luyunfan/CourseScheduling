namespace CourseScheduling.model
{
    /// <summary>
    /// 课程实体类
    /// </summary>
    public class Course
    {
        /// <summary>
        /// 模型对应的数据库表名
        /// </summary>
        public static readonly string TableName = "Course";

        /// <summary>
        /// 课程的构造函数
        /// </summary>
        /// <param name="id">课程表中的主键值</param>
        /// <param name="name">课程的名称</param>
        /// <param name="grade">课程的年级信息</param>
        /// <param name="teacher">课程的老师</param>
        /// <param name="vipInfo">课程的VIP信息</param>
        public Course(int id, string name, Grade grade, Teacher teacher, string vipInfo)
        {
            Id = id;
            _name = name;
            _grade = grade;
            _teacher = teacher;
            _vipInfo = vipInfo;
        }

        /// <summary>
        /// 课程的名称
        /// </summary>
        private readonly string _name;

        /// <summary>
        /// 课程所属的年级
        /// </summary>
        private readonly Grade _grade;

        /// <summary>
        /// 课程的老师信息
        /// </summary>
        private readonly Teacher _teacher;

        /// <summary>
        /// 课程的VIP信息
        /// </summary>
        private readonly string _vipInfo;

        /// <summary>
        /// 课程的主键值
        /// </summary>
        public int Id { get; set; }


        /// <summary>
        /// 课程的年级
        /// </summary>
        public Grade Grade => _grade;

        /// <summary>
        /// 课程的VIP信息
        /// </summary>
        public string VipInfo => _vipInfo;

        /// <summary>
        /// 课程的名称
        /// </summary>
        public string Name => _name;

        /// <summary>
        /// 课程的教师信息
        /// </summary>
        public Teacher Teacher => _teacher;

        /// <summary>
        /// 重写的ToString方法，输出课程所有字段数据
        /// </summary>
        /// <returns>Course({Id},{Name},{GradeName},{Teacher},{VipInfo})</returns>
        public override string ToString()
        {
            return $"Course({Id},{_name},{_grade.GradeName},{_teacher},{_vipInfo})";
        }

        public override bool Equals(object obj)
        {
            if (obj is Course course)
            {
                return _name == course.Name &&
                       _grade.GradeName == course.Grade.GradeName &&
                       _teacher.Name == course.Teacher.Name &&
                       _vipInfo == course._vipInfo;
            }
            return false;
        }

        public override int GetHashCode()
        {
            var hash = _name.GetHashCode() | _grade.GradeName.GetHashCode() | _teacher.Name.GetHashCode();
            if (_vipInfo != null)
            {
                hash |= _vipInfo.GetHashCode();
            }
            return hash;
        }
    }
}
