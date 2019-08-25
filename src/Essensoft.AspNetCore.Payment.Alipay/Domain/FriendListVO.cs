using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// FriendListVO Data Structure.
    /// </summary>
    [Serializable]
    public class FriendListVO : AlipayObject
    {
        /// <summary>
        /// 头像的服务地址
        /// </summary>
        [JsonProperty("head_img")]
        public string HeadImg { get; set; }

        /// <summary>
        /// 是否双向好友
        /// </summary>
        [JsonProperty("real_friend")]
        public bool RealFriend { get; set; }

        /// <summary>
        /// 用户id
        /// </summary>
        [JsonProperty("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// 有可能包含emoji表情，业务方要注意编码
        /// </summary>
        [JsonProperty("view_name")]
        public string ViewName { get; set; }
    }
}
