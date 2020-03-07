using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ContractBatchInfoOpenApiResult Data Structure.
    /// </summary>
    public class ContractBatchInfoOpenApiResult : AlipayObject
    {
        /// <summary>
        /// 批次审批状态（处理中：PROCESSING；已拒绝：REFUSE；已撤销：CANCEL； 已通过：PASS）
        /// </summary>
        [JsonPropertyName("approval_status")]
        public string ApprovalStatus { get; set; }

        /// <summary>
        /// 合约信息列表
        /// </summary>
        [JsonPropertyName("contract_infos")]
        public List<ContractInfoVO> ContractInfos { get; set; }
    }
}
