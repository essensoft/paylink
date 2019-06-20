using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// PosDishGroupDetailModel Data Structure.
    /// </summary>
    [Serializable]
    public class PosDishGroupDetailModel : AlipayObject
    {
        /// <summary>
        /// 详情菜的加价
        /// </summary>
        [JsonProperty("add_price")]
        public string AddPrice { get; set; }

        /// <summary>
        /// 详情菜可以点的份数
        /// </summary>
        [JsonProperty("detail_count")]
        public long DetailCount { get; set; }

        /// <summary>
        /// 详情菜的菜品id
        /// </summary>
        [JsonProperty("detail_dish_id")]
        public string DetailDishId { get; set; }

        /// <summary>
        /// 组合菜的名字，查询的返回值
        /// </summary>
        [JsonProperty("detail_dish_name")]
        public string DetailDishName { get; set; }

        /// <summary>
        /// 是否是默认的项目组详情
        /// </summary>
        [JsonProperty("detail_is_default")]
        public string DetailIsDefault { get; set; }

        /// <summary>
        /// 详情菜sku的id
        /// </summary>
        [JsonProperty("detail_sku_id")]
        public string DetailSkuId { get; set; }

        /// <summary>
        /// 选中的菜品的规格中文名
        /// </summary>
        [JsonProperty("detail_sku_spec_name")]
        public string DetailSkuSpecName { get; set; }

        /// <summary>
        /// 菜品的单位
        /// </summary>
        [JsonProperty("detail_sku_unit_name")]
        public string DetailSkuUnitName { get; set; }

        /// <summary>
        /// 详情菜的排序
        /// </summary>
        [JsonProperty("detail_sort")]
        public long DetailSort { get; set; }

        /// <summary>
        /// 组合菜的ID，这个只是查询的返回值，一般不用传
        /// </summary>
        [JsonProperty("group_id")]
        public string GroupId { get; set; }
    }
}
