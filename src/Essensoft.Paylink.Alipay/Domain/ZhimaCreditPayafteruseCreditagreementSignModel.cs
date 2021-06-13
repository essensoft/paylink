using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// ZhimaCreditPayafteruseCreditagreementSignModel Data Structure.
    /// </summary>
    public class ZhimaCreditPayafteruseCreditagreementSignModel : AlipayObject
    {
        /// <summary>
        /// 当用户进入芝麻后付开通页面后，点击左上角的回退按钮，中断开通流程，跳转回商户的页面地址。
        /// </summary>
        [JsonPropertyName("cancel_back_link")]
        public string CancelBackLink { get; set; }

        /// <summary>
        /// 芝麻外部类目。
        /// </summary>
        [JsonPropertyName("category_id")]
        public string CategoryId { get; set; }

        /// <summary>
        /// 用户在商户网站的登录账号。
        /// </summary>
        [JsonPropertyName("external_logon_id")]
        public string ExternalLogonId { get; set; }

        /// <summary>
        /// 业务扩展参数，用于商户的特定业务信息的传递，json格式。
        /// </summary>
        [JsonPropertyName("extra_param")]
        public string ExtraParam { get; set; }

        /// <summary>
        /// 商户外部协议号。
        /// </summary>
        [JsonPropertyName("out_agreement_no")]
        public string OutAgreementNo { get; set; }

        /// <summary>
        /// 产品码，不填默认为 CREDIT_PAY_AFTER_USE。
        /// </summary>
        [JsonPropertyName("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 用户成功完成芝麻后付开通流程后，跳转回商户的页面地址。
        /// </summary>
        [JsonPropertyName("return_back_link")]
        public string ReturnBackLink { get; set; }

        /// <summary>
        /// 芝麻服务ID。
        /// </summary>
        [JsonPropertyName("zm_service_id")]
        public string ZmServiceId { get; set; }
    }
}
