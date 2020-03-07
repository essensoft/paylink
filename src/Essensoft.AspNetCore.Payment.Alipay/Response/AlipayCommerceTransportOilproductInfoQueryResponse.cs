using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayCommerceTransportOilproductInfoQueryResponse.
    /// </summary>
    public class AlipayCommerceTransportOilproductInfoQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 油站列表
        /// </summary>
        [JsonPropertyName("oil_station_models")]
        public OilStationDetails OilStationModels { get; set; }
    }
}
