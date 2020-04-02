using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// GoodsDetailInfo Data Structure.
    /// </summary>
    public class GoodsDetailInfo : AlipayObject
    {
        /// <summary>
        /// 商品的编号
        /// </summary>
        [JsonPropertyName("goods_id")]
        public string GoodsId { get; set; }

        /// <summary>
        /// 商品名称
        /// </summary>
        [JsonPropertyName("goods_name")]
        public string GoodsName { get; set; }

        /// <summary>
        /// 商品单位
        /// </summary>
        [JsonPropertyName("goods_unit")]
        public string GoodsUnit { get; set; }

        /// <summary>
        /// 商品数量
        /// </summary>
        [JsonPropertyName("quantity")]
        public string Quantity { get; set; }

        /// <summary>
        /// 商品单价，单位元
        /// </summary>
        [JsonPropertyName("unit_price")]
        public string UnitPrice { get; set; }
    }
}
