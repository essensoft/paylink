using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayMarketingFacetofaceDecodeUseResponse.
    /// </summary>
    public class AlipayMarketingFacetofaceDecodeUseResponse : AlipayResponse
    {
        /// <summary>
        /// 用户userId
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
