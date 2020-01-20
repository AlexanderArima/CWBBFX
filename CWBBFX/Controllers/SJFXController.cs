using CWBBFX.ViewModel.SJFX;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Mvc;

namespace CWBBFX.Controllers
{
    public class SJFXController : Controller
    {
        /// <summary>
        /// 数据分析（个人）
        /// </summary>
        /// <returns></returns>
        public ActionResult PersonIndex()
        {
            var yf = Url.RequestContext.HttpContext.Request["YF"];
            PersonIndexViewModel model = null;
            if(yf == null)
            {
                model = PersonIndexViewModel.Query(DateTime.Now);
            }
            else
            {
                if(Regex.IsMatch(yf, @"^\d[6]$"))
                {
                    int year = Convert.ToInt32(yf.Substring(0, 4));
                    int month = Convert.ToInt32(yf.Substring(4, 2));
                    DateTime date = new DateTime(year, month, 1);
                    model = PersonIndexViewModel.Query(date);
                }
               
            }
          
            ViewData["JZ"] = model.JZ;
            ViewData["JZHB"] = model.JZHB;
            ViewData["code"] = model.code;
            ViewData["msg"] = model.msg;
            return View();
        }
        
    }
}