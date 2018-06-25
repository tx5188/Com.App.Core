using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
namespace Com.App.Model.Base {
    public class BaseDeparment :Entity
    {
     //   public int Id { get; set; }
        public int CompanyId { get; set; }
        public string DeptName { get; set; }
        public int ParentId { get; set; }
        public string DeptCode { get; set; }
        public int DepteType { get; set; }
        public int DeptLevel { get; set; }
        public int DeleteFlag { get; set; }
        /// <summary>
        /// ������
        /// </summary>
        public string RecordMan { get; set; }
        /// <summary>
        /// ��������
        /// </summary>
        public DateTime RecordDate { get; set; }
        /// <summary>
        /// ������
        /// </summary>
        public string UpdateMan { get; set; }
        /// <summary>
        /// ��������
        /// </summary>
        public DateTime UpdateDate { get; set; }
        [ForeignKey ("CompanyId")]
        public virtual  BaseCompany BaseCompany { get; set; }
    }
}