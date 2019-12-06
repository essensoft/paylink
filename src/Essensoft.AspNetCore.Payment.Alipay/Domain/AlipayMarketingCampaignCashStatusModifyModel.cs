using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayMarketingCampaignCashStatusModifyModel Data Structure.
    /// </summary>
    public class AlipayMarketingCampaignCashStatusModifyModel : AlipayObject
    {
        /// <summary>
        /// 修改后的活动状态, PAUSE或者READY或者CLOSED
        /// </summary>
        [JsonPropertyName("camp_status")]
        public string CampStatus { get; set; }

        /// <summary>
        /// 要修改的现金红包活动号
        /// </summary>
        [JsonPropertyName("crowd_no")]
        public string CrowdNo { get; set; }
    }
}
