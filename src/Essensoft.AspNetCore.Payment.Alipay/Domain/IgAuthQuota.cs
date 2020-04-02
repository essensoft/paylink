using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// IgAuthQuota Data Structure.
    /// </summary>
    public class IgAuthQuota : AlipayObject
    {
        /// <summary>
        /// 份额数量
        /// </summary>
        [JsonPropertyName("quota_count")]
        public long QuotaCount { get; set; }

        /// <summary>
        /// 周期类型
        /// </summary>
        [JsonPropertyName("range_type")]
        public string RangeType { get; set; }
    }
}
