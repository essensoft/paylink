using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayIserviceCcmSwLibraryCreateResponse.
    /// </summary>
    public class AlipayIserviceCcmSwLibraryCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 知识库Id
        /// </summary>
        [JsonPropertyName("id")]
        public long Id { get; set; }
    }
}
