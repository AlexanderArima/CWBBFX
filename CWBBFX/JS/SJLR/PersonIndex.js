window.onload = function () {
    //收入
    /**
     * 工资收入
     * */
    var number_gz = $("#number_gz");

    /**
     * 被动收入
     * */
    var number_bdsr = $("#number_bdsr");

    /**
     * 分红
     * */
    var number_fh = $("#number_fh");

    /**
     * 房租收入
     * */
    var number_fz = $("#number_fz");

    /**
     * 意外收入
     * */
    var number_yw = $("#number_yw");

    /**
     * 其他收入1
     * */
    var number_qt1 = $("#number_qt1");

    /**
     * 其他收2
     * */
    var number_qt2 = $("#number_qt2"); 

    /**
     * 收入合计
     * */
    var number_srhj = $("#number_srhj"); 

    //支出

    /**
     * 日常开销
     * */
    var number_rckx = $("#number_rckx"); 

    /**
     * 被动支出
     * */
    var number_bdzc = $("#number_bdzc");

    /**
     * 房贷
     * */
    var number_fd = $("#number_fd");

    /**
     * 车贷
     * */
    var number_cd = $("#number_cd");

    /**
     * 消费贷
     * */
    var number_xfd = $("#number_xfd");

    /**
     * 学习
     * */
    var number_xx = $("#number_xx");

    /**
     * 享乐
     * */
    var number_xl = $("#number_xl");

    /**
     * 其他支出1
     * */
    var number_zcqt1 = $("#number_zcqt1");

    /**
     * 其他支出2
     * */
    var number_zcqt2 = $("#number_zcqt2"); 

    /**
     * 支出合计
     * */
    var number_zchj = $("#number_zchj"); 

    /**
     * 当月现金流
     * */
    var number_xjl = $("#number_xjl");  

    //资产

    /**
     * 储蓄
     * */
    var number_cx = $("#number_cx");

    /**
     * 投资储备
     * */
    var number_tzcb = $("#number_tzcb");

    //纸质产
    var number_zzc1_mc = $("#number_zzc1_mc");
    var number_zzc1_sl = $("#number_zzc1_sl");
    var number_zzc1_jg = $("#number_zzc1_jg");
    var number_zzc1_hj = $("#number_zzc1_hj");

    var number_zzc2_mc = $("#number_zzc2_mc");
    var number_zzc2_sl = $("#number_zzc2_sl");
    var number_zzc2_jg = $("#number_zzc2_jg");
    var number_zzc2_hj = $("#number_zzc2_hj");

    var number_zzc3_mc = $("#number_zzc3_mc");
    var number_zzc3_sl = $("#number_zzc3_sl");
    var number_zzc3_jg = $("#number_zzc3_jg");
    var number_zzc3_hj = $("#number_zzc3_hj");

    var number_zzc4_mc = $("#number_zzc4_mc");
    var number_zzc4_sl = $("#number_zzc4_sl");
    var number_zzc4_jg = $("#number_zzc4_jg");
    var number_zzc4_hj = $("#number_zzc4_hj");

    var number_zzc5_mc = $("#number_zzc5_mc");
    var number_zzc5_sl = $("#number_zzc5_sl");
    var number_zzc5_jg = $("#number_zzc5_jg");
    var number_zzc5_hj = $("#number_zzc5_hj");

    var number_fc1_mc = $("#number_fc1_mc");
    var number_fc1_jg = $("#number_fc1_jg");
    var number_fc2_mc = $("#number_fc2_mc");
    var number_fc2_jg = $("#number_fc2_jg");
    var number_zzc = $("#number_zzc");

    //负债
    var number_fz_fd = $("#number_fz_fd");
    var number_fz_cd = $("#number_fz_cd");
    var number_fz_xfd = $("#number_fz_xfd");
    var number_fz_fc1mc = $("#number_fz_fc1mc");
    var number_fz_fc1jg = $("#number_fz_fc1jg");
    var number_fz_fc1dk = $("#number_fz_fc1dk");
    var number_fz_fc2mc = $("#number_fz_fc2mc");
    var number_fz_fc2jg = $("#number_fz_fc2jg");
    var number_fz_fc2dk = $("#number_fz_fc2dk");
    var number_zfz = $("#number_zfz");
    var number_jz = $("#number_jz");

    /**
     * 总负债
     * */
    var number_zfz = $("#number_zfz"); 
    
    //收入
    number_gz.change(function () {
        SRHJ();
    });

    number_fh.change(function () {
        SRHJ();
    });

    number_fz.change(function () {
        SRHJ();
    });

    number_yw.change(function () {
        SRHJ();
    });

    number_qt1.change(function () {
        SRHJ();
    });

    number_qt2.change(function () {
        SRHJ();
    });

    //支出
    number_rckx.change(function () {
        ZCHJ();
    });

    number_fd.change(function () {
        ZCHJ();
    });

    number_cd.change(function () {
        ZCHJ();
    });

    number_xfd.change(function () {
        ZCHJ();
    });
    number_xx.change(function () {
        ZCHJ();
    });

    number_xl.change(function () {
        ZCHJ();
    });

    number_zcqt1.change(function () {
        ZCHJ();
    });

    number_zcqt2.change(function () {
        ZCHJ();
    });

    number_cx.change(function () {
        ZZCHJ();
    });

    number_tzcb.change(function () {
        ZZCHJ();
    });

    number_fz_fd.change(function () {
        ZFZHJ();
    });

    number_fz_cd.change(function () {
        ZFZHJ();
    });

    number_fz_xfd.change(function () {
        ZFZHJ();
    });

    number_fz_fc1jg.change(function () {
        ZFZHJ();
    });

    number_fz_fc1dk.change(function () {
        ZFZHJ();
    });

    number_fz_fc2jg.change(function () {
        ZFZHJ();
    });

    number_fz_fc2dk.change(function () {
        ZFZHJ();
    });

    number_zzc1_sl.change(function () {
        //计算纸资产合计金额
        var total = GetPaper(number_zzc1_sl.val(), number_zzc1_jg.val());
        number_zzc1_hj.val(total);
        ZZCHJ();
    });

    number_zzc1_jg.change(function () {
        //计算纸资产合计金额
        var total = GetPaper(number_zzc1_sl.val(), number_zzc1_jg.val());
        number_zzc1_hj.val(total);
        ZZCHJ();
    });
    
    number_zzc2_sl.change(function () {
        //计算纸资产合计金额
        var total = GetPaper(number_zzc2_sl.val(), number_zzc2_jg.val());
        number_zzc2_hj.val(total);
        ZZCHJ();
    });

    number_zzc2_jg.change(function () {
        //计算纸资产合计金额
        var total = GetPaper(number_zzc2_sl.val(), number_zzc2_jg.val());
        number_zzc2_hj.val(total);
        ZZCHJ();
    });

    number_zzc3_sl.change(function () {
        //计算纸资产合计金额
        var total = GetPaper(number_zzc3_sl.val(), number_zzc3_jg.val());
        number_zzc3_hj.val(total);
        ZZCHJ();
    });

    number_zzc3_jg.change(function () {
        //计算纸资产合计金额
        var total = GetPaper(number_zzc3_sl.val(), number_zzc3_jg.val());
        number_zzc3_hj.val(total);
        ZZCHJ();
    });

    number_zzc4_sl.change(function () {
        //计算纸资产合计金额
        var total = GetPaper(number_zzc4_sl.val(), number_zzc4_jg.val());
        number_zzc4_hj.val(total);
        ZZCHJ();
    });

    number_zzc4_jg.change(function () {
        //计算纸资产合计金额
        var total = GetPaper(number_zzc4_sl.val(), number_zzc4_jg.val());
        number_zzc4_hj.val(total);
        ZZCHJ();
    });

    number_zzc5_sl.change(function () {
        //计算纸资产合计金额
        var total = GetPaper(number_zzc5_sl.val(), number_zzc5_jg.val());
        number_zzc5_hj.val(total);
        ZZCHJ();
    });

    number_zzc5_jg.change(function () {
        //计算纸资产合计金额
        var total = GetPaper(number_zzc5_sl.val(), number_zzc5_jg.val());
        number_zzc5_hj.val(total);
        ZZCHJ();
    });
    
    number_fc1_jg.change(function () {
        ZZCHJ();
    });

    number_fc2_jg.change(function () {
        ZZCHJ();
    });

    $("#button_sub").click(function () {
        //提交
        var req = {
            "number_gz": number_gz.val(),
            "number_bdsr": number_bdsr.val(),
            "number_fh": number_fh.val(),
            "number_fz": number_fz.val(),
            "number_yw": number_yw.val(),
            "number_qt1": number_qt1.val(),
            "number_qt2": number_qt2.val(),
            "number_srhj": number_srhj.val(),
            "number_rckx": number_rckx.val(),
            "number_bdzc": number_bdzc.val(),
            "number_fd": number_fd.val(),
            "number_cd": number_cd.val(),
            "number_xfd": number_xfd.val(),
            "number_xx": number_xx.val(),
            "number_xl": number_xl.val(),
            "number_zcqt1": number_zcqt1.val(),
            "number_zcqt2": number_zcqt2.val(),
            "number_zchj": number_zchj.val(),
            "number_xjl": number_xjl.val(),
            "number_cx": number_cx.val(),
            "number_tzcb": number_tzcb.val(),
            "number_zzc1_mc": number_zzc1_mc.val(),
            "number_zzc1_sl": number_zzc1_sl.val(),
            "number_zzc1_jg": number_zzc1_jg.val(),
            "number_zzc1_hj": number_zzc1_hj.val(),
            "number_zzc2_mc": number_zzc2_mc.val(),
            "number_zzc2_sl": number_zzc2_sl.val(),
            "number_zzc2_jg": number_zzc2_jg.val(),
            "number_zzc2_hj": number_zzc2_hj.val(),
            "number_zzc3_mc": number_zzc3_mc.val(),
            "number_zzc3_sl": number_zzc3_sl.val(),
            "number_zzc3_jg": number_zzc3_jg.val(),
            "number_zzc3_hj": number_zzc3_hj.val(),
            "number_zzc4_mc": number_zzc4_mc.val(),
            "number_zzc4_sl": number_zzc4_sl.val(),
            "number_zzc4_jg": number_zzc4_jg.val(),
            "number_zzc4_hj": number_zzc4_hj.val(),
            "number_zzc5_mc": number_zzc5_mc.val(),
            "number_zzc5_sl": number_zzc5_sl.val(),
            "number_zzc5_jg": number_zzc5_jg.val(),
            "number_zzc5_hj": number_zzc5_hj.val(),
            "number_fc1_mc": number_fc1_mc.val(),
            "number_fc1_jg": number_fc1_jg.val(),
            "number_fc2_mc": number_fc2_mc.val(),
            "number_fc2_jg": number_fc2_jg.val(),
            "number_zzc": number_zzc.val(),
            "number_fz_fd": number_fz_fd.val(),
            "number_fz_cd": number_fz_cd.val(),
            "number_fz_xfd": number_fz_xfd.val(),
            "number_fz_fc1mc": number_fz_fc1mc.val(),
            "number_fz_fc1jg": number_fz_fc1jg.val(),
            "number_fz_fc1dk": number_fz_fc1dk.val(),
            "number_fz_fc2mc": number_fz_fc2mc.val(),
            "number_fz_fc2jg": number_fz_fc2jg.val(),
            "number_fz_fc2dk": number_fz_fc2dk.val(),
            "number_zfz": number_zfz.val(),
            "number_jz": number_jz.val(),
        };
        console.log(JSON.stringify(req));
        $.post("PersonIndex", req, function (data) {
            console.log(data);
        });
    });
    
    /*
     * 收入合计
     * **/
    function SRHJ()
    {
        var total = 0;
        if (number_gz.val().length > 0)
        {
            total = total + parseFloat(number_gz.val());
        }
        if (number_fh.val().length > 0) {
            total = total + parseFloat(number_fh.val());
        }
        if (number_fz.val().length > 0) {
            total = total + parseFloat(number_fz.val());
        }
        if (number_yw.val().length > 0) {
            total = total + parseFloat(number_yw.val());
        }
        if (number_qt1.val().length > 0) {
            total = total + parseFloat(number_qt1.val());
        }
        if (number_qt2.val().length > 0) {
            total = total + parseFloat(number_qt2.val());
        }
        number_srhj.val(total);
        var zchj = number_zchj.val();
        if (zchj.length > 0)
        {
            number_xjl.val(total - parseFloat(zchj));
        }
        //console.log(total);
    }
    
    /*
     * 支出合计
     * **/
    function ZCHJ() {
        var total = 0;
        if (number_rckx.val().length > 0) {
            total = total + parseFloat(number_rckx.val());
        }
        if (number_fd.val().length > 0) {
            total = total + parseFloat(number_fd.val());
        }
        if (number_cd.val().length > 0) {
            total = total + parseFloat(number_cd.val());
        }
        if (number_xfd.val().length > 0) {
            total = total + parseFloat(number_xfd.val());
        }
        if (number_xx.val().length > 0) {
            total = total + parseFloat(number_xx.val());
        }
        if (number_xl.val().length > 0) {
            total = total + parseFloat(number_xl.val());
        }
        if (number_zcqt1.val().length > 0) {
            total = total + parseFloat(number_zcqt1.val());
        }
        if (number_zcqt2.val().length > 0) {
            total = total + parseFloat(number_zcqt2.val());
        }
        number_zchj.val(total);
        var srhj = number_srhj.val();
        if (srhj.length > 0) 
        {
            number_xjl.val(parseFloat(srhj) - total);
        }
    }

    /*
     * 纸资产合计
     * **/
    function GetPaper(sj, jg)
    {
        if (sj.length > 0 && jg.length > 0)
        {
            return sj * jg;
        }
        return 0;
    }

    /**
     * 总资产合计
     * */
    function ZZCHJ()
    {
        var total = 0;
        if (number_cx.val().length > 0) {
            total = total + parseInt(number_cx.val());
        }
        if (number_tzcb.val().length > 0) {
            total = total + parseInt(number_tzcb.val());
        }
        if (number_zzc1_hj.val().length > 0) {
            total = total + parseInt(number_zzc1_hj.val());
        }
        if (number_zzc2_hj.val().length > 0) {
            total = total + parseInt(number_zzc2_hj.val());
        }
        if (number_zzc3_hj.val().length > 0) {
            total = total + parseInt(number_zzc3_hj.val());
        }
        if (number_zzc4_hj.val().length > 0) {
            total = total + parseInt(number_zzc4_hj.val());
        }
        if (number_zzc5_hj.val().length > 0) {
            total = total + parseInt(number_zzc5_hj.val());
        }
        if (number_fc1_jg.val().length > 0) {
            total = total + parseInt(number_fc1_jg.val());
        }
        if (number_fc2_jg.val().length > 0) {
            total = total + parseInt(number_fc2_jg.val());
        }
        number_zzc.val(total);
        JZJS();
    }

    /**
     * 总负债合计
     * */
    function ZFZHJ()
    {
        var total = 0;
        if (number_fz_fd.val().length > 0) {
            total = total + parseInt(number_fz_fd.val());
        }
        if (number_fz_cd.val().length > 0) {
            total = total + parseInt(number_fz_cd.val());
        }
        if (number_fz_xfd.val().length > 0) {
            total = total + parseInt(number_fz_xfd.val());
        }
        if (number_fz_fc1dk.val().length > 0) {
            total = total + parseInt(number_fz_fc1dk.val());
        }
        if (number_fz_fc2dk.val().length > 0) {
            total = total + parseInt(number_fz_fc2dk.val());
        }
        number_zfz.val(total);
        JZJS();
    }

    /**
     * 净值计算
     * */
    function JZJS()
    {
        var zzc = 0;
        var zfz = 0;
        if (number_zzc.val().length > 0)
        {
            zzc = parseInt(number_zzc.val());
        }
        if (number_zfz.val().length > 0)
        {
            zfz = parseInt(number_zfz.val());
        }
        number_jz.val(zzc - zfz);
    }

}