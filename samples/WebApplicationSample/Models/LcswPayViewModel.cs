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
        [Display(Name = "终端流水号")]
        [Required(ErrorMessage = "请输入终端流水号")]
        public string TerminalTrace { get; set; }
        /// <summary>
        /// 终端注册时间，yyyyMMddHHmmss，全局统一时间格式
        /// </summary>
        [Display(Name = "终端注册时间")]
        [Required(ErrorMessage = "请输入终端注册时间")]
        public string TerminalTime { get; set; }
    }
    public class LcswPayBarcodePayViewModel
    {
        /// <summary>
        /// 请求类型，010微信，020 支付宝，060qq钱包，080京东钱包，090口碑，100翼支付，110银联二维码，000自动识别类型
        /// </summary>
        [Display(Name = "请求类型")]
        [Required(ErrorMessage = "请输入请求类型")]
        public string PayType { get; set; }
        /// <summary>
        /// 终端流水号，填写商户系统的订单号
        /// </summary>
        [Display(Name = "终端流水号")]
        [Required(ErrorMessage = "请输入终端流水号")]
        public string TerminalTrace { get; set; }
        /// <summary>
        /// 终端交易时间，yyyyMMddHHmmss，全局统一时间格式
        /// </summary>
        [Display(Name = "终端交易时间")]
        [Required(ErrorMessage = "请输入终端交易时间")]
        public string TerminalTime { get; set; }
        /// <summary>
        /// 授权码，客户的付款码
        /// </summary>
        [Display(Name = "授权码")]
        [Required(ErrorMessage = "请输入授权码")]
        public string AuthNo { get; set; }
        /// <summary>
        /// 金额，单位分
        /// </summary>
        [Display(Name = "金额")]
        [Required(ErrorMessage = "请输入金额")]
        public string TotalFee { get; set; }
        /// <summary>
        /// 公众号appid
        /// </summary>
        [Display(Name = "公众号appid")]
        public string SubAppid { get; set; }
        /// <summary>
        /// 订单描述
        /// </summary>
        [Display(Name = "订单描述")]
        public string OrderBody { get; set; }
        /// <summary>
        /// 附加数据,原样返回
        /// </summary>
        [Display(Name = "附加数据")]
        public string Attach { get; set; }
        /// <summary>
        /// 订单包含的商品列表信息，Json格式。pay_type为090时，可选填此字段
        /// </summary>
        [Display(Name = "商品列表信息")]
        public string GoodsDetail { get; set; }
        /// <summary>
        /// 订单优惠标记，代金券或立减优惠功能的参数（字段值：cs和bld）
        /// </summary>
        [Display(Name = "订单优惠标记")]
        public string GoodsTag { get; set; }

    }
    public class LcswPayQueryViewModel
    {
        /// <summary>
        /// 请求类型，010微信，020 支付宝，060qq钱包，080京东钱包，090口碑，100翼支付，110银联二维码，000自动识别类型
        /// </summary>
        [Display(Name = "请求类型")]
        [Required(ErrorMessage = "请输入请求类型")]
        public string PayType { get; set; }
        /// <summary>
        /// 终端流水号，填写商户系统的订单号
        /// </summary>
        [Display(Name = "终端流水号")]
        [Required(ErrorMessage = "请输入终端流水号")]
        public string TerminalTrace { get; set; }
        /// <summary>
        /// 终端交易时间，yyyyMMddHHmmss，全局统一时间格式
        /// </summary>
        [Display(Name = "终端交易时间")]
        [Required(ErrorMessage = "请输入终端交易时间")]
        public string TerminalTime { get; set; }
        /// <summary>
        /// 终端流水号
        /// </summary>
        [Display(Name = "终端流水号")]
        public string PayTrace { get; set; }
        /// <summary>
        /// 终端交易时间
        /// </summary>
        [Display(Name = "终端交易时间")]
        public string PayTime { get; set; }
        /// <summary>
        /// 订单号，查询凭据，可填利楚订单号、微信订单号、支付宝订单号、银行卡订单号任意一个
        /// </summary>
        [Display(Name = "订单号")]
        [Required(ErrorMessage ="请输入订单号")]
        public string OutTradeNo { get; set; }
    }
    public class LcswPayRefundViewModel
    {
        /// <summary>
        /// 请求类型，010微信，020 支付宝，060qq钱包，080京东钱包，090口碑，100翼支付，110银联二维码，000自动识别类型
        /// </summary>
        [Display(Name = "请求类型")]
        [Required(ErrorMessage = "请输入请求类型")]
        public string PayType { get; set; }
        /// <summary>
        /// 终端退款流水号，填写商户系统的退款流水号
        /// </summary>
        [Display(Name = "终端流水号")]
        [Required(ErrorMessage = "请输入终端流水号")]
        public string TerminalTrace { get; set; }
        /// <summary>
        /// 终端退款时间，yyyyMMddHHmmss，全局统一时间格式
        /// </summary>
        [Display(Name = "终端交易时间")]
        [Required(ErrorMessage = "请输入终端交易时间")]
        public string TerminalTime { get; set; }
        /// <summary>
        /// 退款金额，单位分
        /// </summary>
        [Display(Name = "退款金额")]
        [Required(ErrorMessage = "请输入退款金额")]
        public string RefundFee { get; set; }
        /// <summary>
        /// 订单号，查询凭据，利楚订单号、微信订单号、支付宝订单号任意一个
        /// </summary>
        [Display(Name = "订单号")]
        [Required(ErrorMessage = "请输入订单号")]
        public string OutTradeNo { get; set; }
        /// <summary>
        /// 当前支付终端流水号，与pay_time同时传递
        /// </summary>
        [Display(Name = "当前支付终端流水号")]
        public string PayTrace { get; set; }
        /// <summary>
        /// 当前支付终端交易时间，yyyyMMddHHmmss，全局统一时间格式，与pay_trace同时传递
        /// </summary>
        [Display(Name = "当前支付终端交易时间")]
        public string PayTime { get; set; }
        /// <summary>
        /// 短信或邮箱验证码
        /// </summary>
        [Display(Name = "短信或邮箱验证码")]
        public string AuthCode { get; set; }
    }
}
