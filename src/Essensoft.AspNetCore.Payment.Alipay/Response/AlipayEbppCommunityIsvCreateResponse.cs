using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayEbppCommunityIsvCreateResponse.
    /// </summary>
    public class AlipayEbppCommunityIsvCreateResponse : AlipayResponse
    {
        /// <summary>
        /// ISV短名
        /// </summary>
        [JsonPropertyName("isv_short_name")]
        public string IsvShortName { get; set; }
    }
}
