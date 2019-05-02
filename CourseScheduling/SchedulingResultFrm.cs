using CourseScheduling.model;
using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Application = System.Windows.Forms.Application;

namespace CourseScheduling
{
    public partial class SchedulingResultFrm : Form
    {
        private SchedulingResultFrm()
        {
            InitializeComponent();
            MessageBox.Show(@"为了确保没有错误，排课结果请人工核对哦！", @"注意");
        }

        /// <summary>
        /// 需要进行排课的课程
        /// </summary>
        private readonly List<Course> _courses;

        /// <summary>
        /// 需要进行排课的教室
        /// </summary>
        private readonly List<Classroom> _classrooms;

        /// <summary>
        /// 成功添加到界面上的课程数量
        /// </summary>
        private int _addedCourseCount = 0;

        /// <summary>
        /// 排课是否成功（决定界面是否显示）
        /// </summary>
        private bool _isSchedulingSuccess = false;

        /// <summary>
        /// 排课是否成功（决定界面是否显示）
        /// </summary>
        public bool IsSchedulingSuccess => _isSchedulingSuccess;

        /// <summary>
        /// 排课结果窗体的构造函数，需要传入需要进行排课的课程和教室
        /// </summary>
        /// <param name="courses">课程</param>
        /// <param name="classrooms">教室</param>
        public SchedulingResultFrm(List<Course> courses, List<Classroom> classrooms) : this()
        {
            _courses = courses;
            _classrooms = classrooms;
            Scheduling();
        }

        /// <summary>
        /// 进行排课操作，并更新界面
        /// </summary>
        private void Scheduling()
        {
            var gradeAndCounts = new Dictionary<string, int>(_courses.Count); //Word Count
            foreach (var course in _courses)
            {
                var gradeName = course.Grade.GradeName;
                if (gradeAndCounts.ContainsKey(gradeName))
                {
                    gradeAndCounts[gradeName]++;
                }
                else
                {
                    gradeAndCounts.Add(gradeName, 1);
                }
            }
            //计算在课表出现的次数
            var gradeAndCountsList = gradeAndCounts
                .Select(gradeAndCount => new Tuple<string, int>(gradeAndCount.Key, gradeAndCount.Value / 4 + 1))
                .ToList();

            gradeAndCountsList.ForEach(tuple =>
             {
                 for (var i = 0; i < tuple.Item2; i++)
                 {
                     var column = new DataGridViewTextBoxColumn
                     {
                         Name = tuple.Item1,
                         HeaderText = tuple.Item1,
                         SortMode = DataGridViewColumnSortMode.NotSortable //不可排序
                     };
                     ResultDataGridView.Columns.Add(column);
                 }
             });

            AddRowsToDataGridView(); //添加4行时间数据
            _classrooms.ForEach(AddClassroomToDataGridView);
            ClassroomDataGridView.ClearSelection(); //默认不选中表格
            ResultDataGridView.ClearSelection();

            var result = new List<Tuple<Tuple<Course, bool[]>, Classroom, int>>(); //课程，教室，时间段
            var classrooms = new Queue<Classroom>(_classrooms);
            try
            {
                var time = 0;
                var currentClassroom = classrooms.Dequeue();
                foreach (var course in _courses)
                {
                    if (time >= 4) //每4次出队一个教室
                    {
                        time = 0;
                        currentClassroom = classrooms.Dequeue();
                    }
                    result.Add(new Tuple<Tuple<Course, bool[]>, Classroom, int>(new Tuple<Course, bool[]>(course, new[] { false }), currentClassroom, time));
                    time++;
                }
            }
            catch (InvalidOperationException) //教室用完了还在出队
            {
                MessageBox.Show(@"排课失败！教室不够用了！", @"错误！");
                return;
            }


            foreach (var res in result) //渲染到界面上
            {
                var row = ResultDataGridView.Rows[res.Item3]; //时间决定的行

                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (res.Item1.Item1.Grade.GradeName.Equals(cell.OwningColumn.HeaderText)) //找到的列
                    {
                        if (cell.Value == null && !res.Item1.Item2[0]) //如果这个Cell没有被写入过
                        {
                            AddInfoToCell(cell, res.Item2, res.Item1.Item1); //写入信息
                            res.Item1.Item2[0] = true;
                            break;
                        }
                    }
                }
            }

