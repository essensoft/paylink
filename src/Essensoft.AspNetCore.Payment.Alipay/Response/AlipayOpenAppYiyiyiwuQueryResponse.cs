using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayOpenAppYiyiyiwuQueryResponse.
    /// </summary>
    public class AlipayOpenAppYiyiyiwuQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 12
        /// </summary>
        [JsonProperty("chucan")]
        public string Chucan { get; set; }
    }
}
