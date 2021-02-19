using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayMarketingIotMerchantplanCreateormodifyResponse.
    /// </summary>
    public class AlipayMarketingIotMerchantplanCreateormodifyResponse : AlipayResponse
    {
        /// <summary>
        /// 商家活动ID
        /// </summary>
        [JsonPropertyName("merchant_plan_id")]
        public string MerchantPlanId { get; set; }
    }
}
