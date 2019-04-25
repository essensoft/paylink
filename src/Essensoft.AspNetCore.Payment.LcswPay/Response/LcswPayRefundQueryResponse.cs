using System;
using System.Collections.Generic;
using System.Text;
using Essensoft.AspNetCore.Payment.LcswPay.Utility;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.LcswPay.Response
{
    /// <summary>
    /// 利楚商务扫呗支付退款结果查询响应
    /// </summary>
    public class LcswPayRefundQueryResponse : LcswPayResponse
    {
        /// <summary>
        /// 业务结果：01成功 ，02失败
        /// </summary>
        [JsonProperty("result_code")]
        public string ResultCode { get; set; }
        /// <summary>
        /// 请求类型，010微信，020 支付宝，060qq钱包，080京东钱包，090口碑，100翼支付，110银联二维码
        /// </summary>
        [JsonProperty("pay_type")]
        public string PayType { get; set; }
        /// <summary>
        /// 商户名称
        /// </summary>
        [JsonProperty("merchant_name")]
        public string MerchantName { get; set; }
        /// <summary>
        /// 商户号
        /// </summary>
        [JsonProperty("merchant_no")]
        public string MerchantNo { get; set; }
        /// <summary>
        /// 终端号
        /// </summary>
        [JsonProperty("terminal_id")]
        public string TerminalId { get; set; }
        /// <summary>
        /// 终端流水号，商户系统的退款流水号，扫呗系统原样返回
        /// </summary>
        [JsonProperty("terminal_trace")]
        public string TerminalTrace { get; set; }
        /// <summary>
        /// 终端退款时间，yyyyMMddHHmmss，全局统一时间格式
        /// </summary>
        [JsonProperty("terminal_time")]
        public string TerminalTime { get; set; }
        /// <summary>
        /// 退款金额，单位分
        /// </summary>
        [JsonProperty("refund_fee")]
        public string RefundFee { get; set; }
        /// <summary>
        /// 退款完成时间，yyyyMMddHHmmss，全局统一时间格式
        /// </summary>
        [JsonProperty("end_time")]
        public string EndTime { get; set; }
        /// <summary>
        /// 利楚唯一订单号
        /// </summary>
        [JsonProperty("out_trade_no")]
        public string OutTradeNo { get; set; }
        /// <summary>
        /// 利楚唯一退款单号
        /// </summary>
        [JsonProperty("out_refund_no")]
        public string OutRefundNo { get; set; }
        /// <summary>
        /// 退款订单状态，SUCCESS退款成功，FAIL退款失败，REFUNDING退款中，NOREFUND退款超时等
        /// </summary>
        [JsonProperty("trade_status")]
        public string TradeStatus { get; set; }
        /// <summary>
        /// 通道订单号，微信订单号、支付宝订单号等，返回时不参与签名
        /// </summary>
        [JsonProperty("channel_trade_no")]
        public string ChannelTradeNo { get; set; }
        /// <summary>
        /// 银行渠道订单号，微信退款时显示在退款成功页面的条码，可用作扫码退款查询
        /// </summary>
        [JsonProperty("channel_order_no")]
        public string ChannelOrderNo { get; set; }
        /// <summary>
        /// 退款方用户id，“微信openid”、“支付宝账户”、“qq号”等，返回时不参与签名
        /// </summary>
        [JsonProperty("user_id")]
        public string UserId { get; set; }
        /// <summary>
        /// 附加数据，原样返回，返回时不参与签名
        /// </summary>
        [JsonProperty("attach")]
        public string Attach { get; set; }
        /// <summary>
        /// 退款终端流水号
        /// </summary>
        [JsonProperty("pay_trace")]
        public string PayTrace { get; set; }
        /// <summary>
        /// 退款终端交易时间
        /// </summary>
        [JsonProperty("pay_time")]
        public string PayTime { get; set; }


        public override void AddSignedParasWhenReturnCodeSuccess(List<LcswPayParaInfo> signedParas)
        {
            signedParas.AddRange(new List<LcswPayParaInfo> {
                new LcswPayParaInfo("result_code",ResultCode),
                new LcswPayParaInfo("pay_type",PayType),
                new LcswPayParaInfo("merchant_name",MerchantName),
                new LcswPayParaInfo("merchant_no",MerchantNo),
                new LcswPayParaInfo("terminal_id",TerminalId),
                new LcswPayParaInfo("terminal_trace",TerminalTrace),
                new LcswPayParaInfo("terminal_time",TerminalTime),
                new LcswPayParaInfo("refund_fee",RefundFee),
                new LcswPayParaInfo("end_time",EndTime),
                new LcswPayParaInfo("out_refund_no",OutRefundNo),
                new LcswPayParaInfo("out_trade_no",OutTradeNo)
            });
        }
    }
}
