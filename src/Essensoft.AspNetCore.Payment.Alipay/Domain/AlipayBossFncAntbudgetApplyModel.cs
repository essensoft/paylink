using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayBossFncAntbudgetApplyModel Data Structure.
    /// </summary>
    public class AlipayBossFncAntbudgetApplyModel : AlipayObject
    {
        /// <summary>
        /// 申请参数列表
        /// </summary>
        [JsonPropertyName("apply_biz_budget_request_list")]
        public List<ApplyBizBudgetRequest> ApplyBizBudgetRequestList { get; set; }

        /// <summary>
        /// 幂等字段
        /// </summary>
        [JsonPropertyName("idempotent_id")]
        public string IdempotentId { get; set; }
    }
}
