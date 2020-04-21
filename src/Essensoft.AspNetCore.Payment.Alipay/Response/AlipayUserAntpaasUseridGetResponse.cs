using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayUserAntpaasUseridGetResponse.
    /// </summary>
    public class AlipayUserAntpaasUseridGetResponse : AlipayResponse
    {
        /// <summary>
        /// 支付宝用户id
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
