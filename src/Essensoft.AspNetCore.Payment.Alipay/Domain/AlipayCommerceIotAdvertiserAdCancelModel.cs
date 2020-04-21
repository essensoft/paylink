using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayCommerceIotAdvertiserAdCancelModel Data Structure.
    /// </summary>
    public class AlipayCommerceIotAdvertiserAdCancelModel : AlipayObject
    {
        /// <summary>
        /// 投放计划id
        /// </summary>
        [JsonPropertyName("id")]
        public long Id { get; set; }
    }
}