            foreach (var tuple in result.Where(res => !res.Item1.Item2[0])) //没有绘制到表格上的课程
            {
                var column = new DataGridViewTextBoxColumn //新添加一列
                {
                    Name = tuple.Item1.Item1.Grade.GradeName,
                    HeaderText = tuple.Item1.Item1.Grade.GradeName,
                    SortMode = DataGridViewColumnSortMode.NotSortable //不可排序
                };
                var index = ResultDataGridView.Columns.Add(column);
                AddInfoToCell(ResultDataGridView.Rows[tuple.Item3].Cells[index], tuple.Item2, tuple.Item1.Item1);
            }

            LblShowCount.Text = $@"应排课程数目：{_courses.Count}，算法完成排课数目：{result.Count}，实际界面排课数目：{_addedCourseCount}";
            if (_courses.Count != result.Count || _courses.Count != _addedCourseCount)
            {
                LblShowCount.ForeColor = Color.Red;
                LblShowCount.Text += @" 出现异常！";
            }

            _isSchedulingSuccess = true;
        }

        /// <summary>
        /// 给结果表中添加基础空行
        /// </summary>
        private void AddRowsToDataGridView()
        {
            var rows = ResultDataGridView.Rows;
            for (var i = 0; i < 4; i++) //增加四行数据
            {
                rows.Add();
                rows[i].Height = ResultDataGridView.ColumnHeadersHeight; //设置高度
            }
            rows[0].HeaderCell.Value = "上午8:30 - 10:20";
            rows[1].HeaderCell.Value = "上午10:30 - 12:20";
            rows[2].HeaderCell.Value = "下午2:00 - 3:50";
            rows[3].HeaderCell.Value = "下午4:00 - 5:50";
        }

        /// <summary>
        /// 添加一个教室到教室显示列
        /// </summary>
        /// <param name="classroom">新添加的教室</param>
        private void AddClassroomToDataGridView(Classroom classroom)
        {
            var index = ClassroomDataGridView.Rows.Add();
            var row = ClassroomDataGridView.Rows[index];
            row.Height = ClassroomDataGridView.ColumnHeadersHeight;
            row.Cells[0].Value = classroom.Name;
            row.Cells[0].Style.BackColor = classroom.Color;
        }

        /// <summary>
        /// 向数据单元格中写入信息
        /// </summary>
        /// <param name="cell">单元格对象</param>
        /// <param name="classroom">要添加的教室对象</param>
        /// <param name="course">要添加的课程对象</param>
        private void AddInfoToCell(DataGridViewCell cell, Classroom classroom, Course course)
        {
            cell.Style.BackColor = classroom.Color;
            cell.Value = $"{course.VipInfo}\r\n{course.Name}\r\n({course.Teacher.Name})";
            _addedCourseCount++;
        }

