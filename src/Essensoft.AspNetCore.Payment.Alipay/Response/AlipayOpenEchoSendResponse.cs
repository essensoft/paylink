using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayOpenEchoSendResponse.
    /// </summary>
    public class AlipayOpenEchoSendResponse : AlipayResponse
    {
        /// <summary>
        /// DDDD
        /// </summary>
        [JsonPropertyName("obj")]
        public MyObjectDdd Obj { get; set; }

        /// <summary>
        /// hello world
        /// </summary>
        [JsonPropertyName("out_a")]
        public string OutA { get; set; }

        /// <summary>
        /// Number
        /// </summary>
        [JsonPropertyName("out_b")]
        public long OutB { get; set; }

        /// <summary>
        /// Price
        /// </summary>
        [JsonPropertyName("out_c")]
        public string OutC { get; set; }

        /// <summary>
        /// xxx
        /// </summary>
        [JsonPropertyName("out_d")]
        public string OutD { get; set; }

        /// <summary>
        /// hello world
        /// </summary>
        [JsonPropertyName("word")]
        public string Word { get; set; }
    }
}
