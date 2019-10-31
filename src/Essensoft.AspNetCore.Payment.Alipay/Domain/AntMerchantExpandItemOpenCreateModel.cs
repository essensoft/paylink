using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AntMerchantExpandItemOpenCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntMerchantExpandItemOpenCreateModel : AlipayObject
    {
        /// <summary>
        /// 商品描述
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// 商品扩展信息（具体KEY请参见产品文档）
        /// </summary>
        [JsonProperty("ext_info")]
        public List<ItemExtInfo> ExtInfo { get; set; }

        /// <summary>
        /// 素材列表（最多3个）
        /// </summary>
        [JsonProperty("material_list")]
        public List<MaterialCreateInfo> MaterialList { get; set; }

        /// <summary>
        /// 商品名称
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// 商品属性列表
        /// </summary>
        [JsonProperty("property_list")]
        public List<ItemPropertyInfo> PropertyList { get; set; }

        /// <summary>
        /// 场景码（具体值请参见产品文档）
        /// </summary>
        [JsonProperty("scene")]
        public string Scene { get; set; }

        /// <summary>
        /// 商品SKU列表（至少1个，最多20个）
        /// </summary>
        [JsonProperty("sku_list")]
        public List<SkuCreateInfo> SkuList { get; set; }

        /// <summary>
        /// 商品所属标准类目ID（具体值请参见产品文档）
        /// </summary>
        [JsonProperty("standard_category_id")]
        public string StandardCategoryId { get; set; }

        /// <summary>
        /// 商品归属主体ID  例：商品归属主体类型为店铺，则商品归属主体ID为店铺ID；归属主体为小程序，则归属主体ID为小程序ID
        /// </summary>
        [JsonProperty("target_id")]
        public string TargetId { get; set; }

        /// <summary>
        /// 商品归属主体类型:  5（店铺）  8（小程序）
        /// </summary>
        [JsonProperty("target_type")]
        public string TargetType { get; set; }

        /// <summary>
        /// 商品类型：STANDARD_GOODS（标品）、NON_STANDARD_GOODS（非标品）
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
