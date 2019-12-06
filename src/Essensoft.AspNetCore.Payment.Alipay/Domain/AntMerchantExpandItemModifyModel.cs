using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AntMerchantExpandItemModifyModel Data Structure.
    /// </summary>
    public class AntMerchantExpandItemModifyModel : AlipayObject
    {
        /// <summary>
        /// 商品详情地址
        /// </summary>
        [JsonPropertyName("detail_url")]
        public string DetailUrl { get; set; }

        /// <summary>
        /// 商品扩展信息：可以解析成 Map<String, String> 的 json string
        /// </summary>
        [JsonPropertyName("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 外部商品ID（item_id不为空时作为普通更新项，item_id为空时作为更新KEY）
        /// </summary>
        [JsonPropertyName("external_item_id")]
        public string ExternalItemId { get; set; }

        /// <summary>
        /// 前台类目id, null表示未分类
        /// </summary>
        [JsonPropertyName("front_category_id")]
        public string FrontCategoryId { get; set; }

        /// <summary>
        /// 商品id(和external_item_id不能同时为空)
        /// </summary>
        [JsonPropertyName("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// 商品标签列表，null表示不修改标签列表，空list表示清空标签
        /// </summary>
        [JsonPropertyName("label_list")]
        public List<ItemLabelModifyInfo> LabelList { get; set; }

        /// <summary>
        /// 商品主图
        /// </summary>
        [JsonPropertyName("main_pic")]
        public string MainPic { get; set; }

        /// <summary>
        /// 商品名称
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// 更新时间戳（只处理时间戳最大的一次请求）
        /// </summary>
        [JsonPropertyName("op_timestamp")]
        public long OpTimestamp { get; set; }

        /// <summary>
        /// 场景：GAS_CHARGE（加油）
        /// </summary>
        [JsonPropertyName("scene")]
        public string Scene { get; set; }

        /// <summary>
        /// SKU列表（会和商品已存在SKU做差异化比较后做增删改操作）
        /// </summary>
        [JsonPropertyName("sku_list")]
        public List<ItemSkuModifyInfo> SkuList { get; set; }

        /// <summary>
        /// 商品状态：  EFFECT（有效）、 INVALID（无效）
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }
    }
}
