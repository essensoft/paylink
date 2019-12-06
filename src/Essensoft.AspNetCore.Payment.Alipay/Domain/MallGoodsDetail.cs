using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// MallGoodsDetail Data Structure.
    /// </summary>
    public class MallGoodsDetail : AlipayObject
    {
        /// <summary>
        /// 商品描述信息
        /// </summary>
        [JsonPropertyName("body")]
        public string Body { get; set; }

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
        /// 商品原价
        /// </summary>
        [JsonPropertyName("org_price")]
        public string OrgPrice { get; set; }

        /// <summary>
        /// 商品单价，单位为元
        /// </summary>
        [JsonPropertyName("price")]
        public string Price { get; set; }

        /// <summary>
        /// 商品数量
        /// </summary>
        [JsonPropertyName("quantity")]
        public long Quantity { get; set; }

        /// <summary>
        /// 商品的展示地址
        /// </summary>
        [JsonPropertyName("show_url")]
        public string ShowUrl { get; set; }
    }
}
