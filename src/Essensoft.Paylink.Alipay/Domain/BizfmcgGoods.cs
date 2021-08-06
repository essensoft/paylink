using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// BizfmcgGoods Data Structure.
    /// </summary>
    public class BizfmcgGoods : AlipayObject
    {
        /// <summary>
        /// 商品编码
        /// </summary>
        [JsonPropertyName("goods_id")]
        public string GoodsId { get; set; }

        /// <summary>
        /// 商品名称
        /// </summary>
        [JsonPropertyName("goods_name")]
        public string GoodsName { get; set; }

        /// <summary>
        /// 商品价格，单位元
        /// </summary>
        [JsonPropertyName("price")]
        public string Price { get; set; }

        /// <summary>
        /// 商品数量
        /// </summary>
        [JsonPropertyName("quantity")]
        public long Quantity { get; set; }
    }
}
