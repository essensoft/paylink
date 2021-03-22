using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// MarketingActivityInfo Data Structure.
    /// </summary>
    public class MarketingActivityInfo : AlipayObject
    {
        /// <summary>
        /// 活动结束时间，即券可领取结束时间，格式为yyyy-MM-dd HH:mm:ss
        /// </summary>
        [JsonPropertyName("activity_end_time")]
        public string ActivityEndTime { get; set; }

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
        /// 活动开始时间，即券可领取开始时间，格式为yyyy-MM-dd HH:mm:ss
        /// </summary>
        [JsonPropertyName("activity_start_time")]
        public string ActivityStartTime { get; set; }

        /// <summary>
        /// 活动状态： 草稿(INIT),已提交审核(P_AUDIT),已审核(AUDIT),待激活(WAIT_ACTIVE),激活(ACTIVE),暂停(PAUSE),已结束(FINISHED),已废弃(DISCARD)
        /// </summary>
        [JsonPropertyName("activity_status")]
        public string ActivityStatus { get; set; }

        /// <summary>
        /// 商户logo
        /// </summary>
        [JsonPropertyName("merchant_logo")]
        public string MerchantLogo { get; set; }

        /// <summary>
        /// 商户名称
        /// </summary>
        [JsonPropertyName("merchant_name")]
        public string MerchantName { get; set; }

        /// <summary>
        /// 券模板列表
        /// </summary>
        [JsonPropertyName("voucher_template_list")]
        public List<VoucherTemplate> VoucherTemplateList { get; set; }
    }
}
