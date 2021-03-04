using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayCommerceAntestTaskCreateResponse.
    /// </summary>
    public class AlipayCommerceAntestTaskCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 任务id
        /// </summary>
        [JsonPropertyName("batch_id")]
        public long BatchId { get; set; }
    }
}
