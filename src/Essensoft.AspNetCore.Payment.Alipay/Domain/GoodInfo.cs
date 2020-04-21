using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// GoodInfo Data Structure.
    /// </summary>
    public class GoodInfo : AlipayObject
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
        /// 设备中该商品的剩余数量
        /// </summary>
        [JsonPropertyName("quantity")]
        public string Quantity { get; set; }

        /// <summary>
        /// 商品重量,单位克
        /// </summary>
        [JsonPropertyName("weight")]
        public string Weight { get; set; }
    }
}
