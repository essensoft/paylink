using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// MybankCreditSupplychainTradeNettingRefundModel Data Structure.
    /// </summary>
    public class MybankCreditSupplychainTradeNettingRefundModel : AlipayObject
    {
        /// <summary>
        /// 买家信息
        /// </summary>
        [JsonPropertyName("buyer")]
        public Member Buyer { get; set; }

        /// <summary>
        /// 渠道，枚举如下：TMGXBL：天猫供销保理，TYZBL：通用自保理，FQZBL：电信分期自保理，TMZBL：天猫自保理，DSCYFRZ：大搜车预付融资，CNBILL：菜鸟电票，CHENGYISHE：诚e赊
        /// </summary>
        [JsonPropertyName("channel")]
        public string Channel { get; set; }

        /// <summary>
        /// 外部订单号，格式：机构ipRoleId_外部订单号
        /// </summary>
        [JsonPropertyName("out_order_no")]
        public string OutOrderNo { get; set; }

        /// <summary>
        /// 只支持整笔退款,外部退款单号必须设置为:  ipRoleId_yyyymmddhhmmss_8位uniqId
        /// </summary>
        [JsonPropertyName("out_refund_no")]
        public string OutRefundNo { get; set; }

        /// <summary>
        /// 账款退款金额,单位元。
        /// </summary>
        [JsonPropertyName("refund_amount")]
        public string RefundAmount { get; set; }

        /// <summary>
        /// 幂等编号，用于幂等控制，格式：机构ipRoleId_yyyymmddhhmmss_8位uniqId
        /// </summary>
        [JsonPropertyName("request_id")]
        public string RequestId { get; set; }

        /// <summary>
        /// 销售产品码
        /// </summary>
        [JsonPropertyName("sale_pd_code")]
        public string SalePdCode { get; set; }

        /// <summary>
        /// 卖家信息
        /// </summary>
        [JsonPropertyName("seller")]
        public Member Seller { get; set; }

        /// <summary>
        /// FACTORING：保理，PREPAYMENT：预付融资，CREDITPAY：信任付，PREPAYBILL：电票预付，CHENGYISHE：诚e赊
        /// </summary>
        [JsonPropertyName("trade_type")]
        public string TradeType { get; set; }
    }
}
