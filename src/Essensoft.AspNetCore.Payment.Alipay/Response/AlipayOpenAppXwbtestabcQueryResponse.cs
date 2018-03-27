using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayOpenAppXwbtestabcQueryResponse.
    /// </summary>
    public class AlipayOpenAppXwbtestabcQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 1
        /// </summary>
        [JsonProperty("xw")]
        public string Xw { get; set; }
    }
}
