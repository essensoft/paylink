using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayCommerceIotAdvertiserAdCreateResponse.
    /// </summary>
    public class AlipayCommerceIotAdvertiserAdCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 投放计划id
        /// </summary>
        [JsonPropertyName("id")]
        public long Id { get; set; }
    }
}
