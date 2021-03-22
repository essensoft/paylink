using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenPublicUserFollowQueryModel Data Structure.
    /// </summary>
    public class AlipayOpenPublicUserFollowQueryModel : AlipayObject
    {
        /// <summary>
        /// 支付宝用户id，用户在支付宝的唯一标识，以 2088 开头的 16 位纯数字组成。
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
