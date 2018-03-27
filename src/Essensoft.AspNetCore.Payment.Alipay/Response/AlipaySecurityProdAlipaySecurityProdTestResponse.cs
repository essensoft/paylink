using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipaySecurityProdAlipaySecurityProdTestResponse.
    /// </summary>
    public class AlipaySecurityProdAlipaySecurityProdTestResponse : AlipayResponse
    {
        /// <summary>
        /// ddd
        /// </summary>
        [JsonProperty("admin")]
        public string Admin { get; set; }
    }
}
