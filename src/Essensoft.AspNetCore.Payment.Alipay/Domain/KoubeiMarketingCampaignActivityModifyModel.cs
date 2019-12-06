using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiMarketingCampaignActivityModifyModel Data Structure.
    /// </summary>
    public class KoubeiMarketingCampaignActivityModifyModel : AlipayObject
    {
        /// <summary>
        /// 是否自动续期活动，仅当活动下券的有效期均为相对有效期时才能设置成Y
        /// </summary>
        [JsonPropertyName("auto_delay_flag")]
        public string AutoDelayFlag { get; set; }

        /// <summary>
        /// 活动预算
        /// </summary>
        [JsonPropertyName("budget_info")]
        public BudgetInfo BudgetInfo { get; set; }

        /// <summary>
        /// 活动id
        /// </summary>
        [JsonPropertyName("camp_id")]
        public string CampId { get; set; }

        /// <summary>
        /// 活动限制信息
        /// </summary>
        [JsonPropertyName("constraint_info")]
        public ConstraintInfo ConstraintInfo { get; set; }

        /// <summary>
        /// 活动详细说明  不允许修改，必须与活动详情查询的结果保持一致
        /// </summary>
        [JsonPropertyName("desc")]
        public string Desc { get; set; }

        /// <summary>
        /// 活动结束时间  活动结束时间只允许延长
        /// </summary>
        [JsonPropertyName("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 活动的扩展信息
        /// </summary>
        [JsonPropertyName("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 活动名称  不允许修改，必须与活动详情查询的结果保持一致
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// 操作人id，必须和operator_type配对出现，不填时默认是商户
        /// </summary>
        [JsonPropertyName("operator_id")]
        public string OperatorId { get; set; }

        /// <summary>
        /// 操作人类型,有以下值可填：MER（外部商户），MER_OPERATOR（外部商户操作员），PROVIDER（外部服务商），PROVIDER_STAFF（外部服务商员工），默认不需要填这个字段，默认为MER
        /// </summary>
        [JsonPropertyName("operator_type")]
        public string OperatorType { get; set; }

        /// <summary>
        /// 外部批次ID，用户指定,每次请求保持唯一
        /// </summary>
        [JsonPropertyName("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 营销工具集
        /// </summary>
        [JsonPropertyName("promo_tools")]
        public List<PromoTool> PromoTools { get; set; }

        /// <summary>
        /// 投放渠道集，当活动类型为DIRECT_SEND或者REAL_TIME_SEND时必填，为CONSUME_SEND时必须为空
        /// </summary>
        [JsonPropertyName("publish_channels")]
        public List<PublishChannel> PublishChannels { get; set; }

        /// <summary>
        /// 招商工具
        /// </summary>
        [JsonPropertyName("recruit_tool")]
        public RecruitTool RecruitTool { get; set; }

        /// <summary>
        /// 活动开始时间  不允许修改，必须与活动详情查询的结果保持一致
        /// </summary>
        [JsonPropertyName("start_time")]
        public string StartTime { get; set; }

        /// <summary>
        /// 活动类型  不允许修改，必须与活动详情查询的结果保持一致
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
