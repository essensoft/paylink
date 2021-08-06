using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// SearchBoxExclusiveMarketingInfoRequest Data Structure.
    /// </summary>
    public class SearchBoxExclusiveMarketingInfoRequest : AlipayObject
    {
        /// <summary>
        /// 状态
        /// </summary>
        [JsonPropertyName("action")]
        public string Action { get; set; }

        /// <summary>
        /// 活动类型，MARETING/营销活动、MEMBERSHIP/开卡活动、CUSTOM/自定义活动
        /// </summary>
        [JsonPropertyName("action_type")]
        public string ActionType { get; set; }

        /// <summary>
        /// 活动链接
        /// </summary>
        [JsonPropertyName("action_url")]
        public string ActionUrl { get; set; }

        /// <summary>
        /// 申请人id
        /// </summary>
        [JsonPropertyName("applier_id")]
        public string ApplierId { get; set; }

        /// <summary>
        /// 品牌boxid
        /// </summary>
        [JsonPropertyName("brand_id")]
        public string BrandId { get; set; }

        /// <summary>
        /// 活动工单id
        /// </summary>
        [JsonPropertyName("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// 素材链接
        /// </summary>
        [JsonPropertyName("material_link")]
        public string MaterialLink { get; set; }

        /// <summary>
        /// 素材类型 IMAGE/VIDEO(图片/视频)
        /// </summary>
        [JsonPropertyName("material_type")]
        public string MaterialType { get; set; }

        /// <summary>
        /// 活动id
        /// </summary>
        [JsonPropertyName("serv_code")]
        public string ServCode { get; set; }

        /// <summary>
        /// 目标时段，包括全天的时段和全年的时段
        /// </summary>
        [JsonPropertyName("target_period")]
        public SearchProductPeriod TargetPeriod { get; set; }

        /// <summary>
        /// 目标区域，为list，元素为区域模型标识区域类型和具体区域
        /// </summary>
        [JsonPropertyName("target_region")]
        public List<SearchProductRegion> TargetRegion { get; set; }

        /// <summary>
        /// 活动标题
        /// </summary>
        [JsonPropertyName("title")]
        public string Title { get; set; }
    }
}
