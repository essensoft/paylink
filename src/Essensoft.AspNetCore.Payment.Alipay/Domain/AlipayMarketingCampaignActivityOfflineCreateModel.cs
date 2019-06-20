using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayMarketingCampaignActivityOfflineCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMarketingCampaignActivityOfflineCreateModel : AlipayObject
    {
        /// <summary>
        /// 预算信息
        /// </summary>
        [JsonProperty("budget")]
        public OpenPromoBudget Budget { get; set; }

        /// <summary>
        /// 活动信息
        /// </summary>
        [JsonProperty("camp")]
        public OpenPromoCamp Camp { get; set; }

        /// <summary>
        /// 活动创建单号
        /// </summary>
        [JsonProperty("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 奖品信息
        /// </summary>
        [JsonProperty("prize")]
        public OpenPromoPrize Prize { get; set; }
    }
}
