using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayUserAntpaasTokenidentityCreateResponse.
    /// </summary>
    public class AlipayUserAntpaasTokenidentityCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 蚂蚁通行证id
        /// </summary>
        [JsonPropertyName("ant_id")]
        public string AntId { get; set; }

        /// <summary>
        /// 支付宝用户Id，即匿名用户Id
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
