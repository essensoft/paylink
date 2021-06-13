using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// VoucherSummary Data Structure.
    /// </summary>
    public class VoucherSummary : AlipayObject
    {
        /// <summary>
        /// 券已发放数量
        /// </summary>
        [JsonPropertyName("publish_count")]
        public long PublishCount { get; set; }

        /// <summary>
        /// 券已核销数量
        /// </summary>
        [JsonPropertyName("used_count")]
        public long UsedCount { get; set; }
    }
}
