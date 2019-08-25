using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayInsSceneHealthGiftQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayInsSceneHealthGiftQueryModel : AlipayObject
    {
        /// <summary>
        /// 查询某范围内某渠道领取的保额的止期，注意，只对sourceGainedSumInsured字段生效
        /// </summary>
        [JsonProperty("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 赠险的产品组标识，例如免费医疗金的COMMON_GIFT_INSURANCE_PRODUCT_GROUP
        /// </summary>
        [JsonProperty("product_group_biz_type")]
        public string ProductGroupBizType { get; set; }

        /// <summary>
        /// 渠道来源，标识赠险的领取渠道
        /// </summary>
        [JsonProperty("source")]
        public string Source { get; set; }

        /// <summary>
        /// 查询某范围内某渠道领取的保额的起期，注意，只对sourceGainedSumInsured字段生效
        /// </summary>
        [JsonProperty("start_time")]
        public string StartTime { get; set; }

        /// <summary>
        /// 用户ID
        /// </summary>
        [JsonProperty("user_id")]
        public string UserId { get; set; }
    }
}
