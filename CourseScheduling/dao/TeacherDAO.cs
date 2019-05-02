using CourseScheduling.model;
using System;
using System.Collections.Generic;
using System.Data;

namespace CourseScheduling.dao
{
    public static class TeacherDAO
    {
        /// <summary>
        /// 初始化Teacher表
        /// </summary>
        public static void InitTable()
        {
            var connection = DatabaseManager.CreateConnection();
            var cmd = connection.CreateCommand();
            cmd.CommandText = $"CREATE TABLE IF NOT EXISTS [{Teacher.TableName}]([ID] INTEGER PRIMARY KEY AUTOINCREMENT, [NAME] varchar(10) NOT NULL);";
            cmd.ExecuteNonQuery();
        }

        /// <summary>
        /// 删除Teacher表
        /// </summary>
        public static void DeleteTable()
        {
            var connection = DatabaseManager.CreateConnection();
            var cmd = connection.CreateCommand();
            cmd.CommandText = $"DROP TABLE IF EXISTS [{Teacher.TableName}];";
            cmd.ExecuteNonQuery();
        }

        /// <summary>
        /// 添加老师
        /// </summary>
        /// <param name="teacher">新添加的老师</param>
        public static void AddTeacher(Teacher teacher)
        {
            var connection = DatabaseManager.CreateConnection();
            var cmd = connection.CreateCommand();
            cmd.CommandText = $"INSERT INTO {Teacher.TableName} (NAME) VALUES(@name);SELECT MAX(ID) FROM {Teacher.TableName};";
            cmd.Parameters.Add("@name", DbType.String).Value = teacher.Name;
            teacher.Id = Convert.ToInt32(cmd.ExecuteScalar());
        }

        /// <summary>
        /// 更新教师信息
        /// </summary>
        /// <param name="source">原教师数据</param>
        /// <param name="update">更新后的数据</param>
        public static void UpdateTeacher(Teacher source, Teacher update)
        {
            var connection = DatabaseManager.CreateConnection();
            var cmd = connection.CreateCommand();
            cmd.CommandText = $"UPDATE {Teacher.TableName} SET NAME = @name WHERE ID = @id";
            cmd.Parameters.Add("@name", DbType.String).Value = update.Name;
            cmd.Parameters.Add("@id", DbType.Int32).Value = source.Id;
            cmd.ExecuteNonQuery();
        }

        /// <summary>
        /// 删除一个教师
        /// </summary>
        /// <param name="delete">要删除的教师信息</param>
        public static void Delete(Teacher delete)
        {
            var connection = DatabaseManager.CreateConnection();
            var cmd = connection.CreateCommand();
            cmd.CommandText = $"DELETE FROM {Teacher.TableName} WHERE ID = @id";
            cmd.Parameters.Add("@id", DbType.Int32).Value = delete.Id;
            cmd.ExecuteNonQuery();
        }

        /// <summary>
        /// 获取数据库中所有的老师
        /// </summary>
        /// <returns>数据库中所有老师</returns>
        public static List<Teacher> GetAllTeachers()
        {
            var connection = DatabaseManager.CreateConnection();
            var cmd = connection.CreateCommand();
            cmd.CommandText = $"SELECT * FROM {Teacher.TableName}";
            var reader = cmd.ExecuteReader();
            var result = new List<Teacher>();
            while (reader.Read())
            {
                result.Add(new Teacher(Convert.ToInt32(reader[0]), reader[1].ToString()));
            }
            return result;
        }
    }
}
