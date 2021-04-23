using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// ProductGroup Data Structure.
    /// </summary>
    public class ProductGroup : AlipayObject
    {
        /// <summary>
        /// 数目
        /// </summary>
        [JsonPropertyName("count")]
        public string Count { get; set; }

        /// <summary>
        /// 产品对象
        /// </summary>
        [JsonPropertyName("product")]
        public ProductInfo Product { get; set; }

        /// <summary>
        /// 产品总价(单位：元)
        /// </summary>
        [JsonPropertyName("total_price")]
        public string TotalPrice { get; set; }
    }
}
