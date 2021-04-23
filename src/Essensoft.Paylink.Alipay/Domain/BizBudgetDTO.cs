using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// BizBudgetDTO Data Structure.
    /// </summary>
    public class BizBudgetDTO : AlipayObject
    {
        /// <summary>
        /// 方案剩余可用金额
        /// </summary>
        [JsonPropertyName("available_amount")]
        public string AvailableAmount { get; set; }

        /// <summary>
        /// 预算业务申请信息
        /// </summary>
        [JsonPropertyName("biz_apply_info")]
        public List<PurchaseApplyInfoDTO> BizApplyInfo { get; set; }

        /// <summary>
        /// 活动预算编码
        /// </summary>
        [JsonPropertyName("biz_budget_id")]
        public string BizBudgetId { get; set; }

        /// <summary>
        /// 活动预算的名称，非用户名，不是敏感字段
        /// </summary>
        [JsonPropertyName("biz_budget_name")]
        public string BizBudgetName { get; set; }

        /// <summary>
        /// 金额币种
        /// </summary>
        [JsonPropertyName("currency")]
        public string Currency { get; set; }
    }
}
