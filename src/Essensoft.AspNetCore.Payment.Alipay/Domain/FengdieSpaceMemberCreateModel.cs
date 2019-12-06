using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// FengdieSpaceMemberCreateModel Data Structure.
    /// </summary>
    public class FengdieSpaceMemberCreateModel : AlipayObject
    {
        /// <summary>
        /// 用户的昵称
        /// </summary>
        [JsonPropertyName("nick")]
        public string Nick { get; set; }

        /// <summary>
        /// 云凤蝶业务空间成员所关联的第三方用户 ID
        /// </summary>
        [JsonPropertyName("origin_user_id")]
        public string OriginUserId { get; set; }
    }
}
