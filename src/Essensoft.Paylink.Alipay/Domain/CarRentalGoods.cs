using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// CarRentalGoods Data Structure.
    /// </summary>
    public class CarRentalGoods : AlipayObject
    {
        /// <summary>
        /// 商家车辆id
        /// </summary>
        [JsonPropertyName("goods_id")]
        public string GoodsId { get; set; }

        /// <summary>
        /// 商品名称
        /// </summary>
        [JsonPropertyName("goods_name")]
        public string GoodsName { get; set; }

        /// <summary>
        /// 商品数量
        /// </summary>
        [JsonPropertyName("goods_num")]
        public string GoodsNum { get; set; }

        /// <summary>
        /// 商品图片id
        /// </summary>
        [JsonPropertyName("goods_pic_url")]
        public string GoodsPicUrl { get; set; }

        /// <summary>
        /// 商品单价
        /// </summary>
        [JsonPropertyName("goods_price")]
        public string GoodsPrice { get; set; }

        /// <summary>
        /// 商品规格
        /// </summary>
        [JsonPropertyName("goods_specs")]
        public string GoodsSpecs { get; set; }
    }
}
