using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// ZhimaCreditPayafteruseCreditbizorderOrderModel Data Structure.
    /// </summary>
    public class ZhimaCreditPayafteruseCreditbizorderOrderModel : AlipayObject
    {
        /// <summary>
        /// 订单描述
        /// </summary>
        [JsonPropertyName("body")]
        public string Body { get; set; }

        /// <summary>
        /// 芝麻外部类目
        /// </summary>
        [JsonPropertyName("category_id")]
        public string CategoryId { get; set; }

        /// <summary>
        /// 芝麻后付开通协议号
        /// </summary>
        [JsonPropertyName("credit_agreement_id")]
        public string CreditAgreementId { get; set; }

        /// <summary>
        /// 业务扩展参数
        /// </summary>
        [JsonPropertyName("extend_params")]
        public string ExtendParams { get; set; }

        /// <summary>
        /// 商户外部订单号，保证不重复
        /// </summary>
        [JsonPropertyName("out_order_no")]
        public string OutOrderNo { get; set; }

        /// <summary>
        /// 产品码，不传默认为CREDIT_PAY_AFTER_USE
        /// </summary>
        [JsonPropertyName("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 订单标题。 注意：不可使用特殊字符，如 /，=，& 等。
        /// </summary>
        [JsonPropertyName("subject")]
        public string Subject { get; set; }
    }
}
