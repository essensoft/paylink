using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayMarketingDataDashboardCancelModel Data Structure.
    /// </summary>
    public class AlipayMarketingDataDashboardCancelModel : AlipayObject
    {
        /// <summary>
        /// 批量取消仪表盘授权
        /// </summary>
        [JsonPropertyName("dashboard_ids")]
        public List<string> DashboardIds { get; set; }
    }
}
