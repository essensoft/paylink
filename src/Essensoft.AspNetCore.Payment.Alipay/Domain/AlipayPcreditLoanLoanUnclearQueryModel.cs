using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayPcreditLoanLoanUnclearQueryModel Data Structure.
    /// </summary>
    public class AlipayPcreditLoanLoanUnclearQueryModel : AlipayObject
    {
        /// <summary>
        /// 预算类型，取值{CLEAR, OVD_AND_CURRENT}：CLEAR-结清预算, OVD_AND_CURRENT-逾期和当期预算
        /// </summary>
        [JsonPropertyName("budget_type")]
        public string BudgetType { get; set; }

        /// <summary>
        /// 代表了一次请求，作为业务幂等性控制
        /// </summary>
        [JsonPropertyName("out_request_no")]
        public string OutRequestNo { get; set; }
    }
}
