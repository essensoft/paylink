using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayCommerceAntestTaskCancelModel Data Structure.
    /// </summary>
    public class AlipayCommerceAntestTaskCancelModel : AlipayObject
    {
        /// <summary>
        /// 任务id
        /// </summary>
        [JsonPropertyName("batch_id")]
        public long BatchId { get; set; }
    }
}
