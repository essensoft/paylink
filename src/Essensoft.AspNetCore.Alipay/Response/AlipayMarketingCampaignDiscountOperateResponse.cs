using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Alipay.Response
{
    /// <summary>
    /// AlipayMarketingCampaignDiscountOperateResponse.
    /// </summary>
    public class AlipayMarketingCampaignDiscountOperateResponse : AlipayResponse
    {
        /// <summary>
        /// 123
        /// </summary>
        [JsonProperty("camp_id")]
        public string CampId { get; set; }
    }
}
