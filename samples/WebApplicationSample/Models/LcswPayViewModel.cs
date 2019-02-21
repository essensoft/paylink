using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationSample.Models
{
    public class LcswPaySignViewModel
    {
        /// <summary>
        /// 终端流水号，填写商户系统的订单号
        /// </summary>
        [Display(Name ="终端流水号")]
        [Required(ErrorMessage ="请输入终端流水号")]
        public string TerminalTrace { get; set; }
        /// <summary>
        /// 终端注册时间，yyyyMMddHHmmss，全局统一时间格式
        /// </summary>
        [Display(Name ="终端注册时间")]
        [Required(ErrorMessage = "请输入终端注册时间")]
        public string TerminalTime { get; set; }
    }
    public class LcswPayBarcodePayViewModel
    {
        /// <summary>
        /// 请求类型，010微信，020 支付宝，060qq钱包，080京东钱包，090口碑，100翼支付，110银联二维码，000自动识别类型
        /// </summary>
        [Display(Name ="请求类型")]
        [Required(ErrorMessage ="请输入请求类型")]
        public string PayType { get; set; }
        /// <summary>
        /// 终端流水号，填写商户系统的订单号
        /// </summary>
        [Display(Name ="终端流水号")]
        [Required(ErrorMessage ="请输入终端流水号")]
        public string TerminalTrace { get; set; }
        /// <summary>
        /// 终端交易时间，yyyyMMddHHmmss，全局统一时间格式
        /// </summary>
        [Display(Name ="终端交易时间")]
        [Required(ErrorMessage ="请输入终端交易时间")]
        public string TerminalTime { get; set; }
        /// <summary>
        /// 授权码，客户的付款码
        /// </summary>
        [Display(Name = "授权码")]
        [Required(ErrorMessage ="请输入授权码")]
        public string AuthNo { get; set; }
        /// <summary>
        /// 金额，单位分
        /// </summary>
        [Display(Name ="金额")]
        [Required(ErrorMessage ="请输入金额")]
        public string TotalFee { get; set; }
        /// <summary>
        /// 公众号appid
        /// </summary>
        [Display(Name = "公众号appid")]
        public string SubAppid { get; set; }
        /// <summary>
        /// 订单描述
        /// </summary>
        [Display(Name ="订单描述")]
        public string OrderBody { get; set; }
        /// <summary>
        /// 附加数据,原样返回
        /// </summary>
        [Display(Name ="附加数据")]
        public string Attach { get; set; }
        /// <summary>
        /// 订单包含的商品列表信息，Json格式。pay_type为090时，可选填此字段
        /// </summary>
        [Display(Name ="商品列表信息")]
        public string GoodsDetail { get; set; }
        /// <summary>
        /// 订单优惠标记，代金券或立减优惠功能的参数（字段值：cs和bld）
        /// </summary>
        [Display(Name = "订单优惠标记")]
        public string GoodsTag { get; set; }

    }
}
