using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// FriendVO Data Structure.
    /// </summary>
    public class FriendVO : AlipayObject
    {
        /// <summary>
        /// 好友open_id
        /// </summary>
        [JsonPropertyName("friend_openid")]
        public string FriendOpenid { get; set; }

        /// <summary>
        /// 好友头像
        /// </summary>
        [JsonPropertyName("head_img")]
        public string HeadImg { get; set; }

        /// <summary>
        /// 好友关系，是否双向好友
        /// </summary>
        [JsonPropertyName("relation")]
        public string Relation { get; set; }

        /// <summary>
        /// 好友昵称
        /// </summary>
        [JsonPropertyName("view_name")]
        public string ViewName { get; set; }
    }
}
