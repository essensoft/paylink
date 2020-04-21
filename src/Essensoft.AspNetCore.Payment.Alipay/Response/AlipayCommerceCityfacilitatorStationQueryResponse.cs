using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayCommerceCityfacilitatorStationQueryResponse.
    /// </summary>
    public class AlipayCommerceCityfacilitatorStationQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 支持设为起点的站点列表
        /// </summary>
        [JsonPropertyName("support_starts")]
        public List<StationDetailInfo> SupportStarts { get; set; }
    }
}
