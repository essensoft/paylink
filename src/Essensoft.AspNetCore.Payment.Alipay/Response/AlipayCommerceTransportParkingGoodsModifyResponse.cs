using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayCommerceTransportParkingGoodsModifyResponse.
    /// </summary>
    public class AlipayCommerceTransportParkingGoodsModifyResponse : AlipayResponse
    {
        /// <summary>
        /// 支付宝商品唯一ID
        /// </summary>
        [JsonPropertyName("goods_id")]
        public string GoodsId { get; set; }

        /// <summary>
        /// isv内部产生商品ID(goods_id和out_id不能同时为空)
        /// </summary>
        [JsonPropertyName("out_id")]
        public string OutId { get; set; }
    }
}
