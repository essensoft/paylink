using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayOpenAppBoyiBoyiCreateResponse.
    /// </summary>
    public class AlipayOpenAppBoyiBoyiCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 1
        /// </summary>
        [JsonPropertyName("esd")]
        public string Esd { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [JsonPropertyName("output")]
        public string Output { get; set; }
    }
}
