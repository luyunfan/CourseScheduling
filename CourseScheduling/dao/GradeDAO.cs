using CourseScheduling.exceptions;
using CourseScheduling.model;
using System.Collections.Generic;
using System.Data;

namespace CourseScheduling.dao
{
    /// <summary>
    /// 年级的数据访问对象
    /// </summary>
    public static class GradeDAO
    {
        /// <summary>
        /// 添加年级
        /// </summary>
        /// <param name="grade">新添加的年级数据</param>
        public static void AddGrade(Grade grade)
        {
            var connection = DatabaseManager.CreateConnection();
            if (HasSameGrade(grade))
            {
                throw new HasSameGradeException("不能添加已经存在的年级信息！");
            }
            var cmd = connection.CreateCommand();
            cmd.CommandText = $"INSERT INTO {Grade.TableName} (GRADENAME) VALUES(@name);";
            cmd.Parameters.Add("@name", DbType.String).Value = grade.GradeName;
            cmd.ExecuteNonQuery();
        }

        /// <summary>
        /// 获取数据库中所有年级信息
        /// </summary>
        /// <returns>数据库中所有年级信息</returns>
        public static List<Grade> GetAllGrades()
        {
            var connection = DatabaseManager.CreateConnection();
            var cmd = connection.CreateCommand();
            cmd.CommandText = $"SELECT * FROM {Grade.TableName}";
            var reader = cmd.ExecuteReader();
            var result = new List<Grade>();
            while (reader.Read())
            {
                result.Add(new Grade(reader[0].ToString()));
            }
            return result;
        }

        /// <summary>
        /// 修改年级的值
        /// </summary>
        /// <param name="source">原值</param>
        /// <param name="changed">修改后新的值</param>
        public static void UpdateGradeValues(Grade source, Grade changed)
        {
            var connection = DatabaseManager.CreateConnection();
            var cmd = connection.CreateCommand();
            cmd.CommandText = $"UPDATE {Grade.TableName} SET GRADENAME = @changed WHERE GRADENAME=@source;";
            cmd.Parameters.Add("@changed", DbType.String).Value = changed.GradeName;
            cmd.Parameters.Add("@source", DbType.String).Value = source.GradeName;
            cmd.ExecuteNonQuery();
        }

        /// <summary>
        /// 删除年级数据
        /// </summary>
        /// <param name="grade">需要删除的数据对象</param>
        public static void DeleteGrade(Grade grade)
        {
            var connection = DatabaseManager.CreateConnection();
            var cmd = connection.CreateCommand();
            cmd.CommandText = $"DELETE FROM {Grade.TableName} WHERE GRADENAME=@grade;";
            cmd.Parameters.Add("@grade", DbType.String).Value = grade.GradeName;
            cmd.ExecuteNonQuery();
        }

        /// <summary>
        /// 根据年级名称获取年级对象
        /// </summary>
        /// <param name="name">年级名称</param>
        /// <returns>年级对象</returns>
        public static Grade GetGrade(string name)
        {
            var result = new Grade(name);
            return HasSameGrade(result) ? result : null;
        }

        /// <summary>
        /// 在数据库中查找是否存在相同的年级
        /// </summary>
        /// <param name="grade">需要查找的年级对象</param>
        /// <returns>是否存在年级对象</returns>
        public static bool HasSameGrade(Grade grade)
        {
            var connection = DatabaseManager.CreateConnection();
            var cmd = connection.CreateCommand();
            cmd.CommandText = $"SELECT * FROM {Grade.TableName} WHERE GRADENAME=@name;";
            cmd.Parameters.Add("@name", DbType.String).Value = grade.GradeName;
            var reader = cmd.ExecuteReader();
            return reader.Read();
        }

        /// <summary>
        /// 初始化Grade表
        /// </summary>
        public static void InitTable()
        {
            var connection = DatabaseManager.CreateConnection();
            var cmd = connection.CreateCommand();
            cmd.CommandText = $"CREATE TABLE IF NOT EXISTS [{Grade.TableName}]([GRADENAME] varchar(10) PRIMARY KEY);";
            cmd.ExecuteNonQuery();
        }

        /// <summary>
        /// 删除Grade表
        /// </summary>
        public static void DeleteTable()
        {
            var connection = DatabaseManager.CreateConnection();
            var cmd = connection.CreateCommand();
            cmd.CommandText = $"DROP TABLE IF EXISTS [{Grade.TableName}];";
            cmd.ExecuteNonQuery();
        }
    }
}
