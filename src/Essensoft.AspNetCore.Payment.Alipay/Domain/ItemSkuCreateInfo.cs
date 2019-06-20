using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ItemSkuCreateInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ItemSkuCreateInfo : AlipayObject
    {
        /// <summary>
        /// 成本价，单位分
        /// </summary>
        [JsonProperty("cost_price")]
        public long CostPrice { get; set; }

        /// <summary>
        /// SKU扩展信息
        /// </summary>
        [JsonProperty("ext_info")]
        public List<ItemExtInfo> ExtInfo { get; set; }

        /// <summary>
        /// 标价，单位分
        /// </summary>
        [JsonProperty("original_price")]
        public long OriginalPrice { get; set; }

        /// <summary>
        /// 售价，单位分
        /// </summary>
        [JsonProperty("price")]
        public long Price { get; set; }
    }
}
