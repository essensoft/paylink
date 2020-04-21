using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayEbppIndustryKmsPubkeyQueryModel Data Structure.
    /// </summary>
    public class AlipayEbppIndustryKmsPubkeyQueryModel : AlipayObject
    {
        /// <summary>
        /// 业务类型
        /// </summary>
        [JsonPropertyName("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 证件号码的hash值，使用MD5算法获取的hash
        /// </summary>
        [JsonPropertyName("cert_no_hash")]
        public string CertNoHash { get; set; }

        /// <summary>
        /// 证件类型  可选值（身份证：IDENTITY_CARD）
        /// </summary>
        [JsonPropertyName("cert_type")]
        public string CertType { get; set; }

        /// <summary>
        /// 子业务类型
        /// </summary>
        [JsonPropertyName("sub_biz_type")]
        public string SubBizType { get; set; }
    }
}
