using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// InsCertificate Data Structure.
    /// </summary>
    public class InsCertificate : AlipayObject
    {
        /// <summary>
        /// 发奖凭证ID
        /// </summary>
        [JsonPropertyName("certificate_id")]
        public string CertificateId { get; set; }

        /// <summary>
        /// 发奖凭证类型;GIFT_INSURANCE:赠险
        /// </summary>
        [JsonPropertyName("certificate_type")]
        public string CertificateType { get; set; }

        /// <summary>
        /// 发奖凭证值
        /// </summary>
        [JsonPropertyName("certificate_value")]
        public string CertificateValue { get; set; }
    }
}
