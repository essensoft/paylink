using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// BkPosGoodsInfo Data Structure.
    /// </summary>
    public class BkPosGoodsInfo : AlipayObject
    {
        /// <summary>
        /// 商品名称
        /// </summary>
        [JsonPropertyName("goods_name")]
        public string GoodsName { get; set; }

        /// <summary>
        /// 商品金额
        /// </summary>
        [JsonPropertyName("goods_price")]
        public string GoodsPrice { get; set; }
    }
}
