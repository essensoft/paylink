using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Alipay.Response
{
    /// <summary>
    /// AlipayOpenAppPackagetestResponse.
    /// </summary>
    public class AlipayOpenAppPackagetestResponse : AlipayResponse
    {
        /// <summary>
        /// testtest
        /// </summary>
        [JsonProperty("testtesttesttest")]
        public string Testtesttesttest { get; set; }
    }
}
