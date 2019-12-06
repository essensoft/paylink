using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipaySecurityProdXwbtestabcAbcQueryResponse.
    /// </summary>
    public class AlipaySecurityProdXwbtestabcAbcQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 1
        /// </summary>
        [JsonPropertyName("xwb")]
        public string Xwb { get; set; }
    }
}
