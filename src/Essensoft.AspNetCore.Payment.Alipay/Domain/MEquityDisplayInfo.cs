using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// MEquityDisplayInfo Data Structure.
    /// </summary>
    [Serializable]
    public class MEquityDisplayInfo : AlipayObject
    {
        /// <summary>
        /// 品牌名
        /// </summary>
        [JsonProperty("brand_name")]
        public string BrandName { get; set; }

        /// <summary>
        /// 权益LOGO
        /// </summary>
        [JsonProperty("logo")]
        public string Logo { get; set; }

        /// <summary>
        /// 权益名称
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
