using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// KoubeiMarketingCampaignActivityModifyResponse.
    /// </summary>
    public class KoubeiMarketingCampaignActivityModifyResponse : AlipayResponse
    {
        /// <summary>
        /// 活动子状态，如审核中
        /// </summary>
        [JsonPropertyName("audit_status")]
        public string AuditStatus { get; set; }

        /// <summary>
        /// 活动状态
        /// </summary>
        [JsonPropertyName("camp_status")]
        public string CampStatus { get; set; }
    }
}
