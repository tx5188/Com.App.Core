using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Com.App.Model.Task
{
    /// <summary>
    /// 现场测试任务通知单明细
    /// </summary>
    [Table("TASK_TESTNOTICE_DETAIL")]
    public class TestTaskNoticeDetail:Entity
    {
        /// <summary>
        /// 现场测试任务id
        /// </summary>
        public int TestTaskId { get; set; }
        /// <summary>
        /// 测试项目（数据字典）
        /// </summary>
        public string TestProject { get; set; }
        /// <summary>
        /// 测试样品数量
        /// </summary>
        public int TestSampleNum { get; set; } 
        /// <summary>
        /// 采样点id
        /// </summary>
        public int PointId { get; set; }
        /// <summary>
        /// 分析方法(可字典选择)
        /// </summary>
        public string AnalysisMethod { get; set; }
        /// <summary>
        /// 要求检测完成时
        /// </summary>
        public string  TestFinishTime { get; set; }
        /// <summary>
        /// 检测人
        /// </summary>
        public String TestMan { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        public String Memo { get; set; }

    }
}
