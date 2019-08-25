using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// PromotionInfo Data Structure.
    /// </summary>
    [Serializable]
    public class PromotionInfo : AlipayObject
    {
        /// <summary>
        /// 优惠品牌
        /// </summary>
        [JsonProperty("brand_name")]
        public string BrandName { get; set; }

        /// <summary>
        /// 优惠是否已领取
        /// </summary>
        [JsonProperty("collected")]
        public bool Collected { get; set; }

        /// <summary>
        /// 优惠领取总数
        /// </summary>
        [JsonProperty("collected_count")]
        public long CollectedCount { get; set; }

        /// <summary>
        /// 优惠详情页跳转链接
        /// </summary>
        [JsonProperty("detail_url")]
        public string DetailUrl { get; set; }

        /// <summary>
        /// 优惠类型图标，惠折满减等
        /// </summary>
        [JsonProperty("icon_url")]
        public string IconUrl { get; set; }

        /// <summary>
        /// 优惠头图
        /// </summary>
        [JsonProperty("main_image_url")]
        public string MainImageUrl { get; set; }

        /// <summary>
        /// 优惠ID
        /// </summary>
        [JsonProperty("promotion_id")]
        public string PromotionId { get; set; }

        /// <summary>
        /// 优惠标题
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }

        /// <summary>
        /// 使用条件说明
        /// </summary>
        [JsonProperty("using_condition")]
        public string UsingCondition { get; set; }

        /// <summary>
        /// 使用范围说明
        /// </summary>
        [JsonProperty("using_scope")]
        public string UsingScope { get; set; }

        /// <summary>
        /// 优惠有效期起：格式yyyy-mm-dd，如"2017-07-18"
        /// </summary>
        [JsonProperty("valid_date_from")]
        public string ValidDateFrom { get; set; }

        /// <summary>
        /// 优惠有效期止：格式yyyy-mm-dd，如"2017-07-18"
        /// </summary>
        [JsonProperty("valid_date_to")]
        public string ValidDateTo { get; set; }

        /// <summary>
        /// 相对有效期展示文案，当valid_date_from及valid_date_to为空时，此字段必然有值
        /// </summary>
        [JsonProperty("valid_time_text")]
        public string ValidTimeText { get; set; }

        /// <summary>
        /// 券使用状态(已领取可使用COLLECTED_UNUSE/未领取UNCOLLECT/已使用USED)
        /// </summary>
        [JsonProperty("voucher_usage_status")]
        public string VoucherUsageStatus { get; set; }
    }
}
