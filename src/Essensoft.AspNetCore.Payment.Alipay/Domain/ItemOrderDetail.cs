using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ItemOrderDetail Data Structure.
    /// </summary>
    public class ItemOrderDetail : AlipayObject
    {
        /// <summary>
        /// 商品原价，单位元，精确到小数点后两位
        /// </summary>
        [JsonPropertyName("original_price")]
        public string OriginalPrice { get; set; }

        /// <summary>
        /// 商品现价，即商品售价，单位为元，精确到小数点后两位
        /// </summary>
        [JsonPropertyName("price")]
        public string Price { get; set; }

        /// <summary>
        /// 购买商品数量
        /// </summary>
        [JsonPropertyName("quantity")]
        public long Quantity { get; set; }

        /// <summary>
        /// 商品skuId
        /// </summary>
        [JsonPropertyName("sku_id")]
        public string SkuId { get; set; }
    }
}
