using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseScheduling
{
    public partial class WaitingFrm : Form
    {
        private WaitingFrm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 窗体正在执行的异步动作
        /// </summary>
        private readonly Task _task;

        /// <summary>
        /// 保存窗体的构造函数
        /// </summary>
        /// <param name="task">执行的动作</param>
        public WaitingFrm(Task task) : this()
        {
            _task = task;
        }

        /// <summary>
        /// 加载窗体触发
        /// </summary>
        private void WaitingFrm_Load(object sender, EventArgs e)
        {
            _task.ContinueWith(task =>
            {
                if (_task.Exception != null)
                {
                    MessageBox.Show($@"文件导出失败！可能是本机没有安装Office组件！具体原因是：{_task.Exception.Message}");
                }
                return BeginInvoke((Action) (Close));
            });
            if (_task.IsCompleted || _task.IsFaulted || _task.IsCanceled)
            {
                if (_task.Exception != null)
                {
                    MessageBox.Show($@"文件导出失败！可能是本机没有安装Office组件！具体原因是：{_task.Exception.Message}");
                }
                BeginInvoke((Action)(Close));
            }
        }
    }
}
