using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AntMemberBenefitInfo Data Structure.
    /// </summary>
    [Serializable]
    public class AntMemberBenefitInfo : AlipayObject
    {
        /// <summary>
        /// 权益对应跳转地址
        /// </summary>
        [JsonProperty("action_url")]
        public string ActionUrl { get; set; }

        /// <summary>
        /// 权益图标地址
        /// </summary>
        [JsonProperty("icon_url")]
        public string IconUrl { get; set; }

        /// <summary>
        /// 权益状态：RECEIVABLE（可领取），RECEIVED（已领取），OTHER（其它）
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }

        /// <summary>
        /// 会员权益标题
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }

        /// <summary>
        /// 会员权益价值
        /// </summary>
        [JsonProperty("value")]
        public string Value { get; set; }
    }
}
