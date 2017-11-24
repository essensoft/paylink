using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Alipay.Domain
{
    /// <summary>
    /// AlipayMarketingCampaignDrawcampTriggerModel Data Structure.
    /// </summary>
    public class AlipayMarketingCampaignDrawcampTriggerModel : AlipayObject
    {
        /// <summary>
        /// 用户参与活动的手机号（如果是用户直接输入手机号的活动形式，该项必填，作为识别用户的依据）
        /// </summary>
        [JsonProperty("bind_mobile")]
        public string BindMobile { get; set; }

        /// <summary>
        /// 活动id
        /// </summary>
        [JsonProperty("camp_id")]
        public string CampId { get; set; }

        /// <summary>
        /// 请求来源，目前支持：1微信 2 微博 3虾米 4淘宝  5天猫
        /// </summary>
        [JsonProperty("camp_source")]
        public long CampSource { get; set; }

        /// <summary>
        /// 渠道来源参数
        /// </summary>
        [JsonProperty("channel_info")]
        public string ChannelInfo { get; set; }

        /// <summary>
        /// 客户端ip
        /// </summary>
        [JsonProperty("client_ip")]
        public string ClientIp { get; set; }

        /// <summary>
        /// rds嵌入页面的js收集的用户行为数据
        /// </summary>
        [JsonProperty("json_ua")]
        public string JsonUa { get; set; }

        /// <summary>
        /// 用户登录号/用户uid，非脱敏账号
        /// </summary>
        [JsonProperty("user_id")]
        public string UserId { get; set; }
    }
}
