using System.Collections.Generic;
using Essensoft.AspNetCore.Payment.LcswPay.Utility;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.LcswPay.Response
{
    /// <summary>
    /// 利楚商务扫呗支付查询
    /// </summary>
    public class LcswPayQueryResponse : LcswPayResponse
    {
        /// <summary>
        /// 业务结果：01成功 ，02失败 ，03支付中。支付失败和退款成功状态均返回02，具体状态和原因会在return_msg中给出解释
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
        /// 终端流水号，商户系统的查询流水号，扫呗系统原样返回
        /// </summary>
        [JsonProperty("terminal_trace")]
        public string TerminalTrace { get; set; }
        /// <summary>
        /// 终端交易时间，yyyyMMddHHmmss，全局统一时间格式
        /// </summary>
        [JsonProperty("terminal_time")]
        public string TerminalTime { get; set; }
        /// <summary>
        /// 金额，单位分
        /// </summary>
        [JsonProperty("total_fee")]
        public string TotalFee { get; set; }
        /// <summary>
        /// 支付完成时间，yyyyMMddHHmmss，全局统一时间格式
        /// </summary>
        [JsonProperty("end_time")]
        public string EndTime { get; set; }
        /// <summary>
        /// 利楚唯一订单号
        /// </summary>
        [JsonProperty("out_trade_no")]
        public string OutTradeNo { get; set; }
        /// <summary>
        /// 交易订单状态，SUCCESS支付成功，REFUND转入退款，NOTPAY未支付，CLOSED已关闭，USERPAYING用户支付中，REVOKED已撤销，NOPAY未支付支付超时，PAYERROR支付失败
        /// </summary>
        [JsonProperty("trade_state")]
        public string TradeState { get; set; }
        /// <summary>
        /// 通道订单号，微信订单号、支付宝订单号等，返回时不参与签名
        /// </summary>
        [JsonProperty("channel_trade_no")]
        public string ChannelTradeNo { get; set; }
        /// <summary>
        /// 银行渠道订单号，微信支付时显示在支付成功页面的条码，可用作扫码查询和扫码退款时匹配
        /// </summary>
        [JsonProperty("channel_order_no")]
        public string ChannelOrderNo { get; set; }
        /// <summary>
        /// 付款方用户id，“微信openid”、“支付宝账户”、“qq号”等，返回时不参与签名
        /// </summary>
        [JsonProperty("user_id")]
        public string UserId { get; set; }
        /// <summary>
        /// 附加数据，原样返回，返回时不参与签名
        /// </summary>
        [JsonProperty("attach")]
        public string Attach { get; set; }
        /// <summary>
        /// 口碑实收金额，pay_type为090时必填
        /// </summary>
        [JsonProperty("receipt_fee")]
        public string ReceiptFee { get; set; }
        /// <summary>
        /// 当前支付终端流水号
        /// </summary>
        [JsonProperty("pay_trace")]
        public string PayTrace { get; set; }
        /// <summary>
        /// 当前支付终端交易时间，yyyyMMddHHmmss，全局统一时间格式
        /// </summary>
        [JsonProperty("pay_time")]
        public string PayTime { get; set; }

        public override List<LcswPayParaInfo> SignedParaInfos => IsReturnCodeSuccess ?
            new List<LcswPayParaInfo> {
                new LcswPayParaInfo("result_code",ResultCode),
                new LcswPayParaInfo("pay_type",PayType),
                new LcswPayParaInfo("merchant_name",MerchantName),
                new LcswPayParaInfo("merchant_no",MerchantNo),
                new LcswPayParaInfo("terminal_id",TerminalId),
                new LcswPayParaInfo("terminal_trace",TerminalTrace),
                new LcswPayParaInfo("terminal_time",TerminalTime),
                new LcswPayParaInfo("total_fee",TotalFee),
                new LcswPayParaInfo("end_time",EndTime),
                new LcswPayParaInfo("out_trade_no",OutTradeNo)
            }
            :
            new List<LcswPayParaInfo>();
    }
}
