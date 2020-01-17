using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// BatchInfo Data Structure.
    /// </summary>
    public class BatchInfo : AlipayObject
    {
        /// <summary>
        /// 合同号
        /// </summary>
        [JsonPropertyName("contract_no")]
        public string ContractNo { get; set; }

        /// <summary>
        /// 参与方列表（包括本方公司和对手方公司）
        /// </summary>
        [JsonPropertyName("contract_partners")]
        public List<InterTradeContractPartner> ContractPartners { get; set; }
    }
}
