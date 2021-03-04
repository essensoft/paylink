using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// ZhubUidTelPair Data Structure.
    /// </summary>
    public class ZhubUidTelPair : AlipayObject
    {
        /// <summary>
        /// 手机号
        /// </summary>
        [JsonPropertyName("phone")]
        public string Phone { get; set; }

        /// <summary>
        /// 支付宝uid
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
