using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ApplyBizBudgetRequest Data Structure.
    /// </summary>
    public class ApplyBizBudgetRequest : AlipayObject
    {
        /// <summary>
        /// 预算申请金额，人民币
        /// </summary>
        [JsonPropertyName("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 假如，amount字段为100 APPEND: 增加，在原有基础上增加100 APPEND_TO:增加到，将原有基础增加到100
        /// </summary>
        [JsonPropertyName("amount_type")]
        public string AmountType { get; set; }

        /// <summary>
        /// 业务预算申请code
        /// </summary>
        [JsonPropertyName("biz_budget_apply_code")]
        public string BizBudgetApplyCode { get; set; }

        /// <summary>
        /// 业务名称
        /// </summary>
        [JsonPropertyName("biz_name")]
        public string BizName { get; set; }

        /// <summary>
        /// * COMMISSION: 返佣 * PURCHASE: 采购 * PROMO: 营销
        /// </summary>
        [JsonPropertyName("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 业务活动唯一id,用于幂等,与biz_type一起组成幂等索引，不可重复
        /// </summary>
        [JsonPropertyName("biz_uk_id")]
        public string BizUkId { get; set; }
    }
}
