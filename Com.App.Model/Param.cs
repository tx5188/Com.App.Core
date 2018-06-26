using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Com.App.Web.Models
{
    public class Param
    {
        //每页多少条数据
       public int limit { get; set; }
        public int start { get; set; }
        public int page { get; set; }
    }
}
