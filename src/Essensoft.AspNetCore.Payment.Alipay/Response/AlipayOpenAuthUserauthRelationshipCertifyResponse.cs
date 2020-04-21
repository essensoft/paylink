using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayOpenAuthUserauthRelationshipCertifyResponse.
    /// </summary>
    public class AlipayOpenAuthUserauthRelationshipCertifyResponse : AlipayResponse
    {
        /// <summary>
        /// 授权关系有效性校验，true:有效，false:无效
        /// </summary>
        [JsonPropertyName("effective")]
        public bool Effective { get; set; }
    }
}
