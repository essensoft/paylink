using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// BrandResult Data Structure.
    /// </summary>
    public class BrandResult : AlipayObject
    {
        /// <summary>
        /// 已有的品牌的id
        /// </summary>
        [JsonPropertyName("brand_id")]
        public string BrandId { get; set; }

        /// <summary>
        /// 已有品牌的名称
        /// </summary>
        [JsonPropertyName("brand_name")]
        public string BrandName { get; set; }
    }
}
