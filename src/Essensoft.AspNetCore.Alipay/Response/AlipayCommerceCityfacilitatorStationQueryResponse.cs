using Newtonsoft.Json;
using System.Collections.Generic;
using Essensoft.AspNetCore.Alipay.Domain;

namespace Essensoft.AspNetCore.Alipay.Response
{
    /// <summary>
    /// AlipayCommerceCityfacilitatorStationQueryResponse.
    /// </summary>
    public class AlipayCommerceCityfacilitatorStationQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 支持设为起点的站点列表
        /// </summary>
        [JsonProperty("support_starts")]
        public List<StationDetailInfo> SupportStarts { get; set; }
    }
}
