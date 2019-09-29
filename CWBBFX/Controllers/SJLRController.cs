using CWBBFX.Models.SJLR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CWBBFX.Controllers
{
    public class SJLRController : Controller
    {
        /// <summary>
        /// 个人首页
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult PersonIndex()
        {
            return View();
        }

        [HttpPost]
        public ActionResult PersonIndex(PersonIndex_RequestObject obj)
        {
            return View();
        }


        /// <summary>
        /// 企业首页
        /// </summary>
        /// <returns></returns>
        public ActionResult EnterpriseIndex()
        {
            return View();
        }
    }
    
}