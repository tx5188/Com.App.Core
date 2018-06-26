using System;
using System.Collections.Generic;
using System.Text;

namespace Com.App.Common
{
    /// <summary>
    /// table的返回数据
    /// </summary>
    public class TableData
    {
        /// <summary>
        /// 状态码
        /// </summary>
        public int code;
        /// <summary>
        /// 操作消息
        /// </summary>
        public string msg;

        /// <summary>
        /// 总记录条数
        /// </summary>
        public int totalCount;

        /// <summary>
        /// 数据内容
        /// </summary>
        public dynamic result;
    }
}
