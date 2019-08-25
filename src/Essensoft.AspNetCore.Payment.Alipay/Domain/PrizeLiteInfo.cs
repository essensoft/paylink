using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// PrizeLiteInfo Data Structure.
    /// </summary>
    [Serializable]
    public class PrizeLiteInfo : AlipayObject
    {
        /// <summary>
        /// 外部奖品ID
        /// </summary>
        [JsonProperty("out_prize_id")]
        public string OutPrizeId { get; set; }

        /// <summary>
        /// 奖品状态，可枚举，分别为“可用”(ENABLED)、“不可用”(DISABLED)、“不满足使用规则”(NOT_MATCH_USE_CONDITION)
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }
    }
}
