using CourseScheduling.dao;
using System;
using System.IO;
using System.Windows.Forms;

namespace CourseScheduling
{
    static class Program
    {
        /// <summary>
        /// SQLite数据库文件名
        /// </summary>
        public static readonly string DatabasePath = "data.db";

        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            if (!File.Exists(DatabasePath)) //如果程序第一次运行不存在数据库
            {
                DatabaseManager.CreateDatabase(); //则建表初始化数据库
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainFrm());
        }
    }
}
