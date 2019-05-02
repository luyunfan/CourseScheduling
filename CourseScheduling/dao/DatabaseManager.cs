using System.Data.SQLite;

namespace CourseScheduling.dao
{
    /// <summary>
    /// 数据库管理类
    /// </summary>
    static class DatabaseManager
    {
        /// <summary>
        /// SQLite连接缓存
        /// </summary>
        private static SQLiteConnection _cache;

        /// <summary>
        /// 创建数据库连接
        /// </summary>
        /// <returns>数据库连接对象</returns>
        public static SQLiteConnection CreateConnection()
        {
            if (_cache != null) return _cache;
            var connection = new SQLiteConnection("data source=" + Program.DatabasePath);
            connection.Open();
            _cache = connection;
            return connection;
        }

        /// <summary>
        /// 初始化数据库（新建所有表）
        /// </summary>
        public static void CreateDatabase()
        {
            GradeDAO.InitTable(); //初始化Grade表
            CourseDAO.InitTable(); //初始化Course表
            TeacherDAO.InitTable(); //初始化Teacher表
            ClassroomDAO.InitTable(); //初始化Classroom表
        }

        /// <summary>
        /// 删除数据库所有表
        /// </summary>
        public static void DeleteDatabase()
        {
            GradeDAO.DeleteTable(); //删除Grade表
            CourseDAO.DeleteTable(); //删除Course表
            TeacherDAO.DeleteTable(); //删除Teacher表
            ClassroomDAO.DeleteTable(); //删除Classroom表
        }
    }
}
