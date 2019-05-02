using CourseScheduling.model;
using System;
using System.Collections.Generic;
using System.Data;

namespace CourseScheduling.dao
{
    /// <summary>
    /// 课程的数据访问对象
    /// </summary>
    public static class CourseDAO
    {
        /// <summary>
        /// 添加课程到数据库（课程的ID会被忽略，由数据库管理）
        /// </summary>
        /// <param name="course">需要添加的课程</param>
        /// <returns>添加成功得到的主键值</returns>
        public static void AddCourse(Course course)
        {
            var connection = DatabaseManager.CreateConnection();
            var cmd = connection.CreateCommand();
            cmd.CommandText = $"INSERT INTO {Course.TableName} (NAME, GRADE, TEACHER, VIPINFO) VALUES(@name, @grade, @teacher, @vipInfo);SELECT MAX(ID) FROM {Course.TableName};";
            cmd.Parameters.Add("@name", DbType.String).Value = course.Name;
            cmd.Parameters.Add("@grade", DbType.String).Value = course.Grade.GradeName;
            cmd.Parameters.Add("@teacher", DbType.String).Value = course.Teacher.Name;
            cmd.Parameters.Add("@vipInfo", DbType.String).Value = course.VipInfo;
            course.Id = Convert.ToInt32(cmd.ExecuteScalar());
        }

        /// <summary>
        /// 从数据库获取所有课程
        /// </summary>
        /// <returns>所有课程组成的List</returns>
        public static List<Course> GetAllCourses()
        {
            var connection = DatabaseManager.CreateConnection();
            var cmd = connection.CreateCommand();
            cmd.CommandText = $"SELECT * FROM {Course.TableName};";
            var reader = cmd.ExecuteReader();
            var result = new List<Course>();
            while (reader.Read())
            {
                var id = Convert.ToInt32(reader[0]);
                var name = reader[1].ToString();
                var grade = new Grade(reader[2].ToString());
                var teacher = new Teacher(-1, reader[3].ToString());
                var vipInfo = reader[4].ToString();
                var course = new Course(id, name, grade, teacher, vipInfo);
                result.Add(course);
            }
            return result;
        }

        /// <summary>
        /// 修改课程的值（根据原值ID查找新值修改）
        /// </summary>
        /// <param name="source">原值</param>
        /// <param name="changed">修改后新的值</param>
        public static void UpdateCourseValues(Course source, Course changed)
        {
            var connection = DatabaseManager.CreateConnection();
            var cmd = connection.CreateCommand();
            cmd.CommandText = $"UPDATE {Course.TableName} SET NAME = @name, GRADE = @grade, TEACHER = @teacher, VIPINFO = @vipInfo WHERE ID=@id;";
            cmd.Parameters.Add("@name", DbType.String).Value = changed.Name;
            cmd.Parameters.Add("@grade", DbType.String).Value = changed.Grade.GradeName;
            cmd.Parameters.Add("@teacher", DbType.String).Value = changed.Teacher.Name;
            cmd.Parameters.Add("@vipInfo", DbType.String).Value = changed.VipInfo;
            cmd.Parameters.Add("@id", DbType.Int32).Value = source.Id;
            cmd.ExecuteNonQuery();
        }

        public static void DeleteCourse(Course delete)
        {
            var connection = DatabaseManager.CreateConnection();
            var cmd = connection.CreateCommand();
            cmd.CommandText = $"DELETE FROM {Course.TableName} WHERE ID = @id";
            cmd.Parameters.Add("@id", DbType.Int32).Value = delete.Id;
            cmd.ExecuteNonQuery();
        }

        /// <summary>
        /// 初始化Course表
        /// </summary>
        public static void InitTable()
        {
            var connection = DatabaseManager.CreateConnection();
            var cmd = connection.CreateCommand();
            cmd.CommandText = $@"CREATE TABLE IF NOT EXISTS [{Course.TableName}]( [ID] INTEGER PRIMARY KEY AUTOINCREMENT, 
[NAME] VARCHAR(15) NOT NULL, [GRADE] VARCHAR(10) NOT NULL, [TEACHER] VARCHAR(10) NOT NULL, [VIPINFO] VARCHAR(10));";
            cmd.ExecuteNonQuery();
        }

        /// <summary>
        /// 删除Course表
        /// </summary>
        public static void DeleteTable()
        {
            var connection = DatabaseManager.CreateConnection();
            var cmd = connection.CreateCommand();
            cmd.CommandText = $"DROP TABLE IF EXISTS [{Course.TableName}];";
            cmd.ExecuteNonQuery();
        }
    }
}
