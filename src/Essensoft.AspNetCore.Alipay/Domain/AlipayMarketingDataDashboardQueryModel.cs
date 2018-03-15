using Newtonsoft.Json;
using System.Collections.Generic;

namespace Essensoft.AspNetCore.Alipay.Domain
{
    /// <summary>
    /// AlipayMarketingDataDashboardQueryModel Data Structure.
    /// </summary>
    public class AlipayMarketingDataDashboardQueryModel : AlipayObject
    {
        /// <summary>
        /// 仪表盘ID
        /// </summary>
        [JsonProperty("dashboard_id")]
        public string DashboardId { get; set; }

        /// <summary>
        /// 仪表盘过滤条件
        /// </summary>
        [JsonProperty("param")]
        public List<DashboardParam> Param { get; set; }
    }
}
