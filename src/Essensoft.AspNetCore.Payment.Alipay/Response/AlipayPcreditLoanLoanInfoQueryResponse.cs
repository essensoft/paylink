using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayPcreditLoanLoanInfoQueryResponse.
    /// </summary>
    public class AlipayPcreditLoanLoanInfoQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 贷款记录列表
        /// </summary>
        [JsonPropertyName("base_apply_list")]
        public List<BaseLoanApplyVO> BaseApplyList { get; set; }

        /// <summary>
        /// 结果总数
        /// </summary>
        [JsonPropertyName("total")]
        public long Total { get; set; }
    }
}
