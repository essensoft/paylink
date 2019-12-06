using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayMarketingToolFengdieMemberCreateModel Data Structure.
    /// </summary>
    public class AlipayMarketingToolFengdieMemberCreateModel : AlipayObject
    {
        /// <summary>
        /// 用户的昵称
        /// </summary>
        [JsonPropertyName("nick")]
        public string Nick { get; set; }

        /// <summary>
        /// 空间管理员，可由 vip 账户代替，值为vip账号或该空间管理员的 origin_user_id
        /// </summary>
        [JsonPropertyName("operator")]
        public string Operator { get; set; }

        /// <summary>
        /// 欲创建的空间成员所关联的第三方用户ID，由调用方保持其唯一性
        /// </summary>
        [JsonPropertyName("origin_user_id")]
        public string OriginUserId { get; set; }

        /// <summary>
        /// 欲创建成员的空间ID
        /// </summary>
        [JsonPropertyName("space_id")]
        public string SpaceId { get; set; }
    }
}
