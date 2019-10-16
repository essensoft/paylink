using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// PrizePriceStrategy Data Structure.
    /// </summary>
    [Serializable]
    public class PrizePriceStrategy : AlipayObject
    {
        /// <summary>
        /// 根据不同的奖品类型填写不同的值，具体用法联系营销技术获取
        /// </summary>
        [JsonProperty("max_price")]
        public string MaxPrice { get; set; }

        /// <summary>
        /// 根据不同的奖品类型填写不同的值，具体用法联系营销技术获取
        /// </summary>
        [JsonProperty("min_price")]
        public string MinPrice { get; set; }

        /// <summary>
        /// 定价策略值，根据不同的奖品类型填写不同的值，具体用法联系营销技术获取
        /// </summary>
        [JsonProperty("stragety_value")]
        public string StragetyValue { get; set; }

        /// <summary>
        /// RANDOM_PRICE随机，FIX_PRICE定额奖品，不同的定价策略填写不同值，具体根据业务评估
        /// </summary>
        [JsonProperty("strategy_type")]
        public string StrategyType { get; set; }
    }
}
