using System.Collections.Generic;
using Essensoft.AspNetCore.Payment.Alipay.Domain;
using Newtonsoft.Json;

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
        [JsonProperty("app_pv")]
        public long AppPv { get; set; }

        /// <summary>
        /// 小程序当日uv
        /// </summary>
        [JsonProperty("app_uv")]
        public long AppUv { get; set; }

        /// <summary>
        /// 小程序的区域pv、uv等数据列表
        /// </summary>
        [JsonProperty("area_detail_list")]
        public List<AreaDetail> AreaDetailList { get; set; }
    }
}
