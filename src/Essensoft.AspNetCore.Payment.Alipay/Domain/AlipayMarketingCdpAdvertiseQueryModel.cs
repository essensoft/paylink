using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayMarketingCdpAdvertiseQueryModel Data Structure.
    /// </summary>
    public class AlipayMarketingCdpAdvertiseQueryModel : AlipayObject
    {
        /// <summary>
        /// 广告Id，唯一标识一条广告
        /// </summary>
        [JsonPropertyName("ad_id")]
        public string AdId { get; set; }
    }
}
