using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// BizBudgetDTO Data Structure.
    /// </summary>
    public class BizBudgetDTO : AlipayObject
    {
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
    }
}
