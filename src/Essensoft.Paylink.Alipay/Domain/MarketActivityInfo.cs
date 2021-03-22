using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// MarketActivityInfo Data Structure.
    /// </summary>
    public class MarketActivityInfo : AlipayObject
    {
        /// <summary>
        /// 活动id
        /// </summary>
        [JsonPropertyName("activity_id")]
        public string ActivityId { get; set; }

        /// <summary>
        /// 活动名称
        /// </summary>
        [JsonPropertyName("activity_name")]
        public string ActivityName { get; set; }

        /// <summary>
        /// 活动发起方LOGO
        /// </summary>
        [JsonPropertyName("brand_logo")]
        public string BrandLogo { get; set; }

        /// <summary>
        /// 活动发起方名称
        /// </summary>
        [JsonPropertyName("brand_name")]
        public string BrandName { get; set; }

        /// <summary>
        /// 发放结束时间. 格式为：yyyy-MM-dd HH:mm:ss
        /// </summary>
        [JsonPropertyName("publish_end_time")]
        public string PublishEndTime { get; set; }

        /// <summary>
        /// 发放开始时间. 格式为：yyyy-MM-dd HH:mm:ss
        /// </summary>
        [JsonPropertyName("publish_start_time")]
        public string PublishStartTime { get; set; }

        /// <summary>
        /// 活动状态;  ACTIVE: 已经发布,  PAUSE:已经暂停, FINISHED: 已结束
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        /// 券列表
        /// </summary>
        [JsonPropertyName("voucher_infos")]
        public List<VoucherTemplateInfo> VoucherInfos { get; set; }
    }
}
