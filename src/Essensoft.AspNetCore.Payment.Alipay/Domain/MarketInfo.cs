using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// MarketInfo Data Structure.
    /// </summary>
    public class MarketInfo : AlipayObject
    {
        /// <summary>
        /// 活动图标。0.优惠券（目前仅提供一种后续增加）。必选项，单选。
        /// </summary>
        [JsonPropertyName("activity_icon")]
        public string ActivityIcon { get; set; }

        /// <summary>
        /// 活动id
        /// </summary>
        [JsonPropertyName("activity_id")]
        public string ActivityId { get; set; }

        /// <summary>
        /// 活动文案字符串，必填项，在加油小程序门店展位对用户展示
        /// </summary>
        [JsonPropertyName("activity_record")]
        public string ActivityRecord { get; set; }

        /// <summary>
        /// 活动链接URL地址字符串，必填项，需符合规范要求
        /// </summary>
        [JsonPropertyName("activity_url")]
        public string ActivityUrl { get; set; }

        /// <summary>
        /// 活动截止时间
        /// </summary>
        [JsonPropertyName("effective_end")]
        public string EffectiveEnd { get; set; }

        /// <summary>
        /// 活动生效开始时间
        /// </summary>
        [JsonPropertyName("effective_start")]
        public string EffectiveStart { get; set; }

        /// <summary>
        /// 上架平台：0 代表支付宝APP端
        /// </summary>
        [JsonPropertyName("last_platform")]
        public string LastPlatform { get; set; }

        /// <summary>
        /// 上架门店id，逗号分隔开
        /// </summary>
        [JsonPropertyName("last_store_id")]
        public string LastStoreId { get; set; }

        /// <summary>
        /// 展位优先级，整数，必填。同一门店多个活动时，优先级数值小优先展示
        /// </summary>
        [JsonPropertyName("priority_booth")]
        public string PriorityBooth { get; set; }

        /// <summary>
        /// processed：发布，on：上架，off：下架
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }
    }
}
