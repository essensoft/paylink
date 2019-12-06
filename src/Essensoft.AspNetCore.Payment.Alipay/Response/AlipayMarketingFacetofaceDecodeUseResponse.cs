using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
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
