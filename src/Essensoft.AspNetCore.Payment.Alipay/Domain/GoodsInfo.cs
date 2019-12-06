using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// GoodsInfo Data Structure.
    /// </summary>
    public class GoodsInfo : AlipayObject
    {
        /// <summary>
        /// 商品类目
        /// </summary>
        [JsonPropertyName("goods_category")]
        public string GoodsCategory { get; set; }

        /// <summary>
        /// 商户自定义商品外部编号
        /// </summary>
        [JsonPropertyName("goods_id")]
        public string GoodsId { get; set; }

        /// <summary>
        /// 商户自定义商品名称
        /// </summary>
        [JsonPropertyName("goods_name")]
        public string GoodsName { get; set; }

        /// <summary>
        /// 商品单价，单位元,精确到小数点后两位，取值范围[0.01,100000000]
        /// </summary>
        [JsonPropertyName("price")]
        public string Price { get; set; }

        /// <summary>
        /// 商品数量,支持小数，但是小数位不能超过两位
        /// </summary>
        [JsonPropertyName("quantity")]
        public string Quantity { get; set; }
    }
}
