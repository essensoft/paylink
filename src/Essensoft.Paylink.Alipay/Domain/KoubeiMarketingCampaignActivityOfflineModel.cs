using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// KoubeiMarketingCampaignActivityOfflineModel Data Structure.
    /// </summary>
    public class KoubeiMarketingCampaignActivityOfflineModel : AlipayObject
    {
        /// <summary>
        /// 活动id。通过 <a href="https://opendocs.alipay.com/apis/api_5/koubei.marketing.campaign.activity.create">koubei.marketing.campaign.activity.create</a>(活动创建接口)获取。
        /// </summary>
        [JsonPropertyName("camp_id")]
        public string CampId { get; set; }

        /// <summary>
        /// 下架活动的扩展信息，不需要设置
        /// </summary>
        [JsonPropertyName("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 操作人id，与operator_type必须配对存在，当不填的时候默认是商户
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
        /// 下架原因
        /// </summary>
        [JsonPropertyName("reason")]
        public string Reason { get; set; }
    }
}
