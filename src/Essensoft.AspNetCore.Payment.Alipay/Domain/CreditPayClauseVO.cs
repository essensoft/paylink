using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// CreditPayClauseVO Data Structure.
    /// </summary>
    public class CreditPayClauseVO : AlipayObject
    {
        /// <summary>
        /// 合同密钥
        /// </summary>
        [JsonPropertyName("contract_key")]
        public string ContractKey { get; set; }

        /// <summary>
        /// 合同名称
        /// </summary>
        [JsonPropertyName("contract_name")]
        public string ContractName { get; set; }

        /// <summary>
        /// 合同url
        /// </summary>
        [JsonPropertyName("contract_url")]
        public string ContractUrl { get; set; }
    }
}
