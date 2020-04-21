using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// LabelContext Data Structure.
    /// </summary>
    public class LabelContext : AlipayObject
    {
        /// <summary>
        /// 标签组发圈人的单个过滤器信息
        /// </summary>
        [JsonPropertyName("a")]
        public LabelFilter A { get; set; }
    }
}
