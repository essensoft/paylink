using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// SummaryInfo Data Structure.
    /// </summary>
    public class SummaryInfo : AlipayObject
    {
        /// <summary>
        /// 创建渠道
        /// </summary>
        [JsonPropertyName("channel")]
        public string Channel { get; set; }

        /// <summary>
        /// 生活号id
        /// </summary>
        [JsonPropertyName("public_id")]
        public string PublicId { get; set; }

        /// <summary>
        /// 生活号名称
        /// </summary>
        [JsonPropertyName("public_name")]
        public string PublicName { get; set; }

        /// <summary>
        /// 上架：ON_LINE,下架：OFF_LINE
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }
    }
}
