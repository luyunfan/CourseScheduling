using CourseScheduling.model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;

namespace CourseScheduling.dao
{
    public static class ClassroomDAO
    {
        /// <summary>
        /// 初始化Classroom表
        /// </summary>
        public static void InitTable()
        {
            var connection = DatabaseManager.CreateConnection();
            var cmd = connection.CreateCommand();
            cmd.CommandText = $"CREATE TABLE IF NOT EXISTS [{Classroom.TableName}]([NAME] varchar(10) PRIMARY KEY, [COLOR] INT NOT NULL);";
            cmd.ExecuteNonQuery();
        }

        /// <summary>
        /// 删除Classroom表
        /// </summary>
        public static void DeleteTable()
        {
            var connection = DatabaseManager.CreateConnection();
            var cmd = connection.CreateCommand();
            cmd.CommandText = $"DROP TABLE IF EXISTS [{Classroom.TableName}];";
            cmd.ExecuteNonQuery();
        }

        /// <summary>
        /// 获取所有教室信息
        /// </summary>
        /// <returns>包含所有教室的List</returns>
        public static List<Classroom> GetAllClassroom()
        {
            var connection = DatabaseManager.CreateConnection();
            var cmd = connection.CreateCommand();
            cmd.CommandText = $"SELECT * FROM {Classroom.TableName}";
            var reader = cmd.ExecuteReader();
            var result = new List<Classroom>();
            while (reader.Read())
            {
                result.Add(new Classroom(reader[0].ToString(), ColorTranslator.FromWin32(Convert.ToInt32(reader[1]))));
            }
            return result;
        }

        /// <summary>
        /// 从数据库中删除教室信息
        /// </summary>
        /// <param name="classroom">需要删除的对象</param>
        public static void Delete(Classroom classroom)
        {
            var connection = DatabaseManager.CreateConnection();
            var cmd = connection.CreateCommand();
            cmd.CommandText = $"DELETE FROM {Classroom.TableName} WHERE NAME = @name;";
            cmd.Parameters.Add("@name", DbType.String).Value = classroom.Name;
            cmd.ExecuteNonQuery();
        }

        /// <summary>
        /// 更新数据库中教室信息
        /// </summary>
        /// <param name="source">需要更新的老对象</param>
        /// <param name="update">更新值对象</param>
        public static void UpdateClassroom(Classroom source, Classroom update)
        {
            var connection = DatabaseManager.CreateConnection();
            var cmd = connection.CreateCommand();
            cmd.CommandText = $"UPDATE {Classroom.TableName} SET NAME = @name, COLOR = @color WHERE NAME = @nameOld";
            cmd.Parameters.Add("@name", DbType.String).Value = update.Name;
            cmd.Parameters.Add("@color", DbType.Int32).Value = ColorTranslator.ToWin32(update.Color);
            cmd.Parameters.Add("@nameOld", DbType.String).Value = source.Name;
            cmd.ExecuteNonQuery();
        }


        /// <summary>
        /// 向数据库添加教室
        /// </summary>
        /// <param name="classroom">需要添加的教室对象</param>
        public static void AddClassroom(Classroom classroom)
        {
            var connection = DatabaseManager.CreateConnection();
            var cmd = connection.CreateCommand();
            cmd.CommandText = $"INSERT INTO {Classroom.TableName} (NAME, COLOR) VALUES(@name, @color);";
            cmd.Parameters.Add("@name", DbType.String).Value = classroom.Name;
            cmd.Parameters.Add("@color", DbType.Int32).Value = ColorTranslator.ToWin32(classroom.Color);
            cmd.ExecuteNonQuery();
        }
    }
}
