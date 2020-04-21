using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiItemExtitemBatchqueryModel Data Structure.
    /// </summary>
    public class KoubeiItemExtitemBatchqueryModel : AlipayObject
    {
        /// <summary>
        /// 品牌编码
        /// </summary>
        [JsonPropertyName("brand_code")]
        public string BrandCode { get; set; }

        /// <summary>
        /// 品类编码
        /// </summary>
        [JsonPropertyName("category_code")]
        public string CategoryCode { get; set; }

        /// <summary>
        /// 当前页码。
        /// </summary>
        [JsonPropertyName("page_num")]
        public string PageNum { get; set; }

        /// <summary>
        /// 分页大小。最大50条，超过限制默认50
        /// </summary>
        [JsonPropertyName("page_size")]
        public string PageSize { get; set; }

        /// <summary>
        /// 商品名称（仅支持前缀匹配）
        /// </summary>
        [JsonPropertyName("title")]
        public string Title { get; set; }
    }
}
