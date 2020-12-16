using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// Certificate Data Structure.
    /// </summary>
    public class Certificate : AlipayObject
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
    }
}
