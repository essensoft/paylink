using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// SpuDetail Data Structure.
    /// </summary>
    public class SpuDetail : AlipayObject
    {
        /// <summary>
        /// 商品品牌
        /// </summary>
        [JsonPropertyName("brand")]
        public string Brand { get; set; }

        /// <summary>
        /// 商品类目
        /// </summary>
        [JsonPropertyName("category")]
        public string Category { get; set; }

        /// <summary>
        /// 商品规格
        /// </summary>
        [JsonPropertyName("dimension")]
        public string Dimension { get; set; }

        /// <summary>
        /// 商品图片地址
        /// </summary>
        [JsonPropertyName("icon")]
        public string Icon { get; set; }

        /// <summary>
        /// 商品链接
        /// </summary>
        [JsonPropertyName("link_url")]
        public string LinkUrl { get; set; }

        /// <summary>
        /// 商品ID
        /// </summary>
        [JsonPropertyName("spu_id")]
        public string SpuId { get; set; }

        /// <summary>
        /// 商品名称
        /// </summary>
        [JsonPropertyName("title")]
        public string Title { get; set; }
    }
}
