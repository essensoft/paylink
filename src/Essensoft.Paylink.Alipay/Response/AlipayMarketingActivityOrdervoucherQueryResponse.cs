using System.Text.Json.Serialization;
using Essensoft.Paylink.Alipay.Domain;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayMarketingActivityOrdervoucherQueryResponse.
    /// </summary>
    public class AlipayMarketingActivityOrdervoucherQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 活动id
        /// </summary>
        [JsonPropertyName("activity_id")]
        public string ActivityId { get; set; }

        /// <summary>
        /// 活动名称。  不对用户进行展示，仅供商家在后台管理活动使用。
        /// </summary>
        [JsonPropertyName("activity_name")]
        public string ActivityName { get; set; }

        /// <summary>
        /// 活动操作状态    CREATING：创建中    MODIFYING：修改中    APPENDING：追加中    FINISHEING：停止中    如果该值为空，说明活动当前没有正在执行中的操作。
        /// </summary>
        [JsonPropertyName("activity_operation_status")]
        public string ActivityOperationStatus { get; set; }

        /// <summary>
        /// 活动状态，状态枚举：    ACTIVE：已激活    FINISHED：已停止    如果该值为空，说明活动还未创建成功。可以使用  activity_operation_status字段判断活动是否处于CREATING状态。
        /// </summary>
        [JsonPropertyName("activity_status")]
        public string ActivityStatus { get; set; }

        /// <summary>
        /// 活动所属的商户信息。 如果为空.则是因为创建时未传入，默认为活动归属于接口的调用者。
        /// </summary>
        [JsonPropertyName("belong_merchant_info")]
        public BelongMerchantInfo BelongMerchantInfo { get; set; }

        /// <summary>
        /// 用户引导相关配置
        /// </summary>
        [JsonPropertyName("customer_guide")]
        public CustomerGuide CustomerGuide { get; set; }

        /// <summary>
        /// 券发放结束时间。  格式为：yyyy-MM-dd HH:mm:ss
        /// </summary>
        [JsonPropertyName("publish_end_time")]
        public string PublishEndTime { get; set; }

        /// <summary>
        /// 券发放开始时间。  格式为：yyyy-MM-dd HH:mm:ss
        /// </summary>
        [JsonPropertyName("publish_start_time")]
        public string PublishStartTime { get; set; }

        /// <summary>
        /// 券汇总信息
        /// </summary>
        [JsonPropertyName("summary")]
        public VoucherSummary Summary { get; set; }

        /// <summary>
        /// 券展示信息
        /// </summary>
        [JsonPropertyName("voucher_display_info")]
        public VoucherDisplayInfo VoucherDisplayInfo { get; set; }

        /// <summary>
        /// 券发放规则
        /// </summary>
        [JsonPropertyName("voucher_send_rule")]
        public VoucherSendRuleDetail VoucherSendRule { get; set; }

        /// <summary>
        /// 券类型。    枚举值：  FIX_VOUCHER：满减券。
        /// </summary>
        [JsonPropertyName("voucher_type")]
        public string VoucherType { get; set; }

        /// <summary>
        /// 券使用规则
        /// </summary>
        [JsonPropertyName("voucher_use_rule")]
        public VoucherUseRule VoucherUseRule { get; set; }
    }
}
