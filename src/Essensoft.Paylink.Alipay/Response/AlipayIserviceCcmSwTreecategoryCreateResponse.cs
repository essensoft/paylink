using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayIserviceCcmSwTreecategoryCreateResponse.
    /// </summary>
    public class AlipayIserviceCcmSwTreecategoryCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 节点ID
        /// </summary>
        [JsonPropertyName("id")]
        public long Id { get; set; }
    }
}
