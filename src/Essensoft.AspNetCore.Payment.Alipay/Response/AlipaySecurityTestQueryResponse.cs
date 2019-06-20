using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipaySecurityTestQueryResponse.
    /// </summary>
    public class AlipaySecurityTestQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 23
        /// </summary>
        [JsonProperty("eeea")]
        public string Eeea { get; set; }
    }
}
