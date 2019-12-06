using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// GoodsDetail Data Structure.
    /// </summary>
    public class GoodsDetail : AlipayObject
    {
        /// <summary>
        /// 支付宝定义的统一商品编号
        /// </summary>
        [JsonPropertyName("alipay_goods_id")]
        public string AlipayGoodsId { get; set; }

        /// <summary>
        /// 商品描述信息
        /// </summary>
        [JsonPropertyName("body")]
        public string Body { get; set; }

        /// <summary>
        /// 商品类目树，从商品类目根节点到叶子节点的类目id组成，类目id值使用|分割
        /// </summary>
        [JsonPropertyName("categories_tree")]
        public string CategoriesTree { get; set; }

        /// <summary>
        /// 商品类目
        /// </summary>
        [JsonPropertyName("goods_category")]
        public string GoodsCategory { get; set; }

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
