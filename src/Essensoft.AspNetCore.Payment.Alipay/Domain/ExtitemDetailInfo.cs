using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ExtitemDetailInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ExtitemDetailInfo : AlipayObject
    {
        /// <summary>
        /// 标品id
        /// </summary>
        [JsonProperty("extitem_id")]
        public string ExtitemId { get; set; }

        /// <summary>
        /// 标品名称
        /// </summary>
        [JsonProperty("extitem_name")]
        public string ExtitemName { get; set; }

        /// <summary>
        /// 标品的货品组成
        /// </summary>
        [JsonProperty("goods_component_list")]
        public List<GoodsComponent> GoodsComponentList { get; set; }
    }
}
