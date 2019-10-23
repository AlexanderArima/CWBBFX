using CWBBFX.Common.Dapper;
using CWBBFX.ViewModel.SJLR;
using Newtonsoft.Json;
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
        public JsonResult PersonIndex(PersonIndexViewModel_ReqObj req)
        {
            PersonIndexViewModel_RespOjb resp = new PersonIndexViewModel_RespOjb();
            //验证
            if (req.text_yf.Length != 6)
            {
                resp.msg = "请输入正确的年月";
                return Json(resp);
            }
            var result = PersonIndexViewModel.Insert(req);
            if(result.Item1 == false)
            {
                resp.msg = result.Item2;
            }
            else
            {
                resp.code = 0;
            }
            return Json(JsonConvert.SerializeObject(resp));
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