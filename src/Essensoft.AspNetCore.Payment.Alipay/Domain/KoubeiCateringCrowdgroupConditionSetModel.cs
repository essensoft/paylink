using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiCateringCrowdgroupConditionSetModel Data Structure.
    /// </summary>
    public class KoubeiCateringCrowdgroupConditionSetModel : AlipayObject
    {
        /// <summary>
        /// 人群规则（创建，更新的时候必填）
        /// </summary>
        [JsonPropertyName("condition_model_list")]
        public List<ConditionItemPattern> ConditionModelList { get; set; }

        /// <summary>
        /// isv创建的用户分组id
        /// </summary>
        [JsonPropertyName("crowd_group_id")]
        public string CrowdGroupId { get; set; }

        /// <summary>
        /// 针对用户分组的描述(创建和更新时必填)
        /// </summary>
        [JsonPropertyName("describe")]
        public string Describe { get; set; }

        /// <summary>
        /// 智慧餐厅用户规则操作创建，删除，查询，更新枚举(CREATE("CREATE", "创建"),DELETE("DELETE", "删除"),RETRIEVE("RETRIEVE", "查询"), UPDATE("UPDATE", "修改"))
        /// </summary>
        [JsonPropertyName("operation")]
        public string Operation { get; set; }

        /// <summary>
        /// 创建规则人的id号
        /// </summary>
        [JsonPropertyName("operator_id")]
        public string OperatorId { get; set; }

        /// <summary>
        /// 智慧餐厅操作人类型，包括("MER", "外部商户")，("MER_OPERATOR", "外部操作员")，("PROVIDER", "外部服务商")，("PROVIDER_STAFF", "外部服务商员工")；不传时默认是MER
        /// </summary>
        [JsonPropertyName("operator_type")]
        public string OperatorType { get; set; }

        /// <summary>
        /// 门店id
        /// </summary>
        [JsonPropertyName("shop_id")]
        public string ShopId { get; set; }
    }
}
