using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// InterTradeConsultOpenApiResult Data Structure.
    /// </summary>
    public class InterTradeConsultOpenApiResult : AlipayObject
    {
        /// <summary>
        /// 合约识别结果
        /// </summary>
        [JsonPropertyName("contracts")]
        public List<ContractConsultResultVO> Contracts { get; set; }

        /// <summary>
        /// 是否需要发起审批
        /// </summary>
        [JsonPropertyName("need_approval")]
        public bool NeedApproval { get; set; }
    }
}
