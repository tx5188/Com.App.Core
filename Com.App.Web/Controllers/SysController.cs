using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Com.App.Common;
using Com.App.IBll.Sys;
using Com.App.Web.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Com.App.Web.Controllers
{
    public class SysController : Controller

    {
        private IBll_SysMenu bllmenu;

        public SysController(IBll_SysMenu menu)
        {
            bllmenu = menu;
        }
        public IActionResult Menu()
        {
            List<Model.Sys.SysMenu> list = bllmenu.GetListAll();
            return View(list);
        }
        [HttpPost]
        public String getSysMenuList(Param param)
        {
            try
            {
                TableData  dt = bllmenu.getSysMenuList(param);
                string  res= JsonConvert.SerializeObject(dt, new IsoDateTimeConverter { DateTimeFormat = "yyyy-MM-dd HH:mm:ss" });
                return res;

            }
            catch(Exception ex) {
                return null;
            }
        }
        [HttpPost]
        public String GetListMenu(string parentId)
        {
            try
            {
                List<Model.Sys.SysMenu> dt = bllmenu.GetListMenu(parentId);
                string  res= JsonConvert.SerializeObject(dt, new IsoDateTimeConverter { DateTimeFormat = "yyyy-MM-dd HH:mm:ss" });
                return res;

            }
            catch(Exception ex) {
                return null;
            }
        }
        [HttpPost]
        public String saveSysMenu(string menuCode, string menuName, string menuUrl, string parentId, string remark)
        {
            try
            {
                Model.Sys.SysMenu menu = new Model.Sys.SysMenu();
                menu.ParentId = Convert.ToInt32(parentId);
                menu.MenuCode = menuCode;
                menu.MenuName = menuName;
                menu.Url = menuUrl;
                menu.Memo = remark;
                menu.DeleteFlag = 0;
                menu.IsOperate = 0;
                menu.IsShow = 1;
                menu.MenuOrder = 1;
                menu.RecordDate = System.DateTime.Now;
                menu.RecordMan = "管理员";
                TableData dt = bllmenu.SaveMenu(menu);
                string  res= JsonConvert.SerializeObject(dt, new IsoDateTimeConverter { DateTimeFormat = "yyyy-MM-dd HH:mm:ss" });
                return res;

            }
            catch(Exception ex) {
                return null;
            }
        }
        [HttpPost]
        public String updateMenu(int id,string menuCode, string menuName, string menuUrl, string parentId, string remark)
        {
            try
            {
                Model.Sys.SysMenu menu = bllmenu.GetMenuById(id);
                menu.ParentId = Convert.ToInt32(parentId);
                menu.MenuCode = menuCode;
                menu.MenuName = menuName;
                menu.Url = menuUrl;
                menu.Memo = remark; 
                menu.UpdateDate = System.DateTime.Now;
                menu.UpdateMan = "管理员";
                TableData dt = bllmenu.UpdaMenu(menu);
                string  res= JsonConvert.SerializeObject(dt, new IsoDateTimeConverter { DateTimeFormat = "yyyy-MM-dd HH:mm:ss" });
                return res;

            }
            catch(Exception ex) {
                return null;
            }
        }
        [HttpPost]
        public String deleteMenu(int id)
        {
            try
            {
                Model.Sys.SysMenu menu = bllmenu.GetMenuById(id);
                menu.DeleteFlag = 1;
                TableData dt = bllmenu.DelMenu(menu);
                string  res= JsonConvert.SerializeObject(dt, new IsoDateTimeConverter { DateTimeFormat = "yyyy-MM-dd HH:mm:ss" });
                return res; 
            }
            catch(Exception ex) {
                return null;
            }
        }
    }
}