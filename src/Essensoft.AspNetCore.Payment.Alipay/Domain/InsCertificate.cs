using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// InsCertificate Data Structure.
    /// </summary>
    [Serializable]
    public class InsCertificate : AlipayObject
    {
        /// <summary>
        /// 发奖凭证ID
        /// </summary>
        [JsonProperty("certificate_id")]
        public string CertificateId { get; set; }

        /// <summary>
        /// 发奖凭证类型;GIFT_INSURANCE:赠险
        /// </summary>
        [JsonProperty("certificate_type")]
        public string CertificateType { get; set; }

        /// <summary>
        /// 发奖凭证值
        /// </summary>
        [JsonProperty("certificate_value")]
        public string CertificateValue { get; set; }
    }
}
