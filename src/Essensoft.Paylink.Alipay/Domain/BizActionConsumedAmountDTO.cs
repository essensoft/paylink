using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// BizActionConsumedAmountDTO Data Structure.
    /// </summary>
    public class BizActionConsumedAmountDTO : AlipayObject
    {
        /// <summary>
        /// 业务预算申请code
        /// </summary>
        [JsonPropertyName("biz_budget_apply_code")]
        public string BizBudgetApplyCode { get; set; }

        /// <summary>
        /// 业务活动唯一id
        /// </summary>
        [JsonPropertyName("biz_uk_id")]
        public string BizUkId { get; set; }

        /// <summary>
        /// 占用金额，单位元
        /// </summary>
        [JsonPropertyName("consumed_amount")]
        public string ConsumedAmount { get; set; }

        /// <summary>
        /// 占用金额币种
        /// </summary>
        [JsonPropertyName("consumed_amount_currency")]
        public string ConsumedAmountCurrency { get; set; }
    }
}
