using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// BrandLevelInfo Data Structure.
    /// </summary>
    public class BrandLevelInfo : AlipayObject
    {
        /// <summary>
        /// 品牌编码
        /// </summary>
        [JsonPropertyName("brand_code")]
        public string BrandCode { get; set; }

        /// <summary>
        /// 当前品牌所属级别
        /// </summary>
        [JsonPropertyName("brand_level")]
        public long BrandLevel { get; set; }

        /// <summary>
        /// 品牌名称
        /// </summary>
        [JsonPropertyName("brand_name")]
        public string BrandName { get; set; }
    }
}
