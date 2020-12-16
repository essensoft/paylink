using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayBossFncAntbudgetReturnModel Data Structure.
    /// </summary>
    public class AlipayBossFncAntbudgetReturnModel : AlipayObject
    {
        /// <summary>
        /// 预算申请金额，默认为人民币
        /// </summary>
        [JsonPropertyName("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 业务预算申请code
        /// </summary>
        [JsonPropertyName("biz_budget_apply_code")]
        public string BizBudgetApplyCode { get; set; }

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

        /// <summary>
        /// 幂等字段
        /// </summary>
        [JsonPropertyName("idempotent_id")]
        public string IdempotentId { get; set; }

        /// <summary>
        /// 退回类型  BIZ_RETURN, 业务活动预算退回      *      *     BIZ_EXPIRE_RETURN, 业务活动预算过期退回
        /// </summary>
        [JsonPropertyName("modify_type")]
        public string ModifyType { get; set; }
    }
}
