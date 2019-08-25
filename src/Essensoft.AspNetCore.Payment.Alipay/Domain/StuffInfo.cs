using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// StuffInfo Data Structure.
    /// </summary>
    [Serializable]
    public class StuffInfo : AlipayObject
    {
        /// <summary>
        /// 商品描述
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// 扩展字段，保留
        /// </summary>
        [JsonProperty("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 商品名称
        /// </summary>
        [JsonProperty("item_name")]
        public string ItemName { get; set; }

        /// <summary>
        /// 物料商品SKU号
        /// </summary>
        [JsonProperty("sku_no")]
        public string SkuNo { get; set; }

        /// <summary>
        /// 商品规格描述
        /// </summary>
        [JsonProperty("standard_description")]
        public string StandardDescription { get; set; }
    }
}
