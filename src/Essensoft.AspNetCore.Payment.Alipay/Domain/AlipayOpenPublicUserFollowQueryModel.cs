using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenPublicUserFollowQueryModel Data Structure.
    /// </summary>
    public class AlipayOpenPublicUserFollowQueryModel : AlipayObject
    {
        /// <summary>
        /// 支付宝用户id，2088开头的16位长度字符串
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
