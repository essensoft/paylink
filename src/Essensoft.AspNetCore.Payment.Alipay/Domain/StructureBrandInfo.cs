using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// StructureBrandInfo Data Structure.
    /// </summary>
    public class StructureBrandInfo : AlipayObject
    {
        /// <summary>
        /// 品牌英文名
        /// </summary>
        [JsonPropertyName("brand_en_name")]
        public string BrandEnName { get; set; }

        /// <summary>
        /// 品牌英文名
        /// </summary>
        [JsonPropertyName("brand_logo")]
        public string BrandLogo { get; set; }

        /// <summary>
        /// 品牌名
        /// </summary>
        [JsonPropertyName("brand_name")]
        public string BrandName { get; set; }
    }
}
