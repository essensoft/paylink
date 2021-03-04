using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayMarketingCampaignActivityOfflineCreateResponse.
    /// </summary>
    public class AlipayMarketingCampaignActivityOfflineCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 创建成功的活动id
        /// </summary>
        [JsonPropertyName("camp_id")]
        public string CampId { get; set; }

        /// <summary>
        /// 创建成功的券模版id
        /// </summary>
        [JsonPropertyName("prize_id")]
        public string PrizeId { get; set; }
    }
}
