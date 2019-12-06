using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// MEquityDisplayInfo Data Structure.
    /// </summary>
    public class MEquityDisplayInfo : AlipayObject
    {
        /// <summary>
        /// 品牌名
        /// </summary>
        [JsonPropertyName("brand_name")]
        public string BrandName { get; set; }

        /// <summary>
        /// 权益LOGO
        /// </summary>
        [JsonPropertyName("logo")]
        public string Logo { get; set; }

        /// <summary>
        /// 权益名称
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}
