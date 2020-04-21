using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ExtBrand Data Structure.
    /// </summary>
    public class ExtBrand : AlipayObject
    {
        /// <summary>
        /// 品牌编码
        /// </summary>
        [JsonPropertyName("brand_code")]
        public string BrandCode { get; set; }

        /// <summary>
        /// 品牌名称
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}
