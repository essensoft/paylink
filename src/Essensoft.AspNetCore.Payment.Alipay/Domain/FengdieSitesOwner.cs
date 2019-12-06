using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// FengdieSitesOwner Data Structure.
    /// </summary>
    public class FengdieSitesOwner : AlipayObject
    {
        /// <summary>
        /// 创建者的昵称
        /// </summary>
        [JsonPropertyName("nick")]
        public string Nick { get; set; }

        /// <summary>
        /// 云凤蝶空间成员所关联的第三方用户ID
        /// </summary>
        [JsonPropertyName("origin_user_id")]
        public string OriginUserId { get; set; }
    }
}
