using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// SkuModifyInfo Data Structure.
    /// </summary>
    public class SkuModifyInfo : AlipayObject
    {
        /// <summary>
        /// 库存
        /// </summary>
        [JsonPropertyName("inventory")]
        public long Inventory { get; set; }

        /// <summary>
        /// SKU素材列表（会和SKU已存在素材做差异化比较后做增删改操作）
        /// </summary>
        [JsonPropertyName("material_list")]
        public List<MaterialModifyInfo> MaterialList { get; set; }

        /// <summary>
        /// 标价，单位分
        /// </summary>
        [JsonPropertyName("original_price")]
        public long OriginalPrice { get; set; }

        /// <summary>
        /// 售价，单位分
        /// </summary>
        [JsonPropertyName("price")]
        public long Price { get; set; }

        /// <summary>
        /// SKU属性列表（覆盖SKU已存在属性）
        /// </summary>
        [JsonPropertyName("property_list")]
        public List<ItemSkuPropertyInfo> PropertyList { get; set; }

        /// <summary>
        /// SKU ID（传空表示新增对应SKU）
        /// </summary>
        [JsonPropertyName("sku_id")]
        public string SkuId { get; set; }
    }
}
