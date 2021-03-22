using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayMarketingIotMerchantplanCancelModel Data Structure.
    /// </summary>
    public class AlipayMarketingIotMerchantplanCancelModel : AlipayObject
    {
        /// <summary>
        /// 商家活动ID
        /// </summary>
        [JsonPropertyName("merchant_plan_id")]
        public string MerchantPlanId { get; set; }
    }
}
