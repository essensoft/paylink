using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KbdishCommRuleInfo Data Structure.
    /// </summary>
    public class KbdishCommRuleInfo : AlipayObject
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
        /// 创建人
        /// </summary>
        [JsonPropertyName("create_user")]
        public string CreateUser { get; set; }

        /// <summary>
        /// 口碑定制组明细id
        /// </summary>
        [JsonPropertyName("group_detail_id")]
        public string GroupDetailId { get; set; }

        /// <summary>
        /// 商户的id,可不传
        /// </summary>
        [JsonPropertyName("merchant_id")]
        public string MerchantId { get; set; }

        /// <summary>
        /// 规则id,口碑系统生成,  如果是新增操作，设置为空.  如果是修改，可以根据rule_id来修改，也可以根据 biz_id+rule_type+comm_group_id+group_detail_id 来操作
        /// </summary>
        [JsonPropertyName("rule_id")]
        public string RuleId { get; set; }

        /// <summary>
        /// 口碑规则定制类型  DISH_PROPERTY_GROUP：菜品属性组 SKU_MATERIAL_GROUP：sku加料组 DISH_PROPERTY_DETAIL：菜品属性明细 SKU_MATERIAL_DETAIL：sku加料明细 DISH_SPEC_GROUP:菜品规格组 DISH_SPEC_DETAIL:菜品规格组标签
        /// </summary>
        [JsonPropertyName("rule_type")]
        public string RuleType { get; set; }

        /// <summary>
        /// 规则列表
        /// </summary>
        [JsonPropertyName("show_rule_list")]
        public List<KbdishCommRuleShowInfo> ShowRuleList { get; set; }

        /// <summary>
        /// 同步类型: add 新增;update 修改;del 删除
        /// </summary>
        [JsonPropertyName("syn_type")]
        public string SynType { get; set; }

        /// <summary>
        /// 修改人
        /// </summary>
        [JsonPropertyName("update_user")]
        public string UpdateUser { get; set; }
    }
}
