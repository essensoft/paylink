using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayUserTwostageIndirectUseResponse.
    /// </summary>
    public class AlipayUserTwostageIndirectUseResponse : AlipayResponse
    {
        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
