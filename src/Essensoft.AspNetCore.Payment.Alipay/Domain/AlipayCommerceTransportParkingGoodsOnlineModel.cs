using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayCommerceTransportParkingGoodsOnlineModel Data Structure.
    /// </summary>
    public class AlipayCommerceTransportParkingGoodsOnlineModel : AlipayObject
    {
        /// <summary>
        /// 支付宝商品唯一ID
        /// </summary>
        [JsonPropertyName("goods_id")]
        public string GoodsId { get; set; }

        /// <summary>
        /// 操作类型：put-上架，pull-下架
        /// </summary>
        [JsonPropertyName("op_type")]
        public string OpType { get; set; }

        /// <summary>
        /// isv内部产生商品ID(goods_id和out_id不能同时为空)
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
