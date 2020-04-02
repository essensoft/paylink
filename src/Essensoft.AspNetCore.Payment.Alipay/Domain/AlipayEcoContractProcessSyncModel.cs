using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayEcoContractProcessSyncModel Data Structure.
    /// </summary>
    public class AlipayEcoContractProcessSyncModel : AlipayObject
    {
        /// <summary>
        /// MCCCode
        /// </summary>
        [JsonPropertyName("batch_no")]
        public string BatchNo { get; set; }

        /// <summary>
        /// 流程信息
        /// </summary>
        [JsonPropertyName("flows")]
        public List<ContractManagerProcessSyncRequest> Flows { get; set; }

        /// <summary>
        /// 签署平台的代码
        /// </summary>
        [JsonPropertyName("sign_platform_code")]
        public string SignPlatformCode { get; set; }
    }
}
