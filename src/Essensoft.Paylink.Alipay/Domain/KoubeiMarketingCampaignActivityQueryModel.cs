using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// KoubeiMarketingCampaignActivityQueryModel Data Structure.
    /// </summary>
    public class KoubeiMarketingCampaignActivityQueryModel : AlipayObject
    {
        /// <summary>
        /// 活动id。通过 <a href="https://opendocs.alipay.com/apis/api_5/koubei.marketing.campaign.activity.create">koubei.marketing.campaign.activity.create</a>(活动创建接口)获取。
        /// </summary>
        [JsonPropertyName("camp_id")]
        public string CampId { get; set; }

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
    }
}
