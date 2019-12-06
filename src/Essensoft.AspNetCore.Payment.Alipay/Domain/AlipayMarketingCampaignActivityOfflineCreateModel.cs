using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayMarketingCampaignActivityOfflineCreateModel Data Structure.
    /// </summary>
    public class AlipayMarketingCampaignActivityOfflineCreateModel : AlipayObject
    {
        /// <summary>
        /// 预算信息
        /// </summary>
        [JsonPropertyName("budget")]
        public OpenPromoBudget Budget { get; set; }

        /// <summary>
        /// 活动信息
        /// </summary>
        [JsonPropertyName("camp")]
        public OpenPromoCamp Camp { get; set; }

        /// <summary>
        /// 活动创建单号
        /// </summary>
        [JsonPropertyName("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 奖品信息
        /// </summary>
        [JsonPropertyName("prize")]
        public OpenPromoPrize Prize { get; set; }
    }
}
