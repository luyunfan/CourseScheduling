using System;

namespace CourseScheduling.exceptions
{
    /// <summary>
    /// 数据库调用修改函数但是没有修改任何值的异常
    /// </summary>
    public class ChangeNothingException : Exception
    {
        /// <summary>
        /// 异常构造函数
        /// </summary>
        /// <param name="msg">异常发生的信息</param>
        public ChangeNothingException(string msg) : base(msg)
        {
        }
    }
}
