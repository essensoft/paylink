using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayCommerceTransportParkingGoodsCreateResponse.
    /// </summary>
    public class AlipayCommerceTransportParkingGoodsCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 支付宝商品ID列表
        /// </summary>
        [JsonPropertyName("goods_id")]
        public string GoodsId { get; set; }

        /// <summary>
        /// isv内部产生商品ID
        /// </summary>
        [JsonPropertyName("out_id")]
        public string OutId { get; set; }
    }
}
