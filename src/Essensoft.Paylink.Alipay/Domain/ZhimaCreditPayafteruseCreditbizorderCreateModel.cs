using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// ZhimaCreditPayafteruseCreditbizorderCreateModel Data Structure.
    /// </summary>
    public class ZhimaCreditPayafteruseCreditbizorderCreateModel : AlipayObject
    {
        /// <summary>
        /// 订单描述
        /// </summary>
        [JsonPropertyName("body")]
        public string Body { get; set; }

        /// <summary>
        /// 当用户进入芝麻后付下单页面后，点击左上角的回退按钮，中断开通流程，跳转回商户的页面地址。
        /// </summary>
        [JsonPropertyName("cancel_back_link")]
        public string CancelBackLink { get; set; }

        /// <summary>
        /// 芝麻外部类目
        /// </summary>
        [JsonPropertyName("category_id")]
        public string CategoryId { get; set; }

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
        /// 用户成功完成芝麻后付开通流程后，跳转回商户的页面地址。
        /// </summary>
        [JsonPropertyName("return_back_link")]
        public string ReturnBackLink { get; set; }

        /// <summary>
        /// 订单标题。 注意：不可使用特殊字符，如 /，=，& 等。
        /// </summary>
        [JsonPropertyName("subject")]
        public string Subject { get; set; }

        /// <summary>
        /// 芝麻服务ID
        /// </summary>
        [JsonPropertyName("zm_service_id")]
        public string ZmServiceId { get; set; }
    }
}
