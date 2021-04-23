using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// Goods Data Structure.
    /// </summary>
    public class Goods : AlipayObject
    {
        /// <summary>
        /// 商品id
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
        /// 商品图片（图片上传返回id）
        /// </summary>
        [JsonPropertyName("goods_pic_url")]
        public string GoodsPicUrl { get; set; }

        /// <summary>
        /// 商品单价，单位为元，精确到小数点后两位，取值范围为 [0.01,100000000]
        /// </summary>
        [JsonPropertyName("goods_price")]
        public string GoodsPrice { get; set; }

        /// <summary>
        /// 商品规格份、件、斤、kg，默认为份
        /// </summary>
        [JsonPropertyName("goods_specs")]
        public string GoodsSpecs { get; set; }
    }
}
