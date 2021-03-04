using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayOpenAppXwbtstabcQueryResponse.
    /// </summary>
    public class AlipayOpenAppXwbtstabcQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 1
        /// </summary>
        [JsonPropertyName("xwbbbdd")]
        public string Xwbbbdd { get; set; }
    }
}
