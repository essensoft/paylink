using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// PersonInfo Data Structure.
    /// </summary>
    public class PersonInfo : AlipayObject
    {
        /// <summary>
        /// 身份证有效期开始日,格式（yyyy-MM-dd）
        /// </summary>
        [JsonPropertyName("cert_effective_date")]
        public string CertEffectiveDate { get; set; }

        /// <summary>
        /// 身份证有效期到期日,格式（yyyy-MM-dd）,其中long 长期
        /// </summary>
        [JsonPropertyName("cert_expiration_date")]
        public string CertExpirationDate { get; set; }

        /// <summary>
        /// 证件号码
        /// </summary>
        [JsonPropertyName("cert_no")]
        public string CertNo { get; set; }

        /// <summary>
        /// 证件类型，RESIDENT-居民身份证
        /// </summary>
        [JsonPropertyName("cert_type")]
        public string CertType { get; set; }

        /// <summary>
        /// 姓名
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// 手机号码
        /// </summary>
        [JsonPropertyName("phone_no")]
        public string PhoneNo { get; set; }
    }
}
