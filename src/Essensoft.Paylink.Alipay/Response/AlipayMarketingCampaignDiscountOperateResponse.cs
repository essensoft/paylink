using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayMarketingCampaignDiscountOperateResponse.
    /// </summary>
    public class AlipayMarketingCampaignDiscountOperateResponse : AlipayResponse
    {
        /// <summary>
        /// 123
        /// </summary>
        [JsonPropertyName("camp_id")]
        public string CampId { get; set; }
    }
}
