using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayOpenMiniDataVisitQueryResponse.
    /// </summary>
    public class AlipayOpenMiniDataVisitQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 小程序当日pv
        /// </summary>
        [JsonPropertyName("app_pv")]
        public long AppPv { get; set; }

        /// <summary>
        /// 小程序当日uv
        /// </summary>
        [JsonPropertyName("app_uv")]
        public long AppUv { get; set; }

        /// <summary>
        /// 小程序的区域pv、uv等数据列表
        /// </summary>
        [JsonPropertyName("area_detail_list")]
        public List<AreaDetail> AreaDetailList { get; set; }
    }
}
