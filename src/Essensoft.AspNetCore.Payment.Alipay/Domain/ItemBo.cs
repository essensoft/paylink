using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ItemBo Data Structure.
    /// </summary>
    [Serializable]
    public class ItemBo : AlipayObject
    {
        /// <summary>
        /// json 字符串表示额外信息
        /// </summary>
        [JsonProperty("attribute")]
        public string Attribute { get; set; }

        /// <summary>
        /// 描述信息
        /// </summary>
        [JsonProperty("desc")]
        public string Desc { get; set; }

        /// <summary>
        /// logo链接
        /// </summary>
        [JsonProperty("logo")]
        public string Logo { get; set; }

        /// <summary>
        /// 名称
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// 原价
        /// </summary>
        [JsonProperty("origin_price")]
        public long OriginPrice { get; set; }

        /// <summary>
        /// 现价
        /// </summary>
        [JsonProperty("price")]
        public long Price { get; set; }
    }
}
