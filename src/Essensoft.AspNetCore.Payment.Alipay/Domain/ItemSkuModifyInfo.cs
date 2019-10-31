using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ItemSkuModifyInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ItemSkuModifyInfo : AlipayObject
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
        /// 外部skuId（sku_id不为空时作为普通更新项,sku_id为空时作为更新key,sku_id和该字段同时为空则新增该条数据）
        /// </summary>
        [JsonProperty("external_sku_id")]
        public string ExternalSkuId { get; set; }

        /// <summary>
        /// 库存
        /// </summary>
        [JsonProperty("inventory")]
        public long Inventory { get; set; }

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

        /// <summary>
        /// skuId
        /// </summary>
        [JsonProperty("sku_id")]
        public string SkuId { get; set; }

        /// <summary>
        /// 商品SKU状态：EFFECT、INVALID
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }
    }
}
