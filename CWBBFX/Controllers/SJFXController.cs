using CWBBFX.ViewModel.SJFX;
using System;
using System.Collections.Generic;
using System.Linq;
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
            PersonIndexViewModel.Query(DateTime.Now);

            return View();
        }
        
    }
}