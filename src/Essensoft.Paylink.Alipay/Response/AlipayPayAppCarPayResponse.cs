using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayPayAppCarPayResponse.
    /// </summary>
    public class AlipayPayAppCarPayResponse : AlipayResponse
    {
        /// <summary>
        /// 上下文token
        /// </summary>
        [JsonPropertyName("context_token")]
        public string ContextToken { get; set; }
    }
}
