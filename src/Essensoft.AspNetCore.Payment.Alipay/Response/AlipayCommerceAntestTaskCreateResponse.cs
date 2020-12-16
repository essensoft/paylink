using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
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
