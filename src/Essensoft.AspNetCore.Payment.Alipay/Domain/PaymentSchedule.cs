using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// PaymentSchedule Data Structure.
    /// </summary>
    public class PaymentSchedule : AlipayObject
    {
        /// <summary>
        /// 还款日
        /// </summary>
        [JsonPropertyName("date")]
        public string Date { get; set; }

        /// <summary>
        /// 已还利息总和，单位为元，小数点保留2位
        /// </summary>
        [JsonPropertyName("repaid_interest_total")]
        public string RepaidInterestTotal { get; set; }

        /// <summary>
        /// 已还罚息总和，单位为元，小数点保留2位
        /// </summary>
        [JsonPropertyName("repaid_penalty_total")]
        public string RepaidPenaltyTotal { get; set; }

        /// <summary>
        /// 已还本金总和，单位为元，小数点保留2位
        /// </summary>
        [JsonPropertyName("repaid_principal_total")]
        public string RepaidPrincipalTotal { get; set; }

        /// <summary>
        /// 期初时间
        /// </summary>
        [JsonPropertyName("start_date")]
        public string StartDate { get; set; }

        /// <summary>
        /// 期次
        /// </summary>
        [JsonPropertyName("term")]
        public long Term { get; set; }

        /// <summary>
        /// 应还利息总和，单位为元，小数点保留2位
        /// </summary>
        [JsonPropertyName("unpaid_interest_total")]
        public string UnpaidInterestTotal { get; set; }

        /// <summary>
        /// 应还罚息总和，单位为元，小数点保留2位
        /// </summary>
        [JsonPropertyName("unpaid_penalty_total")]
        public string UnpaidPenaltyTotal { get; set; }

        /// <summary>
        /// 应还本金总和，单位为元，小数点保留2位
        /// </summary>
        [JsonPropertyName("unpaid_principal_total")]
        public string UnpaidPrincipalTotal { get; set; }
    }
}
