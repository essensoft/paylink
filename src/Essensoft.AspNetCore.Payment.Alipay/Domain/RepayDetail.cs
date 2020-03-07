using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// RepayDetail Data Structure.
    /// </summary>
    public class RepayDetail : AlipayObject
    {
        /// <summary>
        /// 应还本金
        /// </summary>
        [JsonPropertyName("capital_amount")]
        public string CapitalAmount { get; set; }

        /// <summary>
        /// 贷款合同编号
        /// </summary>
        [JsonPropertyName("contract_no")]
        public string ContractNo { get; set; }

        /// <summary>
        /// 应还利息
        /// </summary>
        [JsonPropertyName("interest_amount")]
        public string InterestAmount { get; set; }

        /// <summary>
        /// 贷款年份
        /// </summary>
        [JsonPropertyName("loan_year")]
        public string LoanYear { get; set; }

        /// <summary>
        /// 总还款金额
        /// </summary>
        [JsonPropertyName("total_amount")]
        public string TotalAmount { get; set; }
    }
}
