using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AntMerchantExpandItemOpenCreateModel Data Structure.
    /// </summary>
    public class AntMerchantExpandItemOpenCreateModel : AlipayObject
    {
        /// <summary>
        /// 商品描述
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        /// 商品扩展信息（具体KEY请参见产品文档）。 小程序订单中心场景参见 https://opendocs.alipay.com/mini/00u9ga
        /// </summary>
        [JsonPropertyName("ext_info")]
        public List<ItemExtInfo> ExtInfo { get; set; }

        /// <summary>
        /// 素材列表（最多3个），素材内容为素材key（素材key获取方式参照：https://opendocs.alipay.com/apis/api_4/alipay.merchant.item.file.upload）
        /// </summary>
        [JsonPropertyName("material_list")]
        public List<MaterialCreateInfo> MaterialList { get; set; }

        /// <summary>
        /// 商品名称
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// 商品属性列表
        /// </summary>
        [JsonPropertyName("property_list")]
        public List<ItemPropertyInfo> PropertyList { get; set; }

        /// <summary>
        /// 业务场景码。 小程序订单中心场景固定为 APP_ORDER。
        /// </summary>
        [JsonPropertyName("scene")]
        public string Scene { get; set; }

        /// <summary>
        /// 商品SKU列表（至少1个，最多20个）
        /// </summary>
        [JsonPropertyName("sku_list")]
        public List<SkuCreateInfo> SkuList { get; set; }

        /// <summary>
        /// 商品所属标准类目ID，当 type 为STANDARD_GOODS（标品）时必填。  请填入 https://opendocs.alipay.com/mini/011lxt  小程序商品类目表中三级类目ID。
        /// </summary>
        [JsonPropertyName("standard_category_id")]
        public string StandardCategoryId { get; set; }

        /// <summary>
        /// 商品归属主体ID 例：商品归属主体类型target_type为店铺，则商品归属主体ID为店铺ID（支付宝侧店铺ID）；归属主体类型target_type为小程序，则归属主体ID为小程序ID
        /// </summary>
        [JsonPropertyName("target_id")]
        public string TargetId { get; set; }

        /// <summary>
        /// 商品归属主体类型。枚举如下： 5：店铺。 8：小程序。
        /// </summary>
        [JsonPropertyName("target_type")]
        public string TargetType { get; set; }

        /// <summary>
        /// 商品类型。枚举支持： STANDARD_GOODS：标品，一般是具有明确、标准规格、型号、参数的商品，如：手机、数码产品、大多数的家电 。 NON_STANDARD_GOODS：非标品等，，则是在这些方面没有统一的行业标准和参数规格的商品，如：服装、鞋袜等。
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
