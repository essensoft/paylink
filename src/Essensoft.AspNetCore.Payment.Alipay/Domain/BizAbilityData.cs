using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// BizAbilityData Data Structure.
    /// </summary>
    [Serializable]
    public class BizAbilityData : AlipayObject
    {
        /// <summary>
        /// 业务能力数据json值
        /// </summary>
        [JsonProperty("data")]
        public string Data { get; set; }

        /// <summary>
        /// 数据key
        /// </summary>
        [JsonProperty("key")]
        public string Key { get; set; }
    }
}
