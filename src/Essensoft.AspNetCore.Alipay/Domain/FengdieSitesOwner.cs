using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Alipay.Domain
{
    /// <summary>
    /// FengdieSitesOwner Data Structure.
    /// </summary>
    public class FengdieSitesOwner : AlipayObject
    {
        /// <summary>
        /// 创建者的昵称
        /// </summary>
        [JsonProperty("nick")]
        public string Nick { get; set; }

        /// <summary>
        /// 云凤蝶空间成员所关联的第三方用户ID
        /// </summary>
        [JsonProperty("origin_user_id")]
        public string OriginUserId { get; set; }
    }
}
