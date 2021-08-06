using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// SearchBrandboxQueryCatalogRequest Data Structure.
    /// </summary>
    public class SearchBrandboxQueryCatalogRequest : AlipayObject
    {
        /// <summary>
        /// 品牌id
        /// </summary>
        [JsonPropertyName("brand_id")]
        public string BrandId { get; set; }
    }
}
