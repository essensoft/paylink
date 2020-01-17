using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ContractInfoVO Data Structure.
    /// </summary>
    public class ContractInfoVO : AlipayObject
    {
        /// <summary>
        /// 审批列表
        /// </summary>
        [JsonPropertyName("approval_infos")]
        public List<ContractApprovalInfoVO> ApprovalInfos { get; set; }

        /// <summary>
        /// 合约金额（元）
        /// </summary>
        [JsonPropertyName("contract_amount")]
        public string ContractAmount { get; set; }

        /// <summary>
        /// 合约名称
        /// </summary>
        [JsonPropertyName("contract_name")]
        public string ContractName { get; set; }

        /// <summary>
        /// 合约号
        /// </summary>
        [JsonPropertyName("contract_no")]
        public string ContractNo { get; set; }

        /// <summary>
        /// 币种（如：CNY）
        /// </summary>
        [JsonPropertyName("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// 统计口径
        /// </summary>
        [JsonPropertyName("stats_type")]
        public string StatsType { get; set; }
    }
}
