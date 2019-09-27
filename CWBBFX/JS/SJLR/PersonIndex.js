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


    var number_tzcb = $("#number_tzcb");
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

    /**
     * 总资产合计
     * */
    function ZZCHJ()
    {

    }

    /**
     * 总负债合计
     * */
    function ZFZHJ()
    {
        
    }

}