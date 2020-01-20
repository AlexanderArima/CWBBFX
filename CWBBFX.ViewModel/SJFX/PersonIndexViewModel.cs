using CWBBFX.Common.Dapper;
using CWBBFX.ViewModel.SJLR;
using System;
using System.Collections.Generic;
using System.Text;

namespace CWBBFX.ViewModel.SJFX
{
    public class PersonIndexViewModel
    {

        /// <summary>
        /// 净值
        /// </summary>
        public string JZ { get; set; }

        /// <summary>
        /// 净值环比
        /// </summary>
        public string JZHB { get; set; }

        /// <summary>
        /// 现金流
        /// </summary>
        public string XJL { get; set; }

        /// <summary>
        /// 现金流环比
        /// </summary>
        public string XJLHB { get; set; }

        /// <summary>
        /// 资产
        /// </summary>
        public string ZC { get; set; }
        
        /// <summary>
        /// 负债
        /// </summary>
        public string FZ { get; set; }

        /// <summary>
        /// 资产负债比例
        /// </summary>
        public string ZCFZBL { get; set; }

        /// <summary>
        /// 错误码，0表示返回数据成功
        /// </summary>
        public int code { get; set; } = 0;

        /// <summary>
        /// 错误信息
        /// </summary>
        public string msg { get; set; } = "";

        /// <summary>
        /// 查询
        /// </summary>
        /// <returns></returns>
        public static PersonIndexViewModel Query(DateTime date)
        {
            PersonIndexViewModel model = new PersonIndexViewModel();
            //1. 查询本月和上个月
            var list = DapperHelper.Query<T_SJLR_Person>(@"SELECT * FROM T_SJLR_Person
                                                                                                                WHERE YF = @YF OR YF = @YF2
                                                                                                                Order By YF DESC
                                                                                                                LIMIT 2 ",
                                                                                                                new
                                                                                                                {
                                                                                                                    YF = date.ToString("yyyyMM"),
                                                                                                                    YF2 = date.AddMonths(-1).ToString("yyyyMM")
                                                                                                                });
            switch (list.Count)
            {
                case 2:
                    //返回两条数据，第一条是这个月的，第二条是上个月的
                    var now_month = list[0];
                    var last_month = list[1];
                    model.JZ = now_month.JZ;
                    var jzhb = (Convert.ToDecimal(now_month.JZ) - Convert.ToDecimal(last_month.JZ)) / Convert.ToDecimal(now_month.JZ);
                    model.JZHB = Math.Round(jzhb,3).ToString("P");
                    break;
                case 1:
                    //返回一条数据，可能是这个月的也可能是上个月的
                    var item = list[0];
                    if(item.YF == date.ToString("yyyyMM"))
                    {
                        //本月
                        model.JZ = item.JZ;
                        model.JZHB = "0%";
                        break;
                    }
                    model.code = 1;
                    model.msg = "查询不到本月数据";
                    break;
                case 0:
                    //没有返回数据
                    model.code = 1;
                    model.msg = "查询不到本月数据";
                    break;
            }
            return model;
        }

    }
}
