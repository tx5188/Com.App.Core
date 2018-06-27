using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Com.App.Common;
using Com.App.Data;
using Com.App.IBll.Sys;
using Com.App.Model;
using Com.App.Web.Models;

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace Com.App.Web.Controllers
{

    public class HomeController : Controller
    {

        private IBll_SysUser bll;
        private IBll_SysMenu bllmenu;
        public HomeController(IBll_SysUser _bll, IBll_SysMenu _bllmenu)
        {
            bll = _bll;
            bllmenu = _bllmenu;
        }
        public IActionResult Index()
        {
         
            return View();
            //return View (new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });

        }
        public IActionResult Login()
        {
            if (ModelState.IsValid)
            {
                LoginModel mode = new LoginModel();
                mode.UserName = "admin";
                if (mode.UserName == "admin")
                {
                    //记录Session
                    HttpContext.Session.Set("CurrentUser", ByteConvertHelper.Object2Bytes(mode));
                    //跳转到系统首页
                    return RedirectToAction("Index", "Home");
                }
                else
                {

                    ModelState.AddModelError("", "用户名或密码错误。");
                    return View();
                }
            }
            return View();
        }

        [HttpGet]
        public string loadSysMenu(string parentid)
        {
            List<Model.Sys.SysMenu> list = new List<Model.Sys.SysMenu>();
            list = bllmenu.GetListMenu(parentid);
            var s = JsonConvert.SerializeObject(list);
            return s;
        }
        [HttpGet]
        public void SetMenuSession(Model.Sys.SysUser user)
        {
            HttpContext.Session.Set("MenuSession", ByteConvertHelper.Object2Bytes(user));
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}