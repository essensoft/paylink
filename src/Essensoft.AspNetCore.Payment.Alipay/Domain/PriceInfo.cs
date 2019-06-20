using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// PriceInfo Data Structure.
    /// </summary>
    [Serializable]
    public class PriceInfo : AlipayObject
    {
        /// <summary>
        /// 商品价格维度信息
        /// </summary>
        [JsonProperty("dimension")]
        public string Dimension { get; set; }

        /// <summary>
        /// 价格，单位为元
        /// </summary>
        [JsonProperty("price")]
        public string Price { get; set; }
    }
}
