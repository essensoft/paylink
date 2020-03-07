using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayEbppIndustryOrderQueryResponse.
    /// </summary>
    public class AlipayEbppIndustryOrderQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 扩展属性，json串(key-value对)
        /// </summary>
        [JsonPropertyName("extend_field")]
        public string ExtendField { get; set; }

        /// <summary>
        /// 订单创建时间GMT，yyyyMMdd HH:mm:ss
        /// </summary>
        [JsonPropertyName("gmt_create")]
        public string GmtCreate { get; set; }

        /// <summary>
        /// 订单支付时间GMT，yyyyMMdd HH:mm:ss
        /// </summary>
        [JsonPropertyName("gmt_pay")]
        public string GmtPay { get; set; }

        /// <summary>
        /// 退款时间GMT，yyyyMMdd HH:mm:ss
        /// </summary>
        [JsonPropertyName("gmt_refund")]
        public string GmtRefund { get; set; }

        /// <summary>
        /// 订单成功时间GMT，yyyyMMdd HH:mm:ss
        /// </summary>
        [JsonPropertyName("gmt_success")]
        public string GmtSuccess { get; set; }

        /// <summary>
        /// 支付宝的业务订单号，具有唯一性。
        /// </summary>
        [JsonPropertyName("order_no")]
        public string OrderNo { get; set; }

        /// <summary>
        /// 回传外部流水号
        /// </summary>
        [JsonPropertyName("out_order_no")]
        public string OutOrderNo { get; set; }

        /// <summary>
        /// 账单的状态，I-等待付款，P-处理中，已扣款待销账，C-单据关闭，F-失败，W-清算后退款，S-销账成功
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }
    }
}
