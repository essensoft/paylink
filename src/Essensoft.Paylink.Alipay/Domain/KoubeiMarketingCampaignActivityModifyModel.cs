using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
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
        /// 活动id，通过 <a href="https://opendocs.alipay.com/apis/api_5/koubei.marketing.campaign.activity.create">koubei.marketing.campaign.activity.create</a>(活动创建接口)获取。
        /// </summary>
        [JsonPropertyName("camp_id")]
        public string CampId { get; set; }

        /// <summary>
        /// 活动限制信息
        /// </summary>
        [JsonPropertyName("constraint_info")]
        public ConstraintInfo ConstraintInfo { get; set; }

        /// <summary>
        /// 活动详细说明。  注意：本参数不允许修改，必须与  <a href="https://opendocs.alipay.com/apis/api_5/koubei.marketing.campaign.activity.query">koubei.marketing.campaign.activity.query</a>(活动详情查询)接口查询结果保持一致。
        /// </summary>
        [JsonPropertyName("desc")]
        public string Desc { get; set; }

        /// <summary>
        /// 活动结束时间，格式为"yyyy-MM-dd HH:mm:ss"。 注意：活动结束时间只允许延长
        /// </summary>
        [JsonPropertyName("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 活动的扩展信息
        /// </summary>
        [JsonPropertyName("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 活动名称。 注意：本参数不允许修改，必须与  <a href="https://opendocs.alipay.com/apis/api_5/koubei.marketing.campaign.activity.query">koubei.marketing.campaign.activity.query</a>(活动详情查询)接口查询结果保持一致。
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// 操作人id，必须和operator_type配对出现，不填时默认是商户
        /// </summary>
        [JsonPropertyName("operator_id")]
        public string OperatorId { get; set; }

        /// <summary>
        /// 操作人类型，不填默认为 MER（外部商户）。支持枚举值如下： * MER：外部商户。 * MER_OPERATOR：外部商户操作员。 * PROVIDER：外部服务商。 * PROVIDER_STAFF：外部服务商员工。
        /// </summary>
        [JsonPropertyName("operator_type")]
        public string OperatorType { get; set; }

        /// <summary>
        /// 外部批次ID。需保证同一账户下唯一，控制幂等。
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
        /// 活动开始时间，格式为"yyyy-MM-dd HH:mm:ss"。 注意：本参数不允许修改，必须与  <a href="https://opendocs.alipay.com/apis/api_5/koubei.marketing.campaign.activity.query">koubei.marketing.campaign.activity.query</a>(活动详情查询)接口查询结果保持一致。
        /// </summary>
        [JsonPropertyName("start_time")]
        public string StartTime { get; set; }

        /// <summary>
        /// 活动类型。  注意：本参数不允许修改，必须与  <a href="https://opendocs.alipay.com/apis/api_5/koubei.marketing.campaign.activity.query">koubei.marketing.campaign.activity.query</a>(活动详情查询)接口查询结果保持一致。
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
