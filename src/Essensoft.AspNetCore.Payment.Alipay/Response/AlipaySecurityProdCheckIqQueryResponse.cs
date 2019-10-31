using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipaySecurityProdCheckIqQueryResponse.
    /// </summary>
    public class AlipaySecurityProdCheckIqQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 1
        /// </summary>
        [JsonProperty("a")]
        public string A { get; set; }
    }
}
