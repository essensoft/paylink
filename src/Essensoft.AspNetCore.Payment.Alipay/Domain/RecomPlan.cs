using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// RecomPlan Data Structure.
    /// </summary>
    [Serializable]
    public class RecomPlan : AlipayObject
    {
        /// <summary>
        /// 投保key关键字
        /// </summary>
        [JsonProperty("key")]
        public string Key { get; set; }

        /// <summary>
        /// 方案名称，展示用
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// 用户选择后投保带的对象
        /// </summary>
        [JsonProperty("value")]
        public string Value { get; set; }
    }
}
