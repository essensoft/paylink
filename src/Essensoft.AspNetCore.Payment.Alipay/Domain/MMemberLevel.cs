using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// MMemberLevel Data Structure.
    /// </summary>
    [Serializable]
    public class MMemberLevel : AlipayObject
    {
        /// <summary>
        /// 会员等级code码
        /// </summary>
        [JsonProperty("code")]
        public string Code { get; set; }

        /// <summary>
        /// 会员等级值
        /// </summary>
        [JsonProperty("level")]
        public string Level { get; set; }

        /// <summary>
        /// 会员等级名称
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
