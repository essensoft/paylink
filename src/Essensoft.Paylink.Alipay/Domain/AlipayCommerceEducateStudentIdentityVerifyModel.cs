using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayCommerceEducateStudentIdentityVerifyModel Data Structure.
    /// </summary>
    public class AlipayCommerceEducateStudentIdentityVerifyModel : AlipayObject
    {
        /// <summary>
        /// 单次核验业务token
        /// </summary>
        [JsonPropertyName("biz_token")]
        public string BizToken { get; set; }
    }
}
