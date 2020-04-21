using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KbdishGroupDetailInfo Data Structure.
    /// </summary>
    public class KbdishGroupDetailInfo : AlipayObject
    {
        /// <summary>
        /// 组下明细的加价单价 例如加2元 加3元
        /// </summary>
        [JsonPropertyName("add_price")]
        public string AddPrice { get; set; }

        /// <summary>
        /// 明细菜品在套餐里的个数,
        /// </summary>
        [JsonPropertyName("detail_count")]
        public string DetailCount { get; set; }

        /// <summary>
        /// 菜品id
        /// </summary>
        [JsonPropertyName("detail_dish_id")]
        public string DetailDishId { get; set; }

        /// <summary>
        /// 组下面的菜品是否默认 Y/N，该字段目前废弃
        /// </summary>
        [JsonPropertyName("detail_is_default")]
        public string DetailIsDefault { get; set; }

        /// <summary>
        /// 分组下包含的明细菜品的sku_id
        /// </summary>
        [JsonPropertyName("detail_sku_id")]
        public string DetailSkuId { get; set; }

        /// <summary>
        /// 排序字典
        /// </summary>
        [JsonPropertyName("detail_sort")]
        public string DetailSort { get; set; }

        /// <summary>
        /// 组id
        /// </summary>
        [JsonPropertyName("group_id")]
        public string GroupId { get; set; }
    }
}
