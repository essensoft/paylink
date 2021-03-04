using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayUserCertdocUrlQueryResponse.
    /// </summary>
    public class AlipayUserCertdocUrlQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 链接
        /// </summary>
        [JsonPropertyName("url")]
        public string Url { get; set; }
    }
}
