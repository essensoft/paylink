using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// TuitionCertificate Data Structure.
    /// </summary>
    public class TuitionCertificate : AlipayObject
    {
        /// <summary>
        /// 证件号码
        /// </summary>
        [JsonPropertyName("certificate_no")]
        public string CertificateNo { get; set; }

        /// <summary>
        /// 证件类型
        /// </summary>
        [JsonPropertyName("certificate_type")]
        public string CertificateType { get; set; }

        /// <summary>
        /// 证件生效时间
        /// </summary>
        [JsonPropertyName("effective_date")]
        public string EffectiveDate { get; set; }

        /// <summary>
        /// 证件有效截止时间
        /// </summary>
        [JsonPropertyName("expire_date")]
        public string ExpireDate { get; set; }

        /// <summary>
        /// 证件姓名
        /// </summary>
        [JsonPropertyName("holder_name")]
        public TuitionUserName HolderName { get; set; }
    }
}
