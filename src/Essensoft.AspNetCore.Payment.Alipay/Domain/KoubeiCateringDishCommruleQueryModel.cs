using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiCateringDishCommruleQueryModel Data Structure.
    /// </summary>
    public class KoubeiCateringDishCommruleQueryModel : AlipayObject
    {
        /// <summary>
        /// 口碑菜品id/口碑skuId/规格的specId,需要和type一一对应
        /// </summary>
        [JsonPropertyName("biz_id")]
        public string BizId { get; set; }

        /// <summary>
        /// 绑定的组id
        /// </summary>
        [JsonPropertyName("comm_group_id")]
        public string CommGroupId { get; set; }

        /// <summary>
        /// 口碑定制组明细id
        /// </summary>
        [JsonPropertyName("group_detail_id")]
        public string GroupDetailId { get; set; }

        /// <summary>
        /// 查询页码，表示第几页；兼顾老版本，批量查询不传时默认为1
        /// </summary>
        [JsonPropertyName("page_no")]
        public string PageNo { get; set; }

        /// <summary>
        /// 分页大小，表示每页查询数量，不超过200；兼容老版本，批量查询不传时默认为200
        /// </summary>
        [JsonPropertyName("page_size")]
        public string PageSize { get; set; }

        /// <summary>
        /// 口碑的定制规则id
        /// </summary>
        [JsonPropertyName("rule_id")]
        public string RuleId { get; set; }

        /// <summary>
        /// 口碑规则定制类型 DISH_PROPERTY_GROUP：菜品属性组 SKU_MATERIAL_GROUP：sku加料组 DISH_PROPERTY_DETAIL：菜品属性明细 SKU_MATERIAL_DETAIL：sku加料明细 DISH_SPEC_GROUP:菜品规格组 DISH_SPEC_DETAIL:菜品规格组标签
        /// </summary>
        [JsonPropertyName("rule_type")]
        public string RuleType { get; set; }
    }
}
