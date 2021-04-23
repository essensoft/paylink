using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// CreditQuotaDetail Data Structure.
    /// </summary>
    public class CreditQuotaDetail : AlipayObject
    {
        /// <summary>
        /// 授信期限
        /// </summary>
        [JsonPropertyName("credit_term")]
        public string CreditTerm { get; set; }

        /// <summary>
        /// 授信期限单位，DAY-日，MONTH-月，YEAR-年
        /// </summary>
        [JsonPropertyName("credit_term_unit")]
        public string CreditTermUnit { get; set; }

        /// <summary>
        /// 授信有效期结束日，格式（yyyy-MM-dd）
        /// </summary>
        [JsonPropertyName("end_date")]
        public string EndDate { get; set; }

        /// <summary>
        /// 额度类型，CREDIT - 信用，ORDER - 订单，MORTGAGE - 抵押，MAXIMUM - 最大额度
        /// </summary>
        [JsonPropertyName("loan_quota_type")]
        public string LoanQuotaType { get; set; }

        /// <summary>
        /// 申请授信额度，币种最小单位，如果是CNY，则单位分
        /// </summary>
        [JsonPropertyName("quota_amount")]
        public long QuotaAmount { get; set; }

        /// <summary>
        /// 申请授信额度币种
        /// </summary>
        [JsonPropertyName("quota_amount_currency")]
        public string QuotaAmountCurrency { get; set; }

        /// <summary>
        /// 授信有效期开始日，格式（yyyy-MM-dd）
        /// </summary>
        [JsonPropertyName("start_date")]
        public string StartDate { get; set; }
    }
}
