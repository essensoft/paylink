using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayCommerceTransportParkingGoodsQueryResponse.
    /// </summary>
    public class AlipayCommerceTransportParkingGoodsQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 商品列表
        /// </summary>
        [JsonPropertyName("parking_goods_detail")]
        public ParkingGoodsDetail ParkingGoodsDetail { get; set; }
    }
}
