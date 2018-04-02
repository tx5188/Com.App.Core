using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
namespace Com.App.Model.Sys {
    public class SysRole : Entity
    {
        //public int Id { get; set; }
        public int RoleName { get; set; }  
        public string Memo { get; set; }
        public int DeleteFlag { get; set; } 
    }
}