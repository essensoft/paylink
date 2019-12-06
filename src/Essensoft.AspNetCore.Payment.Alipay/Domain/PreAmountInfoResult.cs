using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// PreAmountInfoResult Data Structure.
    /// </summary>
    public class PreAmountInfoResult : AlipayObject
    {
        /// <summary>
        /// 前置费用明细列表
        /// </summary>
        [JsonPropertyName("pre_amount_list")]
        public List<PreAmountClauseResult> PreAmountList { get; set; }

        /// <summary>
        /// 金额
        /// </summary>
        [JsonPropertyName("total_pre_mount")]
        public string TotalPreMount { get; set; }
    }
}
