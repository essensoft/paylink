using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayOpenServicemarketYcstestQueryResponse.
    /// </summary>
    public class AlipayOpenServicemarketYcstestQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 111
        /// </summary>
        [JsonPropertyName("out_1")]
        public string Out1 { get; set; }

        /// <summary>
        /// 222
        /// </summary>
        [JsonPropertyName("out_2")]
        public string Out2 { get; set; }
    }
}
