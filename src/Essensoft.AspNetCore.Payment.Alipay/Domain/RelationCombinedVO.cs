using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// RelationCombinedVO Data Structure.
    /// </summary>
    public class RelationCombinedVO : AlipayObject
    {
        /// <summary>
        /// 扩展信息
        /// </summary>
        [JsonPropertyName("ext_info")]
        public ExtraInfoVO ExtInfo { get; set; }

        /// <summary>
        /// 支付宝头像
        /// </summary>
        [JsonPropertyName("head_img")]
        public string HeadImg { get; set; }

        /// <summary>
        /// 是否支付宝双向好友
        /// </summary>
        [JsonPropertyName("real_friend")]
        public bool RealFriend { get; set; }

        /// <summary>
        /// 支付宝userid
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
