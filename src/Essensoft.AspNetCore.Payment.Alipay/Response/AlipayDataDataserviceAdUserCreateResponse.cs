using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayDataDataserviceAdUserCreateResponse.
    /// </summary>
    public class AlipayDataDataserviceAdUserCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 商家id
        /// </summary>
        [JsonProperty("principal_id")]
        public long PrincipalId { get; set; }

        /// <summary>
        /// 账户id
        /// </summary>
        [JsonProperty("user_id")]
        public long UserId { get; set; }
    }
}
