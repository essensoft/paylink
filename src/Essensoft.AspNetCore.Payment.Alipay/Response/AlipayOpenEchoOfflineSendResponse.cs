using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayOpenEchoOfflineSendResponse.
    /// </summary>
    public class AlipayOpenEchoOfflineSendResponse : AlipayResponse
    {
        /// <summary>
        /// 10000
        /// </summary>
        [JsonProperty("word")]
        public string Word { get; set; }
    }
}
