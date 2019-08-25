using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// CreditPayClauseVO Data Structure.
    /// </summary>
    [Serializable]
    public class CreditPayClauseVO : AlipayObject
    {
        /// <summary>
        /// 合同密钥
        /// </summary>
        [JsonProperty("contract_key")]
        public string ContractKey { get; set; }

        /// <summary>
        /// 合同名称
        /// </summary>
        [JsonProperty("contract_name")]
        public string ContractName { get; set; }

        /// <summary>
        /// 合同url
        /// </summary>
        [JsonProperty("contract_url")]
        public string ContractUrl { get; set; }
    }
}
