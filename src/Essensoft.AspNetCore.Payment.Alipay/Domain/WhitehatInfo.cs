using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// WhitehatInfo Data Structure.
    /// </summary>
    [Serializable]
    public class WhitehatInfo : AlipayObject
    {
        /// <summary>
        /// 当前有效的安全币奖励
        /// </summary>
        [JsonProperty("coin")]
        public long Coin { get; set; }

        /// <summary>
        /// 历史总金币奖励
        /// </summary>
        [JsonProperty("history_coin")]
        public long HistoryCoin { get; set; }

        /// <summary>
        /// 称号
        /// </summary>
        [JsonProperty("level")]
        public string Level { get; set; }
    }
}
