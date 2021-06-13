using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayMarketingActivityOrdervoucherModifyModel Data Structure.
    /// </summary>
    public class AlipayMarketingActivityOrdervoucherModifyModel : AlipayObject
    {
        /// <summary>
        /// 活动id
        /// </summary>
        [JsonPropertyName("activity_id")]
        public string ActivityId { get; set; }

        /// <summary>
        /// 引导用户配置
        /// </summary>
        [JsonPropertyName("customer_guide")]
        public CustomerGuideModify CustomerGuide { get; set; }

        /// <summary>
        /// 外部业务单号，用作幂等控制。  幂等作用： 参数不变的情况下，再次请求返回与上一次相同的结果。 外部接入方需保证业务单号唯一。
        /// </summary>
        [JsonPropertyName("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 券发放结束时间。    格式为：yyyy-MM-dd HH:mm:ss    限制：  券发放结束时间  publish_end_time 与 券发放开始时间  publish_start_time 间隔必须小于等于180天    修改发放结束时间，只能延长，不允许缩短。
        /// </summary>
        [JsonPropertyName("publish_end_time")]
        public string PublishEndTime { get; set; }

        /// <summary>
        /// 券使用规则
        /// </summary>
        [JsonPropertyName("voucher_use_rule")]
        public VoucherUseRuleModify VoucherUseRule { get; set; }
    }
}
