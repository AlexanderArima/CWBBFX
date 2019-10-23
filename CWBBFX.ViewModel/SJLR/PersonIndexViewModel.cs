using CWBBFX.Common.Dapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace CWBBFX.ViewModel.SJLR
{
    /// <summary>
    /// 负责前台页面和数据库的连通
    /// </summary>
    public class PersonIndexViewModel
    {
        /// <summary>
        /// 插入数据
        /// </summary>
        public static Tuple<bool,string> Insert(PersonIndexViewModel_ReqObj req)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append(@"SELECT COUNT(*) FROM T_SJLR_Person
                                     WHERE YF = @YF");
            int result = DapperHelper.QuerySingle<int>(sql.ToString(), new {
                YF = req.text_yf
            });
            if(result > 0)
            {
                return new Tuple<bool, string>(false, "当前月份的报表已存在");
            }
            sql.Clear();
            sql.Append(@"INSERT INTO T_SJLR_Person (
                              ID,
                              YF,
                              GZ,
                              BDSR,
                              FH,
                              FZ,
                              YW,
                              QT1,
                              QT2,
                              SRHJ,
                              RCKX,
                              BDZC,
                              FD,
                              CD,
                              XFD,
                              XX,
                              XL,
                              ZCQT1,
                              ZCQT2,
                              ZCHJ,
                              XJL,
                              CX,
                              TZCB,
                              ZZC1_MC,
                              ZZC1_SL,
                              ZZC1_JG,
                              ZZC1_HJ,
                              ZZC2_MC,
                              ZZC2_SL,
                              ZZC2_JG,
                              ZZC2_HJ,
                              ZZC3_MC,
                              ZZC3_SL,
                              ZZC3_JG,
                              ZZC3_HJ,
                              ZZC4_MC,
                              ZZC4_SL,
                              ZZC4_JG,
                              ZZC4_HJ,
                              ZZC5_MC,
                              ZZC5_SL,
                              ZZC5_JG,
                              ZZC5_HJ,
                              FC1_MC,
                              FC1_JG,
                              FC2_MC,
                              FC2_JG,
                              ZZC,
                              FZFD,
                              FZCD,
                              FZXFD,
                              FZFC1MC,
                              FZFC1JG,
                              FZFC1DK,
                              FZFC2MC,
                              FZFC2JG,
                              FZFC2DK,
                              ZFZ,
                              JZ
                          )
                          VALUES (
                              @ID,
                              @YF,
                              @GZ,
                              @BDSR,
                              @FH,
                              @FZ,
                              @YW,
                              @QT1,
                              @QT2,
                              @SRHJ,
                              @RCKX,
                              @BDZC,
                              @FD,
                              @CD,
                              @XFD,
                              @XX,
                              @XL,
                              @ZCQT1,
                              @ZCQT2,
                              @ZCHJ,
                              @XJL,
                              @CX,
                              @TZCB,
                              @ZZC1_MC,
                              @ZZC1_SL,
                              @ZZC1_JG,
                              @ZZC1_HJ,
                              @ZZC2_MC,
                              @ZZC2_SL,
                              @ZZC2_JG,
                              @ZZC2_HJ,
                              @ZZC3_MC,
                              @ZZC3_SL,
                              @ZZC3_JG,
                              @ZZC3_HJ,
                              @ZZC4_MC,
                              @ZZC4_SL,
                              @ZZC4_JG,
                              @ZZC4_HJ,
                              @ZZC5_MC,
                              @ZZC5_SL,
                              @ZZC5_JG,
                              @ZZC5_HJ,
                              @FC1_MC,
                              @FC1_JG,
                              @FC2_MC,
                              @FC2_JG,
                              @ZZC,
                              @FZFD,
                              @FZCD,
                              @FZXFD,
                              @FZFC1MC,
                              @FZFC1JG,
                              @FZFC1DK,
                              @FZFC2MC,
                              @FZFC2JG,
                              @FZFC2DK,
                              @ZFZ,
                              @JZ);");
            int num = DapperHelper.Execute(sql.ToString(),new {
                    ID = Guid.NewGuid().ToString(),
                    YF = req.text_yf,
                    GZ = req.number_gz,
                    BDSR = req.number_bdsr,
                    FH = req.number_fh,
                    FZ = req.number_fz,
                    YW = req.number_yw,
                    QT1 = req.number_qt1,
                    QT2 = req.number_qt2,
                    SRHJ = req.number_srhj,
                    RCKX = req.number_rckx,
                    BDZC = req.number_bdzc,
                    FD = req.number_fd,
                    CD = req.number_cd,
                    XFD = req.number_xfd,
                    XX = req.number_xx,
                    XL = req.number_xl,
                    ZCQT1 = req.number_zcqt1,
                    ZCQT2 = req.number_zcqt2,
                    ZCHJ = req.number_zchj,
                    XJL = req.number_xjl,
                    CX = req.number_cx,
                    TZCB = req.number_tzcb,
                    ZZC1_MC = req.number_zzc1_mc,
                    ZZC1_SL = req.number_zzc1_sl,
                    ZZC1_JG = req.number_zzc1_jg,
                    ZZC1_HJ = req.number_zzc1_hj,
                    ZZC2_MC = req.number_zzc2_mc,
                    ZZC2_SL = req.number_zzc2_sl,
                    ZZC2_JG = req.number_zzc2_jg,
                    ZZC2_HJ = req.number_zzc2_mc,
                    ZZC3_MC = req.number_zzc3_mc,
                    ZZC3_SL = req.number_zzc2_sl,
                    ZZC3_JG = req.number_zzc3_jg,
                    ZZC3_HJ = req.number_zzc3_hj,
                    ZZC4_MC = req.number_zzc4_mc,
                    ZZC4_SL = req.number_zzc4_sl,
                    ZZC4_JG = req.number_zzc4_jg,
                    ZZC4_HJ = req.number_zzc4_hj,
                    ZZC5_MC = req.number_zzc5_mc,
                    ZZC5_SL = req.number_zzc5_sl,
                    ZZC5_JG = req.number_zzc5_jg,
                    ZZC5_HJ = req.number_zzc5_hj,
                    FC1_MC = req.number_fc1_mc,
                    FC1_JG = req.number_fc1_jg,
                    FC2_MC = req.number_fc2_jg,
                    FC2_JG = req.number_fc2_jg,
                    ZZC = req.number_zzc,
                    FZFD = req.number_fz_fd,
                    FZCD = req.number_fz_cd,
                    FZXFD = req.number_fz_xfd,
                    FZFC1MC = req.number_fz_fc1mc,
                    FZFC1JG = req.number_fz_fc1jg,
                    FZFC1DK = req.number_fz_fc1dk,
                    FZFC2MC = req.number_fz_fc2mc,
                    FZFC2JG = req.number_fz_fc2jg,
                    FZFC2DK = req.number_fz_fc2dk,
                    ZFZ = req.number_zfz,
                    JZ = req.number_jz
            });
            if(num > 0)
            {
                return new Tuple<bool, string>(true, ""); ;
            }
            else
            {
                return new Tuple<bool, string>(false, "未能成功插入数据");
            }
        }


    }

    public class T_SJLR_Person
    {

        /// <summary>
        /// 月份
        /// </summary>
        public string YF { get; set; }

        /// <summary>
        /// 工资
        /// </summary>
        public string GZ { get; set; }

        /// <summary>
        /// 被动收入
        /// </summary>
        public string BDSR { get; set; }

        /// <summary>
        /// 分红
        /// </summary>
        public string FH { get; set; }

        /// <summary>
        /// 房租收入
        /// </summary>
        public string FZ { get; set; }

        /// <summary>
        /// 意外收入
        /// </summary>
        public string YW { get; set; }

        /// <summary>
        /// 其他收入1
        /// </summary>
        public string QT1 { get; set; }

        /// <summary>
        /// 其他收入2
        /// </summary>
        public string QT2 { get; set; }

        /// <summary>
        /// 收入合计
        /// </summary>
        public string SRHJ { get; set; }

        /// <summary>
        /// 日常开销
        /// </summary>
        public string RCKX { get; set; }

        /// <summary>
        /// 被动支出
        /// </summary>
        public string BDZC { get; set; }

        /// <summary>
        /// 房贷支出
        /// </summary>
        public string FD { get; set; }

        /// <summary>
        /// 车贷支出
        /// </summary>
        public string CD { get; set; }

        /// <summary>
        /// 消费贷支出
        /// </summary>
        public string XFD { get; set; }

        /// <summary>
        /// 学习支出
        /// </summary>
        public string XX { get; set; }

        /// <summary>
        /// 享乐支出
        /// </summary>
        public string XL { get; set; }

        /// <summary>
        /// 其他支出1
        /// </summary>
        public string ZCQT1 { get; set; }

        /// <summary>
        /// 其他支出2
        /// </summary>
        public string ZCQT2 { get; set; }

        /// <summary>
        /// 支出合计
        /// </summary>
        public string ZCHJ { get; set; }

        /// <summary>
        /// 本月现金流
        /// </summary>
        public string XJL { get; set; }

        /// <summary>
        /// 储蓄
        /// </summary>
        public string CX { get; set; }

        /// <summary>
        /// 投资储备
        /// </summary>
        public string TZCB { get; set; }

        /// <summary>
        /// 纸质产1的名称
        /// </summary>
        public string ZZC1_MC { get; set; }

        /// <summary>
        /// 纸质产1的数量
        /// </summary>
        public string ZZC1_SL { get; set; }

        /// <summary>
        /// 纸质产1的价格
        /// </summary>
        public string ZZC1_JG { get; set; }

        /// <summary>
        /// 纸质产1的合计
        /// </summary>
        public string ZZC1_HJ { get; set; }

        /// <summary>
        /// 纸质产2的名称
        /// </summary>
        public string ZZC2_MC { get; set; }

        /// <summary>
        /// 纸质产2的数量
        /// </summary>
        public string ZZC2_SL { get; set; }

        /// <summary>
        /// 纸质产2的价格
        /// </summary>
        public string ZZC2_JG { get; set; }

        /// <summary>
        /// 纸质产2的合计
        /// </summary>
        public string ZZC2_HJ { get; set; }

        /// <summary>
        /// 纸质产3的名称
        /// </summary>
        public string ZZC3_MC { get; set; }

        /// <summary>
        /// 纸质产3的数量
        /// </summary>
        public string ZZC3_SL { get; set; }

        /// <summary>
        /// 纸质产3的价格
        /// </summary>
        public string ZZC3_JG { get; set; }

        /// <summary>
        /// 纸质产3的合计
        /// </summary>
        public string ZZC3_HJ { get; set; }

        /// <summary>
        /// 纸质产4的名称
        /// </summary>
        public string ZZC4_MC { get; set; }

        /// <summary>
        /// 纸质产4的数量
        /// </summary>
        public string ZZC4_SL { get; set; }

        /// <summary>
        /// 纸质产4的价格
        /// </summary>
        public string ZZC4_JG { get; set; }

        /// <summary>
        /// 纸质产4的合计
        /// </summary>
        public string ZZC4_HJ { get; set; }

        /// <summary>
        /// 纸质产5的名称
        /// </summary>
        public string ZZC5_MC { get; set; }

        /// <summary>
        /// 纸质产5的数量
        /// </summary>
        public string ZZC5_SL { get; set; }

        /// <summary>
        /// 纸质产5的价格
        /// </summary>
        public string ZZC5_JG { get; set; }

        /// <summary>
        /// 纸质产5的合计
        /// </summary>
        public string ZZC5_HJ { get; set; }

        /// <summary>
        /// 房产1的名称
        /// </summary>
        public string FC1_MC { get; set; }

        /// <summary>
        /// 房产1的价格
        /// </summary>
        public string FC1_JG { get; set; }

        /// <summary>
        /// 房产2的名称
        /// </summary>
        public string FC2_MC { get; set; }

        /// <summary>
        /// 房产2的价格
        /// </summary>
        public string FC2_JG { get; set; }

        /// <summary>
        /// 总资产
        /// </summary>
        public string ZZC { get; set; }

        /// <summary>
        /// 负债房贷
        /// </summary>
        public string FZFD { get; set; }

        /// <summary>
        /// 负债车贷
        /// </summary>
        public string FZCD { get; set; }

        /// <summary>
        /// 负债消费贷
        /// </summary>
        public string FZXFD { get; set; }

        /// <summary>
        /// 房产1名称 - 负债
        /// </summary>
        public string FZFC1MC { get; set; }

        /// <summary>
        /// 房产1价格 - 负债
        /// </summary>
        public string FZFC1JG { get; set; }

        /// <summary>
        /// 房产1贷款 - 负债
        /// </summary>
        public string FZFC1DK { get; set; }

        /// <summary>
        /// 房产2名称 - 负债
        /// </summary>
        public string FZFC2MC { get; set; }

        /// <summary>
        /// 房产2价格 - 负债
        /// </summary>
        public string FZFC2JG { get; set; }

        /// <summary>
        /// 房产2贷款 - 负债
        /// </summary>
        public string FZFC2DK { get; set; }

        /// <summary>
        /// 总负债
        /// </summary>
        public string ZFZ { get; set; }

        /// <summary>
        /// 净值
        /// </summary>
        public string JZ { get; set; }
    }

    /// <summary>
    /// 个人财务报表的请求参数
    /// </summary>
    public class PersonIndexViewModel_ReqObj
    {
        /// <summary>
        /// 月份
        /// </summary>
        public string text_yf { get; set; }

        /// <summary>
        /// 工资
        /// </summary>
        public string number_gz { get; set; }

        /// <summary>
        /// 被动收入
        /// </summary>
        public string number_bdsr { get; set; }

        /// <summary>
        /// 分红
        /// </summary>
        public string number_fh { get; set; }

        /// <summary>
        /// 房租
        /// </summary>
        public string number_fz { get; set; }

        /// <summary>
        /// 意外收入
        /// </summary>
        public string number_yw { get; set; }

        /// <summary>
        /// 其他收入1
        /// </summary>
        public string number_qt1 { get; set; }

        /// <summary>
        /// 其他收入2
        /// </summary>
        public string number_qt2 { get; set; }

        /// <summary>
        /// 收入合计
        /// </summary>
        public string number_srhj { get; set; }

        /// <summary>
        /// 日常开销
        /// </summary>
        public string number_rckx { get; set; }

        /// <summary>
        /// 被动支出
        /// </summary>
        public string number_bdzc { get; set; }

        /// <summary>
        /// 房贷
        /// </summary>
        public string number_fd { get; set; }

        /// <summary>
        /// 车贷
        /// </summary>
        public string number_cd { get; set; }

        /// <summary>
        /// 消费贷
        /// </summary>
        public string number_xfd { get; set; }

        /// <summary>
        /// 学习
        /// </summary>
        public string number_xx { get; set; }

        /// <summary>
        /// 享乐
        /// </summary>
        public string number_xl { get; set; }

        /// <summary>
        /// 其他支出1
        /// </summary>
        public string number_zcqt1 { get; set; }

        /// <summary>
        /// 其他支出2
        /// </summary>
        public string number_zcqt2 { get; set; }

        /// <summary>
        /// 支出合计
        /// </summary>
        public string number_zchj { get; set; }

        /// <summary>
        /// 现金流
        /// </summary>
        public string number_xjl { get; set; }

        /// <summary>
        /// 储蓄
        /// </summary>
        public string number_cx { get; set; }

        /// <summary>
        /// 投资储备
        /// </summary>
        public string number_tzcb { get; set; }

        /// <summary>
        /// 纸质产1-名称
        /// </summary>
        public string number_zzc1_mc { get; set; }

        /// <summary>
        /// 纸质产1-数量
        /// </summary>
        public string number_zzc1_sl { get; set; }

        /// <summary>
        /// 纸质产1-价格
        /// </summary>
        public string number_zzc1_jg { get; set; }

        /// <summary>
        /// 纸质产1-合计
        /// </summary>
        public string number_zzc1_hj { get; set; }
        public string number_zzc2_mc { get; set; }
        public string number_zzc2_sl { get; set; }
        public string number_zzc2_jg { get; set; }
        public string number_zzc2_hj { get; set; }
        public string number_zzc3_mc { get; set; }
        public string number_zzc3_sl { get; set; }
        public string number_zzc3_jg { get; set; }
        public string number_zzc3_hj { get; set; }
        public string number_zzc4_mc { get; set; }
        public string number_zzc4_sl { get; set; }
        public string number_zzc4_jg { get; set; }
        public string number_zzc4_hj { get; set; }
        public string number_zzc5_mc { get; set; }
        public string number_zzc5_sl { get; set; }
        public string number_zzc5_jg { get; set; }
        public string number_zzc5_hj { get; set; }
        public string number_fc1_mc { get; set; }
        public string number_fc1_jg { get; set; }
        public string number_fc2_mc { get; set; }
        public string number_fc2_jg { get; set; }
        public string number_zzc { get; set; }
        public string number_fz_fd { get; set; }
        public string number_fz_cd { get; set; }
        public string number_fz_xfd { get; set; }
        public string number_fz_fc1mc { get; set; }
        public string number_fz_fc1jg { get; set; }
        public string number_fz_fc1dk { get; set; }
        public string number_fz_fc2mc { get; set; }
        public string number_fz_fc2jg { get; set; }
        public string number_fz_fc2dk { get; set; }
        public string number_zfz { get; set; }
        public string number_jz { get; set; }
    }

    /// <summary>
    /// 个人财务报表的响应参数
    /// </summary>
    public class PersonIndexViewModel_RespOjb
    {
        /// <summary>
        /// 返回值：999999表示数据异常
        /// </summary>
        public int code { get; set; } = 999999;

        public string msg { get; set; } = "数据异常";

        public object data { get; set; }
    }

}
