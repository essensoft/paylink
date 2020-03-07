using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayUserAccountInstitutionCertifyResponse.
    /// </summary>
    public class AlipayUserAccountInstitutionCertifyResponse : AlipayResponse
    {
        /// <summary>
        /// 机构是否存在的标示  如果此机构存在，exist返回值为T  如果此机构不存在，exist返回为F
        /// </summary>
        [JsonPropertyName("match")]
        public string Match { get; set; }

        /// <summary>
        /// 该帐号对应的uid
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
