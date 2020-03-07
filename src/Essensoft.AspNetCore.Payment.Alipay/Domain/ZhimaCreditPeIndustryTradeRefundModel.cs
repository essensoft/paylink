using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ZhimaCreditPeIndustryTradeRefundModel Data Structure.
    /// </summary>
    public class ZhimaCreditPeIndustryTradeRefundModel : AlipayObject
    {
        /// <summary>
        /// 退款金额,单位元,支持两位小数
        /// </summary>
        [JsonPropertyName("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 扩展信息字段，格式:json，注意，如果字符串对应的json对象包含中文字符，需要对包含中文的字段进行编码
        /// </summary>
        [JsonPropertyName("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 退款描述,该字段在支付宝账单直接展示给用户
        /// </summary>
        [JsonPropertyName("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 扣款时传入的扣款资金单号
        /// </summary>
        [JsonPropertyName("out_fund_no")]
        public string OutFundNo { get; set; }

        /// <summary>
        /// 退款资金单号，需要保证唯一, 退款失败继续使用该退款资金单号进行退款
        /// </summary>
        [JsonPropertyName("out_refund_no")]
        public string OutRefundNo { get; set; }

        /// <summary>
        /// 签约产品码
        /// </summary>
        [JsonPropertyName("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 平台订单号
        /// </summary>
        [JsonPropertyName("zm_order_id")]
        public string ZmOrderId { get; set; }
    }
}
