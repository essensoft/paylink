using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// FriendListVO Data Structure.
    /// </summary>
    public class FriendListVO : AlipayObject
    {
        /// <summary>
        /// 头像的服务地址
        /// </summary>
        [JsonPropertyName("head_img")]
        public string HeadImg { get; set; }

        /// <summary>
        /// 是否双向好友
        /// </summary>
        [JsonPropertyName("real_friend")]
        public bool RealFriend { get; set; }

        /// <summary>
        /// 用户id
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// 有可能包含emoji表情，业务方要注意编码
        /// </summary>
        [JsonPropertyName("view_name")]
        public string ViewName { get; set; }
    }
}
