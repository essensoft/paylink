using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// ZhimaCustomerBehaviorSyncResponse.
    /// </summary>
    public class ZhimaCustomerBehaviorSyncResponse : AlipayResponse
    {
        /// <summary>
        /// 行为合约号
        /// </summary>
        [JsonPropertyName("contract_no")]
        public string ContractNo { get; set; }

        /// <summary>
        /// 行为所触发的合约号
        /// </summary>
        [JsonPropertyName("contract_nos")]
        public List<string> ContractNos { get; set; }
    }
}
