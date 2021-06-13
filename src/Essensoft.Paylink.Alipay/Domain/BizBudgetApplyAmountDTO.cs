using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// BizBudgetApplyAmountDTO Data Structure.
    /// </summary>
    public class BizBudgetApplyAmountDTO : AlipayObject
    {
        /// <summary>
        /// 业务预算申请Code
        /// </summary>
        [JsonPropertyName("biz_budget_apply_code")]
        public string BizBudgetApplyCode { get; set; }

        /// <summary>
        /// BBA全量占用金额，单位元
        /// </summary>
        [JsonPropertyName("consumed_amount")]
        public string ConsumedAmount { get; set; }

        /// <summary>
        /// 占用金额币种
        /// </summary>
        [JsonPropertyName("consumed_amount_currency")]
        public string ConsumedAmountCurrency { get; set; }

        /// <summary>
        /// BBA全量剩余金额，单位为元
        /// </summary>
        [JsonPropertyName("remain_amount")]
        public string RemainAmount { get; set; }

        /// <summary>
        /// 剩余金额币种
        /// </summary>
        [JsonPropertyName("remain_amount_currency")]
        public string RemainAmountCurrency { get; set; }
    }
}
