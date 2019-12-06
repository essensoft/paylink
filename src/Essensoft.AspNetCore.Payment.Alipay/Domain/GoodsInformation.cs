using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// GoodsInformation Data Structure.
    /// </summary>
    public class GoodsInformation : AlipayObject
    {
        /// <summary>
        /// 购买的商品个数
        /// </summary>
        [JsonPropertyName("quantity")]
        public long Quantity { get; set; }

        /// <summary>
        /// 基于alipay商品库的skuId
        /// </summary>
        [JsonPropertyName("sku_id")]
        public string SkuId { get; set; }
    }
}
