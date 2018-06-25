using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
namespace Com.App.Model.Sys
{
    public class SysMenu : Entity
    {
       // public int Id { get; set; }
        public string MenuName { get; set; }
        /// <summary>
        /// 编号
        /// </summary>
        /// <returns></returns>
        public string MenuCode { get; set; }
        /// <summary>
        /// 路径
        /// </summary>
        /// <returns></returns>
        public string Url { get; set; }
        /// <summary>
        /// tab：页签,dialog：弹出页
        /// </summary>
        /// <returns></returns>
        public string Target { get; set; }
        /// <summary>
        /// o-菜单 1-按钮（功能项）
        /// </summary>
        /// <returns></returns>
        public int IsOperate { get; set; }
        
        public int ParentId { get; set; }
        /// <summary>
        /// 是否显示 0 不显示 1显示
        /// </summary>
        /// <returns></returns>
        public int IsShow { get; set; }
        /// <summary>
        /// 排序
        /// </summary>
        /// <returns></returns>
        public int MenuOrder { get; set; }
        public string Img { get; set; }
        public string Memo { get; set; }
        public int DeleteFlag { get; set; }
        /// <summary>
        /// 新增人
        /// </summary>
        public string RecordMan { get; set; }
        /// <summary>
        /// 新增日期
        /// </summary>
        public DateTime RecordDate { get; set; }
        /// <summary>
        /// 更新人
        /// </summary>
        public string UpdateMan { get; set; }
        /// <summary>
        /// 更新日期
        /// </summary>
        public DateTime UpdateDate { get; set; }
    }
}