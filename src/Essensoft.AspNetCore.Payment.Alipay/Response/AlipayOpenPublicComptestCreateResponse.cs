using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayOpenPublicComptestCreateResponse.
    /// </summary>
    public class AlipayOpenPublicComptestCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 1
        /// </summary>
        [JsonProperty("result")]
        public string Result { get; set; }

        /// <summary>
        /// 2
        /// </summary>
        [JsonProperty("resulttwo")]
        public string Resulttwo { get; set; }
    }
}
