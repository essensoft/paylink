using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayEcoContractProcessDeleteModel Data Structure.
    /// </summary>
    public class AlipayEcoContractProcessDeleteModel : AlipayObject
    {
        /// <summary>
        /// MCCCode
        /// </summary>
        [JsonPropertyName("batch_no")]
        public string BatchNo { get; set; }

        /// <summary>
        /// 流程Id
        /// </summary>
        [JsonPropertyName("flow_ids")]
        public List<string> FlowIds { get; set; }

        /// <summary>
        /// 签署平台的代码
        /// </summary>
        [JsonPropertyName("sign_platform_code")]
        public string SignPlatformCode { get; set; }
    }
}
