using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// MybankPaymentTradeFinancingOrderRefundModel Data Structure.
    /// </summary>
    public class MybankPaymentTradeFinancingOrderRefundModel : AlipayObject
    {
        /// <summary>
        /// 退款金额，单位：分
        /// </summary>
        [JsonPropertyName("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 外部业务单号
        /// </summary>
        [JsonPropertyName("biz_no")]
        public string BizNo { get; set; }

        /// <summary>
        /// 操作币种，默认：156
        /// </summary>
        [JsonPropertyName("currency_value")]
        public string CurrencyValue { get; set; }

        /// <summary>
        /// 扩展字段， JSON字符串；URLEncoder.encode(String,"UTF-8")
        /// </summary>
        [JsonPropertyName("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 网商的订单编号
        /// </summary>
        [JsonPropertyName("order_no")]
        public string OrderNo { get; set; }

        /// <summary>
        /// 退款类型，阿里云填 REFUND
        /// </summary>
        [JsonPropertyName("refund_type")]
        public string RefundType { get; set; }

        /// <summary>
        /// 交易备注,URLEncoder.encode(String,"UTF-8")
        /// </summary>
        [JsonPropertyName("remark")]
        public string Remark { get; set; }

        /// <summary>
        /// 请求流水号，bktradecore根据此字段做幂等控制
        /// </summary>
        [JsonPropertyName("request_no")]
        public string RequestNo { get; set; }

        /// <summary>
        /// 请求时间，格式yyyyMMddHHmmss
        /// </summary>
        [JsonPropertyName("request_time")]
        public string RequestTime { get; set; }

        /// <summary>
        /// FINANCING_REFUND_BY_PAYER-退款场景1（付方垫付利息)  FINANCING_REFUND_BY_PAYEE-退款场景2（收方垫付利息）
        /// </summary>
        [JsonPropertyName("scene_type")]
        public string SceneType { get; set; }
    }
}
