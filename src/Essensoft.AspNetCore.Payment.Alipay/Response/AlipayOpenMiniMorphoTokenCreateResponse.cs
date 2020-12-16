using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayOpenMiniMorphoTokenCreateResponse.
    /// </summary>
    public class AlipayOpenMiniMorphoTokenCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 闪蝶 SDK Token
        /// </summary>
        [JsonPropertyName("url")]
        public string Url { get; set; }
    }
}
