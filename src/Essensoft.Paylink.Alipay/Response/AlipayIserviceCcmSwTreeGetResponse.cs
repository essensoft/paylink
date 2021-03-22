using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayIserviceCcmSwTreeGetResponse.
    /// </summary>
    public class AlipayIserviceCcmSwTreeGetResponse : AlipayResponse
    {
        /// <summary>
        /// 类目树字符串
        /// </summary>
        [JsonPropertyName("tree")]
        public string Tree { get; set; }
    }
}
