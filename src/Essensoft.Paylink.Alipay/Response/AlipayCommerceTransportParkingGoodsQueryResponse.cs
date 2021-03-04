using System.Text.Json.Serialization;
using Essensoft.Paylink.Alipay.Domain;

namespace Essensoft.Paylink.Alipay.Response
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
