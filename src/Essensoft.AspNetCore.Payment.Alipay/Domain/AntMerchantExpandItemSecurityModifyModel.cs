using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AntMerchantExpandItemSecurityModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntMerchantExpandItemSecurityModifyModel : AlipayObject
    {
        /// <summary>
        /// 商品描述
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// 商品所属前台类目ID列表（会和商品已存在所属前台类目做差异化比较后做增删操作）
        /// </summary>
        [JsonProperty("front_category_id_list")]
        public List<string> FrontCategoryIdList { get; set; }

        /// <summary>
        /// 商品ID
        /// </summary>
        [JsonProperty("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// 商品素材列表（会和商品已存在素材做差异化比较后做增删改操作）
        /// </summary>
        [JsonProperty("material_list")]
        public List<MaterialModifyInfo> MaterialList { get; set; }

        /// <summary>
        /// 商品名称
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// 商品属性列表（覆盖商品已存在属性）
        /// </summary>
        [JsonProperty("property_list")]
        public List<ItemPropertyInfo> PropertyList { get; set; }

        /// <summary>
        /// SKU列表（会和商品已存在SKU做差异化比较后做增删改操作）
        /// </summary>
        [JsonProperty("sku_list")]
        public List<SkuModifyInfo> SkuList { get; set; }

        /// <summary>
        /// 商品状态：EFFECT（有效）、INVALID（无效）
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }

        /// <summary>
        /// 商品类型：STANDARD_GOODS（标品）、NON_STANDARD_GOODS（非标品）
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
