using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Com.App.Model.Sys
{
    [Table(public string SYS_DICTIONARYpublic string )]
    public class SysDictionary : Entity
    {
      
        public string DicType { get; set; }
        public string DicCode { get; set; }
        public string DicName { get; set; }
        public int DicOrder { get; set; }
        public string DicMemo{ get; set; }
        public int DeleteFlag { get; set; }
        public string RecordName { get; set; }
        public DateTime RecordDate { get; set; }
        public string UpdateName { get; set; }
        public DateTime UpdateDate { get; set; }
    }
}
