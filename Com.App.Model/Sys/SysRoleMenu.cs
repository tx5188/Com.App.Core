using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
namespace Com.App.Model.Sys
{
    public class SysRoleMenu : Entity
    {
       // public int Id { get; set; }
        public int RoleId { get; set; }
        public int MenuId { get; set; }

        /// <summary>
        /// 记录人ID
        /// </summary>
        /// <returns></returns>
        public int RecordId { get; set; }
        /// <summary>
        /// 记录日期
        /// </summary>
        /// <returns></returns>
        public DateTime RecordDate { get; set; }
    }
}