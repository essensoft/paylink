using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// RepayDetail Data Structure.
    /// </summary>
    [Serializable]
    public class RepayDetail : AlipayObject
    {
        /// <summary>
        /// 应还本金
        /// </summary>
        [JsonProperty("capital_amount")]
        public string CapitalAmount { get; set; }

        /// <summary>
        /// 贷款合同编号
        /// </summary>
        [JsonProperty("contract_no")]
        public string ContractNo { get; set; }

        /// <summary>
        /// 应还利息
        /// </summary>
        [JsonProperty("interest_amount")]
        public string InterestAmount { get; set; }

        /// <summary>
        /// 贷款年份
        /// </summary>
        [JsonProperty("loan_year")]
        public string LoanYear { get; set; }

        /// <summary>
        /// 总还款金额
        /// </summary>
        [JsonProperty("total_amount")]
        public string TotalAmount { get; set; }
    }
}