        /// <summary>
        /// 确定按钮
        /// </summary>
        private void OKBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// 导出到Excel按钮
        /// </summary>
        private void ExportExcelBtn_Click(object sender, EventArgs e)
        {
            var saveDialog = new SaveFileDialog
            {
                DefaultExt = "xlsx",
                Filter = @"Excel文件 | *.xlsx",
                FileName = "排课结果"
            };
            var result = saveDialog.ShowDialog();
            if (result == DialogResult.Cancel) //点了取消什么都不做
            {
                return;
            }

            var task = Task.Run(() =>
            {
                var saveFileName = saveDialog.FileName;
                Microsoft.Office.Interop.Excel.Application excelApplication = null;
                try
                {
                    excelApplication = new Microsoft.Office.Interop.Excel.Application();
                    var workbooks = excelApplication.Workbooks;
                    var workbook = workbooks.Add(XlWBATemplate.xlWBATWorksheet);
                    var worksheet = (Worksheet)workbook.Worksheets[1]; //取得sheet1

                    var column = 0;
                    for (var i = 1; i <= ResultDataGridView.ColumnCount; i++)
                    {
                        worksheet.Cells[1, i + 1] = ResultDataGridView.Columns[i - 1].HeaderText;
                        var range = worksheet.Range[worksheet.Cells[1, i + 1], worksheet.Cells[1, i + 1]];
                        range.HorizontalAlignment = XlHAlign.xlHAlignCenter;//水平居中  
                        range.VerticalAlignment = XlVAlign.xlVAlignCenter;//垂直居中  
                        column = i;
                    }
                    worksheet.Cells[1, column + 2] = ClassroomDataGridView.Columns[0].HeaderText; //添加教室列
                    var classroomRange = worksheet.Range[worksheet.Cells[1, column + 2], worksheet.Cells[1, column + 2]];
                    classroomRange.HorizontalAlignment = XlHAlign.xlHAlignCenter;//水平居中  
                    classroomRange.VerticalAlignment = XlVAlign.xlVAlignCenter;//垂直居中  

                    //写入数值
                    for (var r = 0; r < ResultDataGridView.RowCount; r++)
                    {
                        for (var i = 1; i <= ResultDataGridView.ColumnCount; i++)
                        {
                            var text = (string)ResultDataGridView.Rows[r].Cells[i - 1].Value;
                            if (string.IsNullOrEmpty(text))
                            {
                                continue;
                            }

                            worksheet.Cells[r + 2, i + 1] = text;
                            var cell = worksheet.Cells[r + 2, i + 1];
                            var range = worksheet.Range[cell, cell];
                            range.HorizontalAlignment = XlHAlign.xlHAlignCenter;//水平居中  
                            range.VerticalAlignment = XlVAlign.xlVAlignCenter;//垂直居中  
                            var backColor = ResultDataGridView.Rows[r].Cells[i - 1].Style.BackColor;
                            range.Interior.Color = backColor;
                        }
                    }

                    for (var row = 0; row < ClassroomDataGridView.RowCount; row++)
                    {
                        var text = (string)ClassroomDataGridView.Rows[row].Cells[0].Value;
                        worksheet.Cells[row + 2, column + 2] = text;
                        var cell = worksheet.Cells[row + 2, column + 2];
                        var range = worksheet.Range[cell, cell];
                        range.HorizontalAlignment = XlHAlign.xlHAlignCenter;//水平居中  
                        range.VerticalAlignment = XlVAlign.xlVAlignCenter;//垂直居中  
                        var backColor = ClassroomDataGridView.Rows[row].Cells[0].Style.BackColor;
                        range.Interior.Color = backColor;
                    }
                    Application.DoEvents();

                    worksheet.Cells[2, 1] = "上午8:30 - 10:20"; //加时间
                    worksheet.Cells[3, 1] = "上午10:30 - 12:20";
                    worksheet.Cells[4, 1] = "下午2:00 - 3:50";
                    worksheet.Cells[5, 1] = "下午4:00 - 5:50";
                    var timeRange = worksheet.Range[worksheet.Cells[2, 1], worksheet.Cells[5, 1]];
                    timeRange.HorizontalAlignment = XlHAlign.xlHAlignCenter;//水平居中  
                    timeRange.VerticalAlignment = XlVAlign.xlVAlignCenter;//垂直居中  

                    var rowcount = worksheet.UsedRange.CurrentRegion.Rows.Count; //加边框
                    var borderRange = worksheet.Range[worksheet.Cells[1, 1], worksheet.Cells[rowcount, ResultDataGridView.ColumnCount + 1]];
                    borderRange.Borders.LineStyle = XlLineStyle.xlContinuous;

                    worksheet
                        .Range[worksheet.Cells[1, column + 2], worksheet.Cells[ClassroomDataGridView.RowCount + 1, column + 2]]
                        .Borders.LineStyle = XlLineStyle.xlContinuous;

                    worksheet.Columns.EntireColumn.AutoFit(); //列宽自适应

                    if (saveFileName != "")
                    {
                        try
                        {
                            workbook.Saved = true;
                            workbook.SaveCopyAs(saveFileName);
                        }
                        catch (Exception)
                        {
                            MessageBox.Show(@"导出文件时出错，文件可能正被使用！");
                            return;
                        }
                    }


                    MessageBox.Show($@"文件：{saveFileName} 保存成功", @"提示", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                catch (System.Runtime.InteropServices.COMException ex)
                {
                    MessageBox.Show($@"文件导出失败！可能是本机没有安装Office组件！具体原因是：{ex.Message}");
                }
                finally
                {
                    excelApplication?.Quit();
                }
            });

            var form = new WaitingFrm(task); //等待界面
            form.ShowDialog();

        }
    }
}
