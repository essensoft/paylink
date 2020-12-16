using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayUserCertdocCertverifyConsultModel Data Structure.
    /// </summary>
    public class AlipayUserCertdocCertverifyConsultModel : AlipayObject
    {
        /// <summary>
        /// 信息校验验证ID
        /// </summary>
        [JsonPropertyName("verify_id")]
        public string VerifyId { get; set; }
    }
}
