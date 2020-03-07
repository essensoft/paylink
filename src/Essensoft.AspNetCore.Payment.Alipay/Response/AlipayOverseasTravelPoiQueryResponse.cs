using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayOverseasTravelPoiQueryResponse.
    /// </summary>
    public class AlipayOverseasTravelPoiQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 支付宝poi查询结果
        /// </summary>
        [JsonPropertyName("poi_query_result")]
        public PoiQueryResult PoiQueryResult { get; set; }
    }
}
