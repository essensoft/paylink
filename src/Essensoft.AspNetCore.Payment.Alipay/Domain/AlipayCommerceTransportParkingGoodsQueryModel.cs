using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayCommerceTransportParkingGoodsQueryModel Data Structure.
    /// </summary>
    public class AlipayCommerceTransportParkingGoodsQueryModel : AlipayObject
    {
        /// <summary>
        /// isv内部产生商品ID(goods_id和out_id不能同时为空)
        /// </summary>
        [JsonPropertyName("goods_id")]
        public string GoodsId { get; set; }

        /// <summary>
        /// isv内部产生商品ID
        /// </summary>
        [JsonPropertyName("out_id")]
        public string OutId { get; set; }

        /// <summary>
        /// 支付宝返回停车场ID
        /// </summary>
        [JsonPropertyName("parking_id")]
        public string ParkingId { get; set; }
    }
}
