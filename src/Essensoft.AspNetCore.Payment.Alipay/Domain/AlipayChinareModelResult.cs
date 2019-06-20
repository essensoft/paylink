using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayChinareModelResult Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayChinareModelResult : AlipayObject
    {
        /// <summary>
        /// 体检记录id
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// 规则id
        /// </summary>
        [JsonProperty("rule_id")]
        public string RuleId { get; set; }

        /// <summary>
        /// 核保结果
        /// </summary>
        [JsonProperty("rule_result")]
        public string RuleResult { get; set; }

        /// <summary>
        /// 交易流水记录id
        /// </summary>
        [JsonProperty("trans_id")]
        public string TransId { get; set; }
    }
}
