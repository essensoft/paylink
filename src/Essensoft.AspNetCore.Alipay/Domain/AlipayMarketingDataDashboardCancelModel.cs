using Newtonsoft.Json;
using System.Collections.Generic;

namespace Essensoft.AspNetCore.Alipay.Domain
{
    /// <summary>
    /// AlipayMarketingDataDashboardCancelModel Data Structure.
    /// </summary>
    public class AlipayMarketingDataDashboardCancelModel : AlipayObject
    {
        /// <summary>
        /// 批量取消仪表盘授权
        /// </summary>
        [JsonProperty("dashboard_ids")]
        public List<string> DashboardIds { get; set; }
    }
}
