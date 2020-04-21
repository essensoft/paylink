using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KbGoodsInfo Data Structure.
    /// </summary>
    public class KbGoodsInfo : AlipayObject
    {
        /// <summary>
        /// 商品类目
        /// </summary>
        [JsonPropertyName("goods_category")]
        public string GoodsCategory { get; set; }

        /// <summary>
        /// 商品ID
        /// </summary>
        [JsonPropertyName("goods_id")]
        public string GoodsId { get; set; }

        /// <summary>
        /// 商品名称
        /// </summary>
        [JsonPropertyName("goods_name")]
        public string GoodsName { get; set; }

        /// <summary>
        /// 价格
        /// </summary>
        [JsonPropertyName("price")]
        public string Price { get; set; }

        /// <summary>
        /// 数量
        /// </summary>
        [JsonPropertyName("quantity")]
        public string Quantity { get; set; }
    }
}
