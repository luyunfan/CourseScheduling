using System;

namespace CourseScheduling.exceptions
{
    /// <summary>
    /// 存在相同的年级异常
    /// </summary>
    class HasSameGradeException : Exception
    {
        /// <summary>
        /// 构造函数，传入错误信息
        /// </summary>
        /// <param name="msg">错误异常信息</param>
        public HasSameGradeException(string msg) : base(msg)
        {
        }
    }
}
