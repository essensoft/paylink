using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayUserAuthZhimaorgIdentityApplyModel Data Structure.
    /// </summary>
    public class AlipayUserAuthZhimaorgIdentityApplyModel : AlipayObject
    {
        /// <summary>
        /// 营业执照号码
        /// </summary>
        [JsonPropertyName("cert_no")]
        public string CertNo { get; set; }

        /// <summary>
        /// NATIONAL_LEGAL:营业执照号码  NATIONAL_LEGAL_MERGE:三证合一号码
        /// </summary>
        [JsonPropertyName("cert_type")]
        public string CertType { get; set; }

        /// <summary>
        /// 企业名称
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}
